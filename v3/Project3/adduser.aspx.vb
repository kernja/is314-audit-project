
Partial Class adduser
    Inherits System.Web.UI.Page
    Dim myAuditor As clsAuditor
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        myAuditor = Session.Item("auditor")
        If myAuditor.currentUser Is Nothing Then
            Server.Transfer("index.aspx", False)
        End If
    End Sub

    Protected Sub btnCancel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Server.Transfer("menu.aspx", False)
    End Sub

    Protected Sub btnCreate_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCreate.Click
        Dim myDAO As New clsDAO
        Dim myHash As New IST.DataHash.MD5


        If verifyInput() = True Then
            'input was OK
            Dim tempPassword As String = myHash.Encrypt(textPassword.Text)
            Dim myReturn As clsDAO.DAO_RETURN_MESSAGE = myDAO.createUser(Me.textUsername.Text, tempPassword, Me.textNameFirst.Text, Me.textNameLast.Text, Me.textNameMI.Text)

            'create user
            If myReturn = clsDAO.DAO_RETURN_MESSAGE.DAO_SUCCESS Then
                'MsgBox("User was created successfully.")
                'Me.Dispose()
                Server.Transfer("addusersuccess.aspx")

                'user already exists
            ElseIf myReturn = clsDAO.DAO_RETURN_MESSAGE.DAO_USER_ALREADY_EXISTS Then
                Me.labelError.Text = "Username already exists."
                Me.labelError.Visible = True
                'user was already created
            ElseIf myReturn = clsDAO.DAO_RETURN_MESSAGE.DAO_GENERIC_ERROR Then
                Me.labelError.Text = "Database error."
                Me.labelError.Visible = True
            End If
        Else
            Me.labelError.Text = "Please make sure the two passwords entered match."
            Me.labelError.Visible = True
        End If

    End Sub

    Private Function VerifyInput() As Boolean
        Dim myReturn As Boolean = False
        'trim out excess whitespace from the input
        Me.textNameMI.Text = Trim(Me.textNameMI.Text)
        Me.textNameFirst.Text = Trim(Me.textNameFirst.Text)
        Me.textNameLast.Text = Trim(Me.textNameLast.Text)
        Me.textUsername.Text = Trim(Me.textUsername.Text)


        'make sure nobody was all sneaky and tried to pass through empty values
        If (Not (textNameFirst.Text = "")) _
            And (Not (textNameLast.Text = "")) And (Not (textUsername.Text = "")) Then

            'verify to make sure the two passwords entered match
            If Me.textPassword.Text.Length >= 6 Then
                If Me.textPassword.Text.Equals(textConfirmPassword.Text) Then
                    myReturn = True
                End If
            End If
        End If
        Return myReturn
    End Function
End Class
