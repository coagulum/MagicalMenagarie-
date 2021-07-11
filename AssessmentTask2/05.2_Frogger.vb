Public Class Frogger

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        pbSnake.Left += 3
        If (pbFrog.Bounds.IntersectsWith(pbSnake.Bounds)) Then
            Startpage.Show()
            Me.Close()
        End If
        If (pbFrog.Bounds.IntersectsWith(PictureBox1.Bounds)) Then
            Button2.Enabled = True
            Button1.Enabled = False
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        pbFrog.Left += 5
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Timer1.Enabled = False
        flyCatching.Show()
        Me.Hide()
        pbSnake.Location = New Point(3, 120)
        pbFrog.Location = New Point(205, 147)
        Button1.Enabled = True

    End Sub
End Class