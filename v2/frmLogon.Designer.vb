<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogon
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
        Me.txtPass = New System.Windows.Forms.TextBox
        Me.btnLogon = New System.Windows.Forms.Button
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.lblHeader = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.grpMenu = New System.Windows.Forms.GroupBox
        Me.btnUser = New System.Windows.Forms.Button
        Me.btnLogOff = New System.Windows.Forms.Button
        Me.btnViewTables = New System.Windows.Forms.Button
        Me.btnAudit = New System.Windows.Forms.Button
        Me.cboUserNames = New System.Windows.Forms.ComboBox
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtPass
        '
        Me.txtPass.Location = New System.Drawing.Point(142, 102)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPass.Size = New System.Drawing.Size(137, 20)
        Me.txtPass.TabIndex = 1
        '
        'btnLogon
        '
        Me.btnLogon.Location = New System.Drawing.Point(204, 128)
        Me.btnLogon.Name = "btnLogon"
        Me.btnLogon.Size = New System.Drawing.Size(75, 23)
        Me.btnLogon.TabIndex = 2
        Me.btnLogon.Text = "Log On"
        Me.btnLogon.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.PictureBox1.Location = New System.Drawing.Point(-1, -6)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(70, 314)
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'lblHeader
        '
        Me.lblHeader.AutoSize = True
        Me.lblHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeader.Location = New System.Drawing.Point(75, 9)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(94, 31)
        Me.lblHeader.TabIndex = 4
        Me.lblHeader.Text = "Logon"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(81, 81)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Username"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(81, 102)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Password"
        '
        'grpMenu
        '
        Me.grpMenu.Controls.Add(Me.btnUser)
        Me.grpMenu.Controls.Add(Me.btnLogOff)
        Me.grpMenu.Controls.Add(Me.btnViewTables)
        Me.grpMenu.Controls.Add(Me.btnAudit)
        Me.grpMenu.Location = New System.Drawing.Point(81, 43)
        Me.grpMenu.Name = "grpMenu"
        Me.grpMenu.Size = New System.Drawing.Size(205, 177)
        Me.grpMenu.TabIndex = 7
        Me.grpMenu.TabStop = False
        Me.grpMenu.Visible = False
        '
        'btnUser
        '
        Me.btnUser.Location = New System.Drawing.Point(6, 45)
        Me.btnUser.Name = "btnUser"
        Me.btnUser.Size = New System.Drawing.Size(193, 25)
        Me.btnUser.TabIndex = 11
        Me.btnUser.Text = "Add additional users"
        Me.btnUser.UseVisualStyleBackColor = True
        '
        'btnLogOff
        '
        Me.btnLogOff.Location = New System.Drawing.Point(6, 146)
        Me.btnLogOff.Name = "btnLogOff"
        Me.btnLogOff.Size = New System.Drawing.Size(193, 25)
        Me.btnLogOff.TabIndex = 2
        Me.btnLogOff.Text = "Log Off"
        Me.btnLogOff.UseVisualStyleBackColor = True
        '
        'btnViewTables
        '
        Me.btnViewTables.Location = New System.Drawing.Point(6, 74)
        Me.btnViewTables.Name = "btnViewTables"
        Me.btnViewTables.Size = New System.Drawing.Size(193, 25)
        Me.btnViewTables.TabIndex = 1
        Me.btnViewTables.Text = "View all tables in database"
        Me.btnViewTables.UseVisualStyleBackColor = True
        '
        'btnAudit
        '
        Me.btnAudit.Location = New System.Drawing.Point(6, 17)
        Me.btnAudit.Name = "btnAudit"
        Me.btnAudit.Size = New System.Drawing.Size(193, 25)
        Me.btnAudit.TabIndex = 0
        Me.btnAudit.Text = "Perform an audit"
        Me.btnAudit.UseVisualStyleBackColor = True
        '
        'cboUserNames
        '
        Me.cboUserNames.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboUserNames.FormattingEnabled = True
        Me.cboUserNames.Location = New System.Drawing.Point(142, 78)
        Me.cboUserNames.Name = "cboUserNames"
        Me.cboUserNames.Size = New System.Drawing.Size(137, 21)
        Me.cboUserNames.TabIndex = 10
        '
        'frmLogon
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(301, 241)
        Me.Controls.Add(Me.grpMenu)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblHeader)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnLogon)
        Me.Controls.Add(Me.txtPass)
        Me.Controls.Add(Me.cboUserNames)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(309, 270)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(309, 270)
        Me.Name = "frmLogon"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Auditor"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpMenu.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtPass As System.Windows.Forms.TextBox
    Friend WithEvents btnLogon As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lblHeader As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents grpMenu As System.Windows.Forms.GroupBox
    Friend WithEvents btnAudit As System.Windows.Forms.Button
    Friend WithEvents btnLogOff As System.Windows.Forms.Button
    Friend WithEvents btnViewTables As System.Windows.Forms.Button
    Friend WithEvents cboUserNames As System.Windows.Forms.ComboBox
    Friend WithEvents btnUser As System.Windows.Forms.Button
End Class
