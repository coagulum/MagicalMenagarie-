Public Class flyCatching
    Dim randomSnake As Integer
    Dim snakeTime As Integer = 7
    Dim flyPoints As Integer
    Dim eggsLaid As Integer
    Private Sub flyPointer()
        If flyPoints = 5 Then
            btnLayEggs.Enabled = True
        End If
        If flyPoints = 10 Then
            btnLayEggs.Enabled = True
        End If
        If flyPoints = 15 Then
            btnLayEggs.Enabled = True
        End If
        If flyPoints > 20 Then
            btnLayEggs.Enabled = True
        End If
    End Sub
    Private Sub flyCatching_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel1.BackColor = Color.Transparent
        pbFly1.BackColor = Color.Transparent
        pbFly2.BackColor = Color.Transparent
        pbFly3.BackColor = Color.Transparent
        TableLayoutPanel1.BackColor = Color.Transparent
    End Sub

    Private Sub upTimer1_Tick(sender As Object, e As EventArgs) Handles upTimer1.Tick
        pbFly1.Top -= 20
        If pbFly1.Top <= 0 Then
            upTimer1.Enabled = False
            downTimer1.Enabled = True
        End If
    End Sub

    Private Sub downTimer1_Tick(sender As Object, e As EventArgs) Handles downTimer1.Tick
        pbFly1.Top += 20
        If pbFly1.Top >= Me.Height - 140 Then
            upTimer1.Enabled = True
            downTimer1.Enabled = False
        End If
    End Sub

    Private Sub leftTimer1_Tick(sender As Object, e As EventArgs) Handles leftTimer1.Tick
        pbFly2.Left -= 20
        pbFly3.Left -= 80
        If pbFly2.Left <= 0 Then
            leftTimer1.Enabled = False
            rightTimer1.Enabled = True
        End If
        If pbFly3.Left <= 0 Then
            leftTimer1.Enabled = False
            rightTimer1.Enabled = True
        End If
    End Sub

    Private Sub rightTimer1_Tick(sender As Object, e As EventArgs) Handles rightTimer1.Tick
        pbFly2.Left += 20
        pbFly3.Left += 80
        If pbFly2.Left >= Me.Width Then
            leftTimer1.Enabled = True
            rightTimer1.Enabled = False
        End If
        If pbFly3.Left >= Me.Width Then
            leftTimer1.Enabled = True
            rightTimer1.Enabled = False
        End If
    End Sub

    Private Sub pbFly1_Click(sender As Object, e As EventArgs) Handles pbFly1.Click
        lblPoints.Text = flyPoints
        flyPointer()
        flyPoints += 1
        pbFly1.Location = New Point(169, 239)
        Randomize()
        randomSnake = Int((Rnd() * 20) + 1)
        If randomSnake = 3 Then
            pbSnake.Visible = True
            Snake.Enabled = True
            btnRun.Enabled = True
        End If
    End Sub

    Private Sub pbFly2_Click(sender As Object, e As EventArgs) Handles pbFly2.Click
        lblPoints.Text = flyPoints
        flyPointer()
        flyPoints += 1
        pbFly2.Location = New Point(123, 123)
        Randomize()
        randomSnake = Int((Rnd() * 10) + 1)
        If randomSnake = 3 Then
            pbSnake.Visible = True
            Snake.Enabled = True
            btnRun.Enabled = True
        End If
    End Sub

    Private Sub pbFly3_Click(sender As Object, e As EventArgs) Handles pbFly3.Click
        lblPoints.Text = flyPoints
        flyPointer()
        flyPoints += 3
        pbFly3.Location = New Point(150, 320)
        Randomize()
        randomSnake = Int((Rnd() * 5) + 1)
        If randomSnake = 3 Then
            pbSnake.Visible = True
            Snake.Enabled = True
            btnRun.Enabled = True
        End If
    End Sub

    Private Sub Snake_Tick(sender As Object, e As EventArgs) Handles Snake.Tick
        If snakeTime >= 0 Then
            snakeTime -= 1
        Else
            froggerEnter.Show()
            Me.Hide()

        End If
    End Sub

    Private Sub btnLayEggs_Click(sender As Object, e As EventArgs) Handles btnLayEggs.Click
        eggsLaid += 1
        lblEggs.Text = eggsLaid
        btnLayEggs.Enabled = False
        If eggsLaid = 5 Then
            Startpage.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub btnRun_Click(sender As Object, e As EventArgs) Handles btnRun.Click
        Snake.Enabled = False
        snakeTime = 7
        pbSnake.Visible = False
        Frogger.Show()
        Me.Hide()
        Frogger.lblPoints.Text = flyPoints
        Frogger.Timer1.Enabled = True
    End Sub

    Private Sub TableLayoutPanel1_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel1.Paint

    End Sub
End Class