
Partial Class audit
    Inherits System.Web.UI.Page
    Dim myAuditor As clsAuditor
    Dim selectedCategory As clsCategory

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        myAuditor = Session.Item("auditor")
        If myAuditor.currentUser Is Nothing Then
            Server.Transfer("index.aspx", False)
        End If

        Me.lblName.Text = Me.myAuditor.currentUser.FirstName & " " & Me.myAuditor.currentUser.MiddleName & " " & Me.myAuditor.currentUser.LastName


        'If we have at least one Category for the auditor, set the ListBox to this one value
        'So that the form automatically fills out.
        'If Me.listCategory.Items.Count >= 1 Then
        '    Me.listCategory.SelectedIndex = 0
        'End If
        Dim myReturn As clsDAO.DAO_RETURN_MESSAGE = myAuditor.LoadCategories(1)
        If myReturn <> clsDAO.DAO_RETURN_MESSAGE.DAO_SUCCESS Then
            Server.Transfer("errorCategory.aspx")
        End If
        If Me.listCategory.Items.Count = 0 Then refreshListBox()
    End Sub

    Private Sub refreshListBox()
        'Clear all items in the listbox
        listCategory.Items.Clear()
        'Create an array with all of the catagories in the Auditor
        Dim _tempArray As ArrayList = myAuditor.Catagories.getCatagories
        'Create a temporary Category variable to hold the active Category
        Dim _tempCategory As clsCategory
        'create iterator variable
        Dim i As Single
        'iterate through all of the items in the array, which are catagories from the auditor
        For i = 0 To _tempArray.Count - 1
            'set the Category to the temp. var declared above.
            _tempCategory = _tempArray(i)
            'add to the listbox the Category.
            listCategory.Items.Add(_tempCategory.toString)
        Next

        UpdateForm()
    End Sub
    Private Sub UpdateForm()

        Me.lblName.Text = Me.myAuditor.currentUser.FirstName & " " & Me.myAuditor.currentUser.MiddleName & " " & Me.myAuditor.currentUser.LastName
        'update the trackbar to the minimum and maximum values for the selected Category.
        Dim i As Single
        Me.lstRating.Items.Clear()
        If Not (selectedCategory Is Nothing) Then
            For i = selectedCategory.Min To selectedCategory.Max
                Me.lstRating.Items.Add(i)
            Next

            For i = 0 To Me.lstRating.Items.Count - 1
                If Me.lstRating.Items(i).Text = selectedCategory.Value Then
                    Me.lstRating.Items(i).Selected = True
                    Exit For
                End If
            Next

            'enable the trackbar and the textbox (we disable them from start in case
            'we have an audit with no catagories)
            Me.lstRating.Enabled = True
            Me.txtComments.Enabled = True

            'determines whether or not the comment text box is visible.
            'is passing
            If selectedCategory.getRating = clsAuditor.auditRating.pass Then
                Me.txtComments.Visible = False

            Else
                'is not passing
                Me.txtComments.Visible = True
                Me.txtComments.Text = selectedCategory.Comment
            End If
        End If
        'create var to hold the auditor's overall system rating.
        Dim myRanking As clsAuditor.auditRating
        'get the rating.
        myRanking = Me.myAuditor.Catagories.getRating

        'make sure the txtbox is enabled.
        'Me.txtRating.Enabled = True
        'if the rating is FAIL, set the colors to red and text to FAIL
        If myRanking = clsAuditor.auditRating.fail Then
            Me.lblRating.Text = "*FAIL*"
            Me.lblRating.BackColor = Drawing.Color.Red
        ElseIf myRanking = clsAuditor.auditRating.pass Then
            'if pass, set to green and text to PASS
            Me.lblRating.Text = "*PASS*"
            Me.lblRating.BackColor = Drawing.Color.Green
        Else
            'if warning, set to yellow and text to WARN
            Me.lblRating.Text = "*WARN*"
            Me.lblRating.BackColor = Drawing.Color.Yellow
        End If


        lblScore.Text = "SCORE: " & Me.myAuditor.Catagories.getScore & " / " & Me.myAuditor.Catagories.getMaxScore
        'update the form to show the current store and the total possible overall score
        'Me.lblOverallScore.Text = Me.myAuditor.Catagories.getScore & " / " & Me.myAuditor.Catagories.getMaxScore
    End Sub

    Private Sub UpdateCategory()
        Dim _tempCategory As clsCategory = myAuditor.Catagories.getCategory(listCategory.SelectedItem.ToString)
        selectedCategory = _tempcategory

        'update the selected Category with the newly inputted values
        selectedCategory.Value = Me.lstRating.SelectedItem.Text
        selectedCategory.Comment = Me.txtComments.Text
        'set the info
        Me.myAuditor.Catagories.setCategory(selectedCategory)
        'refresh form to update info.
        UpdateForm()
    End Sub



    Private Sub txtComment_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtComments.TextChanged
        'refresh Category since audit info has changed.
        Dim myObject As TextBox = sender
        myObject.Text = myObject.Text.Replace(Chr(34), "")
        myObject.Text = myObject.Text.Replace(Chr(39), "")
        UpdateCategory()

    End Sub
 
    '   End Sub
    Protected Sub lstRating_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstRating.SelectedIndexChanged
        UpdateCategory()
    End Sub

    Protected Sub btnCancel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Server.Transfer("menu.aspx")
    End Sub

    Protected Sub btnSubmit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSubmit.Click
        'declare the DAO object
        Dim myDao As New clsDAO
        'submit the data.
        If myDao.submitAudit(Me.myAuditor) <> clsDAO.DAO_RETURN_MESSAGE.DAO_SUCCESS Then
            Server.Transfer("errorAudit.aspx")
        Else
            Server.Transfer("successAudit.aspx")
        End If

        'hide the form.
    End Sub

    Protected Sub listCategory_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles listCategory.SelectedIndexChanged
        'user clicked on the listbox.
        'create a variable to hold the selected Category from the listbox
        'Session.Add("categoryIndex", Me.listCategory.SelectedIndex)
        Dim _tempCategory As clsCategory = myAuditor.Catagories.getCategory(listCategory.SelectedItem.ToString)
        selectedCategory = _tempCategory
        'update the form with the information from the Category.
        UpdateForm()
    End Sub
End Class
