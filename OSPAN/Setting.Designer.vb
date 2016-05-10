<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Setting
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.cBoxPractice = New System.Windows.Forms.CheckBox()
        Me.cBoxWriteToFile = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblDirectory = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblFileName = New System.Windows.Forms.Label()
        Me.rBtnReadFromFile = New System.Windows.Forms.RadioButton()
        Me.rBtnGenerateRandomAOspan = New System.Windows.Forms.RadioButton()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.ttDirectory = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'cBoxPractice
        '
        Me.cBoxPractice.AutoSize = True
        Me.cBoxPractice.Location = New System.Drawing.Point(6, 19)
        Me.cBoxPractice.Name = "cBoxPractice"
        Me.cBoxPractice.Size = New System.Drawing.Size(63, 17)
        Me.cBoxPractice.TabIndex = 0
        Me.cBoxPractice.Text = "Practice"
        Me.cBoxPractice.UseVisualStyleBackColor = True
        '
        'cBoxWriteToFile
        '
        Me.cBoxWriteToFile.AutoSize = True
        Me.cBoxWriteToFile.Location = New System.Drawing.Point(6, 43)
        Me.cBoxWriteToFile.Name = "cBoxWriteToFile"
        Me.cBoxWriteToFile.Size = New System.Drawing.Size(80, 17)
        Me.cBoxWriteToFile.TabIndex = 1
        Me.cBoxWriteToFile.Text = "Write to File"
        Me.cBoxWriteToFile.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblDirectory)
        Me.GroupBox1.Controls.Add(Me.cBoxPractice)
        Me.GroupBox1.Controls.Add(Me.cBoxWriteToFile)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(165, 89)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        '
        'lblDirectory
        '
        Me.lblDirectory.AutoSize = True
        Me.lblDirectory.BackColor = System.Drawing.Color.White
        Me.lblDirectory.Location = New System.Drawing.Point(7, 67)
        Me.lblDirectory.MaximumSize = New System.Drawing.Size(150, 13)
        Me.lblDirectory.Name = "lblDirectory"
        Me.lblDirectory.Size = New System.Drawing.Size(49, 13)
        Me.lblDirectory.TabIndex = 2
        Me.lblDirectory.Text = "Directory"
        Me.lblDirectory.Visible = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblFileName)
        Me.GroupBox2.Controls.Add(Me.rBtnReadFromFile)
        Me.GroupBox2.Controls.Add(Me.rBtnGenerateRandomAOspan)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 107)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(166, 92)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        '
        'lblFileName
        '
        Me.lblFileName.AccessibleDescription = "hi"
        Me.lblFileName.AutoSize = True
        Me.lblFileName.BackColor = System.Drawing.Color.White
        Me.lblFileName.Location = New System.Drawing.Point(7, 68)
        Me.lblFileName.Name = "lblFileName"
        Me.lblFileName.Size = New System.Drawing.Size(51, 13)
        Me.lblFileName.TabIndex = 2
        Me.lblFileName.Text = "FileName"
        Me.lblFileName.Visible = False
        '
        'rBtnReadFromFile
        '
        Me.rBtnReadFromFile.AutoSize = True
        Me.rBtnReadFromFile.Location = New System.Drawing.Point(7, 44)
        Me.rBtnReadFromFile.Name = "rBtnReadFromFile"
        Me.rBtnReadFromFile.Size = New System.Drawing.Size(135, 17)
        Me.rBtnReadFromFile.TabIndex = 1
        Me.rBtnReadFromFile.TabStop = True
        Me.rBtnReadFromFile.Text = "Read AOspan From File"
        Me.rBtnReadFromFile.UseVisualStyleBackColor = True
        '
        'rBtnGenerateRandomAOspan
        '
        Me.rBtnGenerateRandomAOspan.AutoSize = True
        Me.rBtnGenerateRandomAOspan.Location = New System.Drawing.Point(7, 19)
        Me.rBtnGenerateRandomAOspan.Name = "rBtnGenerateRandomAOspan"
        Me.rBtnGenerateRandomAOspan.Size = New System.Drawing.Size(151, 17)
        Me.rBtnGenerateRandomAOspan.TabIndex = 0
        Me.rBtnGenerateRandomAOspan.TabStop = True
        Me.rBtnGenerateRandomAOspan.Text = "Generate Random AOspan"
        Me.rBtnGenerateRandomAOspan.UseVisualStyleBackColor = True
        '
        'btnOK
        '
        Me.btnOK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnOK.Location = New System.Drawing.Point(68, 209)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(52, 23)
        Me.btnOK.TabIndex = 4
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(126, 209)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(52, 23)
        Me.btnCancel.TabIndex = 5
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'Setting
        '
        Me.AcceptButton = Me.btnOK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(188, 240)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Setting"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Text = "AOspan Settings"
        Me.TopMost = True
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cBoxPractice As System.Windows.Forms.CheckBox
    Friend WithEvents cBoxWriteToFile As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lblFileName As System.Windows.Forms.Label
    Friend WithEvents rBtnReadFromFile As System.Windows.Forms.RadioButton
    Friend WithEvents rBtnGenerateRandomAOspan As System.Windows.Forms.RadioButton
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents lblDirectory As System.Windows.Forms.Label
    Friend WithEvents ttDirectory As System.Windows.Forms.ToolTip
End Class
