
Partial Class menu
    Inherits System.Web.UI.Page
    Dim myAuditor As clsAuditor
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        myAuditor = Session.Item("auditor")
        If myAuditor.currentUser Is Nothing Then
            Server.Transfer("index.aspx", False)
        End If
    End Sub

    Protected Sub btnLogOff_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnLogOff.Click
        myAuditor.currentUser = Nothing
        Session.Item("auditor") = myAuditor

        Server.Transfer("index.aspx")
    End Sub

    Protected Sub btnView_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnView.Click
        Server.Transfer("view.aspx")
    End Sub

    Protected Sub btnAdd_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Server.Transfer("adduser.aspx")
    End Sub

    Protected Sub btnAudit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAudit.Click
        Server.Transfer("audit.aspx")
    End Sub
End Class
