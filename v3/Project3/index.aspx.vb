
Partial Class index
    Inherits System.Web.UI.Page

    Protected Sub btnClear_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnClear.Click
        Me.txtPassword.Text = ""
        Me.txtUsername.Text = ""
    End Sub

    Protected Sub btnSubmit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSubmit.Click

        Dim myAuditor As clsAuditor
        myAuditor = New clsAuditor
        myAuditor.Username = Me.txtUsername.Text
        myAuditor.Password = Me.txtPassword.Text

        If myAuditor.verifyPassword = clsDAO.DAO_RETURN_MESSAGE.DAO_SUCCESS Then
            Me.labelError.Visible = False
            myAuditor.currentUser = New clsUser(myAuditor.Username)
            Session.Add("auditor", myAuditor)
            Server.Transfer("menu.aspx")
        Else
            myAuditor.Username = ""
            myAuditor.Password = ""
            Me.labelError.Visible = True
        End If

    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub
End Class
