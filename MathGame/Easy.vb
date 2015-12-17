Public Class Easy
    'all the variables needed
    Dim RandomImage As Integer
    Dim Score As Integer


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        ' This one generates a random image in the form 
        Randomize()
        RandomImage = Int(7 * Rnd() + 0)
        If RandomImage = 0 Then
            PictureBox1.Image = ImageList1.Images(0)
        ElseIf RandomImage = 1 Then
            PictureBox1.Image = ImageList1.Images(1)
        ElseIf RandomImage = 2 Then
            PictureBox1.Image = ImageList1.Images(2)
        ElseIf RandomImage = 3 Then
            PictureBox1.Image = ImageList1.Images(3)
        ElseIf RandomImage = 4 Then
            PictureBox1.Image = ImageList1.Images(4)
        ElseIf RandomImage = 5 Then
            PictureBox1.Image = ImageList1.Images(5)
        Else
            PictureBox1.Image = ImageList1.Images(6)
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If RandomImage = 0 Then
            If RadioButton1.Checked = True Then
                MsgBox("Correct Answer")
                Label2.Text = Label2.Text + 1
            Else
                MsgBox("Incorrect Answer")
                Label2.Text = Label2.Text - 1
            End If
        ElseIf RandomImage = 1 Then
            If RadioButton2.Checked = True Then
                MsgBox("Correct Answer")
                Label2.Text = Label2.Text + 1
            Else
                MsgBox("Incorrect Answer")
                Label2.Text = Label2.Text - 1
            End If
        ElseIf RandomImage = 2 Then
            If RadioButton3.Checked = True Then
                MsgBox("Correct Answer")
                Label2.Text = Label2.Text + 1
            Else
                MsgBox("Incorrect Answer")
                Label2.Text = Label2.Text - 1

            End If
        ElseIf RandomImage = 3 Then
            If RadioButton4.Checked = True Then
                MsgBox("Correct Answer")
                Label2.Text = Label2.Text + 1
            Else
                MsgBox("Incorrect Answer")
                Label2.Text = Label2.Text - 1
            End If
        ElseIf RandomImage = 4 Then
            If RadioButton5.Checked = True Then
                MsgBox("Correct Answer")
                Label2.Text = Label2.Text + 1
            Else
                MsgBox("Incorrect Answer")
                Label2.Text = Label2.Text - 1
            End If
        ElseIf RandomImage = 5 Then
            If RadioButton6.Checked = True Then
                MsgBox("Correct Answer")
                Label2.Text = Label2.Text + 1
            Else
                MsgBox("Incorrect Answer")
                Label2.Text = Label2.Text - 1
            End If
        ElseIf RandomImage = 6 Then
            If RadioButton7.Checked = True Then
                MsgBox("Correct Answer")
                Label2.Text = Label2.Text + 1
            Else
                MsgBox("Incorrect Answer")
                Label2.Text = Label2.Text - 1
            End If
        End If

        If Label2.Text = 10 Then
            MsgBox("Congratulations, Go to the Next Level")
            End


        End If
    End Sub
End Class
