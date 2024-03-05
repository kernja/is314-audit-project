Public Class frmLogon
    'create var to hold the auditor class
    Dim myAuditor As IS314_Proj2_Kernja.clsAuditor

    'var of a form that does the actual auditing.
    Dim childAudit As frmAudit

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogon.Click
        'create the new auditor
        'Dim foo As New IST.DataHash.MD5

        'Me.txtName.Text = foo.Encrypt(Me.txtPass.Text)
        'Exit Sub


        myAuditor = New IS314_Proj2_Kernja.clsAuditor
        'set the auditor username/info
        myAuditor.Username = Me.cboUserNames.Text
        myAuditor.Password = Me.txtPass.Text

        If myAuditor.verifyPassword = IS314_Proj2_Kernja.clsDAO.DAO_RETURN_MESSAGE.DAO_SUCCESS Then

            myAuditor.currentUser = New IS314_Assignment1.IS314_Proj2_Kernja.clsUser(myAuditor.Username)
            myAuditor.Password = ""
            myAuditor.Username = ""
            grpMenu.Visible = True
            Me.txtPass.Visible = False
            Me.cboUserNames.Visible = False
            Me.btnLogon.Visible = False
            Me.lblHeader.Text = "Menu"
        Else
            'if not, fail.
            MsgBox("Invalid username or password.")
            txtPass.Text = ""
            Me.cboUserNames.Focus()
        End If
    End Sub

    Private Sub frmLogon_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        End
    End Sub

    Private Sub frmLogon_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'MsgBox(DateTime.Now.ToString("yyyyMMdd hh:mm:ss"))
        loadComboBox()
        Me.Show()
    End Sub

    Private Sub btnLogOff_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogOff.Click
        Dim myForm As New frmLogon
        myForm.Show()
        Me.Hide()
        Me.Dispose()

    End Sub

    Private Sub btnViewTables_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnViewTables.Click
        Dim myForm As New frmTableView
        myForm.ShowDialog()

    End Sub

    Sub loadComboBox()
        Dim myDAO As New IS314_Assignment1.IS314_Proj2_Kernja.clsDAO
        Me.cboUserNames.Items.Clear()
        Dim myNames As ArrayList = myDAO.getUserNames()

        For Each item As String In myNames
            cboUserNames.Items.Add(item)
        Next

        cboUserNames.SelectedIndex = 0
    End Sub

    Private Sub btnUser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUser.Click
        Dim myForm As New frmAddUser
        myForm.ShowDialog()

    End Sub

    Private Sub btnAudit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAudit.Click
        myAuditor.LoadCategories(1)
        Dim foo As New IS314_Assignment1.frmAudit(myAuditor)
        foo.Visible = False
        foo.ShowDialog()
    End Sub

    Private Sub grpMenu_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grpMenu.Enter

    End Sub
End Class