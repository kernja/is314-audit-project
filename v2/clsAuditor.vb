Namespace IS314_Proj2_Kernja
    Public Class clsAuditor
        Inherits IS314_Assignment1.IS314_Proj2_Kernja.clsObject

        'create an enumeration so that we have values that mean "Pass", "Warn" and "fail"
        Public Enum auditRating
            pass = 0
            warn = 1
            fail = 2
        End Enum
        'private vars that hold the username and password.
        Public currentUser As clsUser

        Private _auditType As Integer
        Private _username As String
        Private _password As String

        Public Property AuditType() As Integer
            Get
                Return _auditType
            End Get
            Set(ByVal value As Integer)
                _auditType = value
            End Set
        End Property
        'default getter and setters.
        Public Property Username() As String
            Get
                Return _username
            End Get
            Set(ByVal value As String)
                _username = value
            End Set
        End Property
        Public Property Password() As String
            Get
                Return _password
            End Get
            Set(ByVal value As String)
                _password = value
            End Set
        End Property
        'vars that hold the Category factory, which holds all catagories of an audit.
        Private _CategoryFactory As clsCategoryFactory
        Public Sub New()
            'set default values.
            Username = "foo"
            Password = "bar"
            Catagories = New clsCategoryFactory()
        End Sub

        Public Property Catagories() As clsCategoryFactory
            Get
                Return _CategoryFactory
            End Get
            Set(ByVal value As clsCategoryFactory)
                _CategoryFactory = value
            End Set
        End Property
        'verify whether or not a password equals what we have in the auditor.

        Public Function verifyPassword() As clsDAO.DAO_RETURN_MESSAGE
            'create the DAO object which handles the DB functions specifically
            'and verifies the password.
            Dim myreturn As clsDAO.DAO_RETURN_MESSAGE = (New clsDAO).verifyPassword(Username, Password)

            Return myreturn
        End Function

        Public Function verifyPassword(ByVal passedUsername As String, ByVal passedPassword As String) As clsDAO.DAO_RETURN_MESSAGE
            'set the current passwords in the class to what we have passed in
            Password = passedPassword
            Username = passedUsername

            'once again, create the DAO object which handles the DB call and verifies the password.
            Dim myreturn As clsDAO.DAO_RETURN_MESSAGE = (New clsDAO).verifyPassword(Username, Password)


            Return myreturn
        End Function
        Public Sub LoadCategories(ByVal passedType As Integer)
            'pass in the type of Audit we're performing
            'and go to the DAO and populate the information from the tables
            AuditType = passedType
            Dim myDAO As New IS314_Assignment1.IS314_Proj2_Kernja.clsDAO
            If myDAO.createAudit(1, _CategoryFactory) <> clsDAO.DAO_RETURN_MESSAGE.DAO_SUCCESS Then
                MsgBox("Unable to load audit data")
                End
            End If
        End Sub
        Public Overrides Function toString() As String
            Return "clsAuditor"
        End Function
    End Class

End Namespace