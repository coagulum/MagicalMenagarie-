Public Class Startpage

    Dim buttonCounter = 0

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Welcome.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        quiz.Show()
        Me.Hide()

    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs)
        fishEnter.Show()
        Me.Hide()
    End Sub
End Class
