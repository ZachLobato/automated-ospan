Imports System.IO

Public Class Setting

#Region "Variables"

    Dim boolPractice As Boolean
    Dim boolWriteToFile As Boolean
    Dim boolGenerateRandomAOspan As Boolean

    Dim stringSaveLocation As String
    Dim stringReadFileLocation As String



#End Region

#Region "Load"

    Private Sub Setting_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load



        Dim readText() As String = File.ReadAllLines("settings.cfg")
        Dim ConfigOptions(20), s As String
        Dim k As Integer
        k = 0
        For Each s In readText
            k = k + 1
            ConfigOptions(k) = s
        Next

        boolPractice = Mid(ConfigOptions(1), 1, ConfigOptions(1).Count)
        boolWriteToFile = Mid(ConfigOptions(2), 1, ConfigOptions(2).Count)
        boolGenerateRandomAOspan = Mid(ConfigOptions(4), 1, ConfigOptions(4).Count)

        stringSaveLocation = Mid(ConfigOptions(3), 1, ConfigOptions(3).Count)
        stringReadFileLocation = Mid(ConfigOptions(5), 1, ConfigOptions(5).Count)

        lblDirectory.Text = stringSaveLocation
        ttDirectory.SetToolTip(Me.lblDirectory, lblDirectory.Text)
        lblFileName.Text = Mid(stringReadFileLocation, stringReadFileLocation.LastIndexOf("\") + 2, (stringReadFileLocation.Count - stringReadFileLocation.LastIndexOf("\")))


        If (boolPractice = True) Then

            cBoxPractice.Checked = True

        Else

            cBoxPractice.Checked = False

        End If


        If (boolWriteToFile = True) Then

            cBoxWriteToFile.Checked = True
            lblDirectory.Visible = True

        Else

            cBoxWriteToFile.Checked = False

        End If


        If (boolGenerateRandomAOspan = True) Then

            rBtnGenerateRandomAOspan.Select()

        Else

            rBtnReadFromFile.Select()
            lblFileName.Visible = True

        End If

    End Sub

#End Region

#Region "Buttons"

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        Me.Close()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

#End Region


    Private Sub cBoxPractice_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cBoxPractice.CheckedChanged

        If (cBoxPractice.Checked = False) Then

            boolPractice = False

        Else

            boolPractice = True

        End If

    End Sub

    Private Sub cBoxWriteToFile_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cBoxWriteToFile.CheckedChanged

        If (cBoxWriteToFile.Checked = False) Then
            boolWriteToFile = False
            lblDirectory.Visible = False
        Else
            boolWriteToFile = True
            lblDirectory.Visible = True
        End If

    End Sub

    Private Sub rBtnGenerateRandomAOspan_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rBtnGenerateRandomAOspan.CheckedChanged

        If (rBtnGenerateRandomAOspan.Checked = True) Then
            boolGenerateRandomAOspan = True
            lblFileName.Visible = False
        End If

    End Sub

    Private Sub rBtnReadFromFile_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rBtnReadFromFile.CheckedChanged

        If (rBtnReadFromFile.Checked = True) Then
            boolGenerateRandomAOspan = False
            lblFileName.Visible = True
        End If

    End Sub
End Class