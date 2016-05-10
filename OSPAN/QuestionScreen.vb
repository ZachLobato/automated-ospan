Imports System.IO
Imports System.Reflection
Imports System.Diagnostics

Public Class QuestionScreen

#Region "Variables"

    Public nameString, answerString, participantTrialString(), readText(), storageString(), tempLettersHolderValues(100) As String
    Private taskArrayList As New ArrayList
    Dim numOfTasks, numCounterTasks, numCounterTrials, numArrayIntegerCounter, tempLettersIntegerCounter, tempLettersValuesCountInteger As Integer
    Dim practiceInstructionsSubCount As Single
    Dim practiceInt1 As Integer
    Dim mathTotalCount, mathErrors, tempMathErrors, mathSpeedErrors, ospanTotalMissed, tempOspanMissed, calculateAverageTimeCount, notOspanScore As Integer
    Dim correctBool, doneBool, applicationExit, practiceOspanBool, calculateAverageTime, useTimer As Boolean
    Dim Screen As String = "btnContinue"
    Dim fontSize As Single = 10
    Dim startTime As Date
    Dim endTime As TimeSpan
    Dim timesToAnswer(14), averageTime, standardDevation As Double
    Dim checkForTestBool, checkForTestBoolB As Boolean

    Dim timeToDoMathStopwatch, timeToClickTrueFalseStopwatch, timeToClickLettersStopwatch As New Stopwatch

#End Region

#Region "Logical Stuff"

    Public Sub New(ByVal name As String, ByVal practiceOspan As Boolean, ByVal avgTimeToRespond As Double, ByVal standardDeviationOfParticipant As Double)
        InitializeComponent()
        averageTime = avgTimeToRespond
        standardDevation = standardDeviationOfParticipant
        If avgTimeToRespond = 0 Then
            useTimer = False
        Else
            useTimer = True
            timeToRespond.Interval = averageTime + (2.5 * standardDevation)
        End If
        nameString = name
        'practiceOspanBool = practiceOspan
        practiceOspanBool = False
    End Sub
    Private Sub QuestionScreen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ' Runs Practice Ospan or Real Ospan
        LoadTask()
        LoopToFinishOspan()
        FormatPanels()

    End Sub
    '****stuff to do LoadTask()*******
    Private Sub LoadTask()
        Me.KeyPreview = True

        pnlQuestion.BringToFront()

        pnlPracticeInstructions.Location = New Point(0, 0)
        pnlPracticeInstructions.Size = New Size(Me.Width, Me.Height)
        lblPracticeInstructions.Font = New Font(lblPracticeInstructions.Font.FontFamily, fontSize, lblPracticeInstructions.Font.Style)

        ' Open the file to read from.

        If practiceOspanBool Then
            readText = File.ReadAllLines("Practice.csv")
        Else
            readText = File.ReadAllLines("RandomTrial.csv")

            Dim tempInteger As Integer
            Dim tempIntegerTwo As Integer

            While checkForTestBoolB = False
                If readText(tempInteger).Contains(":") Or readText(tempInteger).Contains("=") Or readText(tempInteger).Contains("#") Or readText(tempInteger).Count = 0 Then
                    tempInteger = tempInteger + 1
                Else
                    checkForTestBoolB = True
                End If
            End While

            tempIntegerTwo = readText.Count

            participantTrialString = New String(tempIntegerTwo - tempInteger) {}

            Array.Copy(readText, tempInteger, participantTrialString, 0, tempIntegerTwo - tempInteger)

        End If

        Dim QuestionSet As Task = New Task
        Dim k As Integer = 0

        ' This loop reads all of the tasks and creates objects out of them as well.
        For Each s In readText

            '*************Make it so it also ignores lines with a '~"s in them (so we can put any feedback want to in the output file).*****************
            'Right now it is saying If the line isn't a number and it doesn't contain an equals sign, then read it... haha I think the only part of this that is actually useful
            'is the bit about the equals sign. So you could probably get rid of the IsNumeric stuff somehow...haha or just leave it in there.
            If s.Contains("=") = False And s.Contains(":") = False And s.Contains("#") = False And s.Count <> 0 Then
                numOfTasks = numOfTasks + 1

                Dim FirstX = s.IndexOf(",")
                Dim LastX = s.LastIndexOf(",") - FirstX - 1

                Dim Num = Integer.Parse(Mid(s, FirstX + 2, LastX))
                Dim x As Integer = 0
                QuestionSet = New Task
                QuestionSet.LettersInBoxes = Mid(s, 1, FirstX)
                QuestionSet.NumberOfTrials = Num

                '**********change variable names from candy**************
                'Haha terrible variable names... I just needed 4 temporary variables and that was all I could think of...could probably change them to sizeQuestionsArray, sizeAnswersArray..etc...
                'and in Visual Studio there is a great way to rename variables. You right-click on them and click the rename button and it will rename all instances of that variable (of which I 
                'now realize there are only two for these variable :D and I could have changed myself in the time that it took to write of all of this haha oh well. 
                Dim candy(Num - 1) As String
                Dim candy2(Num - 1) As Integer
                Dim candy3(Num - 1) As Boolean
                Dim candy4(Num - 1) As String
                QuestionSet.Questions = candy
                QuestionSet.Answers = candy2
                QuestionSet.Booleans = candy3
                QuestionSet.LetterAnswers = candy4
                Dim startIndex = 0
                Dim stopIndex = 0
                While x < Num
                    x = x + 1
                    startIndex = startIndex + 1
                    stopIndex = readText(x + k).IndexOf(",") - startIndex + 1
                    QuestionSet.Questions(x - 1) = Mid(readText(x + k), startIndex, stopIndex)

                    startIndex = stopIndex + 1
                    stopIndex = readText(x + k).IndexOf(",", startIndex) - startIndex
                    QuestionSet.Answers(x - 1) = Mid(readText(x + k), startIndex + 1, stopIndex)

                    startIndex = startIndex + stopIndex + 1
                    stopIndex = readText(x + k).IndexOf(",", startIndex) - startIndex
                    QuestionSet.Booleans(x - 1) = Mid(readText(x + k), startIndex + 1, stopIndex)

                    startIndex = startIndex + stopIndex + 1
                    stopIndex = readText(x + k).IndexOf(",", startIndex) - startIndex
                    QuestionSet.LetterAnswers(x - 1) = Mid(readText(x + k), startIndex + 1, stopIndex)

                    startIndex = 0
                    stopIndex = 0
                End While
                taskArrayList.Add(QuestionSet)
            End If

            k = k + 1
        Next

    End Sub
    Private Sub LoopToFinishOspan()

        If practiceOspanBool Then
            UpdatePracticeInstructions()
        End If

        If numCounterTasks < numOfTasks Then
            If numCounterTrials < taskArrayList(numCounterTasks).NumberOfTrials Then

                numArrayIntegerCounter = numArrayIntegerCounter + 1

                If practiceOspanBool = False Then

                    If numCounterTasks = 0 And numCounterTrials = 0 Then
                        participantTrialString(0) = ":" + participantTrialString(0)
                        participantTrialString(numArrayIntegerCounter) = participantTrialString(numArrayIntegerCounter) + Now().ToLongTimeString + ","
                        timeToDoMathStopwatch.Start()
                        timeToDoMathStopwatch.Restart()
                    Else
                        participantTrialString(numArrayIntegerCounter) = participantTrialString(numArrayIntegerCounter) + Now().ToLongTimeString + ","
                        timeToDoMathStopwatch.Restart()
                    End If

                End If

                lblMathQuestion.Text = taskArrayList(numCounterTasks).Questions(numCounterTrials)
                'masterTextBox.Focus()
                'Keeps Question Centered
                lblMathQuestion.Location = New Point((pnlQuestion.Width / 2) - (lblMathQuestion.Width / 2), (pnlQuestion.Height / 2) - (lblMathQuestion.Height / 2) - 50)

                lblMathAnswer.Text = taskArrayList(numCounterTasks).Answers(numCounterTrials).ToString()
                correctBool = taskArrayList(numCounterTasks).Booleans(numCounterTrials)
                lblLetterAnswer.Text = taskArrayList(numCounterTasks).LetterAnswers(numCounterTrials).ToString()

                answerString = answerString + lblLetterAnswer.Text

                numCounterTrials = numCounterTrials + 1

                If useTimer = True Then
                    timeToRespond.Enabled = True
                End If

                If practiceOspanBool = True And CType(numCounterTasks + practiceInstructionsSubCount, Single) > CType(0.3, Single) And CType(numCounterTasks + practiceInstructionsSubCount, Single) < CType(4, Single) Then
                    timerLetterPanelShow.Enabled = True
                End If



            Else
                If practiceOspanBool = False Then
                    numArrayIntegerCounter = numArrayIntegerCounter + 1
                    participantTrialString(numArrayIntegerCounter) = ":" + participantTrialString(numArrayIntegerCounter)
                    numArrayIntegerCounter = numArrayIntegerCounter + 1
                End If
                'timerFeedback.Enabled = True
                If practiceOspanBool And CType((numCounterTasks + practiceInstructionsSubCount), Single) = CType(4.4, Single) Then
                    pnlFeedback.Visible = True
                    pnlQuestion.Visible = False
                    pnlLetter.Visible = False
                    pnlAnswer.Visible = False
                    lblPnlLettersInstructions.Visible = False
                    pnlLetters.Visible = False
                    AnswerCheck()
                    UpdateFeedback()
                    timerFeedback.Enabled = True
                Else
                    lblPnlLettersInstructions.Visible = True
                    pnlLetters.Visible = True

                    If practiceOspanBool = False Then
                        tempLettersIntegerCounter = numArrayIntegerCounter - taskArrayList(numCounterTasks).NumberOfTrials - 1
                        timeToClickLettersStopwatch.Restart()
                    End If

                    pnlLetters.BringToFront()
                End If
                numCounterTasks = numCounterTasks + 1
                practiceInstructionsSubCount = 0
                numCounterTrials = 0

                letter1.Text = Mid((taskArrayList(numCounterTasks - 1).LettersInBoxes), 1, 1)
                letter2.Text = Mid((taskArrayList(numCounterTasks - 1).LettersInBoxes), 2, 1)
                letter3.Text = Mid((taskArrayList(numCounterTasks - 1).LettersInBoxes), 3, 1)
                letter4.Text = Mid((taskArrayList(numCounterTasks - 1).LettersInBoxes), 4, 1)
                letter5.Text = Mid((taskArrayList(numCounterTasks - 1).LettersInBoxes), 5, 1)
                letter6.Text = Mid((taskArrayList(numCounterTasks - 1).LettersInBoxes), 6, 1)
                letter7.Text = Mid((taskArrayList(numCounterTasks - 1).LettersInBoxes), 7, 1)
                letter8.Text = Mid((taskArrayList(numCounterTasks - 1).LettersInBoxes), 8, 1)
                letter9.Text = Mid((taskArrayList(numCounterTasks - 1).LettersInBoxes), 9, 1)
                letter10.Text = Mid((taskArrayList(numCounterTasks - 1).LettersInBoxes), 10, 1)
                letter11.Text = Mid((taskArrayList(numCounterTasks - 1).LettersInBoxes), 11, 1)
                letter12.Text = Mid((taskArrayList(numCounterTasks - 1).LettersInBoxes), 12, 1)

                If numCounterTasks < numOfTasks Then

                    lblMathQuestion.Text = taskArrayList(numCounterTasks).Questions(numCounterTrials)
                    'Keeps Question Centered
                    lblMathQuestion.Location = New Point((pnlQuestion.Width / 2) - (lblMathQuestion.Width / 2), (pnlQuestion.Height / 2) - (lblMathQuestion.Height / 2) - 50)

                    lblMathAnswer.Text = taskArrayList(numCounterTasks).Answers(numCounterTrials).ToString()
                    correctBool = taskArrayList(numCounterTasks).Booleans(numCounterTrials)
                    lblLetterAnswer.Text = taskArrayList(numCounterTasks).LetterAnswers(numCounterTrials).ToString()
                    numCounterTrials = numCounterTrials + 1
                    If practiceOspanBool = False Then
                        participantTrialString(numArrayIntegerCounter) = participantTrialString(numArrayIntegerCounter) + Now().ToLongTimeString + ","
                    End If
                Else
                    useTimer = False
                    timeToRespond.Enabled = False
                    doneBool = True
                End If
            End If
        End If
    End Sub
    Private Sub FormatPanels()

        'The Practice Instructions Panel
        While (lblPracticeInstructions.Width / pnlPracticeInstructions.Width) < 0.8 Or (lblPracticeInstructions.Width / pnlPracticeInstructions.Width) > 0.9
            lblPracticeInstructions.Font = New Font(lblPracticeInstructions.Font.FontFamily, fontSize, lblPracticeInstructions.Font.Style)
            Dim lblToScreenRatio As Double = (lblPracticeInstructions.Width / pnlPracticeInstructions.Width)
            If lblToScreenRatio > 0.9 Then
                fontSize = fontSize - 1
            ElseIf lblToScreenRatio < 0.9 Then
                fontSize = fontSize + 1
            End If
        End While
        While (lblPracticeInstructions.Width / pnlPracticeInstructions.Width) > 0.85
            lblPracticeInstructions.Font = New Font(lblPracticeInstructions.Font.FontFamily, fontSize, lblPracticeInstructions.Font.Style)
            fontSize = fontSize - 0.1
        End While
        While (lblPracticeInstructions.Height / pnlPracticeInstructions.Height) > 0.85
            lblPracticeInstructions.Font = New Font(lblPracticeInstructions.Font.FontFamily, fontSize, lblPracticeInstructions.Font.Style)
            fontSize = fontSize - 0.1
        End While
        lblPracticeInstructions.Location = New Point((pnlPracticeInstructions.Width * 1 / 2) - (lblPracticeInstructions.Width / 2), (pnlPracticeInstructions.Height * 5 / 10) - (lblPracticeInstructions.Height * 1 / 2))

        'The Question Panel
        lblMathQuestion.Location = New Point((pnlQuestion.Width / 2) - (lblMathQuestion.Width / 2), (pnlQuestion.Height / 2) - (lblMathQuestion.Height / 2) - 50)
        lblClickToContinue.Text = "When you have solved the math problem," & vbNewLine & "click the left mouse button to continue."
        lblClickToContinue.Location = New Point((pnlQuestion.Width / 2) - (lblClickToContinue.Width / 2), (pnlQuestion.Height / 2) - (lblClickToContinue.Height / 2) + 150)

        'The Response Panel
        lblMathAnswer.Location = New Point((pnlAnswer.Width / 2) - (lblMathAnswer.Width / 2), (pnlAnswer.Height / 2) - (lblMathAnswer.Height / 2) - 50)
        lblCorrect.Location = New Point((pnlAnswer.Width / 2) - (lblCorrect.Width / 2), (pnlAnswer.Height / 2) - (lblCorrect.Height / 2) + 150)
        lblIncorrect.Location = New Point((pnlAnswer.Width / 2) - (lblIncorrect.Width / 2), (pnlAnswer.Height / 2) - (lblIncorrect.Height / 2) + 150)
        btnTrue.Location = New Point((pnlAnswer.Width / 3) - (btnTrue.Width / 2), (pnlAnswer.Height / 2) - (btnTrue.Height / 2) + 150)
        btnFalse.Location = New Point((pnlAnswer.Width * 2 / 3) - (btnFalse.Width / 2), (pnlAnswer.Height / 2) - (btnFalse.Height / 2) + 150)

        'The Letter Display Panel
        lblLetterAnswer.Location = New Point((pnlLetter.Width / 2) - (lblLetterAnswer.Width / 2), (pnlLetter.Height / 2) - (lblLetterAnswer.Height / 2) - 50)

        'The Letters Display Panel
        lblPnlLettersInstructions.Location = New Point(((Me.Width * 1 / 2) - lblPnlLettersInstructions.Width / 2), (Me.Height * 1 / 16) - (lblPnlLettersInstructions.Height / 2))

        letter1.Location = New Point((pnlLetters.Width * 1 / 4) - (letter1.Width / 2), (pnlLetters.Height / 6) - (letter1.Height / 2))
        letter2.Location = New Point((pnlLetters.Width * 2 / 4) - (letter2.Width / 2), (pnlLetters.Height / 6) - (letter2.Height / 2))
        letter3.Location = New Point((pnlLetters.Width * 3 / 4) - (letter3.Width / 2), (pnlLetters.Height / 6) - (letter3.Height / 2))

        letter4.Location = New Point((pnlLetters.Width * 1 / 4) - (letter4.Width / 2), (pnlLetters.Height * 2 / 6) - (letter4.Height / 2))
        letter5.Location = New Point((pnlLetters.Width * 2 / 4) - (letter5.Width / 2), (pnlLetters.Height * 2 / 6) - (letter5.Height / 2))
        letter6.Location = New Point((pnlLetters.Width * 3 / 4) - (letter6.Width / 2), (pnlLetters.Height * 2 / 6) - (letter6.Height / 2))

        letter7.Location = New Point((pnlLetters.Width * 1 / 4) - (letter7.Width / 2), (pnlLetters.Height * 3 / 6) - (letter7.Height / 2))
        letter8.Location = New Point((pnlLetters.Width * 2 / 4) - (letter8.Width / 2), (pnlLetters.Height * 3 / 6) - (letter8.Height / 2))
        letter9.Location = New Point((pnlLetters.Width * 3 / 4) - (letter9.Width / 2), (pnlLetters.Height * 3 / 6) - (letter9.Height / 2))

        letter10.Location = New Point((pnlLetters.Width * 1 / 4) - (letter10.Width / 2), (pnlLetters.Height * 4 / 6) - (letter10.Height / 2))
        letter11.Location = New Point((pnlLetters.Width * 2 / 4) - (letter11.Width / 2), (pnlLetters.Height * 4 / 6) - (letter11.Height / 2))
        letter12.Location = New Point((pnlLetters.Width * 3 / 4) - (letter12.Width / 2), (pnlLetters.Height * 4 / 6) - (letter12.Height / 2))

        btnClearLetters.Location = New Point((pnlLetters.Width * 1 / 6) - (btnClearLetters.Width / 2), (pnlLetters.Height * 7 / 8) - (btnClearLetters.Height / 2))
        btnBlankLetter.Location = New Point((pnlLetters.Width * 3 / 6) - (btnBlankLetter.Width / 2), (pnlLetters.Height * 4.75 / 6) - (btnBlankLetter.Height / 2))
        btnExitLetters.Location = New Point((pnlLetters.Width * 5 / 6) - (btnExitLetters.Width / 2), (pnlLetters.Height * 7 / 8) - (btnExitLetters.Height / 2))

        AnswerBox.Location = New Point(((pnlLetters.Width * 1 / 2) - AnswerBox.Width / 2), (pnlLetters.Height * 7 / 8) - (btnExitLetters.Height / 2))

        'The Feedback Panel
        lblPercentMathCorrect.Location = New Point((pnlFeedback.Width * 7 / 8) - (lblPercentMathCorrect.Width / 2), (pnlFeedback.Height * 1 / 8) - (lblPercentMathCorrect.Height / 2))
        lblRecall.Location = New Point((pnlFeedback.Width / 2) - (lblRecall.Width / 2), (pnlFeedback.Height * 6 / 12) - (lblRecall.Height * 1 / 2))
        lblMathErrors.Location = New Point((pnlFeedback.Width / 2) - (lblMathErrors.Width / 2), (pnlFeedback.Height * 7 / 12) - (lblMathErrors.Height * 1 / 2))

        'The Done Panel
        lblGetRA.Location = New Point((pnlDone.Width * 1 / 2) - (lblGetRA.Width / 2), (pnlDone.Height * 1 / 2) - (lblPercentMathCorrect.Height / 2))

        'The Results Panel
        lblPartID.Location = New Point((pnlResults.Width * 1 / 2) - (lblPartID.Width / 2), (pnlResults.Height * 2.5 / 10) - (lblPartID.Height * 1 / 2))
        lblOspanAbsolute.Location = New Point((pnlResults.Width * 1 / 2) - (lblPartID.Width / 2), (pnlResults.Height * 4 / 10) - (lblPartID.Height * 1 / 2))
        lblOspanTotalCorrect.Location = New Point((pnlResults.Width * 1 / 2) - (lblPartID.Width / 2), (pnlResults.Height * 5 / 10) - (lblPartID.Height * 1 / 2))
        lblMathTotalErrors.Location = New Point((pnlResults.Width * 1 / 2) - (lblPartID.Width / 2), (pnlResults.Height * 6 / 10) - (lblPartID.Height * 1 / 2))
        lblMathSpeedErrors.Location = New Point((pnlResults.Width * 1 / 2) - (lblPartID.Width / 2), (pnlResults.Height * 7 / 10) - (lblPartID.Height * 1 / 2))
        lblMathAccuracyErrors.Location = New Point((pnlResults.Width * 1 / 2) - (lblPartID.Width / 2), (pnlResults.Height * 8 / 10) - (lblPartID.Height * 1 / 2))

    End Sub
    Private Sub AnswerCheck()

        While answerString.Count > AnswerBox.Text.Count
            AnswerBox.Text = AnswerBox.Text + "_"
        End While


        Dim x = 1
        Dim y = 0

        While y < answerString.Count
            If Mid(answerString, x, 1) <> Mid(AnswerBox.Text, x, 1) Then
                tempOspanMissed = tempOspanMissed + 1
                x = x + 1
            Else
                x = x + 1
            End If
            y = y + 1
        End While

        If tempOspanMissed <> 0 Then
            notOspanScore = notOspanScore + taskArrayList(numCounterTasks - 1).NumberOfTrials
        End If
        mathErrors = mathErrors + tempMathErrors
        ospanTotalMissed = ospanTotalMissed + tempOspanMissed

    End Sub
    Private Sub UpdatePracticeInstructions()
        Select Case (CType(numCounterTasks + practiceInstructionsSubCount, Single))
            Case 0
                pnlPracticeInstructions.BringToFront()
                pnlPracticeInstructions.Visible = True
                lblPracticeInstructions.Text = "In this experiment you will try to memorize letters you see on the screen" & vbNewLine & "while you also solve simple math problems." & vbNewLine & vbNewLine & "In the next few minutes, you" & _
                    " will have some practice to get you" & vbNewLine & "familiar with how the experiment works." & vbNewLine & vbNewLine & "We will begin by practicing the letter part of the experiment." & vbNewLine & vbNewLine & vbNewLine & "Click" & _
                    " the mouse to continue."
            Case 0.1
                lblPracticeInstructions.Text = "For this practice set, letters will appear on the screen one at a time." & vbNewLine & vbNewLine & "Try to remember each letter in the order presented.  " & vbNewLine & vbNewLine & "After 2-3 letter" & _
                    "s have been shown, you will see a screen listing 12 possible letters." & vbNewLine & vbNewLine & "Your job is to select each letter in the ord" & _
                    "er presented. " & vbNewLine & "To do this, use the mouse to select each letter.  " & vbNewLine & vbNewLine & "The letters you select will appear at the bottom of the screen.  " & vbNewLine & vbNewLine & vbNewLine & _
                    "Click the mouse button to continue."
            Case 0.2
                lblPracticeInstructions.Text = "When you have selected all the letters, and they are in the correct order," & vbNewLine & " hit the EXIT box at the bottom right of the screen." & vbNewLine & vbNewLine & "If you make a mist" & _
                    "ake, hit the CLEAR box to start over. " & vbNewLine & vbNewLine & " If you forget one of the letters, click the BLANK box to mark the spot" & vbNewLine & " for the missing letter." & vbNewLine & vbNewLine & "Remember," & _
                    " it is very important to get the letters in the same order as you see them.  " & vbNewLine & "If you forget one, use the BLANK box to mark the position." & vbNewLine & vbNewLine & "Do you have" & _
                    " any questions so far?" & vbNewLine & vbNewLine & vbNewLine & "When you're ready, click the mouse button to start the letter practice."
            Case 0.3
                pnlLetter.Visible = True
                pnlLetter.BringToFront()
                pnlPracticeInstructions.Visible = False
                pnlPracticeInstructions.SendToBack()
                practiceInstructionsSubCount = practiceInstructionsSubCount + 0.1

                lblMathErrors.Visible = False
                lblPercentMathCorrect.Visible = False

                timerLetterPanelShow.Enabled = True
            Case 4
                lblRecall.Visible = False
                lblMathErrors.Visible = True
                lblPercentMathCorrect.Visible = True

                pnlPracticeInstructions.BringToFront()
                pnlPracticeInstructions.Visible = True
                lblPracticeInstructions.Text = "Now you will practice doing the math part of the experiment." & vbNewLine & vbNewLine & "A math problem will appear on the screen, like this:" & vbNewLine & "" & vbNewLine & "(2 * 1) + 1 = ?" & vbNewLine & vbNewLine & "As soon as " & _
                    "you see the math problem, you should compute the correct answer.  " & vbNewLine & "" & vbNewLine & "In the above problem, the answer 3 is correct." & vbNewLine & vbNewLine & "When you know the correct answ" & _
                    "er, you will click the mouse button." & vbNewLine & vbNewLine & vbNewLine & "Click the mouse to continue."
                FormatPanels()
            Case 4.1
                lblPracticeInstructions.Text = "You will see a number displayed on the next screen," & vbNewLine & " along with a box marked TRUE and a box marked FALSE." & vbNewLine & vbNewLine & "If the number on the screen is the corre" & _
                    "ct answer to the math problem," & vbNewLine & " click on the TRUE box with the mouse." & vbNewLine & vbNewLine & "If the number is not the correct answer, click on the FALSE box." & vbNewLine & vbNewLine & "For exampl" & _
                    "e, if you see the problem" & vbNewLine & vbNewLine & "(2 * 2) + 1 = ?" & vbNewLine & vbNewLine & "and the number on the following screen is 5" & vbNewLine & "click the TRUE box, because the answer is correct." & vbNewLine & vbNewLine & "If you " & _
                    "see the problem" & vbNewLine & vbNewLine & "(2 * 2) + 1 =  ?" & vbNewLine & vbNewLine & "and the number on the next screen is 6" & vbNewLine & "click the FALSE box, because the correct answer is 5, not 6." & vbNewLine & vbNewLine & "After you c" & _
                    "lick on one of the boxes," & vbNewLine & " the computer will tell you if  you made the right choice." & vbNewLine & vbNewLine & vbNewLine & "Click the mouse to continue."
            Case 4.2
                lblPracticeInstructions.Text = "It is VERY important that you get the math problems correct." & vbNewLine & "It is also important that you try to solve the problem as quickly as you can." & vbNewLine & vbNewLine & vbNewLine & _
                    "Do you have any questions?" & vbNewLine & vbNewLine & vbNewLine & "When you're ready, click the mouse to try some practice problems."
                practiceInstructionsSubCount = practiceInstructionsSubCount + 0.1
                calculateAverageTime = True
            Case 5
                lblRecall.Visible = True
                lblMathErrors.Visible = True
                lblPercentMathCorrect.Visible = True
                useTimer = True
                timeToRespond.Enabled = False
                timerLetterPanelShow.Enabled = False
                timerFeedback.Enabled = False
                timerResponsePractice.Enabled = False
                timeToRespond.Interval = averageTime + (2.5 * standardDevation)

                mathTotalCount = 0
                mathErrors = 0

                pnlPracticeInstructions.BringToFront()
                pnlPracticeInstructions.Visible = True
                lblPracticeInstructions.Text = "Now you will practice doing both parts of the experiment at the same time." & vbNewLine & vbNewLine & "In the next practice set, you will be given one of the math problems." & vbNewLine & "  O" & _
                    "nce you make your decision about the math problem," & vbNewLine & "a letter will appear on the screen.  Try to remember the letter." & vbNewLine & vbNewLine & "In the previous section where " & _
                    "you only solved math problems," & vbNewLine & "the computer computed your average time to solve the problems. " & vbNewLine & vbNewLine & "If you take longer than your average time," & vbNewLine & "the computer" & _
                    " will automatically move you onto the letter part," & vbNewLine & "thus skipping the True or False part and will count that problem as a math error.  " & vbNewLine & "Therefore it i" & _
                    "s VERY important to solve the problems as quickly" & vbNewLine & "and as accurately as possible." & vbNewLine & vbNewLine & vbNewLine & "Click the mouse to continue."
                FormatPanels()
                timeToRespond.Enabled = False
                timerLetterPanelShow.Enabled = False
                timerFeedback.Enabled = False
                timerResponsePractice.Enabled = False
                practiceInstructionsSubCount = practiceInstructionsSubCount + 0.1
            Case 8
                useTimer = False
                timeToRespond.Enabled = False
                pnlPracticeInstructions.BringToFront()
                pnlPracticeInstructions.Visible = True
                lblPracticeInstructions.Text = "That is the end of the practice." & vbNewLine & vbNewLine & "The real trials will look like the practice trials you just completed." & vbNewLine & vbNewLine & "First you will get a math problem to sol" & _
                    "ve, then a letter to remember.  " & vbNewLine & vbNewLine & "When you see the recall screen, select the letters in the order presented.   " & vbNewLine & "If you forget a letter, click the BLA" & _
                    "NK box to mark where it should go." & vbNewLine & vbNewLine & "Some sets will have more math problems and letters than others." & vbNewLine & vbNewLine & "It is important that you do your best on both" & _
                    " the math problems and " & vbNewLine & "the letter recall parts of this experiment." & vbNewLine & vbNewLine & "Remember on the math you must work as QUICKLY and ACCURATELY as possible." & vbNewLine & vbNewLine & "Als" & _
                    "o, remember to keep your math accuracy at 85% or above." & vbNewLine & vbNewLine & vbNewLine & "Do you have any questions?  If not, click the mouse to begin the experiment."
                FormatPanels()
            Case 8.1
                Dim questionScreenTest As New QuestionScreen(nameString, False, averageTime, standardDevation)
                questionScreenTest.Show()
                Me.Visible = False
            Case Else
                If calculateAverageTime = True And calculateAverageTimeCount = 0 Then
                    startTime = Date.Now()
                    calculateAverageTimeCount = 1
                End If
                pnlPracticeInstructions.Visible = False
                pnlPracticeInstructions.SendToBack()
        End Select
    End Sub
    Private Sub UpdateFeedback()

        lblRecall.Text = "You recalled " & (answerString.Count - tempOspanMissed).ToString() & " out of " & answerString.Count.ToString() & " letters correctly."
        If tempMathErrors > 2 Then
            lblMathErrors.Text = "You made " & tempMathErrors & " math errors during this trial.  Please do your best on the math."
            lblMathErrors.Location = New Point((pnlFeedback.Width / 2) - (lblMathErrors.Width / 2), (pnlFeedback.Height * 7 / 12) - (lblMathErrors.Height * 1 / 2))
        Else
            lblMathErrors.Text = "You made " & tempMathErrors & " math error(s) on this set of trials."
            lblMathErrors.Location = New Point((pnlFeedback.Width / 2) - (lblMathErrors.Width / 2), (pnlFeedback.Height * 7 / 12) - (lblMathErrors.Height * 1 / 2))
        End If
        lblPercentMathCorrect.Text = (FormatPercent(((mathTotalCount - mathErrors) / mathTotalCount), 0)).ToString()
        tempOspanMissed = 0
        tempMathErrors = 0
    End Sub
    '********stuff to do in UpdateResults()**********
    Private Sub UpdateResults()
        lblPartID.Text = "Results for Participant # " & nameString
        lblOspanAbsolute.Text = "OSPAN Absolute Score: " & (75 - notOspanScore).ToString()
        lblOspanTotalCorrect.Text = "OSPAN Total Correct: " & (75 - ospanTotalMissed).ToString()
        lblMathTotalErrors.Text = "Math Total Errors: " & mathErrors.ToString()
        lblMathSpeedErrors.Text = "Math Speed Errors: " & mathSpeedErrors.ToString()
        lblMathAccuracyErrors.Text = "Math Accuracy Errors: " & (mathErrors - mathSpeedErrors).ToString()
        WriteOutputFile()
        '*********put if the ospanPracticeBool is false..(so it is not run in the practice trial), then run 'Private Sub WriteOutputFile()' (or some cool name)...and
        'just create the code for writing output file :D  I think this would be the best place to run because this as at this point, all of the data has been collected/calculated.
        'We still need to figure out how to put the "Accuracy"/"Speed" word following when an error took place (as my original plan was to just copy all of that text
        'from the randomly created file into the output file. Also we need to figure out how to Add in the string of letters they selected as their answer somewhere on our output file without
        'messing up the ability for the program to read the file and run the task.  I would recommend looking in the "Private Sub AnswerCheck()" section as that is where the string of 
        'letters they input is analyzed. Lastly, as a tip, we can add anything we want to after the last comma in the .csv file (if you open it in notepad, you will see that there are
        'commas at the end of every line.).  These are used to tell the linereader at what location the information is in front of it, just be sure to not add any more commas in those lines
        'and to not add any "="s signs to any lines.
    End Sub
    Private Sub WriteOutputFile()

        Dim FileName, FileLocation As String
        Dim WriteToFile As Boolean = True

        FileLocation = "C:\Saves\"

        'FileLocation = FileLocation & Now().Year.ToString() & " - " & _
        '    Now().Month.ToString() & "-" & _
        '    Now().Day.ToString() & "-" & _
        '    Now().Hour.ToString() & "-" & _
        '    Now().Minute.ToString() & "-" & _
        '    Now().Second.ToString() & "-" & _
        '    nameString & ".csv"

        FileLocation = FileLocation & Format(Now(), "yyyy-MM-dd - HH-mm-ss ") & nameString & ".csv"


        FileName = FileLocation

        My.Computer.FileSystem.WriteAllText(FileName, lblPartID.Text + Environment.NewLine, False)
        My.Computer.FileSystem.WriteAllText(FileName, Environment.NewLine, True)
        My.Computer.FileSystem.WriteAllText(FileName, lblOspanAbsolute.Text + Environment.NewLine, True)
        My.Computer.FileSystem.WriteAllText(FileName, lblOspanTotalCorrect.Text + Environment.NewLine, True)
        My.Computer.FileSystem.WriteAllText(FileName, lblMathTotalErrors.Text + Environment.NewLine, True)
        My.Computer.FileSystem.WriteAllText(FileName, lblMathSpeedErrors.Text + Environment.NewLine, True)
        My.Computer.FileSystem.WriteAllText(FileName, lblMathAccuracyErrors.Text + Environment.NewLine, True)

        My.Computer.FileSystem.WriteAllText(FileName, Environment.NewLine, True)
        My.Computer.FileSystem.WriteAllText(FileName, ":Question,Answer Displayed,Correct Response,Letter Displayed,Q-Timestamp, A-Timestamp,Time To Do Math (mSecs),Participant Response,PR-Timestamp,Time To Click True/False (mSecs),Participant Letter,PL-Timestamp,Time To Click First/Next Letter (mSecs)" + Environment.NewLine, True)
        My.Computer.FileSystem.WriteAllText(FileName, Environment.NewLine, True)

        Dim i As Integer = 0
        While i < participantTrialString.Count
            My.Computer.FileSystem.WriteAllText(FileName, participantTrialString(i) + Environment.NewLine, True)
            i = i + 1
        End While

        My.Computer.FileSystem.WriteAllText(FileName, Environment.NewLine, True)
        My.Computer.FileSystem.WriteAllText(FileName, ":DO NOT EDIT BELOW. REQUIRED TO RUN SAME OSPAN FROM THIS FILE." + Environment.NewLine, True)

        i = 0
        While i < readText.Count
            While checkForTestBool = False
                If readText(i).Contains(":") Or readText(i).Contains("=") Or readText(i).Contains("#") Or readText(i).Count = 0 Then
                    i = i + 1
                Else
                    checkForTestBool = True
                End If
            End While
            My.Computer.FileSystem.WriteAllText(FileName, readText(i) + Environment.NewLine, True)
            i = i + 1
        End While


    End Sub


#End Region

#Region "Buttons (Some of which are very logical)"

    'Practice Instruction Buttons
    Private Sub btnNextInstruction_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNextInstruction.Click, pnlPracticeInstructions.Click, lblPracticeInstructions.Click
        practiceInstructionsSubCount = CType(practiceInstructionsSubCount + 0.1, Single)
        UpdatePracticeInstructions()
        FormatPanels()
    End Sub

    'Form Background Click Settings
    Private Sub QuestionScreen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Click
        If Screen = "btnContinue" Then
            btnContinue.PerformClick()
        End If
    End Sub

    'Button Continue Clicking Settings
    Private Sub pnlClickPast(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pnlQuestion.Click, lblMathQuestion.Click, lblClickToContinue.Click
        btnContinue.PerformClick()
    End Sub

    ''Question Buttons
    Private Sub btnContinue_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnContinue.Click
        If practiceOspanBool = False Then
            timeToDoMathStopwatch.Stop()
            timeToClickTrueFalseStopwatch.Start()
            timeToClickTrueFalseStopwatch.Restart()
            participantTrialString(numArrayIntegerCounter) = participantTrialString(numArrayIntegerCounter) + Now().ToLongTimeString + "," + timeToDoMathStopwatch.ElapsedMilliseconds.ToString() + ","
        End If

        pnlFeedback.Visible = True
        pnlLetters.Visible = False
        lblPnlLettersInstructions.Visible = False
        pnlLetter.Visible = False
        pnlAnswer.BringToFront()
        pnlAnswer.Visible = True
        pnlQuestion.Visible = False
        If calculateAverageTime = True Then
            endTime = Now.Subtract(startTime)
            timesToAnswer(calculateAverageTimeCount - 1) = CType(endTime.TotalMilliseconds, Double)
            If calculateAverageTimeCount < 15 Then
                calculateAverageTimeCount = calculateAverageTimeCount + 1
            Else
                calculateAverageTime = False
                While calculateAverageTimeCount >= 1
                    averageTime = averageTime + timesToAnswer(calculateAverageTimeCount - 1)
                    calculateAverageTimeCount = calculateAverageTimeCount - 1
                End While
                averageTime = averageTime / 15
                While calculateAverageTimeCount < 15
                    calculateAverageTimeCount = calculateAverageTimeCount + 1
                    standardDevation = standardDevation + ((timesToAnswer(calculateAverageTimeCount - 1) - averageTime) * (timesToAnswer(calculateAverageTimeCount - 1) - averageTime))
                End While
                standardDevation = standardDevation / 14
                standardDevation = Math.Sqrt(standardDevation)
            End If
        End If
        If useTimer = True Then
            timeToRespond.Enabled = False
        End If
    End Sub
    ''Answer Buttons
    Private Sub btnTrue_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTrue.Click
        mathTotalCount = mathTotalCount + 1
        timeToClickTrueFalseStopwatch.Stop()

        Screen = "btnToLetters"

        If correctBool = False Then
            tempMathErrors = tempMathErrors + 1
            If practiceOspanBool = False Then
                participantTrialString(numArrayIntegerCounter) = participantTrialString(numArrayIntegerCounter) + "TRUE - Incorrect," + Now().ToLongTimeString + "," + timeToClickTrueFalseStopwatch.ElapsedMilliseconds.ToString() + ","
            End If
        Else
            If practiceOspanBool = False Then
                participantTrialString(numArrayIntegerCounter) = participantTrialString(numArrayIntegerCounter) + "TRUE," + Now().ToLongTimeString + "," + timeToClickTrueFalseStopwatch.ElapsedMilliseconds.ToString() + ","
            End If
        End If

        If practiceOspanBool = True And CType(numCounterTasks + practiceInstructionsSubCount, Single) <= CType(5, Single) Then
            If correctBool = False Then
                lblIncorrect.Visible = True
            Else
                lblCorrect.Visible = True
            End If
            timerResponsePractice.Enabled = True
        Else
            pnlFeedback.Visible = True
            pnlLetters.Visible = False
            lblPnlLettersInstructions.Visible = False
            pnlLetter.BringToFront()
            pnlLetter.Visible = True
            pnlAnswer.Visible = False
            pnlQuestion.Visible = False
            timerLetterPanelShow.Enabled = True
        End If

    End Sub
    Private Sub btnFalse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFalse.Click
        mathTotalCount = mathTotalCount + 1
        timeToClickTrueFalseStopwatch.Stop()

        Screen = "btnToLetters"

        If correctBool = True Then
            tempMathErrors = tempMathErrors + 1
            If practiceOspanBool = False Then
                participantTrialString(numArrayIntegerCounter) = participantTrialString(numArrayIntegerCounter) + "FALSE - Incorrect," + Now().ToLongTimeString + "," + timeToClickTrueFalseStopwatch.ElapsedMilliseconds.ToString() + ","
            End If
        Else
            If practiceOspanBool = False Then
                participantTrialString(numArrayIntegerCounter) = participantTrialString(numArrayIntegerCounter) + "FALSE," + Now().ToLongTimeString + "," + timeToClickTrueFalseStopwatch.ElapsedMilliseconds.ToString() + ","
            End If
        End If

        If practiceOspanBool = True And CType(numCounterTasks + practiceInstructionsSubCount, Single) <= CType(5, Single) Then
            If correctBool = False Then
                lblCorrect.Visible = True
            Else
                lblIncorrect.Visible = True
            End If
            timerResponsePractice.Enabled = True
        Else

            pnlFeedback.Visible = True
            pnlLetters.Visible = False
            lblPnlLettersInstructions.Visible = False
            pnlLetter.BringToFront()
            pnlLetter.Visible = True
            pnlAnswer.Visible = False
            pnlQuestion.Visible = False
            timerLetterPanelShow.Enabled = True
        End If

    End Sub

    ''Letter Buttons
    Private Sub btnToLetters_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnToLetters.Click

        pnlQuestion.Visible = True
        pnlFeedback.Visible = False
        pnlLetters.BringToFront()
        pnlLetters.Visible = False
        lblPnlLettersInstructions.Visible = False
        pnlLetter.Visible = False
        pnlAnswer.Visible = False


        'pnlFeedback.Visible = False
        'pnlQuestion.Visible = True
        'pnlLetter.Visible = False
        'pnlAnswer.Visible = False

        Screen = "btnContinue"

        LoopToFinishOspan()

    End Sub

    ''Letters Buttons
    Private Sub letter1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles letter1.Click
        AnswerBox.Text = AnswerBox.Text + letter1.Text
        AnswerBox.Location = New Point(((pnlLetters.Width * 1 / 2) - AnswerBox.Width / 2), (pnlLetters.Height * 7 / 8) - (btnExitLetters.Height / 2))
        If practiceOspanBool = False Then
            tempLettersHolderValues(tempLettersValuesCountInteger) = letter1.Text + "," + Now().ToLongTimeString + "," + timeToClickLettersStopwatch.ElapsedMilliseconds.ToString()
            timeToClickLettersStopwatch.Restart()
            tempLettersValuesCountInteger = tempLettersValuesCountInteger + 1
        End If
    End Sub
    Private Sub letter2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles letter2.Click
        AnswerBox.Text = AnswerBox.Text + letter2.Text
        AnswerBox.Location = New Point(((pnlLetters.Width * 1 / 2) - AnswerBox.Width / 2), (pnlLetters.Height * 7 / 8) - (btnExitLetters.Height / 2))
        If practiceOspanBool = False Then
            tempLettersHolderValues(tempLettersValuesCountInteger) = letter2.Text + "," + Now().ToLongTimeString + "," + timeToClickLettersStopwatch.ElapsedMilliseconds.ToString()
            timeToClickLettersStopwatch.Restart()
            tempLettersValuesCountInteger = tempLettersValuesCountInteger + 1
        End If
    End Sub
    Private Sub letter3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles letter3.Click
        AnswerBox.Text = AnswerBox.Text + letter3.Text
        AnswerBox.Location = New Point(((pnlLetters.Width * 1 / 2) - AnswerBox.Width / 2), (pnlLetters.Height * 7 / 8) - (btnExitLetters.Height / 2))
        If practiceOspanBool = False Then
            tempLettersHolderValues(tempLettersValuesCountInteger) = letter3.Text + "," + Now().ToLongTimeString + "," + timeToClickLettersStopwatch.ElapsedMilliseconds.ToString()
            timeToClickLettersStopwatch.Restart()
            tempLettersValuesCountInteger = tempLettersValuesCountInteger + 1
        End If
    End Sub
    Private Sub letter4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles letter4.Click
        AnswerBox.Text = AnswerBox.Text + letter4.Text
        AnswerBox.Location = New Point(((pnlLetters.Width * 1 / 2) - AnswerBox.Width / 2), (pnlLetters.Height * 7 / 8) - (btnExitLetters.Height / 2))
        If practiceOspanBool = False Then
            tempLettersHolderValues(tempLettersValuesCountInteger) = letter4.Text + "," + Now().ToLongTimeString + "," + timeToClickLettersStopwatch.ElapsedMilliseconds.ToString()
            timeToClickLettersStopwatch.Restart()
            tempLettersValuesCountInteger = tempLettersValuesCountInteger + 1
        End If
    End Sub
    Private Sub letter5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles letter5.Click
        AnswerBox.Text = AnswerBox.Text + letter5.Text
        AnswerBox.Location = New Point(((pnlLetters.Width * 1 / 2) - AnswerBox.Width / 2), (pnlLetters.Height * 7 / 8) - (btnExitLetters.Height / 2))
        If practiceOspanBool = False Then
            tempLettersHolderValues(tempLettersValuesCountInteger) = letter5.Text + "," + Now().ToLongTimeString + "," + timeToClickLettersStopwatch.ElapsedMilliseconds.ToString()
            timeToClickLettersStopwatch.Restart()
            tempLettersValuesCountInteger = tempLettersValuesCountInteger + 1
        End If
    End Sub
    Private Sub letter6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles letter6.Click
        AnswerBox.Text = AnswerBox.Text + letter6.Text
        AnswerBox.Location = New Point(((pnlLetters.Width * 1 / 2) - AnswerBox.Width / 2), (pnlLetters.Height * 7 / 8) - (btnExitLetters.Height / 2))
        If practiceOspanBool = False Then
            tempLettersHolderValues(tempLettersValuesCountInteger) = letter6.Text + "," + Now().ToLongTimeString + "," + timeToClickLettersStopwatch.ElapsedMilliseconds.ToString()
            timeToClickLettersStopwatch.Restart()
            tempLettersValuesCountInteger = tempLettersValuesCountInteger + 1
        End If
    End Sub
    Private Sub letter7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles letter7.Click
        AnswerBox.Text = AnswerBox.Text + letter7.Text
        AnswerBox.Location = New Point(((pnlLetters.Width * 1 / 2) - AnswerBox.Width / 2), (pnlLetters.Height * 7 / 8) - (btnExitLetters.Height / 2))
        If practiceOspanBool = False Then
            tempLettersHolderValues(tempLettersValuesCountInteger) = letter7.Text + "," + Now().ToLongTimeString + "," + timeToClickLettersStopwatch.ElapsedMilliseconds.ToString()
            timeToClickLettersStopwatch.Restart()
            tempLettersValuesCountInteger = tempLettersValuesCountInteger + 1
        End If
    End Sub
    Private Sub letter8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles letter8.Click
        AnswerBox.Text = AnswerBox.Text + letter8.Text
        AnswerBox.Location = New Point(((pnlLetters.Width * 1 / 2) - AnswerBox.Width / 2), (pnlLetters.Height * 7 / 8) - (btnExitLetters.Height / 2))
        If practiceOspanBool = False Then
            tempLettersHolderValues(tempLettersValuesCountInteger) = letter8.Text + "," + Now().ToLongTimeString + "," + timeToClickLettersStopwatch.ElapsedMilliseconds.ToString()
            timeToClickLettersStopwatch.Restart()
            tempLettersValuesCountInteger = tempLettersValuesCountInteger + 1
        End If
    End Sub
    Private Sub letter9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles letter9.Click
        AnswerBox.Text = AnswerBox.Text + letter9.Text
        AnswerBox.Location = New Point(((pnlLetters.Width * 1 / 2) - AnswerBox.Width / 2), (pnlLetters.Height * 7 / 8) - (btnExitLetters.Height / 2))
        If practiceOspanBool = False Then
            tempLettersHolderValues(tempLettersValuesCountInteger) = letter9.Text + "," + Now().ToLongTimeString + "," + timeToClickLettersStopwatch.ElapsedMilliseconds.ToString()
            timeToClickLettersStopwatch.Restart()
            tempLettersValuesCountInteger = tempLettersValuesCountInteger + 1
        End If
    End Sub
    Private Sub letter10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles letter10.Click
        AnswerBox.Text = AnswerBox.Text + letter10.Text
        AnswerBox.Location = New Point(((pnlLetters.Width * 1 / 2) - AnswerBox.Width / 2), (pnlLetters.Height * 7 / 8) - (btnExitLetters.Height / 2))
        If practiceOspanBool = False Then
            tempLettersHolderValues(tempLettersValuesCountInteger) = letter10.Text + "," + Now().ToLongTimeString + "," + timeToClickLettersStopwatch.ElapsedMilliseconds.ToString()
            timeToClickLettersStopwatch.Restart()
            tempLettersValuesCountInteger = tempLettersValuesCountInteger + 1
        End If
    End Sub
    Private Sub letter11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles letter11.Click
        AnswerBox.Text = AnswerBox.Text + letter11.Text
        AnswerBox.Location = New Point(((pnlLetters.Width * 1 / 2) - AnswerBox.Width / 2), (pnlLetters.Height * 7 / 8) - (btnExitLetters.Height / 2))
        If practiceOspanBool = False Then
            tempLettersHolderValues(tempLettersValuesCountInteger) = letter11.Text + "," + Now().ToLongTimeString + "," + timeToClickLettersStopwatch.ElapsedMilliseconds.ToString()
            timeToClickLettersStopwatch.Restart()
            tempLettersValuesCountInteger = tempLettersValuesCountInteger + 1
        End If
    End Sub
    Private Sub letter12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles letter12.Click
        AnswerBox.Text = AnswerBox.Text + letter12.Text
        AnswerBox.Location = New Point(((pnlLetters.Width * 1 / 2) - AnswerBox.Width / 2), (pnlLetters.Height * 7 / 8) - (btnExitLetters.Height / 2))
        If practiceOspanBool = False Then
            tempLettersHolderValues(tempLettersValuesCountInteger) = letter12.Text + "," + Now().ToLongTimeString + "," + timeToClickLettersStopwatch.ElapsedMilliseconds.ToString()
            timeToClickLettersStopwatch.Restart()
            tempLettersValuesCountInteger = tempLettersValuesCountInteger + 1
        End If
    End Sub

    Private Sub btnClearLetters_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClearLetters.Click
        AnswerBox.Text = ""
        If practiceOspanBool = False Then
            ReDim tempLettersHolderValues(100)
            timeToClickLettersStopwatch.Restart()
            tempLettersValuesCountInteger = 0
        End If
    End Sub
    Private Sub btnBlankLetter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBlankLetter.Click
        AnswerBox.Text = AnswerBox.Text + "_"
        AnswerBox.Location = New Point(((pnlLetters.Width * 1 / 2) - AnswerBox.Width / 2), (pnlLetters.Height * 7 / 8) - (btnExitLetters.Height / 2))
        If practiceOspanBool = False Then
            tempLettersHolderValues(tempLettersValuesCountInteger) = "_" + "," + Now().ToLongTimeString + "," + timeToClickLettersStopwatch.ElapsedMilliseconds.ToString()
            timeToClickLettersStopwatch.Restart()
            tempLettersValuesCountInteger = tempLettersValuesCountInteger + 1
        End If
    End Sub
    Private Sub btnExitLetters_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExitLetters.Click
        pnlFeedback.Visible = True
        pnlQuestion.Visible = False
        pnlLetter.Visible = False
        pnlAnswer.Visible = False
        lblPnlLettersInstructions.Visible = False
        pnlLetters.Visible = False
        AnswerCheck()
        UpdateFeedback()
        timerFeedback.Enabled = True

        If practiceOspanBool = False Then
            timeToClickLettersStopwatch.Stop()
            Dim q As Integer
            While q < taskArrayList(numCounterTasks - 1).NumberOfTrials
                participantTrialString(tempLettersIntegerCounter + q) = participantTrialString(tempLettersIntegerCounter + q) + tempLettersHolderValues(q)
                q = q + 1
            End While
            ReDim tempLettersHolderValues(100)
            tempLettersValuesCountInteger = 0
            q = 0
        End If

    End Sub

    ''Feedback Buttons
    Private Sub btnExitFeedback_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExitFeedback.Click
        If practiceOspanBool Then
            UpdatePracticeInstructions()
        End If

        If practiceOspanBool = True And numCounterTasks < 4 Then
            pnlLetter.Visible = True
            pnlLetter.BringToFront()
            pnlAnswer.Visible = False
            lblPnlLettersInstructions.Visible = False
            pnlLetters.Visible = False
            pnlFeedback.Visible = False
            pnlQuestion.Visible = False
            timerLetterPanelShow.Enabled = True

        Else
            pnlFeedback.Visible = False
            pnlQuestion.Visible = True
            pnlLetter.Visible = False
            pnlAnswer.Visible = False
            lblPnlLettersInstructions.Visible = False
            pnlLetters.Visible = False
        End If
        timerFeedback.Enabled = False

        answerString = lblLetterAnswer.Text



        AnswerBox.Text = ""

        If useTimer = True Then
            If CType(numCounterTasks, Single) = CType(5, Single) And practiceOspanBool = True Then
            Else
                timeToRespond.Enabled = True
            End If

        End If

        If doneBool Then
            pnlDone.BringToFront()
            pnlDone.Visible = True
            TextBox1.Focus()
        End If
        'MessageBox.Show(accuracyErrors)
        'MessageBox.Show(mathErrors)
    End Sub

    ''To the Result Page Button
    Private Sub btnToResults_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnToResults.Click
        UpdateResults()
        pnlResults.BringToFront()
        pnlResults.Visible = True
        masterTextBox.Focus()
    End Sub

    'Button Mouse Over Settings
    Private Sub btnExitLetters_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExitLetters.MouseEnter
        btnExitLetters.BackColor = Color.FromArgb(200, 200, 200)
    End Sub
    Private Sub btnExitLetters_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExitLetters.MouseLeave
        btnExitLetters.BackColor = Color.FromArgb(255, 255, 255)
    End Sub
    Private Sub btnBlankLetter_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBlankLetter.MouseEnter
        btnBlankLetter.BackColor = Color.FromArgb(200, 200, 200)
    End Sub
    Private Sub btnBlankLetter_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBlankLetter.MouseLeave
        btnBlankLetter.BackColor = Color.FromArgb(255, 255, 255)
    End Sub
    Private Sub btnClearLetters_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClearLetters.MouseEnter
        btnClearLetters.BackColor = Color.FromArgb(200, 200, 200)
    End Sub
    Private Sub btnClearLetters_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClearLetters.MouseLeave
        btnClearLetters.BackColor = Color.FromArgb(255, 255, 255)
    End Sub

    Private Sub btnTrue_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTrue.MouseEnter
        btnTrue.BackColor = Color.FromArgb(240, 248, 255)
    End Sub
    Private Sub btnTrue_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTrue.MouseLeave
        btnTrue.BackColor = Color.FromArgb(250, 250, 250)
    End Sub
    Private Sub btnFalse_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFalse.MouseEnter
        btnFalse.BackColor = Color.FromArgb(240, 248, 255)
    End Sub
    Private Sub btnFalse_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFalse.MouseLeave
        btnFalse.BackColor = Color.FromArgb(250, 250, 250)
    End Sub

    Private Sub letter1_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles letter1.MouseEnter
        letter1.BackColor = Color.FromArgb(200, 200, 200)
    End Sub
    Private Sub letter1_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles letter1.MouseLeave
        letter1.BackColor = Color.FromArgb(255, 255, 255)
    End Sub
    Private Sub letter2_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles letter2.MouseEnter
        letter2.BackColor = Color.FromArgb(200, 200, 200)
    End Sub
    Private Sub letter2_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles letter2.MouseLeave
        letter2.BackColor = Color.FromArgb(255, 255, 255)
    End Sub
    Private Sub letter3_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles letter3.MouseEnter
        letter3.BackColor = Color.FromArgb(200, 200, 200)
    End Sub
    Private Sub letter3_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles letter3.MouseLeave
        letter3.BackColor = Color.FromArgb(255, 255, 255)
    End Sub
    Private Sub letter4_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles letter4.MouseEnter
        letter4.BackColor = Color.FromArgb(200, 200, 200)
    End Sub
    Private Sub letter4_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles letter4.MouseLeave
        letter4.BackColor = Color.FromArgb(255, 255, 255)
    End Sub
    Private Sub letter5_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles letter5.MouseEnter
        letter5.BackColor = Color.FromArgb(200, 200, 200)
    End Sub
    Private Sub letter5_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles letter5.MouseLeave
        letter5.BackColor = Color.FromArgb(255, 255, 255)
    End Sub
    Private Sub letter6_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles letter6.MouseEnter
        letter6.BackColor = Color.FromArgb(200, 200, 200)
    End Sub
    Private Sub letter6_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles letter6.MouseLeave
        letter6.BackColor = Color.FromArgb(255, 255, 255)
    End Sub
    Private Sub letter7_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles letter7.MouseEnter
        letter7.BackColor = Color.FromArgb(200, 200, 200)
    End Sub
    Private Sub letter7_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles letter7.MouseLeave
        letter7.BackColor = Color.FromArgb(255, 255, 255)
    End Sub
    Private Sub letter8_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles letter8.MouseEnter
        letter8.BackColor = Color.FromArgb(200, 200, 200)
    End Sub
    Private Sub letter8_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles letter8.MouseLeave
        letter8.BackColor = Color.FromArgb(255, 255, 255)
    End Sub
    Private Sub letter9_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles letter9.MouseEnter
        letter9.BackColor = Color.FromArgb(200, 200, 200)
    End Sub
    Private Sub letter9_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles letter9.MouseLeave
        letter9.BackColor = Color.FromArgb(255, 255, 255)
    End Sub
    Private Sub letter10_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles letter10.MouseEnter
        letter10.BackColor = Color.FromArgb(200, 200, 200)
    End Sub
    Private Sub letter10_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles letter10.MouseLeave
        letter10.BackColor = Color.FromArgb(255, 255, 255)
    End Sub
    Private Sub letter11_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles letter11.MouseEnter
        letter11.BackColor = Color.FromArgb(200, 200, 200)
    End Sub
    Private Sub letter11_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles letter11.MouseLeave
        letter11.BackColor = Color.FromArgb(255, 255, 255)
    End Sub
    Private Sub letter12_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles letter12.MouseEnter
        letter12.BackColor = Color.FromArgb(200, 200, 200)
    End Sub
    Private Sub letter12_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles letter12.MouseLeave
        letter12.BackColor = Color.FromArgb(255, 255, 255)
    End Sub

#End Region

#Region "Timers"

    Private Sub timerFeedback_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timerFeedback.Tick
        btnExitFeedback.PerformClick()
    End Sub
    Private Sub timerLetterPanelShow_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timerLetterPanelShow.Tick
        timerLetterPanelShow.Enabled = False
        If practiceOspanBool = True And CType(numCounterTasks + practiceInstructionsSubCount, Single) <= CType(5, Single) Then
            LoopToFinishOspan()
        Else
            btnToLetters.PerformClick()
        End If
    End Sub
    Private Sub timerResponsePractice_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timerResponsePractice.Tick
        pnlQuestion.Visible = True
        lblIncorrect.Visible = False
        lblCorrect.Visible = False
        pnlFeedback.Visible = True
        pnlLetters.Visible = False
        lblPnlLettersInstructions.Visible = False
        pnlLetter.BringToFront()
        pnlLetter.Visible = False
        pnlAnswer.Visible = False

        timerResponsePractice.Enabled = False

        LoopToFinishOspan()

        If calculateAverageTime = True Then
            startTime = Date.Now()
        End If

    End Sub
    Private Sub timeToRespond_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timeToRespond.Tick
        If practiceOspanBool = False Then
            timeToDoMathStopwatch.Stop()
            participantTrialString(numArrayIntegerCounter) = participantTrialString(numArrayIntegerCounter) + Now().ToLongTimeString + "," + timeToDoMathStopwatch.ElapsedMilliseconds.ToString() + "," + "SPEED - Incorrect,,,"
        End If
        timeToRespond.Enabled = False
        mathTotalCount = mathTotalCount + 1
        tempMathErrors = tempMathErrors + 1
        mathSpeedErrors = mathSpeedErrors + 1
        pnlFeedback.Visible = True
        pnlLetters.Visible = False
        lblPnlLettersInstructions.Visible = False
        pnlLetter.BringToFront()
        pnlLetter.Visible = True
        pnlAnswer.Visible = False
        pnlQuestion.Visible = False
        timerLetterPanelShow.Enabled = True

    End Sub

#End Region

#Region "Super Secret Textboxes...what do they do?!"
    'They're actually used to take the input for the "Space" bar at the end followed by the "Shift + Esc" exiting. Haha I need to find a better way to do this.
    Private Sub TextBox1_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Space Then
            btnToResults.PerformClick()
        End If
    End Sub
    Private Sub masterTextBox_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles masterTextBox.KeyDown
        If e.KeyCode = Keys.ShiftKey Then
            applicationExit = True
        End If
        If e.KeyCode = Keys.Escape Then
            If applicationExit Then
                Application.Exit()
            End If
        End If
    End Sub

#End Region

    Private Sub QuestionScreen_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Application.Exit()
    End Sub
End Class