Public Class dichotomousEnter
    Dim randomActivity As Integer
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        choose.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Randomize()
        randomActivity = Int((Rnd() * 3) + 1)
        If randomActivity = 1 Then
            DichotomousTabular.Show()
            Me.Hide()
        End If
        If randomActivity = 2 Then
            DicotomousFlowChart.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub TableLayoutPanel4_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel4.Paint

    End Sub
End Class