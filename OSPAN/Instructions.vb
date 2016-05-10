Public Class InstructionsWindow

    Declare Sub Sleep Lib "kernel32" Alias "Sleep" (ByVal dwMilliseconds As Long)
    Dim partID As String
    Dim x, w As Integer
    Dim randomNumberSingle As Single
    Dim randomNumberInteger As Integer

    Private Sub InstructionsWindow_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        btnBegin.Enabled = False
        'Entering/Validating the Participant ID:
        partID = InputBox("Please Enter Participant ID:", "Automated OSPAN")
        If partID = "" Then
            InstructionsWindow_Load(sender, e)
        End If

        RandomOspanCreation()
        randomTimer.Enabled = True
    End Sub
    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Application.Exit()
    End Sub
    Private Sub btnBegin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBegin.Click
        Dim questionScreen As New QuestionScreen(partID, True, 0, 0)
        questionScreen.Show()
        Me.Visible = False
    End Sub

    Private Sub InstructionsWindow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Click
        btnBegin.PerformClick()
    End Sub
    '*****If you figure out how the weights affect the random number generation, you can fix it here**********
    Private Sub RandomOspanCreation()

        Dim fileName As String = "RandomTrial.csv"
        Dim lettersInBoxes As String = "FHJKLNPQRSTY"
        Dim lettersToChooseFrom As String = "FHJKLNPQRSTY"
        Dim numOfTrialsLeft As Integer = 20
        Dim currentSetSize, currentTrialInSet, multDivA, multDivB, addSub, answer As Integer
        Dim newLineEquation, multOrDiv, addOrSub, trueOrFalse, randomVariable As String
        Dim newFile As Boolean = True

        My.Computer.FileSystem.WriteAllText("RandomTrial.csv", "", False)

        While numOfTrialsLeft > 0
            currentSetSize = 0
            currentTrialInSet = 0
            lettersToChooseFrom = "FHJKLNPQRSTY"

            While currentSetSize < 3 Or currentSetSize > 7
                currentSetSize = GetRandomNumber(3, 7)
                If (numOfTrialsLeft - currentSetSize) < 3 And (numOfTrialsLeft - currentSetSize) <> 0 Then
                    currentSetSize = 0
                End If
            End While

            If newFile Then
                My.Computer.FileSystem.WriteAllText(fileName, lettersInBoxes & "," & currentSetSize & "," & Environment.NewLine, False)
                newFile = False
            Else
                My.Computer.FileSystem.WriteAllText(fileName, lettersInBoxes & "," & currentSetSize & "," & Environment.NewLine, True)
            End If

            While currentTrialInSet < currentSetSize
                If GetRandomNumber(1, 10) < 6 Then
                    multOrDiv = "*"
                Else
                    multOrDiv = "/"
                End If

                If GetRandomNumber(1, 20) > 10 Then
                    addOrSub = "+"
                Else
                    addOrSub = "-"
                End If

                If GetRandomNumber(1, 40) < 21 Then
                    trueOrFalse = "True"
                Else
                    trueOrFalse = "False"
                End If

                randomVariable = Mid(lettersToChooseFrom, GetRandomNumber(1, lettersToChooseFrom.Count), 1)
                lettersToChooseFrom = Replace(lettersToChooseFrom, randomVariable, "")

                answer = 999

                If multOrDiv = "/" Then
                    multDivB = GetRandomNumber(1, 9)
                    While multDivA = 0 Or (multDivA Mod multDivB) <> 0
                        multDivA = GetRandomNumber(1, 9)
                    End While

                    If addOrSub = "-" Then
                        While addSub = 0 Or ((multDivA / multDivB) - addSub) < 0
                            addSub = GetRandomNumber(1, 9)
                        End While
                    Else
                        addSub = GetRandomNumber(1, 9)
                    End If

                    If trueOrFalse = "False" Then
                        While answer = 999 Or answer < 0
                            If addOrSub = "-" Then
                                answer = (((multDivA / multDivB) - addSub) + GetRandomNumber(1, 9))
                            Else
                                answer = (((multDivA / multDivB) + addSub) + GetRandomNumber(1, 9))
                            End If
                        End While
                    Else
                        If addOrSub = "-" Then
                            answer = (((multDivA / multDivB) - addSub))
                        Else
                            answer = (((multDivA / multDivB) + addSub))
                        End If
                    End If

                    newLineEquation = "(" & multDivA.ToString() & "/" & multDivB.ToString() & ")" & " " & addOrSub & " " & addSub & " = ?," & answer & "," & trueOrFalse & "," & randomVariable & ","
                    My.Computer.FileSystem.WriteAllText(fileName, newLineEquation & Environment.NewLine, True)
                Else
                    If (w Mod 2) = 0 Then
                        multDivB = GetRandomNumber(1, 9)
                        If multDivB = 8 Or 2 Then
                            While multDivA * multDivB = 0 Or multDivA * multDivB > 17
                                multDivA = GetRandomNumber(1, 9)
                            End While
                        Else
                            While multDivA * multDivB = 0 Or multDivA * multDivB > 16
                                multDivA = GetRandomNumber(1, 9)
                            End While
                        End If
                        w = w + 1
                    Else
                        multDivA = GetRandomNumber(1, 9)
                        If multDivA = 8 Or 2 Then
                            While multDivB * multDivA = 0 Or multDivB * multDivA > 17
                                multDivB = GetRandomNumber(1, 9)
                            End While
                        Else
                            While multDivA * multDivB = 0 Or multDivA * multDivB > 16
                                multDivB = GetRandomNumber(1, 9)
                            End While
                        End If
                        w = w + 1
                    End If

                    If addOrSub = "-" Then
                        While addSub = 0 Or ((multDivA * multDivB) - addSub) < 0
                            addSub = GetRandomNumber(1, 9)
                        End While
                    Else
                        addSub = GetRandomNumber(1, 9)
                    End If

                    If trueOrFalse = "False" Then
                        While answer = 999 Or answer < 0
                            If addOrSub = "-" Then
                                answer = (((multDivA * multDivB) - addSub) + GetRandomNumber(1, 9))
                            Else
                                answer = (((multDivA * multDivB) + addSub) + GetRandomNumber(1, 9))
                            End If
                        End While
                    Else
                        If addOrSub = "-" Then
                            answer = (((multDivA * multDivB) - addSub))
                        Else
                            answer = (((multDivA * multDivB) + addSub))
                        End If
                    End If

                    newLineEquation = "(" & multDivA.ToString() & " * " & multDivB.ToString() & ")" & " " & addOrSub & " " & addSub & " = ?," & answer & "," & trueOrFalse & "," & randomVariable & ","
                    My.Computer.FileSystem.WriteAllText(fileName, newLineEquation & Environment.NewLine, True)
                End If
                currentTrialInSet = currentTrialInSet + 1

            End While

            numOfTrialsLeft = numOfTrialsLeft - currentSetSize

        End While
    End Sub

    Public Function GetRandomNumber(Optional ByVal Low As Integer = 1, Optional ByVal High As Integer = 100)

        Randomize()
        'randomNumber = CInt(Int((High * Rnd()) + Low))
        randomNumberSingle = Rnd()
        randomNumberSingle = (High * randomNumberSingle) + Low - 0.5
        randomNumberInteger = CInt(randomNumberSingle)
        Return randomNumberInteger

    End Function


    Private Sub randomTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles randomTimer.Tick
        btnBegin.Enabled = True
        randomTimer.Enabled = False
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub
    Private Sub SettingsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SettingsToolStripMenuItem.Click
        Dim settingsWindow As New Settings
        'settingsWindow.Show()
        Setting.Show()
    End Sub
End Class