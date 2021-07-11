Public Class Welcome
    Dim username As String
    Dim buttonCounter As Integer
    Private Sub TextBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbName.Click
        tbName.Clear()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Select Case buttonCounter
            Case 0
                buttonCounter += 1
                Label1.Visible = False
                lblName.Visible = True
                tbName.Visible = True
            Case 1
                If tbName.Text.Trim.Length = 0 Or tbName.Text = "Enter name" Then
                    Label1.Visible = True
                    Label1.Text = "please enter your name!"
                Else
                    If tbName.Text.Length > 15 Then
                        Label1.Text = "Your name is too long"
                    Else
                        username = tbName.Text
                        tbName.Visible = False
                        Label1.Text = "Hello " + username + ", follow me to see the islands!"
                        Label1.Visible = True
                        Button1.Text = "follow"
                        lblName.Visible = False
                        buttonCounter += 1
                    End If
                End If
            Case 2
                choose.Show()
                Me.Hide()
        End Select
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class