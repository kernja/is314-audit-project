Public Class frmLogon
    'create var to hold the auditor class
    Dim myAuditor As IS314_Proj1_Kernja.clsAuditor
    'var of a form that does the actual auditing.
    Dim childAudit As frmAudit
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogon.Click
        'create the new auditor
        myAuditor = New IS314_Proj1_Kernja.clsAuditor
        'set the auditor username/info
        myAuditor.Username = Me.txtName.Text
        myAuditor.Password = Me.txtPass.Text

        'if the auditor has the correct username password, show the audit screen.
        If myAuditor.verifyPassword = True Then
            Me.Hide()
            childAudit = New frmAudit(myAuditor)
            childAudit.Show()
        Else
            'if not, fail.
            MsgBox("Invalid username/pass combo")
            txtName.Text = ""
            txtPass.Text = ""
            txtName.Focus()
        End If
    End Sub

    Private Sub frmLogon_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class