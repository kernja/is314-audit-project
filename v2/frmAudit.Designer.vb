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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.lblName = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.lblQualityMin = New System.Windows.Forms.Label
        Me.lblOverallScore = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.lblQualityCurrentValue = New System.Windows.Forms.Label
        Me.txtRating = New System.Windows.Forms.TextBox
        Me.txtComment = New System.Windows.Forms.TextBox
        Me.lblQualityMAx = New System.Windows.Forms.Label
        Me.tbQuality = New System.Windows.Forms.TrackBar
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.lstCategory = New System.Windows.Forms.ListBox
        Me.lblQualityPassingValue = New System.Windows.Forms.Label
        Me.lblHeader = New System.Windows.Forms.Label
        Me.btnCommit = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.tbQuality, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.PictureBox1.Location = New System.Drawing.Point(-2, -18)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(70, 395)
        Me.PictureBox1.TabIndex = 24
        Me.PictureBox1.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblName)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.lblQualityMin)
        Me.GroupBox1.Controls.Add(Me.lblOverallScore)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.lblQualityCurrentValue)
        Me.GroupBox1.Controls.Add(Me.txtRating)
        Me.GroupBox1.Controls.Add(Me.txtComment)
        Me.GroupBox1.Controls.Add(Me.lblQualityMAx)
        Me.GroupBox1.Controls.Add(Me.tbQuality)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.lstCategory)
        Me.GroupBox1.Controls.Add(Me.lblQualityPassingValue)
        Me.GroupBox1.Location = New System.Drawing.Point(74, 43)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(511, 289)
        Me.GroupBox1.TabIndex = 25
        Me.GroupBox1.TabStop = False
        '
        'lblName
        '
        Me.lblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(69, 16)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(184, 13)
        Me.lblName.TabIndex = 40
        Me.lblName.Text = "Passing Value:"
        Me.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 13)
        Me.Label4.TabIndex = 39
        Me.Label4.Text = "Auditor:"
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(259, 90)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(77, 13)
        Me.Label7.TabIndex = 34
        Me.Label7.Text = "Current Value:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblQualityMin
        '
        Me.lblQualityMin.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQualityMin.Location = New System.Drawing.Point(273, 64)
        Me.lblQualityMin.Name = "lblQualityMin"
        Me.lblQualityMin.Size = New System.Drawing.Size(32, 13)
        Me.lblQualityMin.TabIndex = 29
        Me.lblQualityMin.Text = " "
        Me.lblQualityMin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblOverallScore
        '
        Me.lblOverallScore.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOverallScore.Location = New System.Drawing.Point(343, 231)
        Me.lblOverallScore.Name = "lblOverallScore"
        Me.lblOverallScore.Size = New System.Drawing.Size(75, 13)
        Me.lblOverallScore.TabIndex = 38
        Me.lblOverallScore.Text = " "
        Me.lblOverallScore.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(264, 231)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(85, 13)
        Me.Label10.TabIndex = 37
        Me.Label10.Text = "Overall Score:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(378, 90)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(85, 13)
        Me.Label6.TabIndex = 35
        Me.Label6.Text = "Passing Value:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblQualityCurrentValue
        '
        Me.lblQualityCurrentValue.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQualityCurrentValue.Location = New System.Drawing.Point(342, 90)
        Me.lblQualityCurrentValue.Name = "lblQualityCurrentValue"
        Me.lblQualityCurrentValue.Size = New System.Drawing.Size(41, 13)
        Me.lblQualityCurrentValue.TabIndex = 33
        Me.lblQualityCurrentValue.Text = " "
        Me.lblQualityCurrentValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtRating
        '
        Me.txtRating.BackColor = System.Drawing.Color.White
        Me.txtRating.Enabled = False
        Me.txtRating.Location = New System.Drawing.Point(267, 254)
        Me.txtRating.Name = "txtRating"
        Me.txtRating.Size = New System.Drawing.Size(232, 20)
        Me.txtRating.TabIndex = 32
        Me.txtRating.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtComment
        '
        Me.txtComment.Enabled = False
        Me.txtComment.Location = New System.Drawing.Point(267, 125)
        Me.txtComment.Multiline = True
        Me.txtComment.Name = "txtComment"
        Me.txtComment.Size = New System.Drawing.Size(232, 99)
        Me.txtComment.TabIndex = 31
        Me.txtComment.Visible = False
        '
        'lblQualityMAx
        '
        Me.lblQualityMAx.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQualityMAx.Location = New System.Drawing.Point(470, 64)
        Me.lblQualityMAx.Name = "lblQualityMAx"
        Me.lblQualityMAx.Size = New System.Drawing.Size(32, 13)
        Me.lblQualityMAx.TabIndex = 30
        Me.lblQualityMAx.Text = " "
        Me.lblQualityMAx.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tbQuality
        '
        Me.tbQuality.Enabled = False
        Me.tbQuality.LargeChange = 1
        Me.tbQuality.Location = New System.Drawing.Point(276, 32)
        Me.tbQuality.Name = "tbQuality"
        Me.tbQuality.Size = New System.Drawing.Size(223, 45)
        Me.tbQuality.TabIndex = 28
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(259, 109)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 13)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "Comments"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(259, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 13)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Quality Scale"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Items"
        '
        'lstCategory
        '
        Me.lstCategory.FormattingEnabled = True
        Me.lstCategory.Location = New System.Drawing.Point(15, 62)
        Me.lstCategory.Name = "lstCategory"
        Me.lstCategory.Size = New System.Drawing.Size(238, 212)
        Me.lstCategory.TabIndex = 24
        '
        'lblQualityPassingValue
        '
        Me.lblQualityPassingValue.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQualityPassingValue.Location = New System.Drawing.Point(458, 90)
        Me.lblQualityPassingValue.Name = "lblQualityPassingValue"
        Me.lblQualityPassingValue.Size = New System.Drawing.Size(41, 13)
        Me.lblQualityPassingValue.TabIndex = 36
        Me.lblQualityPassingValue.Text = " "
        Me.lblQualityPassingValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblHeader
        '
        Me.lblHeader.AutoSize = True
        Me.lblHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeader.Location = New System.Drawing.Point(74, 9)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(107, 31)
        Me.lblHeader.TabIndex = 26
        Me.lblHeader.Text = "Auditor"
        '
        'btnCommit
        '
        Me.btnCommit.Location = New System.Drawing.Point(474, 338)
        Me.btnCommit.Name = "btnCommit"
        Me.btnCommit.Size = New System.Drawing.Size(109, 23)
        Me.btnCommit.TabIndex = 27
        Me.btnCommit.Text = "Commit Changes"
        Me.btnCommit.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(359, 338)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(109, 23)
        Me.Button2.TabIndex = 28
        Me.Button2.Text = "Cancel"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'frmAudit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(591, 373)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnCommit)
        Me.Controls.Add(Me.lblHeader)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "frmAudit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Auditor"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.tbQuality, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lblQualityMin As System.Windows.Forms.Label
    Friend WithEvents lblOverallScore As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblQualityCurrentValue As System.Windows.Forms.Label
    Friend WithEvents txtRating As System.Windows.Forms.TextBox
    Friend WithEvents txtComment As System.Windows.Forms.TextBox
    Friend WithEvents lblQualityMAx As System.Windows.Forms.Label
    Friend WithEvents tbQuality As System.Windows.Forms.TrackBar
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lstCategory As System.Windows.Forms.ListBox
    Friend WithEvents lblQualityPassingValue As System.Windows.Forms.Label
    Friend WithEvents lblHeader As System.Windows.Forms.Label
    Friend WithEvents btnCommit As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label

End Class
