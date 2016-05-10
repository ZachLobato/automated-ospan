<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Settings
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
        Me.settingsPanel = New System.Windows.Forms.Panel()
        Me.groupBoxTest = New System.Windows.Forms.GroupBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.lblGenerateRandomTest = New System.Windows.Forms.Label()
        Me.lblFileName = New System.Windows.Forms.Label()
        Me.radioBtnRunTestFromFile = New System.Windows.Forms.Label()
        Me.txtBoxFileName = New System.Windows.Forms.Label()
        Me.btnGenerateRandomYes = New System.Windows.Forms.Label()
        Me.btnGenerateRandomNo = New System.Windows.Forms.Label()
        Me.groupBoxPractice = New System.Windows.Forms.GroupBox()
        Me.txtBoxStandardDeviation = New System.Windows.Forms.Label()
        Me.txtboxTimeToRespond = New System.Windows.Forms.Label()
        Me.lblRTF1 = New System.Windows.Forms.Label()
        Me.lblTimeToRespond = New System.Windows.Forms.Label()
        Me.lblPractice = New System.Windows.Forms.Label()
        Me.btnPracticeYes = New System.Windows.Forms.Label()
        Me.btnPracticeNo = New System.Windows.Forms.Label()
        Me.btnCancelSettings = New System.Windows.Forms.Label()
        Me.btnOKSettings = New System.Windows.Forms.Label()
        Me.settingsPanel.SuspendLayout()
        Me.groupBoxTest.SuspendLayout()
        Me.groupBoxPractice.SuspendLayout()
        Me.SuspendLayout()
        '
        'settingsPanel
        '
        Me.settingsPanel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.settingsPanel.BackColor = System.Drawing.Color.White
        Me.settingsPanel.Controls.Add(Me.groupBoxTest)
        Me.settingsPanel.Controls.Add(Me.groupBoxPractice)
        Me.settingsPanel.Controls.Add(Me.btnCancelSettings)
        Me.settingsPanel.Controls.Add(Me.btnOKSettings)
        Me.settingsPanel.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.settingsPanel.Location = New System.Drawing.Point(12, 12)
        Me.settingsPanel.Name = "settingsPanel"
        Me.settingsPanel.Size = New System.Drawing.Size(1238, 781)
        Me.settingsPanel.TabIndex = 0
        '
        'groupBoxTest
        '
        Me.groupBoxTest.Controls.Add(Me.ListBox1)
        Me.groupBoxTest.Controls.Add(Me.lblGenerateRandomTest)
        Me.groupBoxTest.Controls.Add(Me.lblFileName)
        Me.groupBoxTest.Controls.Add(Me.radioBtnRunTestFromFile)
        Me.groupBoxTest.Controls.Add(Me.txtBoxFileName)
        Me.groupBoxTest.Controls.Add(Me.btnGenerateRandomYes)
        Me.groupBoxTest.Controls.Add(Me.btnGenerateRandomNo)
        Me.groupBoxTest.Dock = System.Windows.Forms.DockStyle.Top
        Me.groupBoxTest.Location = New System.Drawing.Point(0, 89)
        Me.groupBoxTest.Name = "groupBoxTest"
        Me.groupBoxTest.Size = New System.Drawing.Size(1238, 226)
        Me.groupBoxTest.TabIndex = 3
        Me.groupBoxTest.TabStop = False
        '
        'ListBox1
        '
        Me.ListBox1.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 22
        Me.ListBox1.Location = New System.Drawing.Point(726, 106)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(79, 70)
        Me.ListBox1.TabIndex = 2
        '
        'lblGenerateRandomTest
        '
        Me.lblGenerateRandomTest.AutoSize = True
        Me.lblGenerateRandomTest.Font = New System.Drawing.Font("Calibri", 24.0!)
        Me.lblGenerateRandomTest.ForeColor = System.Drawing.Color.DarkGray
        Me.lblGenerateRandomTest.Location = New System.Drawing.Point(6, 16)
        Me.lblGenerateRandomTest.Name = "lblGenerateRandomTest"
        Me.lblGenerateRandomTest.Size = New System.Drawing.Size(366, 35)
        Me.lblGenerateRandomTest.TabIndex = 1
        Me.lblGenerateRandomTest.Text = "Generate Random OSPAN Test:"
        '
        'lblFileName
        '
        Me.lblFileName.AutoSize = True
        Me.lblFileName.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFileName.ForeColor = System.Drawing.Color.DarkGray
        Me.lblFileName.Location = New System.Drawing.Point(29, 55)
        Me.lblFileName.Name = "lblFileName"
        Me.lblFileName.Size = New System.Drawing.Size(84, 21)
        Me.lblFileName.TabIndex = 1
        Me.lblFileName.Text = "File Name:"
        '
        'radioBtnRunTestFromFile
        '
        Me.radioBtnRunTestFromFile.AutoSize = True
        Me.radioBtnRunTestFromFile.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.radioBtnRunTestFromFile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.radioBtnRunTestFromFile.Font = New System.Drawing.Font("Calibri", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radioBtnRunTestFromFile.ForeColor = System.Drawing.Color.DarkGray
        Me.radioBtnRunTestFromFile.Location = New System.Drawing.Point(644, 173)
        Me.radioBtnRunTestFromFile.Name = "radioBtnRunTestFromFile"
        Me.radioBtnRunTestFromFile.Size = New System.Drawing.Size(15, 13)
        Me.radioBtnRunTestFromFile.TabIndex = 1
        Me.radioBtnRunTestFromFile.Text = "    "
        '
        'txtBoxFileName
        '
        Me.txtBoxFileName.AutoSize = True
        Me.txtBoxFileName.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.txtBoxFileName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBoxFileName.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBoxFileName.ForeColor = System.Drawing.Color.DarkGray
        Me.txtBoxFileName.Location = New System.Drawing.Point(125, 55)
        Me.txtBoxFileName.Name = "txtBoxFileName"
        Me.txtBoxFileName.Size = New System.Drawing.Size(28, 23)
        Me.txtBoxFileName.TabIndex = 1
        Me.txtBoxFileName.Text = "    "
        '
        'btnGenerateRandomYes
        '
        Me.btnGenerateRandomYes.AutoSize = True
        Me.btnGenerateRandomYes.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.btnGenerateRandomYes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.btnGenerateRandomYes.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGenerateRandomYes.ForeColor = System.Drawing.Color.DimGray
        Me.btnGenerateRandomYes.Location = New System.Drawing.Point(383, 23)
        Me.btnGenerateRandomYes.Name = "btnGenerateRandomYes"
        Me.btnGenerateRandomYes.Size = New System.Drawing.Size(39, 28)
        Me.btnGenerateRandomYes.TabIndex = 0
        Me.btnGenerateRandomYes.Text = "On"
        '
        'btnGenerateRandomNo
        '
        Me.btnGenerateRandomNo.AutoSize = True
        Me.btnGenerateRandomNo.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.btnGenerateRandomNo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.btnGenerateRandomNo.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGenerateRandomNo.ForeColor = System.Drawing.Color.DimGray
        Me.btnGenerateRandomNo.Location = New System.Drawing.Point(435, 23)
        Me.btnGenerateRandomNo.Name = "btnGenerateRandomNo"
        Me.btnGenerateRandomNo.Size = New System.Drawing.Size(40, 28)
        Me.btnGenerateRandomNo.TabIndex = 0
        Me.btnGenerateRandomNo.Text = "Off"
        '
        'groupBoxPractice
        '
        Me.groupBoxPractice.Controls.Add(Me.txtBoxStandardDeviation)
        Me.groupBoxPractice.Controls.Add(Me.txtboxTimeToRespond)
        Me.groupBoxPractice.Controls.Add(Me.lblRTF1)
        Me.groupBoxPractice.Controls.Add(Me.lblTimeToRespond)
        Me.groupBoxPractice.Controls.Add(Me.lblPractice)
        Me.groupBoxPractice.Controls.Add(Me.btnPracticeYes)
        Me.groupBoxPractice.Controls.Add(Me.btnPracticeNo)
        Me.groupBoxPractice.Dock = System.Windows.Forms.DockStyle.Top
        Me.groupBoxPractice.Location = New System.Drawing.Point(0, 0)
        Me.groupBoxPractice.Name = "groupBoxPractice"
        Me.groupBoxPractice.Size = New System.Drawing.Size(1238, 89)
        Me.groupBoxPractice.TabIndex = 2
        Me.groupBoxPractice.TabStop = False
        '
        'txtBoxStandardDeviation
        '
        Me.txtBoxStandardDeviation.AutoSize = True
        Me.txtBoxStandardDeviation.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.txtBoxStandardDeviation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBoxStandardDeviation.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBoxStandardDeviation.ForeColor = System.Drawing.Color.DarkGray
        Me.txtBoxStandardDeviation.Location = New System.Drawing.Point(311, 50)
        Me.txtBoxStandardDeviation.Name = "txtBoxStandardDeviation"
        Me.txtBoxStandardDeviation.Size = New System.Drawing.Size(181, 23)
        Me.txtBoxStandardDeviation.TabIndex = 1
        Me.txtBoxStandardDeviation.Text = "2.5 x Standard Deviation"
        Me.txtBoxStandardDeviation.Visible = False
        '
        'txtboxTimeToRespond
        '
        Me.txtboxTimeToRespond.AutoSize = True
        Me.txtboxTimeToRespond.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.txtboxTimeToRespond.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtboxTimeToRespond.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtboxTimeToRespond.ForeColor = System.Drawing.Color.DarkGray
        Me.txtboxTimeToRespond.Location = New System.Drawing.Point(178, 50)
        Me.txtboxTimeToRespond.Name = "txtboxTimeToRespond"
        Me.txtboxTimeToRespond.Size = New System.Drawing.Size(96, 23)
        Me.txtboxTimeToRespond.TabIndex = 1
        Me.txtboxTimeToRespond.Text = "2000 mSecs"
        Me.txtboxTimeToRespond.Visible = False
        '
        'lblRTF1
        '
        Me.lblRTF1.AutoSize = True
        Me.lblRTF1.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRTF1.ForeColor = System.Drawing.Color.DarkGray
        Me.lblRTF1.Location = New System.Drawing.Point(178, 51)
        Me.lblRTF1.Name = "lblRTF1"
        Me.lblRTF1.Size = New System.Drawing.Size(116, 21)
        Me.lblRTF1.TabIndex = 1
        Me.lblRTF1.Text = "Average Time +"
        Me.lblRTF1.Visible = False
        '
        'lblTimeToRespond
        '
        Me.lblTimeToRespond.AutoSize = True
        Me.lblTimeToRespond.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTimeToRespond.ForeColor = System.Drawing.Color.DarkGray
        Me.lblTimeToRespond.Location = New System.Drawing.Point(29, 51)
        Me.lblTimeToRespond.Name = "lblTimeToRespond"
        Me.lblTimeToRespond.Size = New System.Drawing.Size(132, 21)
        Me.lblTimeToRespond.TabIndex = 1
        Me.lblTimeToRespond.Text = "Time to Respond:"
        '
        'lblPractice
        '
        Me.lblPractice.AutoSize = True
        Me.lblPractice.Font = New System.Drawing.Font("Calibri", 24.0!)
        Me.lblPractice.ForeColor = System.Drawing.Color.DarkGray
        Me.lblPractice.Location = New System.Drawing.Point(6, 12)
        Me.lblPractice.Name = "lblPractice"
        Me.lblPractice.Size = New System.Drawing.Size(113, 35)
        Me.lblPractice.TabIndex = 1
        Me.lblPractice.Text = "Practice:"
        '
        'btnPracticeYes
        '
        Me.btnPracticeYes.AutoSize = True
        Me.btnPracticeYes.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.btnPracticeYes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.btnPracticeYes.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPracticeYes.ForeColor = System.Drawing.Color.DimGray
        Me.btnPracticeYes.Location = New System.Drawing.Point(148, 16)
        Me.btnPracticeYes.Name = "btnPracticeYes"
        Me.btnPracticeYes.Size = New System.Drawing.Size(39, 28)
        Me.btnPracticeYes.TabIndex = 0
        Me.btnPracticeYes.Text = "On"
        '
        'btnPracticeNo
        '
        Me.btnPracticeNo.AutoSize = True
        Me.btnPracticeNo.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.btnPracticeNo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.btnPracticeNo.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPracticeNo.ForeColor = System.Drawing.Color.DimGray
        Me.btnPracticeNo.Location = New System.Drawing.Point(200, 16)
        Me.btnPracticeNo.Name = "btnPracticeNo"
        Me.btnPracticeNo.Size = New System.Drawing.Size(40, 28)
        Me.btnPracticeNo.TabIndex = 0
        Me.btnPracticeNo.Text = "Off"
        '
        'btnCancelSettings
        '
        Me.btnCancelSettings.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancelSettings.AutoSize = True
        Me.btnCancelSettings.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.btnCancelSettings.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.btnCancelSettings.Font = New System.Drawing.Font("Calibri", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelSettings.ForeColor = System.Drawing.Color.DimGray
        Me.btnCancelSettings.Location = New System.Drawing.Point(1070, 705)
        Me.btnCancelSettings.Name = "btnCancelSettings"
        Me.btnCancelSettings.Size = New System.Drawing.Size(137, 53)
        Me.btnCancelSettings.TabIndex = 0
        Me.btnCancelSettings.Text = "Cancel"
        '
        'btnOKSettings
        '
        Me.btnOKSettings.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnOKSettings.AutoSize = True
        Me.btnOKSettings.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.btnOKSettings.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.btnOKSettings.Font = New System.Drawing.Font("Calibri", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOKSettings.ForeColor = System.Drawing.Color.DimGray
        Me.btnOKSettings.Location = New System.Drawing.Point(980, 705)
        Me.btnOKSettings.Name = "btnOKSettings"
        Me.btnOKSettings.Size = New System.Drawing.Size(74, 53)
        Me.btnOKSettings.TabIndex = 0
        Me.btnOKSettings.Text = "OK"
        '
        'Settings
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.Crimson
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(1262, 805)
        Me.Controls.Add(Me.settingsPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Settings"
        Me.Text = "Settings"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.settingsPanel.ResumeLayout(False)
        Me.settingsPanel.PerformLayout()
        Me.groupBoxTest.ResumeLayout(False)
        Me.groupBoxTest.PerformLayout()
        Me.groupBoxPractice.ResumeLayout(False)
        Me.groupBoxPractice.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents settingsPanel As System.Windows.Forms.Panel
    Friend WithEvents btnOKSettings As System.Windows.Forms.Label
    Friend WithEvents btnCancelSettings As System.Windows.Forms.Label
    Friend WithEvents lblPractice As System.Windows.Forms.Label
    Friend WithEvents btnPracticeYes As System.Windows.Forms.Label
    Friend WithEvents btnPracticeNo As System.Windows.Forms.Label
    Friend WithEvents groupBoxPractice As System.Windows.Forms.GroupBox
    Friend WithEvents lblTimeToRespond As System.Windows.Forms.Label
    Friend WithEvents txtboxTimeToRespond As System.Windows.Forms.Label
    Friend WithEvents txtBoxStandardDeviation As System.Windows.Forms.Label
    Friend WithEvents lblRTF1 As System.Windows.Forms.Label
    Friend WithEvents lblGenerateRandomTest As System.Windows.Forms.Label
    Friend WithEvents groupBoxTest As System.Windows.Forms.GroupBox
    Friend WithEvents lblFileName As System.Windows.Forms.Label
    Friend WithEvents radioBtnRunTestFromFile As System.Windows.Forms.Label
    Friend WithEvents txtBoxFileName As System.Windows.Forms.Label
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents btnGenerateRandomYes As System.Windows.Forms.Label
    Friend WithEvents btnGenerateRandomNo As System.Windows.Forms.Label
End Class
