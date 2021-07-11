Public Class quiz2
    Dim questions(3, 4) As String
    Dim answers(6) As String
    Dim quesNum As Integer
    Dim quizDone As Boolean = False

    Private Sub GetQuestions()
        questions = New String(,) {
{"What is an ecosystem?", "A biological community of interacting organisms and their physical environment.", "A large naturally occurring community of flora and fauna occupying a major habitat", "A series of organisms each dependent on the next as a source of food", "A biological community of interacting organisms and their physical environment"},
{"What is a scientist who studies ecology called??", "Anatomist", "Ecologist", "Biochemist", "Ecologist"},
{"All the living organisms in an ecosystem are called what?", "Environment", "Community", "Parasitism", "Community"},
{"What is an ecosystem?", "A biological community of interacting organisms and their physical environment.", "A large naturally occurring community of flora and fauna occupying a major habitat", "A series of organisms each dependent on the next as a source of food", "A biological community of interacting organisms and their physical environment"},
{"What is a scientist who studies ecology called??", "Anatomist", "Ecologist", "Biochemist", "Ecologist"},
{"All the living organisms in an ecosystem are called what?", "Environment", "Community", "Parasitism", "Community"}}

    End Sub
    Private Sub MarkTest()
        Dim grade As Integer = 0
        For i = 0 To 2
            If answers(i) = questions(i, 4) Then
                grade += 1
            End If
        Next
        Label1.Text = "Test finished!"
        Label2.Text = "You scored " & grade & " out of " & answers.Length & "!"
        RadioButton1.Enabled = False
        RadioButton2.Enabled = False
        RadioButton3.Enabled = False
        Button1.Visible = False
        Button2.Enabled = True
        Button2.Text = "COME BACK"
        quizDone = True
    End Sub

    Private Sub quiz_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "My Multiple Choice Quiz!"
        GetQuestions()
        quesNum = 1
        Label1.Text = "Question " & quesNum & " of " & answers.Length
        Label2.Text = questions(0, 0)
        Button2.Text = "Next"
        Button1.Text = "Previous"
        RadioButton1.Text = questions(0, 1)
        RadioButton2.Text = questions(0, 2)
        RadioButton3.Text = questions(0, 3)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If quizDone = True Then
            quizEnter.Show()
            Me.Hide()
            RadioButton1.Checked = False
            RadioButton2.Checked = False
            RadioButton3.Checked = False
            RadioButton1.Enabled = True
            RadioButton2.Enabled = True
            RadioButton3.Enabled = True
            Button2.Text = "NEXT"
            Button1.Enabled = True
            Button1.Visible = True
            quizDone = False
            quesNum -= 5
        End If
        If RadioButton1.Checked = True Then
            answers(quesNum - 1) = RadioButton1.Text
        ElseIf RadioButton2.Checked = True Then
            answers(quesNum - 1) = RadioButton2.Text
        ElseIf RadioButton3.Checked = True Then
            answers(quesNum - 1) = RadioButton3.Text
        End If
        RadioButton1.Focus()
        If quesNum < 6 Then
            quesNum += 1
            Label1.Text = "Question " & quesNum & " of " & answers.Length
            Label2.Text = questions(quesNum - 1, 0)
            RadioButton1.Text = questions(quesNum - 1, 1)
            RadioButton2.Text = questions(quesNum - 1, 2)
            RadioButton3.Text = questions(quesNum - 1, 3)
            If quesNum = 6 Then
                Button2.Text = "Submit"
                MarkTest()
            Else
            End If
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If quesNum > 1 Then
            quesNum -= 1
            Label1.Text = "Question " & quesNum & " of 15"
            Label2.Text = questions(quesNum - 1, 0)
            RadioButton1.Text = questions(quesNum - 1, 1)
            RadioButton2.Text = questions(quesNum - 1, 2)
            RadioButton3.Text = questions(quesNum - 1, 3)

            If Button2.Text = "Submit" Then
                Button2.Text = "Next"
            End If
        End If
    End Sub
End Class