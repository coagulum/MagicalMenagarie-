Public Class Fish
    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked Then
            RadioButton3.Visible = True
            RadioButton4.Visible = True
            RadioButton5.Visible = True
            RadioButton6.Visible = True
        Else
            RadioButton3.Visible = False
            RadioButton4.Visible = False
            RadioButton5.Visible = False
            RadioButton6.Visible = False
        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked Then
            PictureBox1.Image = My.Resources.fishOpen
            RadioButton7.Visible = True
            RadioButton8.Visible = True
            RadioButton9.Visible = True
            RadioButton11.Visible = True
            RadioButton12.Visible = True
            RadioButton10.Visible = True
            RadioButton13.Visible = True
            RadioButton1.Visible = False
        Else
            RadioButton7.Visible = False
            RadioButton8.Visible = False
            RadioButton9.Visible = False
            RadioButton10.Visible = False
        End If
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        PictureBox1.Image = My.Resources.fishBelly
        MessageBox.Show("The lateral line functions to detect vibrations and water movement and allows fish to orientate themselves in a water current")
    End Sub
    Private Sub RadioButton8_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton8.CheckedChanged
        PictureBox1.Image = My.Resources.fishHeart
        MessageBox.Show("Fish have a single systemic circuit for blood, where the heart pumps the blood to the gills to be re-oxygenated, after which the blood flows to the rest of the body and back to the heart.")
    End Sub

    Private Sub RadioButton9_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton9.CheckedChanged
        PictureBox1.Image = My.Resources.fishVertebrae
        MessageBox.Show("The main purpose of a backbone and a skeleton for that matter is to support and protect vital organs, muscles and other body parts of the fish. ")
    End Sub

    Private Sub RadioButton12_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton12.CheckedChanged
        PictureBox1.Image = My.Resources.fishSwimBladder
        MessageBox.Show("The swim bladder, gas bladder, fish maw, or air bladder is an internal gas-filled organ that contributes to the ability of many bony fish to control their buoyancy.")
    End Sub

    Private Sub RadioButton7_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton7.CheckedChanged
        PictureBox1.Image = My.Resources.fishStomach
        MessageBox.Show("In carnivorous fish, the stomach is muscular and elastic for holding large prey items, while in omnivorous fish the stomach, if present at all, is small because a more or less constant stream of small food particles can flow directly into the intestine.")
    End Sub

    Private Sub RadioButton13_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton13.CheckedChanged
        PictureBox1.Image = My.Resources.fishRibs
        MessageBox.Show("The ribs help to protect the internal organs that they enclose and lend support to the trunk musculature.")
    End Sub

    Private Sub RadioButton11_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton11.CheckedChanged
        PictureBox1.Image = My.Resources.fishGills
        MessageBox.Show("Fish gills are organs that allow fish to breathe underwater.")
    End Sub

    Private Sub RadioButton10_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton10.CheckedChanged
        PictureBox1.Image = My.Resources.fishAnus
        MessageBox.Show("The Anus’ function is to absorb water from the remaining indigestible food matter, and then to pass useless waste material from the body.")
    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        PictureBox1.Image = My.Resources.fishFins
        MessageBox.Show("Fins are appendages used by the fish to maintain its position, move, steer and stop.")
    End Sub

    Private Sub RadioButton5_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton5.CheckedChanged
        PictureBox1.Image = My.Resources.fishMouth
        MessageBox.Show("While fishes use their mouths to feed, they also use their mouths to do things that many animals do with their paws, feet or claws, such as grabbing, carrying, protecting young, nest building and more.")
    End Sub

    Private Sub RadioButton6_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton6.CheckedChanged
        PictureBox1.Image = My.Resources.fishEyes
        MessageBox.Show("Eyes are used to see the fishes surroundings and assist with basic survival needs")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        fishEnter.Show()
        Me.Hide()
    End Sub
End Class