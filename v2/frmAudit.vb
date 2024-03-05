Public Class frmAudit
    'holds teh auditor that was passed through when the form was created.
    Private _audit As IS314_Proj2_Kernja.clsAuditor
    'holds the information of the selected Category so the whole form has access to it.
    Private _selectedCategory As IS314_Proj2_Kernja.clsCategory
    Public Sub New(ByRef passedAuditor As IS314_Proj2_Kernja.clsAuditor)
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.

        ' Set the Auditor that was passed to a variable on this form
        ' So we have local access to it.
        _audit = passedAuditor
        Me.lblName.Text = Me._audit.currentUser.FirstName & " " & Me._audit.currentUser.MiddleName & " " & Me._audit.currentUser.LastName
        'Show the form, which causes the "Load" event to fire.
    End Sub
    Private Sub frmAudit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Refresh the listbox with all data from the auditor.
        refreshListBox()
        'If we have at least one Category for the auditor, set the ListBox to this one value
        'So that the form automatically fills out.
        If Me.lstCategory.Items.Count >= 1 Then
            Me.lstCategory.SelectedIndex = 0
        End If
    End Sub

    Private Sub refreshListBox()
        'Clear all items in the listbox
        lstCategory.Items.Clear()
        'Create an array with all of the catagories in the Auditor
        Dim _tempArray As ArrayList = _audit.Catagories.getCatagories
        'Create a temporary Category variable to hold the active Category
        Dim _tempCategory As IS314_Proj2_Kernja.clsCategory
        'create iterator variable
        Dim i As Single
        'iterate through all of the items in the array, which are catagories from the auditor
        For i = 0 To _tempArray.Count - 1
            'set the Category to the temp. var declared above.
            _tempCategory = _tempArray(i)
            'add to the listbox the Category.
            lstCategory.Items.Add(_tempCategory.toString)
        Next
    End Sub

    Private Sub lstCategory_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'user clicked on the listbox.
        'create a variable to hold the selected Category from the listbox
        Dim _tempCategory As IS314_Proj2_Kernja.clsCategory = _audit.Catagories.getCategory(lstCategory.SelectedItem.ToString)
        _selectedCategory = _tempCategory
        'update the form with the information from the Category.
        UpdateForm()
    End Sub
    Private Sub UpdateForm()

        Me.lblName.Text = Me._audit.currentUser.FirstName & " " & Me._audit.currentUser.MiddleName & " " & Me._audit.currentUser.LastName
        'update the trackbar to the minimum and maximum values for the selected Category.
        Me.tbQuality.Minimum = _selectedCategory.Min
        Me.tbQuality.Maximum = _selectedCategory.Max
        'update the trackbar to the current value assigned to the Category.
        Me.tbQuality.Value = _selectedCategory.Value

        'update the labels that show the current and passing values for the Category.
        Me.lblQualityCurrentValue.Text = _selectedCategory.Value
        Me.lblQualityPassingValue.Text = _selectedCategory.Passing

        'enable the trackbar and the textbox (we disable them from start in case
        'we have an audit with no catagories)
        Me.tbQuality.Enabled = True
        Me.txtComment.Enabled = True

        'set the min and max labels for the trackbar to show the possible min/max values
        'for the selected Category.
        Me.lblQualityMin.Text = Me._selectedCategory.Min
        Me.lblQualityMAx.Text = Me._selectedCategory.Max

        'determines whether or not the comment text box is visible.
        'is passing
        If _selectedCategory.getRating = IS314_Proj2_Kernja.clsAuditor.auditRating.pass Then
            Me.txtComment.Visible = False
        Else
            'is not passing
            Me.txtComment.Visible = True
            Me.txtComment.Text = _selectedCategory.Comment
        End If

        'create var to hold the auditor's overall system rating.
        Dim myRanking As IS314_Proj2_Kernja.clsAuditor.auditRating
        'get the rating.
        myRanking = Me._audit.Catagories.getRating

        'make sure the txtbox is enabled.
        Me.txtRating.Enabled = True
        'if the rating is FAIL, set the colors to red and text to FAIL
        If myRanking = IS314_Proj2_Kernja.clsAuditor.auditRating.fail Then
            Me.txtRating.Text = "FAIL"
            Me.txtRating.BackColor = Color.Red
        ElseIf myRanking = IS314_Proj2_Kernja.clsAuditor.auditRating.pass Then
            'if pass, set to green and text to PASS
            Me.txtRating.Text = "PASS"
            Me.txtRating.BackColor = Color.Green
        Else
            'if warning, set to yellow and text to WARN
            Me.txtRating.Text = "WARN"
            Me.txtRating.BackColor = Color.Yellow
        End If

        'update the form to show the current store and the total possible overall score
        Me.lblOverallScore.Text = Me._audit.Catagories.getScore & " / " & Me._audit.Catagories.getMaxScore
    End Sub

    Private Sub UpdateCategory()
        'update the selected Category with the newly inputted values
        _selectedCategory.Value = Me.tbQuality.Value
        _selectedCategory.Comment = Me.txtComment.Text
        'set the info
        Me._audit.Catagories.setCategory(_selectedCategory)
        'refresh form to update info.
        UpdateForm()
    End Sub

    Private Sub tbQuality_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbQuality.Scroll
        'refresh Category since audit info has changed.
        UpdateCategory()
    End Sub

    Private Sub txtComment_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtComment.TextChanged
        'refresh Category since audit info has changed.
        Dim myObject As TextBox = sender
        myObject.Text = myObject.Text.Replace(Chr(34), "")
        myObject.Text = myObject.Text.Replace(Chr(39), "")
        UpdateCategory()

    End Sub

    Private Sub txtRating_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtRating.TextChanged
        'just update the form so that the rating box doesn't get maniupulated
        UpdateForm()
    End Sub

    Private Sub lstCategory_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstCategory.SelectedIndexChanged
        'user clicked on the listbox.
        'create a variable to hold the selected Category from the listbox
        Dim _tempCategory As IS314_Proj2_Kernja.clsCategory = _audit.Catagories.getCategory(lstCategory.SelectedItem.ToString)
        _selectedCategory = _tempCategory
        'update the form with the information from the Category.
        UpdateForm()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        'hide the form.  do nothig.
        Me.Dispose()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCommit.Click
        'declare the DAO object
        Dim myDao As New IS314_Assignment1.IS314_Proj2_Kernja.clsDAO
        'submit the data.
        If myDao.submitAudit(Me._audit) <> IS314_Proj2_Kernja.clsDAO.DAO_RETURN_MESSAGE.DAO_SUCCESS Then
            MsgBox("Error submitting the audit.")
        End If

        'hide the form.
        Me.Dispose()
    End Sub
End Class
