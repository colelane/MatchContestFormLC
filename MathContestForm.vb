Option Strict On
Option Explicit On
Option Compare Text
Public Class MathContestForm
    'these needed to be global, so all subs could see them.
    Dim infoArr() As String
    Dim arraySizer As Integer
    Dim correct As String
    Dim opStr As String
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Public Sub SubmitButton_Click(sender As Object, e As EventArgs) Handles SubmitButton.Click
        Dim goodData As Boolean
        ReDim Preserve infoArr(0 To arraySizer)
        goodData = EvaluateTextboxes()
        If goodData = False Then
            Exit Sub
        End If
        EvaluateAnswer()
        SaveInfo()

    End Sub

    Function EvaluateTextboxes() As Boolean
        'This function evaluates the textboxes and makes sure they are filled out correctly before moving on.
        Dim eval As Boolean
        Dim ageCheck As Integer
        Dim gradeCheck As Integer
        Dim answerCheck As Integer
        ArrowBox1.Visible = False
        ArrowBox2.Visible = False
        ArrowBox3.Visible = False
        ArrowBox4.Visible = False
        ArrowBox5.Visible = False
        ArrowBox6.Visible = False
        ArrowBox7.Visible = False
        ArrowBox8.Visible = False

        If NameTextBox.Text = Nothing Then
            ActiveControl = NameTextBox
            ArrowBox1.Image = My.Resources.BigRedArrow
            ArrowBox1.Visible = True
            ArrowBox1.BringToFront()
            ArrowBox1.SizeMode = PictureBoxSizeMode.Normal
            MsgBox("Sir. Enter a name.")
            Exit Function
        ElseIf NameTextBox.Text = "Shrek" Then
            My.Computer.Audio.Play(My.Resources.Allstar1, AudioPlayMode.Background)
            ArrowBox1.Image = My.Resources.shrekmouth
            ArrowBox1.SizeMode = PictureBoxSizeMode.CenterImage
            ArrowBox1.Visible = True
            ArrowBox1.BringToFront()
            Exit Function
        ElseIf NameTextBox.Text > Nothing And NameTextBox.Text <> "shrek" Then
            ArrowBox1.Visible = False
        End If

        If AgeTextBox.Text = Nothing Then
            ActiveControl = AgeTextBox
            ArrowBox2.Image = My.Resources.BigRedArrow
            ArrowBox2.Visible = True
            ArrowBox2.BringToFront()
            MsgBox("Sir. Enter an age.")
            Exit Function
        ElseIf AgeTextBox.Text > Nothing Then
            Try
                ageCheck = CInt(AgeTextBox.Text)
            Catch ex As Exception
                ArrowBox2.Image = My.Resources.BigRedArrow
                ArrowBox2.Visible = True
                ArrowBox2.BringToFront()
                MsgBox("Age must be a number")
                ActiveControl = AgeTextBox
                Exit Function
            End Try
            If CInt(AgeTextBox.Text) > 11 Or CInt(AgeTextBox.Text) < 7 Then
                MsgBox("Age must be between 7 and 11")
                ArrowBox2.Image = My.Resources.BigRedArrow
                ArrowBox2.Visible = True
                ArrowBox2.BringToFront()
                Exit Function
            End If
            ArrowBox2.Visible = False
        End If

        If GradeTextBox.Text = Nothing Then
            ActiveControl = GradeTextBox
            ArrowBox3.Image = My.Resources.BigRedArrow
            ArrowBox3.Visible = True
            ArrowBox3.BringToFront()
            MsgBox("Sir. Enter a Grade.")
            Exit Function
        ElseIf GradeTextBox.Text > Nothing Then
            Try
                gradeCheck = CInt(GradeTextBox.Text)
            Catch ex As Exception
                ArrowBox3.Image = My.Resources.BigRedArrow
                ArrowBox3.Visible = True
                ArrowBox3.BringToFront()
                MsgBox("Grade must be a whole number between 1 and 4")
                ActiveControl = GradeTextBox
                Exit Function
            End Try
            If CInt(GradeTextBox.Text) > 4 Or CInt(GradeTextBox.Text) < 1 Then
                MsgBox("Grade must be a whole number between 1 and 4")
                ArrowBox3.Image = My.Resources.BigRedArrow
                ArrowBox3.Visible = True
                ArrowBox3.BringToFront()
                Exit Function
            End If
            ArrowBox3.Visible = False
        End If

        If AddRadioButton.Checked = False And SubtractRadioButton.Checked = False And MultiplyRadioButton.Checked = False And DivideRadioButton.Checked = False Then
            ArrowBox5.Image = My.Resources.BigRedArrow
            ArrowBox5.Visible = True
            ArrowBox5.BringToFront()
            ArrowBox6.Image = My.Resources.BigRedArrow
            ArrowBox6.Visible = True
            ArrowBox6.BringToFront()
            ArrowBox7.Image = My.Resources.BigRedArrow
            ArrowBox7.Visible = True
            ArrowBox7.BringToFront()
            ArrowBox8.Image = My.Resources.BigRedArrow
            ArrowBox8.Visible = True
            ArrowBox8.BringToFront()
            MsgBox("Sir. Check one of the bubbles.")
            Exit Function
        ElseIf AddRadioButton.Checked = True Or SubtractRadioButton.Checked = True Or MultiplyRadioButton.Checked = True Or DivideRadioButton.Checked = True Then
            ArrowBox5.Visible = False
            ArrowBox6.Visible = False
            ArrowBox7.Visible = False
            ArrowBox8.Visible = False
        End If

        If SATextBox.Text = Nothing Then
            ActiveControl = SATextBox
            ArrowBox4.Image = My.Resources.BigRedArrow
            ArrowBox4.Visible = True
            ArrowBox4.BringToFront()
            MsgBox("Sir. Enter an answer.")
            Exit Function
        ElseIf SATextBox.Text > Nothing Then
            Try
                answerCheck = CInt(SATextBox.Text)
            Catch ex As Exception
                ActiveControl = SATextBox
                ArrowBox4.Image = My.Resources.BigRedArrow
                ArrowBox4.Visible = True
                ArrowBox4.BringToFront()
                MsgBox("Sir. Answer must be a whole number.")
                Exit Function
            End Try
            ArrowBox4.Visible = False
        End If
        eval = True
        Return eval
    End Function

    Sub EvaluateAnswer()
        'this sub evaluates the student answer after a successful evaluation of the text boxes
        Dim answer As Integer
        Dim useresponse As Integer
        If AddRadioButton.Checked = True Then
            answer = 20
            opStr = "+"
        ElseIf SubtractRadioButton.Checked = True Then
            answer = 0
            opStr = "-"
        ElseIf MultiplyRadioButton.Checked = True Then
            answer = 100
            opStr = "*"
        ElseIf DivideRadioButton.Checked = True Then
            answer = 1
            opStr = "/"
        End If
        useresponse = CInt(SATextBox.Text)
        If useresponse = answer Then
            MsgBox("That's the right answer! Good work!")
            correct = "Correct"
        Else
            MsgBox("That is the wrong answer.")
            correct = "Wrong"
        End If

    End Sub


    Public Sub SaveInfo()
        'this sub writes the textbox information to an array for later use
        infoArr(arraySizer) = $"Name: {NameTextBox.Text}, Age: {AgeTextBox.Text}, Grade: {GradeTextBox.Text}, Operation: {FNTextBox.Text}{opStr}{SNTextBox.Text}, Answer: {SATextBox.Text}, Correct?: {correct}{vbNewLine}"
        arraySizer += 1

    End Sub
    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        'This sub clears the next boxes and radio buttons
        NameTextBox.Clear()
        AgeTextBox.Clear()
        GradeTextBox.Clear()
        SATextBox.Clear()
        AddRadioButton.Checked = False
        SubtractRadioButton.Checked = False
        MultiplyRadioButton.Checked = False
        DivideRadioButton.Checked = False
    End Sub

    Public Sub SummaryButton_Click(sender As Object, e As EventArgs) Handles SummaryButton.Click
        'This sub writes the information in the info array to a text file, then opens the file for viewing.
        FileOpen(1, FileSystem.CurDir() & "\info.txt", OpenMode.Output)
        WriteLine(1, infoArr)
        FileClose(1)
        Process.Start(FileSystem.CurDir() & "\info.txt")
    End Sub

End Class
