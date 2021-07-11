Public Class DichotomousTabular
    Dim buttonCounter As Integer
    Dim randomOrganism As Integer
    Dim answer As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCheck.Click
        Select Case buttonCounter
            Case 0
                buttonCounter += 1
                Randomize()
                randomOrganism = Int((Rnd() * 4) + 1)
                btnCheck.Text = "RANDOMISE"
            Case 1
                buttonCounter += 1
                ComboBox1.Visible = True
                btnCheck.Text = "GUESS"
                If randomOrganism = 1 Then
                    answer = "Cobra"
                    PictureBox1.Image = My.Resources.cobra
                End If
                If randomOrganism = 2 Then
                    answer = "Iguana"
                    PictureBox1.Visible = True
                    PictureBox1.Image = My.Resources.iguana
                End If
                If randomOrganism = 3 Then
                    answer = "Skink"
                    PictureBox1.Visible = True
                    PictureBox1.Image = My.Resources.skink
                End If
                If randomOrganism = 4 Then
                    answer = "Python"
                    PictureBox1.Visible = True
                    PictureBox1.Image = My.Resources.python
                End If
            Case 2
                If ComboBox1.Text.Trim.Length = 0 Then
                    Label1.Text = "choose an organism"
                Else
                    If ComboBox1.Text = answer Then
                        Label1.Text = "correct"
                        btnCheck.Text = "COME BACK"
                        buttonCounter += 1
                    Else
                        Label1.Text = "incorrect"
                    End If
                End If
            Case 3
                dichotomousEnter.Show()
                Me.Hide()
                PictureBox1.Image = My.Resources.question
                buttonCounter = 0
                ComboBox1.Text = ""
                Label1.Text = "Who am I?"
                ComboBox1.Visible = False
                btnCheck.Text = "PLAY"
        End Select
    End Sub

    Private Sub TableLayoutPanel2_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel2.Paint

    End Sub

    Private Sub TableLayoutPanel4_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel4.Paint

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub TableLayoutPanel3_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel3.Paint

    End Sub

    Private Sub TableLayoutPanel5_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel5.Paint

    End Sub

    Private Sub TableLayoutPanel1_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel1.Paint

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

    End Sub
End Class