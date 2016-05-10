<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class QuestionScreen
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
        Me.pnlQuestion = New System.Windows.Forms.Panel()
        Me.btnContinue = New System.Windows.Forms.Button()
        Me.lblClickToContinue = New System.Windows.Forms.Label()
        Me.lblMathQuestion = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.pnlAnswer = New System.Windows.Forms.Panel()
        Me.lblIncorrect = New System.Windows.Forms.Label()
        Me.lblCorrect = New System.Windows.Forms.Label()
        Me.btnTrue = New System.Windows.Forms.Label()
        Me.btnFalse = New System.Windows.Forms.Label()
        Me.lblMathAnswer = New System.Windows.Forms.Label()
        Me.pnlLetter = New System.Windows.Forms.Panel()
        Me.btnToLetters = New System.Windows.Forms.Button()
        Me.lblLetterAnswer = New System.Windows.Forms.Label()
        Me.pnlLetters = New System.Windows.Forms.Panel()
        Me.btnClearLetters = New System.Windows.Forms.Label()
        Me.btnBlankLetter = New System.Windows.Forms.Label()
        Me.btnExitLetters = New System.Windows.Forms.Label()
        Me.AnswerBox = New System.Windows.Forms.Label()
        Me.letter12 = New System.Windows.Forms.Label()
        Me.letter8 = New System.Windows.Forms.Label()
        Me.letter4 = New System.Windows.Forms.Label()
        Me.letter11 = New System.Windows.Forms.Label()
        Me.letter7 = New System.Windows.Forms.Label()
        Me.letter3 = New System.Windows.Forms.Label()
        Me.letter10 = New System.Windows.Forms.Label()
        Me.letter6 = New System.Windows.Forms.Label()
        Me.letter2 = New System.Windows.Forms.Label()
        Me.letter9 = New System.Windows.Forms.Label()
        Me.letter5 = New System.Windows.Forms.Label()
        Me.letter1 = New System.Windows.Forms.Label()
        Me.lblPnlLettersInstructions = New System.Windows.Forms.Label()
        Me.timerLetterPanelShow = New System.Windows.Forms.Timer(Me.components)
        Me.pnlFeedback = New System.Windows.Forms.Panel()
        Me.lblMathErrors = New System.Windows.Forms.Label()
        Me.lblPercentMathCorrect = New System.Windows.Forms.Label()
        Me.btnExitFeedback = New System.Windows.Forms.Button()
        Me.lblRecall = New System.Windows.Forms.Label()
        Me.timerFeedback = New System.Windows.Forms.Timer(Me.components)
        Me.pnlResults = New System.Windows.Forms.Panel()
        Me.lblPartID = New System.Windows.Forms.Label()
        Me.lblMathAccuracyErrors = New System.Windows.Forms.Label()
        Me.lblMathSpeedErrors = New System.Windows.Forms.Label()
        Me.lblMathTotalErrors = New System.Windows.Forms.Label()
        Me.lblOspanTotalCorrect = New System.Windows.Forms.Label()
        Me.lblOspanAbsolute = New System.Windows.Forms.Label()
        Me.pnlDone = New System.Windows.Forms.Panel()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.btnToResults = New System.Windows.Forms.Button()
        Me.lblGetRA = New System.Windows.Forms.Label()
        Me.masterTextBox = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.pnlPracticeInstructions = New System.Windows.Forms.Panel()
        Me.btnNextInstruction = New System.Windows.Forms.Button()
        Me.lblPracticeInstructions = New System.Windows.Forms.Label()
        Me.timerResponsePractice = New System.Windows.Forms.Timer(Me.components)
        Me.timeToRespond = New System.Windows.Forms.Timer(Me.components)
        Me.pnlQuestion.SuspendLayout()
        Me.pnlAnswer.SuspendLayout()
        Me.pnlLetter.SuspendLayout()
        Me.pnlLetters.SuspendLayout()
        Me.pnlFeedback.SuspendLayout()
        Me.pnlResults.SuspendLayout()
        Me.pnlDone.SuspendLayout()
        Me.pnlPracticeInstructions.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlQuestion
        '
        Me.pnlQuestion.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlQuestion.BackColor = System.Drawing.Color.Silver
        Me.pnlQuestion.Controls.Add(Me.btnContinue)
        Me.pnlQuestion.Controls.Add(Me.lblClickToContinue)
        Me.pnlQuestion.Controls.Add(Me.lblMathQuestion)
        Me.pnlQuestion.Location = New System.Drawing.Point(101, 87)
        Me.pnlQuestion.Name = "pnlQuestion"
        Me.pnlQuestion.Size = New System.Drawing.Size(801, 567)
        Me.pnlQuestion.TabIndex = 10
        '
        'btnContinue
        '
        Me.btnContinue.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnContinue.Location = New System.Drawing.Point(-200, -200)
        Me.btnContinue.Name = "btnContinue"
        Me.btnContinue.Size = New System.Drawing.Size(75, 23)
        Me.btnContinue.TabIndex = 2
        Me.btnContinue.Text = "Continue"
        Me.btnContinue.UseVisualStyleBackColor = True
        '
        'lblClickToContinue
        '
        Me.lblClickToContinue.AutoSize = True
        Me.lblClickToContinue.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClickToContinue.Location = New System.Drawing.Point(176, 384)
        Me.lblClickToContinue.Name = "lblClickToContinue"
        Me.lblClickToContinue.Size = New System.Drawing.Size(489, 29)
        Me.lblClickToContinue.TabIndex = 1
        Me.lblClickToContinue.Text = "When you have solved the math problem,"
        Me.lblClickToContinue.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblMathQuestion
        '
        Me.lblMathQuestion.AutoSize = True
        Me.lblMathQuestion.Font = New System.Drawing.Font("Arial", 28.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMathQuestion.Location = New System.Drawing.Point(265, 176)
        Me.lblMathQuestion.Name = "lblMathQuestion"
        Me.lblMathQuestion.Size = New System.Drawing.Size(257, 45)
        Me.lblMathQuestion.TabIndex = 0
        Me.lblMathQuestion.Text = "(1 * 2) + 1 = ?"
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(-200, -200)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 1
        Me.btnCancel.Text = "Exit"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'pnlAnswer
        '
        Me.pnlAnswer.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlAnswer.BackColor = System.Drawing.Color.Silver
        Me.pnlAnswer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlAnswer.Controls.Add(Me.lblIncorrect)
        Me.pnlAnswer.Controls.Add(Me.lblCorrect)
        Me.pnlAnswer.Controls.Add(Me.btnTrue)
        Me.pnlAnswer.Controls.Add(Me.btnFalse)
        Me.pnlAnswer.Controls.Add(Me.lblMathAnswer)
        Me.pnlAnswer.Location = New System.Drawing.Point(101, 87)
        Me.pnlAnswer.Name = "pnlAnswer"
        Me.pnlAnswer.Size = New System.Drawing.Size(801, 567)
        Me.pnlAnswer.TabIndex = 10
        Me.pnlAnswer.Visible = False
        '
        'lblIncorrect
        '
        Me.lblIncorrect.AutoSize = True
        Me.lblIncorrect.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIncorrect.ForeColor = System.Drawing.Color.Red
        Me.lblIncorrect.Location = New System.Drawing.Point(336, 429)
        Me.lblIncorrect.Name = "lblIncorrect"
        Me.lblIncorrect.Size = New System.Drawing.Size(113, 27)
        Me.lblIncorrect.TabIndex = 1
        Me.lblIncorrect.Text = "Incorrect!"
        Me.lblIncorrect.Visible = False
        '
        'lblCorrect
        '
        Me.lblCorrect.AutoSize = True
        Me.lblCorrect.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCorrect.ForeColor = System.Drawing.Color.Blue
        Me.lblCorrect.Location = New System.Drawing.Point(342, 397)
        Me.lblCorrect.Name = "lblCorrect"
        Me.lblCorrect.Size = New System.Drawing.Size(98, 27)
        Me.lblCorrect.TabIndex = 1
        Me.lblCorrect.Text = "Correct!"
        Me.lblCorrect.Visible = False
        '
        'btnTrue
        '
        Me.btnTrue.AutoSize = True
        Me.btnTrue.BackColor = System.Drawing.Color.White
        Me.btnTrue.Font = New System.Drawing.Font("Arial", 28.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTrue.Location = New System.Drawing.Point(212, 383)
        Me.btnTrue.Name = "btnTrue"
        Me.btnTrue.Size = New System.Drawing.Size(100, 45)
        Me.btnTrue.TabIndex = 0
        Me.btnTrue.Text = "True"
        '
        'btnFalse
        '
        Me.btnFalse.AutoSize = True
        Me.btnFalse.BackColor = System.Drawing.Color.White
        Me.btnFalse.Font = New System.Drawing.Font("Arial", 28.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFalse.Location = New System.Drawing.Point(468, 383)
        Me.btnFalse.Name = "btnFalse"
        Me.btnFalse.Size = New System.Drawing.Size(117, 45)
        Me.btnFalse.TabIndex = 0
        Me.btnFalse.Text = "False"
        '
        'lblMathAnswer
        '
        Me.lblMathAnswer.AutoSize = True
        Me.lblMathAnswer.Font = New System.Drawing.Font("Arial", 28.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMathAnswer.Location = New System.Drawing.Point(382, 176)
        Me.lblMathAnswer.Name = "lblMathAnswer"
        Me.lblMathAnswer.Size = New System.Drawing.Size(41, 45)
        Me.lblMathAnswer.TabIndex = 0
        Me.lblMathAnswer.Text = "3"
        '
        'pnlLetter
        '
        Me.pnlLetter.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlLetter.BackColor = System.Drawing.Color.Silver
        Me.pnlLetter.Controls.Add(Me.btnToLetters)
        Me.pnlLetter.Controls.Add(Me.lblLetterAnswer)
        Me.pnlLetter.Location = New System.Drawing.Point(101, 87)
        Me.pnlLetter.Name = "pnlLetter"
        Me.pnlLetter.Size = New System.Drawing.Size(801, 567)
        Me.pnlLetter.TabIndex = 10
        Me.pnlLetter.Visible = False
        '
        'btnToLetters
        '
        Me.btnToLetters.Location = New System.Drawing.Point(-400, -400)
        Me.btnToLetters.Name = "btnToLetters"
        Me.btnToLetters.Size = New System.Drawing.Size(75, 23)
        Me.btnToLetters.TabIndex = 3
        Me.btnToLetters.Text = "To Letters"
        Me.btnToLetters.UseVisualStyleBackColor = True
        '
        'lblLetterAnswer
        '
        Me.lblLetterAnswer.AutoSize = True
        Me.lblLetterAnswer.Font = New System.Drawing.Font("Arial", 28.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.lblLetterAnswer.Location = New System.Drawing.Point(378, 216)
        Me.lblLetterAnswer.Name = "lblLetterAnswer"
        Me.lblLetterAnswer.Size = New System.Drawing.Size(47, 45)
        Me.lblLetterAnswer.TabIndex = 0
        Me.lblLetterAnswer.Text = "A"
        '
        'pnlLetters
        '
        Me.pnlLetters.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlLetters.BackColor = System.Drawing.Color.White
        Me.pnlLetters.Controls.Add(Me.btnClearLetters)
        Me.pnlLetters.Controls.Add(Me.btnBlankLetter)
        Me.pnlLetters.Controls.Add(Me.btnExitLetters)
        Me.pnlLetters.Controls.Add(Me.AnswerBox)
        Me.pnlLetters.Controls.Add(Me.letter12)
        Me.pnlLetters.Controls.Add(Me.letter8)
        Me.pnlLetters.Controls.Add(Me.letter4)
        Me.pnlLetters.Controls.Add(Me.letter11)
        Me.pnlLetters.Controls.Add(Me.letter7)
        Me.pnlLetters.Controls.Add(Me.letter3)
        Me.pnlLetters.Controls.Add(Me.letter10)
        Me.pnlLetters.Controls.Add(Me.letter6)
        Me.pnlLetters.Controls.Add(Me.letter2)
        Me.pnlLetters.Controls.Add(Me.letter9)
        Me.pnlLetters.Controls.Add(Me.letter5)
        Me.pnlLetters.Controls.Add(Me.letter1)
        Me.pnlLetters.Location = New System.Drawing.Point(101, 87)
        Me.pnlLetters.Name = "pnlLetters"
        Me.pnlLetters.Size = New System.Drawing.Size(801, 567)
        Me.pnlLetters.TabIndex = 0
        Me.pnlLetters.Visible = False
        '
        'btnClearLetters
        '
        Me.btnClearLetters.AutoSize = True
        Me.btnClearLetters.Font = New System.Drawing.Font("Arial", 28.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClearLetters.Location = New System.Drawing.Point(83, 482)
        Me.btnClearLetters.Name = "btnClearLetters"
        Me.btnClearLetters.Size = New System.Drawing.Size(115, 45)
        Me.btnClearLetters.TabIndex = 0
        Me.btnClearLetters.Text = "Clear"
        '
        'btnBlankLetter
        '
        Me.btnBlankLetter.AutoSize = True
        Me.btnBlankLetter.Font = New System.Drawing.Font("Arial", 28.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBlankLetter.Location = New System.Drawing.Point(340, 452)
        Me.btnBlankLetter.Name = "btnBlankLetter"
        Me.btnBlankLetter.Size = New System.Drawing.Size(123, 45)
        Me.btnBlankLetter.TabIndex = 0
        Me.btnBlankLetter.Text = "Blank"
        '
        'btnExitLetters
        '
        Me.btnExitLetters.AutoSize = True
        Me.btnExitLetters.Font = New System.Drawing.Font("Arial", 28.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExitLetters.Location = New System.Drawing.Point(650, 482)
        Me.btnExitLetters.Name = "btnExitLetters"
        Me.btnExitLetters.Size = New System.Drawing.Size(90, 45)
        Me.btnExitLetters.TabIndex = 0
        Me.btnExitLetters.Text = "Exit"
        '
        'AnswerBox
        '
        Me.AnswerBox.AutoSize = True
        Me.AnswerBox.BackColor = System.Drawing.Color.White
        Me.AnswerBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AnswerBox.ForeColor = System.Drawing.Color.Red
        Me.AnswerBox.Location = New System.Drawing.Point(334, 430)
        Me.AnswerBox.Name = "AnswerBox"
        Me.AnswerBox.Size = New System.Drawing.Size(0, 46)
        Me.AnswerBox.TabIndex = 0
        '
        'letter12
        '
        Me.letter12.AutoSize = True
        Me.letter12.Font = New System.Drawing.Font("Arial", 28.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.letter12.Location = New System.Drawing.Point(592, 384)
        Me.letter12.Name = "letter12"
        Me.letter12.Size = New System.Drawing.Size(47, 45)
        Me.letter12.TabIndex = 0
        Me.letter12.Text = "A"
        '
        'letter8
        '
        Me.letter8.AutoSize = True
        Me.letter8.Font = New System.Drawing.Font("Arial", 28.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.letter8.Location = New System.Drawing.Point(412, 289)
        Me.letter8.Name = "letter8"
        Me.letter8.Size = New System.Drawing.Size(47, 45)
        Me.letter8.TabIndex = 0
        Me.letter8.Text = "A"
        '
        'letter4
        '
        Me.letter4.AutoSize = True
        Me.letter4.Font = New System.Drawing.Font("Arial", 28.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.letter4.Location = New System.Drawing.Point(226, 184)
        Me.letter4.Name = "letter4"
        Me.letter4.Size = New System.Drawing.Size(47, 45)
        Me.letter4.TabIndex = 0
        Me.letter4.Text = "A"
        '
        'letter11
        '
        Me.letter11.AutoSize = True
        Me.letter11.Font = New System.Drawing.Font("Arial", 28.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.letter11.Location = New System.Drawing.Point(412, 384)
        Me.letter11.Name = "letter11"
        Me.letter11.Size = New System.Drawing.Size(47, 45)
        Me.letter11.TabIndex = 0
        Me.letter11.Text = "A"
        '
        'letter7
        '
        Me.letter7.AutoSize = True
        Me.letter7.Font = New System.Drawing.Font("Arial", 28.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.letter7.Location = New System.Drawing.Point(226, 289)
        Me.letter7.Name = "letter7"
        Me.letter7.Size = New System.Drawing.Size(47, 45)
        Me.letter7.TabIndex = 0
        Me.letter7.Text = "A"
        '
        'letter3
        '
        Me.letter3.AutoSize = True
        Me.letter3.Font = New System.Drawing.Font("Arial", 28.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.letter3.Location = New System.Drawing.Point(592, 87)
        Me.letter3.Name = "letter3"
        Me.letter3.Size = New System.Drawing.Size(47, 45)
        Me.letter3.TabIndex = 0
        Me.letter3.Text = "A"
        '
        'letter10
        '
        Me.letter10.AutoSize = True
        Me.letter10.Font = New System.Drawing.Font("Arial", 28.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.letter10.Location = New System.Drawing.Point(226, 384)
        Me.letter10.Name = "letter10"
        Me.letter10.Size = New System.Drawing.Size(47, 45)
        Me.letter10.TabIndex = 0
        Me.letter10.Text = "A"
        '
        'letter6
        '
        Me.letter6.AutoSize = True
        Me.letter6.Font = New System.Drawing.Font("Arial", 28.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.letter6.Location = New System.Drawing.Point(592, 184)
        Me.letter6.Name = "letter6"
        Me.letter6.Size = New System.Drawing.Size(47, 45)
        Me.letter6.TabIndex = 0
        Me.letter6.Text = "A"
        '
        'letter2
        '
        Me.letter2.AutoSize = True
        Me.letter2.Font = New System.Drawing.Font("Arial", 28.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.letter2.Location = New System.Drawing.Point(412, 87)
        Me.letter2.Name = "letter2"
        Me.letter2.Size = New System.Drawing.Size(47, 45)
        Me.letter2.TabIndex = 0
        Me.letter2.Text = "A"
        '
        'letter9
        '
        Me.letter9.AutoSize = True
        Me.letter9.Font = New System.Drawing.Font("Arial", 28.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.letter9.Location = New System.Drawing.Point(592, 289)
        Me.letter9.Name = "letter9"
        Me.letter9.Size = New System.Drawing.Size(47, 45)
        Me.letter9.TabIndex = 0
        Me.letter9.Text = "A"
        '
        'letter5
        '
        Me.letter5.AutoSize = True
        Me.letter5.Font = New System.Drawing.Font("Arial", 28.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.letter5.Location = New System.Drawing.Point(412, 188)
        Me.letter5.Name = "letter5"
        Me.letter5.Size = New System.Drawing.Size(47, 45)
        Me.letter5.TabIndex = 0
        Me.letter5.Text = "A"
        '
        'letter1
        '
        Me.letter1.AutoSize = True
        Me.letter1.Font = New System.Drawing.Font("Arial", 28.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.letter1.Location = New System.Drawing.Point(226, 87)
        Me.letter1.Name = "letter1"
        Me.letter1.Size = New System.Drawing.Size(47, 45)
        Me.letter1.TabIndex = 0
        Me.letter1.Text = "A"
        '
        'lblPnlLettersInstructions
        '
        Me.lblPnlLettersInstructions.AutoSize = True
        Me.lblPnlLettersInstructions.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPnlLettersInstructions.Location = New System.Drawing.Point(12, 23)
        Me.lblPnlLettersInstructions.Name = "lblPnlLettersInstructions"
        Me.lblPnlLettersInstructions.Size = New System.Drawing.Size(1011, 29)
        Me.lblPnlLettersInstructions.TabIndex = 0
        Me.lblPnlLettersInstructions.Text = "Select the letters in the order presented. Use the blank button to fill in forgot" & _
            "ten letters."
        Me.lblPnlLettersInstructions.Visible = False
        '
        'timerLetterPanelShow
        '
        Me.timerLetterPanelShow.Interval = 800
        '
        'pnlFeedback
        '
        Me.pnlFeedback.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlFeedback.BackColor = System.Drawing.Color.White
        Me.pnlFeedback.Controls.Add(Me.lblMathErrors)
        Me.pnlFeedback.Controls.Add(Me.lblPercentMathCorrect)
        Me.pnlFeedback.Controls.Add(Me.btnExitFeedback)
        Me.pnlFeedback.Controls.Add(Me.lblRecall)
        Me.pnlFeedback.Location = New System.Drawing.Point(101, 87)
        Me.pnlFeedback.Name = "pnlFeedback"
        Me.pnlFeedback.Size = New System.Drawing.Size(801, 567)
        Me.pnlFeedback.TabIndex = 10
        Me.pnlFeedback.Visible = False
        '
        'lblMathErrors
        '
        Me.lblMathErrors.AutoSize = True
        Me.lblMathErrors.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.lblMathErrors.ForeColor = System.Drawing.Color.Black
        Me.lblMathErrors.Location = New System.Drawing.Point(163, 289)
        Me.lblMathErrors.Name = "lblMathErrors"
        Me.lblMathErrors.Size = New System.Drawing.Size(529, 29)
        Me.lblMathErrors.TabIndex = 10
        Me.lblMathErrors.Text = "You made 0 math error(s) on this set of trials."
        '
        'lblPercentMathCorrect
        '
        Me.lblPercentMathCorrect.AutoSize = True
        Me.lblPercentMathCorrect.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPercentMathCorrect.ForeColor = System.Drawing.Color.Red
        Me.lblPercentMathCorrect.Location = New System.Drawing.Point(660, 25)
        Me.lblPercentMathCorrect.Name = "lblPercentMathCorrect"
        Me.lblPercentMathCorrect.Size = New System.Drawing.Size(70, 29)
        Me.lblPercentMathCorrect.TabIndex = 10
        Me.lblPercentMathCorrect.Text = "100%"
        '
        'btnExitFeedback
        '
        Me.btnExitFeedback.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExitFeedback.Location = New System.Drawing.Point(-350, -350)
        Me.btnExitFeedback.Name = "btnExitFeedback"
        Me.btnExitFeedback.Size = New System.Drawing.Size(75, 23)
        Me.btnExitFeedback.TabIndex = 3
        Me.btnExitFeedback.Text = "btnExitFeedback"
        Me.btnExitFeedback.UseVisualStyleBackColor = True
        '
        'lblRecall
        '
        Me.lblRecall.AutoSize = True
        Me.lblRecall.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.lblRecall.ForeColor = System.Drawing.Color.Black
        Me.lblRecall.Location = New System.Drawing.Point(203, 155)
        Me.lblRecall.Name = "lblRecall"
        Me.lblRecall.Size = New System.Drawing.Size(458, 29)
        Me.lblRecall.TabIndex = 10
        Me.lblRecall.Text = "You recalled 1 out of 2 letters correctly."
        '
        'timerFeedback
        '
        Me.timerFeedback.Interval = 2000
        '
        'pnlResults
        '
        Me.pnlResults.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlResults.BackColor = System.Drawing.Color.White
        Me.pnlResults.Controls.Add(Me.lblPartID)
        Me.pnlResults.Controls.Add(Me.lblMathAccuracyErrors)
        Me.pnlResults.Controls.Add(Me.lblMathSpeedErrors)
        Me.pnlResults.Controls.Add(Me.lblMathTotalErrors)
        Me.pnlResults.Controls.Add(Me.lblOspanTotalCorrect)
        Me.pnlResults.Controls.Add(Me.lblOspanAbsolute)
        Me.pnlResults.Location = New System.Drawing.Point(101, 87)
        Me.pnlResults.Name = "pnlResults"
        Me.pnlResults.Size = New System.Drawing.Size(801, 567)
        Me.pnlResults.TabIndex = 10
        Me.pnlResults.Visible = False
        '
        'lblPartID
        '
        Me.lblPartID.AutoSize = True
        Me.lblPartID.Font = New System.Drawing.Font("Arial", 28.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.lblPartID.ForeColor = System.Drawing.Color.Black
        Me.lblPartID.Location = New System.Drawing.Point(130, 110)
        Me.lblPartID.Name = "lblPartID"
        Me.lblPartID.Size = New System.Drawing.Size(554, 45)
        Me.lblPartID.TabIndex = 10
        Me.lblPartID.Text = "Results for Participant # 6001"
        '
        'lblMathAccuracyErrors
        '
        Me.lblMathAccuracyErrors.AutoSize = True
        Me.lblMathAccuracyErrors.Font = New System.Drawing.Font("Arial", 28.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.lblMathAccuracyErrors.ForeColor = System.Drawing.Color.Black
        Me.lblMathAccuracyErrors.Location = New System.Drawing.Point(156, 363)
        Me.lblMathAccuracyErrors.Name = "lblMathAccuracyErrors"
        Me.lblMathAccuracyErrors.Size = New System.Drawing.Size(459, 45)
        Me.lblMathAccuracyErrors.TabIndex = 10
        Me.lblMathAccuracyErrors.Text = "Math Accuracy Errors: 0"
        '
        'lblMathSpeedErrors
        '
        Me.lblMathSpeedErrors.AutoSize = True
        Me.lblMathSpeedErrors.Font = New System.Drawing.Font("Arial", 28.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.lblMathSpeedErrors.ForeColor = System.Drawing.Color.Black
        Me.lblMathSpeedErrors.Location = New System.Drawing.Point(156, 318)
        Me.lblMathSpeedErrors.Name = "lblMathSpeedErrors"
        Me.lblMathSpeedErrors.Size = New System.Drawing.Size(404, 45)
        Me.lblMathSpeedErrors.TabIndex = 10
        Me.lblMathSpeedErrors.Text = "Math Speed Errors: 0"
        '
        'lblMathTotalErrors
        '
        Me.lblMathTotalErrors.AutoSize = True
        Me.lblMathTotalErrors.Font = New System.Drawing.Font("Arial", 28.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.lblMathTotalErrors.ForeColor = System.Drawing.Color.Black
        Me.lblMathTotalErrors.Location = New System.Drawing.Point(156, 273)
        Me.lblMathTotalErrors.Name = "lblMathTotalErrors"
        Me.lblMathTotalErrors.Size = New System.Drawing.Size(379, 45)
        Me.lblMathTotalErrors.TabIndex = 10
        Me.lblMathTotalErrors.Text = "Math Total Errors: 0"
        '
        'lblOspanTotalCorrect
        '
        Me.lblOspanTotalCorrect.AutoSize = True
        Me.lblOspanTotalCorrect.Font = New System.Drawing.Font("Arial", 28.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.lblOspanTotalCorrect.ForeColor = System.Drawing.Color.Black
        Me.lblOspanTotalCorrect.Location = New System.Drawing.Point(156, 233)
        Me.lblOspanTotalCorrect.Name = "lblOspanTotalCorrect"
        Me.lblOspanTotalCorrect.Size = New System.Drawing.Size(462, 45)
        Me.lblOspanTotalCorrect.TabIndex = 10
        Me.lblOspanTotalCorrect.Text = "OSPAN Total Correct: 75"
        '
        'lblOspanAbsolute
        '
        Me.lblOspanAbsolute.AutoSize = True
        Me.lblOspanAbsolute.Font = New System.Drawing.Font("Arial", 28.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.lblOspanAbsolute.ForeColor = System.Drawing.Color.Black
        Me.lblOspanAbsolute.Location = New System.Drawing.Point(156, 188)
        Me.lblOspanAbsolute.Name = "lblOspanAbsolute"
        Me.lblOspanAbsolute.Size = New System.Drawing.Size(505, 45)
        Me.lblOspanAbsolute.TabIndex = 10
        Me.lblOspanAbsolute.Text = "OSPAN Absolute Score: 75"
        '
        'pnlDone
        '
        Me.pnlDone.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlDone.BackColor = System.Drawing.Color.White
        Me.pnlDone.Controls.Add(Me.TextBox1)
        Me.pnlDone.Controls.Add(Me.btnToResults)
        Me.pnlDone.Controls.Add(Me.lblGetRA)
        Me.pnlDone.Location = New System.Drawing.Point(101, 87)
        Me.pnlDone.Name = "pnlDone"
        Me.pnlDone.Size = New System.Drawing.Size(801, 567)
        Me.pnlDone.TabIndex = 10
        Me.pnlDone.Visible = False
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(-600, -600)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 0
        '
        'btnToResults
        '
        Me.btnToResults.Location = New System.Drawing.Point(-444, -444)
        Me.btnToResults.Name = "btnToResults"
        Me.btnToResults.Size = New System.Drawing.Size(75, 23)
        Me.btnToResults.TabIndex = 4
        Me.btnToResults.Text = "Button8"
        Me.btnToResults.UseVisualStyleBackColor = True
        '
        'lblGetRA
        '
        Me.lblGetRA.AutoSize = True
        Me.lblGetRA.Font = New System.Drawing.Font("Arial", 28.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.lblGetRA.ForeColor = System.Drawing.Color.Black
        Me.lblGetRA.Location = New System.Drawing.Point(108, 244)
        Me.lblGetRA.Name = "lblGetRA"
        Me.lblGetRA.Size = New System.Drawing.Size(632, 45)
        Me.lblGetRA.TabIndex = 10
        Me.lblGetRA.Text = "Please get the research assistant."
        '
        'masterTextBox
        '
        Me.masterTextBox.Location = New System.Drawing.Point(-500, -600)
        Me.masterTextBox.Name = "masterTextBox"
        Me.masterTextBox.Size = New System.Drawing.Size(100, 20)
        Me.masterTextBox.TabIndex = 11
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Location = New System.Drawing.Point(91, 77)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(821, 587)
        Me.Panel1.TabIndex = 12
        Me.Panel1.Visible = False
        '
        'pnlPracticeInstructions
        '
        Me.pnlPracticeInstructions.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlPracticeInstructions.BackColor = System.Drawing.Color.White
        Me.pnlPracticeInstructions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlPracticeInstructions.Controls.Add(Me.btnNextInstruction)
        Me.pnlPracticeInstructions.Controls.Add(Me.lblPracticeInstructions)
        Me.pnlPracticeInstructions.Location = New System.Drawing.Point(101, 87)
        Me.pnlPracticeInstructions.Name = "pnlPracticeInstructions"
        Me.pnlPracticeInstructions.Size = New System.Drawing.Size(801, 567)
        Me.pnlPracticeInstructions.TabIndex = 10
        Me.pnlPracticeInstructions.Visible = False
        '
        'btnNextInstruction
        '
        Me.btnNextInstruction.Location = New System.Drawing.Point(-500, -500)
        Me.btnNextInstruction.Name = "btnNextInstruction"
        Me.btnNextInstruction.Size = New System.Drawing.Size(75, 23)
        Me.btnNextInstruction.TabIndex = 11
        Me.btnNextInstruction.Text = "O"
        Me.btnNextInstruction.UseVisualStyleBackColor = True
        '
        'lblPracticeInstructions
        '
        Me.lblPracticeInstructions.AutoSize = True
        Me.lblPracticeInstructions.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.lblPracticeInstructions.ForeColor = System.Drawing.Color.Black
        Me.lblPracticeInstructions.Location = New System.Drawing.Point(249, 177)
        Me.lblPracticeInstructions.Name = "lblPracticeInstructions"
        Me.lblPracticeInstructions.Size = New System.Drawing.Size(337, 29)
        Me.lblPracticeInstructions.TabIndex = 10
        Me.lblPracticeInstructions.Text = "In this experiment you will..."
        Me.lblPracticeInstructions.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'timerResponsePractice
        '
        Me.timerResponsePractice.Interval = 500
        '
        'timeToRespond
        '
        '
        'QuestionScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1003, 740)
        Me.Controls.Add(Me.masterTextBox)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.lblPnlLettersInstructions)
        Me.Controls.Add(Me.pnlLetters)
        Me.Controls.Add(Me.pnlLetter)
        Me.Controls.Add(Me.pnlQuestion)
        Me.Controls.Add(Me.pnlAnswer)
        Me.Controls.Add(Me.pnlDone)
        Me.Controls.Add(Me.pnlResults)
        Me.Controls.Add(Me.pnlPracticeInstructions)
        Me.Controls.Add(Me.pnlFeedback)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "QuestionScreen"
        Me.Text = "QuestionScreen"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pnlQuestion.ResumeLayout(False)
        Me.pnlQuestion.PerformLayout()
        Me.pnlAnswer.ResumeLayout(False)
        Me.pnlAnswer.PerformLayout()
        Me.pnlLetter.ResumeLayout(False)
        Me.pnlLetter.PerformLayout()
        Me.pnlLetters.ResumeLayout(False)
        Me.pnlLetters.PerformLayout()
        Me.pnlFeedback.ResumeLayout(False)
        Me.pnlFeedback.PerformLayout()
        Me.pnlResults.ResumeLayout(False)
        Me.pnlResults.PerformLayout()
        Me.pnlDone.ResumeLayout(False)
        Me.pnlDone.PerformLayout()
        Me.pnlPracticeInstructions.ResumeLayout(False)
        Me.pnlPracticeInstructions.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pnlQuestion As System.Windows.Forms.Panel
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents lblMathQuestion As System.Windows.Forms.Label
    Friend WithEvents lblClickToContinue As System.Windows.Forms.Label
    Friend WithEvents btnContinue As System.Windows.Forms.Button
    Friend WithEvents pnlAnswer As System.Windows.Forms.Panel
    Friend WithEvents lblMathAnswer As System.Windows.Forms.Label
    Friend WithEvents pnlLetter As System.Windows.Forms.Panel

    Friend WithEvents lblLetterAnswer As System.Windows.Forms.Label
    Friend WithEvents btnToLetters As System.Windows.Forms.Button
    Friend WithEvents pnlLetters As System.Windows.Forms.Panel

    Friend WithEvents letter12 As System.Windows.Forms.Label
    Friend WithEvents letter8 As System.Windows.Forms.Label
    Friend WithEvents letter4 As System.Windows.Forms.Label
    Friend WithEvents letter11 As System.Windows.Forms.Label
    Friend WithEvents letter7 As System.Windows.Forms.Label
    Friend WithEvents letter3 As System.Windows.Forms.Label
    Friend WithEvents letter10 As System.Windows.Forms.Label
    Friend WithEvents letter6 As System.Windows.Forms.Label
    Friend WithEvents letter2 As System.Windows.Forms.Label
    Friend WithEvents letter9 As System.Windows.Forms.Label
    Friend WithEvents letter5 As System.Windows.Forms.Label
    Friend WithEvents letter1 As System.Windows.Forms.Label
    Friend WithEvents btnExitLetters As System.Windows.Forms.Label
    Friend WithEvents btnTrue As System.Windows.Forms.Label
    Friend WithEvents btnFalse As System.Windows.Forms.Label
    Friend WithEvents timerLetterPanelShow As System.Windows.Forms.Timer
    Friend WithEvents AnswerBox As System.Windows.Forms.Label
    Friend WithEvents pnlFeedback As System.Windows.Forms.Panel
    Friend WithEvents lblMathErrors As System.Windows.Forms.Label
    Friend WithEvents lblRecall As System.Windows.Forms.Label
    Friend WithEvents timerFeedback As System.Windows.Forms.Timer
    Friend WithEvents btnExitFeedback As System.Windows.Forms.Button
    Friend WithEvents btnClearLetters As System.Windows.Forms.Label
    Friend WithEvents btnBlankLetter As System.Windows.Forms.Label
    Friend WithEvents lblPnlLettersInstructions As System.Windows.Forms.Label
    Friend WithEvents lblPercentMathCorrect As System.Windows.Forms.Label
    Friend WithEvents pnlResults As System.Windows.Forms.Panel
    Friend WithEvents lblPartID As System.Windows.Forms.Label
    Friend WithEvents lblMathAccuracyErrors As System.Windows.Forms.Label
    Friend WithEvents lblMathSpeedErrors As System.Windows.Forms.Label
    Friend WithEvents lblMathTotalErrors As System.Windows.Forms.Label
    Friend WithEvents lblOspanTotalCorrect As System.Windows.Forms.Label
    Friend WithEvents lblOspanAbsolute As System.Windows.Forms.Label
    Friend WithEvents pnlDone As System.Windows.Forms.Panel
    Friend WithEvents lblGetRA As System.Windows.Forms.Label
    Friend WithEvents btnToResults As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents masterTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents pnlPracticeInstructions As System.Windows.Forms.Panel
    Friend WithEvents lblPracticeInstructions As System.Windows.Forms.Label
    Friend WithEvents btnNextInstruction As System.Windows.Forms.Button
    Friend WithEvents lblIncorrect As System.Windows.Forms.Label
    Friend WithEvents lblCorrect As System.Windows.Forms.Label
    Friend WithEvents timerResponsePractice As System.Windows.Forms.Timer
    Friend WithEvents timeToRespond As System.Windows.Forms.Timer
End Class
