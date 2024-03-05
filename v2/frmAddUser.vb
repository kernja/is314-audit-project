Public Class frmAddUser

    Private Sub verifyInput(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles txtNameFirst.TextChanged, txtNameLast.TextChanged, txtNameMI.TextChanged, _
        txtUsername.TextChanged

        Dim mySender As TextBox = sender
        mySender.Text = Me.StripNonAlphaNumericCharacters(mySender.Text)

    End Sub
    Private Function StripNonAlphaNumericCharacters(ByVal Text As String) As String
        'found at: http://www.groupsrv.com/dotnet/about67380.html
        Dim sb As New System.Text.StringBuilder(Text.Length)
        Dim chr As Char
        For Each chr In Text
            If Char.IsLetterOrDigit(chr) Then
                sb.Append(chr)
            End If
        Next chr
        Return sb.ToString()
    End Function

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Dispose()
    End Sub

    Private Sub btnCreateUser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCreateUser.Click
        Dim myDAO As New IS314_Assignment1.IS314_Proj2_Kernja.clsDAO
        Dim myHash As New IST.DataHash.MD5


        If verifyInput() = True Then
            'input was OK
            Dim tempPassword As String = myHash.Encrypt(txtPassword.Text)
            Dim myReturn As IS314_Assignment1.IS314_Proj2_Kernja.clsDAO.DAO_RETURN_MESSAGE = myDAO.createUser(Me.txtUsername.Text, tempPassword, Me.txtNameFirst.Text, Me.txtNameLast.Text, Me.txtNameMI.Text)

            'create user
            If myReturn = IS314_Proj2_Kernja.clsDAO.DAO_RETURN_MESSAGE.DAO_SUCCESS Then
                MsgBox("User was created successfully.")
                Me.Dispose()
                'user already exists
            ElseIf myReturn = IS314_Proj2_Kernja.clsDAO.DAO_RETURN_MESSAGE.DAO_USER_ALREADY_EXISTS Then
                MsgBox("Username already exists.")
                'user was already created
            ElseIf myReturn = IS314_Proj2_Kernja.clsDAO.DAO_RETURN_MESSAGE.DAO_GENERIC_ERROR Then
                MsgBox("Error creating user.")
            End If
        Else
            'form wasn't filled out entirely.
            MsgBox("Please fill out the form completely.  Also make sure the two passwords entered match each other.")
        End If

    End Sub

    Private Function VerifyInput() As Boolean
        Dim myReturn As Boolean = False
        'trim out excess whitespace from the input
        Me.txtNameMI.Text = Trim(Me.txtNameMI.Text)
        Me.txtNameFirst.Text = Trim(Me.txtNameFirst.Text)
        Me.txtNameLast.Text = Trim(Me.txtNameLast.Text)
        Me.txtUsername.Text = Trim(Me.txtUsername.Text)


        'make sure nobody was all sneaky and tried to pass through empty values
        If (Not (txtNameFirst.Text = "")) _
            And (Not (txtNameLast.Text = "")) And (Not (txtUsername.Text = "")) Then

            'verify to make sure the two passwords entered match
            If Me.txtPassword.Text.Length >= 6 Then
                If Me.txtPassword.Text.Equals(txtPasswordConfirm.Text) Then
                    myReturn = True
                End If
            End If
        End If
        Return myReturn
    End Function
End Class