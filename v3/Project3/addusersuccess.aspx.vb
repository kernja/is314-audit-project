
Partial Class addusersuccess
    Inherits System.Web.UI.Page
    Dim myAuditor As clsAuditor
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        myAuditor = Session.Item("auditor")
        If myAuditor.currentUser Is Nothing Then
            Server.Transfer("index.aspx", False)
        End If
    End Sub

    Protected Sub btnContinue_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnContinue.Click
        Server.Transfer("menu.aspx")
    End Sub
End Class
