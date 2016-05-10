Public Class Settings

    Dim practiceBool, generateRandomBool As Boolean

    Private Sub Settings_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FormatPracticePanels()
    End Sub
    Private Sub FormatPracticePanels()
        'lblPractice.Location = New Point((settingsPanel.Width * 1 / 10) - (lblPractice.Width / 2), (settingsPanel.Height * 1 / 10) - (lblPractice.Height / 2))
        'btnPracticeYes.Location = New Point((settingsPanel.Width * 2 / 10) - (btnPracticeYes.Width / 2), (settingsPanel.Height * 1 / 10) - (btnPracticeYes.Height / 2))
        'btnPracticeNo.Location = New Point((settingsPanel.Width * 2.5 / 10) - (btnPracticeNo.Width / 2), (settingsPanel.Height * 1 / 10) - (btnPracticeNo.Height / 2))
        groupBoxPractice.Location = New Point((settingsPanel.Width * 0.5 / 10), (settingsPanel.Height * 0.5 / 10))

        'btnCancelSettings.Location = New Point((settingsPanel.Width * 9 / 10) - (btnCancelSettings.Width / 2), (settingsPanel.Height * 9 / 10) - (btnCancelSettings.Height / 2))
        'btnOKSettings.Location = New Point((settingsPanel.Width * 7.5 / 10) - (btnOKSettings.Width / 2), (settingsPanel.Height * 9 / 10) - (btnOKSettings.Height / 2))
    End Sub

#Region "Buttons/TextBoxes"
    'Clicks
    ''Practice? Clicks Section
    Private Sub btnPracticeYes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPracticeYes.Click
        btnPracticeYes.BackColor = Color.Gold
        btnPracticeYes.ForeColor = Color.Black
        btnPracticeNo.BackColor = Color.FromArgb(250, 250, 250)
        btnPracticeNo.ForeColor = Color.DimGray

        txtboxTimeToRespond.Visible = False
        lblRTF1.Visible = True
        txtBoxStandardDeviation.Visible = True

        practiceBool = True
    End Sub
    Private Sub btnPracticeNo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPracticeNo.Click
        btnPracticeNo.BackColor = Color.Gold
        btnPracticeNo.ForeColor = Color.Black
        btnPracticeYes.BackColor = Color.FromArgb(250, 250, 250)
        btnPracticeYes.ForeColor = Color.DimGray

        txtboxTimeToRespond.Visible = True
        lblRTF1.Visible = False
        txtBoxStandardDeviation.Visible = False

        practiceBool = False
    End Sub

    ''Random Test? Clicks Section

    ''OK/Cancel Clicks Section
    Private Sub btnExitSettings_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOKSettings.Click
        Me.Close()
    End Sub
    Private Sub btnCancelSettings_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelSettings.Click
        Me.Close()
    End Sub

    'Mouse Enter/Leave Events
    ''Practice? E/L Section
    Private Sub btnPracticeYes_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPracticeYes.MouseEnter
        btnPracticeYes.BackColor = Color.Gold
        btnPracticeYes.ForeColor = Color.Black
    End Sub
    Private Sub btnPracticeYes_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPracticeYes.MouseLeave
        If practiceBool = True Then
            btnPracticeYes.BackColor = Color.Gold
            btnPracticeYes.ForeColor = Color.Black
        Else
            btnPracticeYes.BackColor = Color.FromArgb(250, 250, 250)
            btnPracticeYes.ForeColor = Color.DimGray
        End If

    End Sub
    Private Sub btnPracticeNo_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPracticeNo.MouseEnter

        btnPracticeNo.BackColor = Color.Gold
        btnPracticeNo.ForeColor = Color.Black

    End Sub
    Private Sub btnPracticeNo_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPracticeNo.MouseLeave
        If practiceBool = False Then
            btnPracticeNo.BackColor = Color.Gold
            btnPracticeNo.ForeColor = Color.Black
        Else
            btnPracticeNo.BackColor = Color.FromArgb(250, 250, 250)
            btnPracticeNo.ForeColor = Color.DimGray
        End If
    End Sub
    Private Sub txtboxTimeToRespond_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtboxTimeToRespond.MouseEnter
        txtboxTimeToRespond.BackColor = Color.Gold
        txtboxTimeToRespond.ForeColor = Color.Black
    End Sub
    Private Sub txtboxTimeToRespond_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtboxTimeToRespond.MouseLeave
        txtboxTimeToRespond.BackColor = Color.FromArgb(250, 250, 250)
        txtboxTimeToRespond.ForeColor = Color.DarkGray
    End Sub
    Private Sub txtBoxStandardDeviation_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBoxStandardDeviation.MouseEnter
        txtBoxStandardDeviation.BackColor = Color.Gold
        txtBoxStandardDeviation.ForeColor = Color.Black
    End Sub
    Private Sub txtBoxStandardDeviation_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBoxStandardDeviation.MouseLeave
        txtBoxStandardDeviation.BackColor = Color.FromArgb(250, 250, 250)
        txtBoxStandardDeviation.ForeColor = Color.DarkGray
    End Sub

    ''Random Test? E/L Section
    Private Sub btnGenerateRandomYes_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerateRandomYes.MouseEnter
        btnGenerateRandomYes.BackColor = Color.Gold
        btnGenerateRandomYes.ForeColor = Color.Black
    End Sub
    Private Sub btnGenerateRandomYes_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerateRandomYes.MouseLeave
        If generateRandomBool = True Then
            btnGenerateRandomYes.BackColor = Color.Gold
            btnGenerateRandomYes.ForeColor = Color.Black
        Else
            btnGenerateRandomYes.BackColor = Color.FromArgb(250, 250, 250)
            btnGenerateRandomYes.ForeColor = Color.DimGray
        End If
    End Sub
    Private Sub btnGenerateRandomNo_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerateRandomNo.MouseEnter
        btnGenerateRandomNo.BackColor = Color.Gold
        btnGenerateRandomNo.ForeColor = Color.Black
    End Sub
    Private Sub btnGenerateRandomNo_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerateRandomNo.MouseLeave
        If generateRandomBool = False Then
            btnGenerateRandomNo.BackColor = Color.Gold
            btnGenerateRandomNo.ForeColor = Color.Black
        Else
            btnGenerateRandomNo.BackColor = Color.FromArgb(250, 250, 250)
            btnGenerateRandomNo.ForeColor = Color.DimGray
        End If
    End Sub
    Private Sub txtBoxFileName_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBoxFileName.MouseEnter
        txtBoxFileName.BackColor = Color.Gold
        txtBoxFileName.ForeColor = Color.Black
    End Sub
    Private Sub txtBoxFileName_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBoxFileName.MouseLeave
        txtBoxFileName.BackColor = Color.FromArgb(250, 250, 250)
        txtBoxFileName.ForeColor = Color.DarkGray
    End Sub

    Private Sub radioBtnRunTestFromFile_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radioBtnRunTestFromFile.MouseEnter
        radioBtnRunTestFromFile.BackColor = Color.Gold
        radioBtnRunTestFromFile.ForeColor = Color.Black
    End Sub
    Private Sub radioBtnRunTestFromFile_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radioBtnRunTestFromFile.MouseLeave
        radioBtnRunTestFromFile.BackColor = Color.FromArgb(250, 250, 250)
        radioBtnRunTestFromFile.ForeColor = Color.DarkGray
    End Sub

    ''OK/Cancel E/L Section
    Private Sub btnOKSettings_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOKSettings.MouseEnter
        'btnExitSettings.BackColor = Color.FromArgb(240, 248, 255)
        btnOKSettings.BackColor = Color.Gold
        btnOKSettings.ForeColor = Color.Black
    End Sub
    Private Sub btnOKSettings_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOKSettings.MouseLeave
        btnOKSettings.BackColor = Color.FromArgb(250, 250, 250)
        btnOKSettings.ForeColor = Color.DimGray
    End Sub
    Private Sub btnCancelSettings_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelSettings.MouseEnter
        btnCancelSettings.BackColor = Color.Gold
        btnCancelSettings.ForeColor = Color.Black
    End Sub
    Private Sub btnCancelSettings_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelSettings.MouseLeave
        btnCancelSettings.BackColor = Color.FromArgb(250, 250, 250)
        btnCancelSettings.ForeColor = Color.DimGray
    End Sub

#End Region


    Private Sub btnGenerateRandomYes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerateRandomYes.Click
        btnGenerateRandomYes.BackColor = Color.Gold
        btnGenerateRandomYes.ForeColor = Color.Black
        btnGenerateRandomNo.BackColor = Color.FromArgb(250, 250, 250)
        btnGenerateRandomNo.ForeColor = Color.DimGray

        lblFileName.Visible = False
        txtBoxFileName.Visible = False

        generateRandomBool = True
    End Sub

    Private Sub btnGenerateRandomNo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerateRandomNo.Click
        btnGenerateRandomNo.BackColor = Color.Gold
        btnGenerateRandomNo.ForeColor = Color.Black
        btnGenerateRandomYes.BackColor = Color.FromArgb(250, 250, 250)
        btnGenerateRandomYes.ForeColor = Color.DimGray

        lblFileName.Visible = True
        txtBoxFileName.Visible = True

        generateRandomBool = False
    End Sub
End Class