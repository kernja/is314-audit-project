'Namespace IS314_Proj2_Kernja

Public Class clsDAO
    Inherits clsObject
    'create a basic enum to handle error/success messages
    Public Enum DAO_RETURN_MESSAGE
        DAO_GENERIC_ERROR = 0
        DAO_USER_ALREADY_EXISTS = 1
        DAO_INVALID_PASSWORD = 2

        DAO_SUCCESS = 99
    End Enum
    'these two items can be kept and reused.
    Dim myConnection As MySql.Data.MySqlClient.MySqlConnection
    Dim myMD5 As New IST.DataHash.MD5

    'code to verify password
    Public Function verifyPassword(ByVal passedUsername As String, ByVal passedPassword As String) As DAO_RETURN_MESSAGE
        Dim myReturn As DAO_RETURN_MESSAGE = DAO_RETURN_MESSAGE.DAO_SUCCESS

        'try/catch block.  any error we cancel what we're doing.
        Try
            'create a query to get the password
            Dim cmd As New MySql.Data.MySqlClient.MySqlCommand
            With cmd
                .CommandText = "select password from TABLE_USERNAME WHERE username=""" & passedUsername & """;"
                .CommandType = Data.CommandType.Text
                .Connection = myConnection
            End With

            'run it
            myConnection.Open()
            Dim sqlResult As String = cmd.ExecuteScalar
            myConnection.Close()

            'verify results
            If myMD5.Verify(passedPassword, sqlResult) Then
                myReturn = DAO_RETURN_MESSAGE.DAO_SUCCESS
            Else
                myReturn = DAO_RETURN_MESSAGE.DAO_INVALID_PASSWORD
            End If
        Catch
            'if error, set the return to an error.
            myReturn = DAO_RETURN_MESSAGE.DAO_GENERIC_ERROR
        End Try

        Return myReturn
    End Function
    Public Function createUser(ByVal passedUsername As String, ByVal passedPassword As String, ByVal passedNameFirst As String, ByVal passedNameLast As String, ByVal passedNameMI As String) As DAO_RETURN_MESSAGE
        Dim myReturn As DAO_RETURN_MESSAGE = DAO_RETURN_MESSAGE.DAO_GENERIC_ERROR

        Try
            Dim cmd As New MySql.Data.MySqlClient.MySqlCommand
            'create query to make sure the user doesn't already exists
            With cmd
                .CommandText = "select * from TABLE_USERNAME where TABLE_USERNAME.USERNAME=""" & passedUsername & """;"
                .CommandType = Data.CommandType.Text
                .Connection = myConnection
            End With

            'run the query
            myConnection.Open()
            Dim sqlNumericalResult As Integer = cmd.ExecuteScalar
            'user exists, throw an error.
            If sqlNumericalResult > 0 Then
                myReturn = DAO_RETURN_MESSAGE.DAO_USER_ALREADY_EXISTS
                Exit Try
            End If
            myConnection.Close()

            'create query to insert data into the DB
            With cmd
                .CommandText = "insert into TABLE_PERSON(NAME_FIRST, NAME_MI, NAME_LAST, TIMESTAMP) VALUES(""" & passedNameFirst & """,""" & passedNameMI & """,""" & passedNameLast & """, now());"
                ' MsgBox(.CommandText)
                .CommandType = Data.CommandType.Text
                .Connection = myConnection
            End With

            'run the query
            myConnection.Open()
            cmd.ExecuteNonQuery()
            myConnection.Close()

            'user was created
            'now we create their username/password into the DB
            With cmd
                .CommandText = "INSERT INTO TABLE_USERNAME (USERNAME,PASSWORD,TIMESTAMP,FK_PERSON) VALUES(""" & passedUsername & """, """ & passedPassword & """, now(), (SELECT id from TABLE_PERSON where NAME_FIRST = """ & passedNameFirst & """ and NAME_MI = """ & passedNameMI & """ and NAME_LAST=""" & passedNameLast & """));"
                '  MsgBox(.CommandText)
                .CommandType = Data.CommandType.Text
                .Connection = myConnection
            End With

            'run the query
            myConnection.Open()
            cmd.ExecuteNonQuery()
            myConnection.Close()

            'success, return as such
            myReturn = DAO_RETURN_MESSAGE.DAO_SUCCESS
        Catch
            'return as an error if there was any error
            myReturn = DAO_RETURN_MESSAGE.DAO_GENERIC_ERROR
        End Try

        Return myReturn
    End Function
    Public Function submitAudit(ByRef passedAuditor As clsAuditor) As DAO_RETURN_MESSAGE
        Dim myReturn As DAO_RETURN_MESSAGE = DAO_RETURN_MESSAGE.DAO_GENERIC_ERROR

        Try
            'create SQL command to enter in the values for the overall audit (who did it, what kind of audit, timestamp)
            Dim cmd As New MySql.Data.MySqlClient.MySqlCommand
            With cmd
                .CommandText = "insert into TABLE_USER_AUDIT(FK_PERSON, FK_AUDIT, TIMESTAMP) VALUES (" & passedAuditor.currentUser.ID & ", " & passedAuditor.AuditType & ", now()); select @@identity;"
                .CommandType = Data.CommandType.Text
                .Connection = myConnection
            End With

            'run it.  get the PK as a result.
            myConnection.Open()
            Dim sqlNumericalResult As Integer = cmd.ExecuteScalar
            myConnection.Close()

            'create a temp category since we're running through all of the categories in the audit.
            Dim tempCategory As clsCategory
            For Each tempCategory In passedAuditor.Catagories.getCatagories
                'create a query that inserts the value, the comment, the PK of the category type (another table), the FK of the overall user audit (PK from another table) and the timestamp.
                With cmd
                    .CommandText = "insert into TABLE_USER_CATEGORY(VALUE, COMMENT, FK_CATEGORY, FK_USER_AUDIT, TIMESTAMP) VALUES (" & tempCategory.Value & ",""" & tempCategory.Comment & """, " & tempCategory.ID & ", " & sqlNumericalResult & ", now());"
                    .CommandType = Data.CommandType.Text
                    .Connection = myConnection
                End With

                'execute query.  each category gets its own query.
                myConnection.Open()
                cmd.ExecuteNonQuery()
                myConnection.Close()
            Next

            'it all works, return as a success
            myReturn = DAO_RETURN_MESSAGE.DAO_SUCCESS
        Catch
            'something was wrong, return as a failure.
            myReturn = DAO_RETURN_MESSAGE.DAO_GENERIC_ERROR
        End Try

        Return myReturn

    End Function
    Public Function getUserNames() As ArrayList
        Dim myReturn As New ArrayList
        Dim cmd As New MySql.Data.MySqlClient.MySqlCommand

        Try
            'create a command that gets all of the usernames from the USERNAME table
            With cmd
                .CommandText = "select username from TABLE_USERNAME;"
                .CommandType = Data.CommandType.Text
                .Connection = myConnection
            End With

            'run the command
            myConnection.Open()
            Dim sqlResult As MySql.Data.MySqlClient.MySqlDataReader = cmd.ExecuteReader

            'for each result in the result set
            'add to an arraylist that we return.
            While sqlResult.Read = True
                myReturn.Add(sqlResult.Item(0).ToString)
            End While
            'close the connection
            myConnection.Close()

            'we will return something, if not a new arraylist with nothing in it.
        Catch ex As Exception
            'something happened, pass a nothing so we can catch it in the form,
            myReturn = Nothing
        End Try

        Return myReturn
    End Function
    Public Function getTableNames() As ArrayList

        Dim myReturn As New ArrayList
        Dim cmd As New MySql.Data.MySqlClient.MySqlCommand
        'create a command that gets all of the tables in my schema
        Try
            With cmd
                .CommandText = "show tables in kernja;"
                .CommandType = Data.CommandType.Text
                .Connection = myConnection
            End With

            'open connection and run command
            myConnection.Open()
            Dim sqlResult As MySql.Data.MySqlClient.MySqlDataReader = cmd.ExecuteReader

            'create an arraylist that holds all of the values.
            While sqlResult.Read = True
                'add each table name
                myReturn.Add(sqlResult.Item(0).ToString)
            End While
            'close connection
            myConnection.Close()
        Catch ex As Exception
            'error resultred
            myReturn = Nothing
            'we can throw the error elsewhere
        End Try
        Return myReturn
    End Function
    Public Function createAudit(ByVal selectedAudit As Integer, ByRef passedCategoryFactory As clsCategoryFactory) As DAO_RETURN_MESSAGE
        Dim myReturn As DAO_RETURN_MESSAGE = DAO_RETURN_MESSAGE.DAO_SUCCESS

        Dim cmd As New MySql.Data.MySqlClient.MySqlCommand
        Try
            'create a command to get the approperiate audit template information
            With cmd
                .CommandText = "SELECT id, AUDIT_WARNING, AUDIT_PASSING FROM TABLE_AUDIT;"
                .CommandType = Data.CommandType.Text
                .Connection = myConnection
            End With

            'run it
            myConnection.Open()
            Dim sqlResult As MySql.Data.MySqlClient.MySqlDataReader = cmd.ExecuteReader

            'get the info we need
            'store it into the category factory
            While sqlResult.Read = True
                Dim myValues(0 To 2) As Integer
                Dim i As Integer
                For i = 0 To 2
                    myValues(i) = Int((sqlResult.Item(i).ToString))
                Next
                passedCategoryFactory.ID = myValues(0)
                passedCategoryFactory.Probation = myValues(1)
                passedCategoryFactory.Pass = myValues(2)
            End While
            myConnection.Close()

            'now we can create all of the categories we need to perform the audit.
            createCategory(selectedAudit, passedCategoryFactory)
        Catch ex As Exception
            myReturn = DAO_RETURN_MESSAGE.DAO_GENERIC_ERROR
        End Try

        Return myReturn
    End Function
    Public Function createCategory(ByVal selectedAudit As Integer, ByRef passedCategoryFactory As clsCategoryFactory) As DAO_RETURN_MESSAGE
        Dim myReturn As DAO_RETURN_MESSAGE = DAO_RETURN_MESSAGE.DAO_SUCCESS

        Dim cmd As New MySql.Data.MySqlClient.MySqlCommand
        Try
            'create a command to get category info from the template in the DB
            With cmd
                .CommandText = "select id, NAME, MIN, MAX, PASSING, VALUE from TABLE_AUDIT_CATEGORY"
                .CommandType = Data.CommandType.Text
                .Connection = myConnection
            End With

            'run the command
            myConnection.Open()
            Dim sqlResult As MySql.Data.MySqlClient.MySqlDataReader = cmd.ExecuteReader

            'for each row that we got
            'we create a category that the auditor can use to intercept information
            'from the user.
            While sqlResult.Read = True
                Dim myValues(0 To 5) As String
                Dim i As Integer
                For i = 0 To 5
                    myValues(i) = (sqlResult.Item(i).ToString)
                Next
                passedCategoryFactory.addCategory(myValues(0), myValues(1), Int(myValues(2)), Int(myValues(3)), Int(myValues(4)), Int(myValues(5)))
            End While

            'close connection
            myConnection.Close()
        Catch ex As Exception
            'return an error if there was a problem
            myReturn = DAO_RETURN_MESSAGE.DAO_GENERIC_ERROR
        End Try

        Return myReturn
    End Function
    Public Function getUserInformation(ByVal passedUsername As String, ByRef passedID As Integer, ByRef passedFirstName As String, ByRef passedLastName As String, ByRef passedMiddleName As String)
        Dim myReturn As DAO_RETURN_MESSAGE
        'get the ID from a person
        myReturn = getID(passedUsername, passedID)

        'if they exist, then we can get the rest of the info
        If myReturn = DAO_RETURN_MESSAGE.DAO_SUCCESS Then
            myReturn = getName(passedID, passedFirstName, passedLastName, passedMiddleName)
        Else
            'if not, we return an error.
            myReturn = DAO_RETURN_MESSAGE.DAO_GENERIC_ERROR
        End If

        Return myReturn
    End Function
    Private Function getID(ByVal passedUsername As String, ByRef passedID As Integer) As DAO_RETURN_MESSAGE
        Dim myReturn As DAO_RETURN_MESSAGE = DAO_RETURN_MESSAGE.DAO_SUCCESS
        Try
            'create a command to get the PK of a person
            'based off of their username
            Dim cmd As New MySql.Data.MySqlClient.MySqlCommand
            With cmd
                .CommandText = "select FK_PERSON from TABLE_USERNAME WHERE username=""" & passedUsername & """;"
                .CommandType = Data.CommandType.Text
                .Connection = myConnection
            End With

            'run it and get the ID
            myConnection.Open()
            passedID = Int(cmd.ExecuteScalar)
            myConnection.Close()

        Catch
            myReturn = DAO_RETURN_MESSAGE.DAO_GENERIC_ERROR
        End Try

        Return myReturn
    End Function
    Private Function getName(ByVal passedID As Integer, ByRef passedFirstName As String, ByRef passedLastName As String, ByRef passedMiddleName As String) As DAO_RETURN_MESSAGE
        Dim myReturn As DAO_RETURN_MESSAGE = DAO_RETURN_MESSAGE.DAO_SUCCESS

        Try
            'create commands to get the first, middle and last names
            'from a person based on username
            'we have to do multiple commands since we cannot return 
            '3 values all at once.
            Dim cmd As New MySql.Data.MySqlClient.MySqlCommand
            With cmd
                .CommandText = "select NAME_FIRST from TABLE_PERSON WHERE id=""" & passedID & """;"
                .CommandType = Data.CommandType.Text
                .Connection = myConnection
            End With

            myConnection.Open()
            passedFirstName = cmd.ExecuteScalar
            myConnection.Close()

            'for middle
            With cmd
                .CommandText = "select NAME_MI from TABLE_PERSON WHERE id=""" & passedID & """;"
                .CommandType = Data.CommandType.Text
                .Connection = myConnection
            End With

            myConnection.Open()
            passedMiddleName = cmd.ExecuteScalar
            myConnection.Close()

            'for last
            With cmd
                .CommandText = "select NAME_LAST from TABLE_PERSON WHERE id=""" & passedID & """;"
                .CommandType = Data.CommandType.Text
                .Connection = myConnection
            End With

            myConnection.Open()
            passedLastName = cmd.ExecuteScalar
            myConnection.Close()


        Catch
            myReturn = DAO_RETURN_MESSAGE.DAO_GENERIC_ERROR
        End Try

        Return myReturn
    End Function
    Public Function getTable(ByVal passedName As String) As Data.DataTable
        Dim cmd As New MySql.Data.MySqlClient.MySqlCommand
        Dim da As New MySql.Data.MySqlClient.MySqlDataAdapter
        Dim myReturn As New Data.DataTable

        Try
            'create command to get the rows from a certain table
            With cmd
                .CommandText = "select * from " & passedName & ";"
                .CommandType = Data.CommandType.Text
                .Connection = myConnection
            End With

            'execute command
            da.SelectCommand = cmd
            da.Fill(myReturn)
        Catch ex As Exception
            'error resulted, return nothing
            myReturn = Nothing
        End Try
        Return myReturn
    End Function
    Public Overrides Function toString() As String
        Return "DAO"
    End Function

    Public Sub New()
        myConnection = New MySql.Data.MySqlClient.MySqlConnection
        myConnection.ConnectionString = "redacted;" & "redacted;" & "redacted;" & "database=kernja"
    End Sub
End Class


'End Namespace
