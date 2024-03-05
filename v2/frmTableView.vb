Public Class frmTableView
    Dim myDAO As New IS314_Assignment1.IS314_Proj2_Kernja.clsDAO
    Private Sub frmTableView_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        loadComboBox()
        Me.Show()
    End Sub
    Sub loadComboBox()
        Me.cboTableNames.Items.Clear()
        Dim myNames As ArrayList = myDAO.getTableNames()

        For Each item As String In myNames
            cboTableNames.Items.Add(item)
        Next
    End Sub

    Private Sub cboTableNames_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboTableNames.SelectedIndexChanged
        If Not (Trim(cboTableNames.SelectedItem).Equals("")) Then
            dgshow.DataSource = myDAO.getTable(cboTableNames.SelectedItem)
        End If
    End Sub


    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        Me.Hide()
    End Sub
End Class