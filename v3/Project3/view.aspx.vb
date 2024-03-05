
Partial Class view
    Inherits System.Web.UI.Page
    Dim myAuditor As clsAuditor
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        myAuditor = Session.Item("auditor")
        If myAuditor.currentUser Is Nothing Then
            Server.Transfer("index.aspx", False)
        End If

        If listTables.Items.Count = 0 Then loadListBox()
        If listTables.Items.Count > 0 Then
            LoadTableData()
        End If
    End Sub

    Private Sub loadListBox()
        Dim myDAO As New clsDAO
        Me.listTables.Items.Clear()
        Dim myNames As ArrayList = myDAO.getTableNames()

        For Each item As String In myNames
            Me.listTables.Items.Add(item)
        Next

    End Sub

    Protected Sub btnBack_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnBack.Click
        Server.Transfer("menu.aspx")
    End Sub

    Protected Sub listTables_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles listTables.SelectedIndexChanged
        LoadTableData()
    End Sub
    Private Sub LoadTableData()
        Dim myDAO As New clsDAO
        If Not (Trim(listTables.SelectedItem.Text).Equals("")) Then
            Me.dgrid.DataSource = myDAO.getTable(listTables.SelectedItem.Text)
        End If

        dgrid.DataBind()
        'dgv1.DataSource = cmd.ExecuteReader(CommandBehavior.CloseConnection)
        'dgv1.DataBind()
    End Sub
End Class
