<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAudit
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lstCategory = New System.Windows.Forms.ListBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.tbQuality = New System.Windows.Forms.TrackBar
        Me.lblQualityMin = New System.Windows.Forms.Label
        Me.lblQualityMAx = New System.Windows.Forms.Label
        Me.txtComment = New System.Windows.Forms.TextBox
        Me.lblQualityPassingValue = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.lblQualityCurrentValue = New System.Windows.Forms.Label
        Me.txtRating = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.lblOverallScore = New System.Windows.Forms.Label
        CType(Me.tbQuality, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lstCategory
        '
        Me.lstCategory.FormattingEnabled = True
        Me.lstCategory.Location = New System.Drawing.Point(12, 32)
        Me.lstCategory.Name = "lstCategory"
        Me.lstCategory.Size = New System.Drawing.Size(238, 212)
        Me.lstCategory.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(9, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Items"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(256, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Quality Scale"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(256, 93)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Comments"
        '
        'tbQuality
        '
        Me.tbQuality.Enabled = False
        Me.tbQuality.LargeChange = 1
        Me.tbQuality.Location = New System.Drawing.Point(273, 32)
        Me.tbQuality.Name = "tbQuality"
        Me.tbQuality.Size = New System.Drawing.Size(223, 42)
        Me.tbQuality.TabIndex = 5
        '
        'lblQualityMin
        '
        Me.lblQualityMin.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQualityMin.Location = New System.Drawing.Point(270, 64)
        Me.lblQualityMin.Name = "lblQualityMin"
        Me.lblQualityMin.Size = New System.Drawing.Size(32, 13)
        Me.lblQualityMin.TabIndex = 6
        Me.lblQualityMin.Text = " "
        Me.lblQualityMin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblQualityMAx
        '
        Me.lblQualityMAx.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQualityMAx.Location = New System.Drawing.Point(467, 64)
        Me.lblQualityMAx.Name = "lblQualityMAx"
        Me.lblQualityMAx.Size = New System.Drawing.Size(32, 13)
        Me.lblQualityMAx.TabIndex = 7
        Me.lblQualityMAx.Text = " "
        Me.lblQualityMAx.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtComment
        '
        Me.txtComment.Enabled = False
        Me.txtComment.Location = New System.Drawing.Point(264, 109)
        Me.txtComment.Multiline = True
        Me.txtComment.Name = "txtComment"
        Me.txtComment.Size = New System.Drawing.Size(232, 99)
        Me.txtComment.TabIndex = 8
        Me.txtComment.Visible = False
        '
        'lblQualityPassingValue
        '
        Me.lblQualityPassingValue.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQualityPassingValue.Location = New System.Drawing.Point(458, 77)
        Me.lblQualityPassingValue.Name = "lblQualityPassingValue"
        Me.lblQualityPassingValue.Size = New System.Drawing.Size(41, 13)
        Me.lblQualityPassingValue.TabIndex = 19
        Me.lblQualityPassingValue.Text = " "
        Me.lblQualityPassingValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(376, 77)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(85, 13)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Passing Value:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(257, 77)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(77, 13)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Current Value:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblQualityCurrentValue
        '
        Me.lblQualityCurrentValue.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQualityCurrentValue.Location = New System.Drawing.Point(340, 77)
        Me.lblQualityCurrentValue.Name = "lblQualityCurrentValue"
        Me.lblQualityCurrentValue.Size = New System.Drawing.Size(41, 13)
        Me.lblQualityCurrentValue.TabIndex = 16
        Me.lblQualityCurrentValue.Text = " "
        Me.lblQualityCurrentValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtRating
        '
        Me.txtRating.BackColor = System.Drawing.Color.White
        Me.txtRating.Enabled = False
        Me.txtRating.Location = New System.Drawing.Point(264, 227)
        Me.txtRating.Name = "txtRating"
        Me.txtRating.Size = New System.Drawing.Size(232, 20)
        Me.txtRating.TabIndex = 15
        Me.txtRating.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(261, 211)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(85, 13)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "Overall Score:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblOverallScore
        '
        Me.lblOverallScore.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOverallScore.Location = New System.Drawing.Point(352, 211)
        Me.lblOverallScore.Name = "lblOverallScore"
        Me.lblOverallScore.Size = New System.Drawing.Size(41, 13)
        Me.lblOverallScore.TabIndex = 23
        Me.lblOverallScore.Text = " "
        Me.lblOverallScore.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmAudit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(509, 255)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lblQualityMin)
        Me.Controls.Add(Me.lblOverallScore)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lblQualityCurrentValue)
        Me.Controls.Add(Me.txtRating)
        Me.Controls.Add(Me.txtComment)
        Me.Controls.Add(Me.lblQualityMAx)
        Me.Controls.Add(Me.tbQuality)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lstCategory)
        Me.Controls.Add(Me.lblQualityPassingValue)
        Me.Name = "frmAudit"
        Me.Text = "Form1"
        CType(Me.tbQuality, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lstCategory As System.Windows.Forms.ListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents tbQuality As System.Windows.Forms.TrackBar
    Friend WithEvents lblQualityMin As System.Windows.Forms.Label
    Friend WithEvents lblQualityMAx As System.Windows.Forms.Label
    Friend WithEvents txtComment As System.Windows.Forms.TextBox
    Friend WithEvents lblQualityPassingValue As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lblQualityCurrentValue As System.Windows.Forms.Label
    Friend WithEvents txtRating As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents lblOverallScore As System.Windows.Forms.Label

End Class
