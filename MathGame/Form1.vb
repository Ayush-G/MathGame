Public Class Form1
    Dim Num As Short
    Dim Den As Short
    Dim TallyNum As Short
    Private Sub Answer_Click(sender As Object, e As EventArgs) Handles Start.Click
        If Num / Den = AnsNum.Text / AnsDen.Text Then
            Verdict.Text = "Correct"
            TallyNum = TallyNum + 1
        Else : Verdict.Text = "Incorrect"
        End If
        Num = Int(15 * Rnd() + 1)
        Den = Int((15 - Num) * Rnd() + Num)
        Numerator.Text = Num
        Denominator.Text = Den
        Tally.Text = TallyNum
        AnsNum.Text = ""
        AnsDen.Text = ""
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Randomize()

    End Sub

    Private Sub Start_Click(sender As Object, e As EventArgs) Handles Start.Click
        Num = Int(15 * Rnd() + 1)
        Den = Int((15 - Num) * Rnd() + Num)
        Numerator.Text = Num
        Denominator.Text = Den
        Start.Hide()

    End Sub
End Class