Public Class Level
    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        Me.Hide()
        My.Forms.Easy.Show()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        My.Forms.Hard.Show()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        My.Forms.Form1.Show()
    End Sub
End Class