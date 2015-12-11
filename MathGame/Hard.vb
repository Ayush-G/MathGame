Public Class Hard
    Dim rng1, rng2, rng3, rng4, rng5 As Integer
    Dim sec1 As Long
    Dim sec2 As Long

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        My.Forms.Calc.Show()
    End Sub

    Dim shtAns1, shtAns2, shtAns3 As Short
    Dim rngOp1, rngOp2, rngOp3 As Integer

    Private Sub Hard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Randomize()
        rng1 = CInt(Int(9 * Rnd()) + 1)
        rng2 = CInt(Int(9 * Rnd()) + 1)
        rng3 = CInt(Int(9 * Rnd()) + 1)
        rng4 = CInt(Int(9 * Rnd()) + 1)
        rng5 = CInt(Int(9 * Rnd()) + 1)
        rngOp1 = CInt(Int(4 * Rnd()) + 1)
        rngOp2 = CInt(Int(4 * Rnd()) + 1)
        rngOp3 = CInt(Int(4 * Rnd()) + 1)

        If rngOp1 = 1 Then
            lblOp1.Text = "+"
        ElseIf rngOp1 = 2
            lblOp1.Text = "-"
        ElseIf rngOp1 = 3
            lblOp1.Text = "x"
        ElseIf rngOp1 = 4
            lblOp1.Text = "÷"
        End If

        If rngOp2 = 1 Then
            lblOp2.Text = "+"
        ElseIf rngOp2 = 2
            lblOp2.Text = "-"
        ElseIf rngOp2 = 3
            lblOp2.Text = "x"
        ElseIf rngOp2 = 4
            lblOp2.Text = "÷"
        End If

        If rngOp3 = 1 Then
            lblOp3.Text = "+"
        ElseIf rngOp3 = 2
            lblOp1.Text = "-"
        ElseIf rngOp3 = 3
            lblOp1.Text = "x"
        ElseIf rngOp3 = 4
            lblOp1.Text = "÷"
        End If

        Num1.Text = rng1
        Num2.Text = rng2
        Num3.Text = rng3
        Num4.Text = rng4
        Num5.Text = rng5
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Solve
        If lblOp1.Text = "+" Then
            shtAns1 = rng1 + rng2
        ElseIf lblOp1.Text = "-" Then
            shtAns1 = rng1 - rng2
        ElseIf lblOp1.Text = "*" Then
            shtAns1 = rng1 * rng2
        ElseIf lblOp1.Text = "÷" Then
            shtAns1 = rng1 / rng2
        End If

        If lblOp2.Text = "+" Then
            shtAns2 = rng4 + rng5
        ElseIf lblOp2.Text = "-" Then
            shtAns2 = rng4 - rng5
        ElseIf lblOp2.Text = "*" Then
            shtAns2 = rng4 * rng5
        ElseIf lblOp2.Text = "÷" Then
            shtAns2 = rng4 / rng5
        End If

        shtAns2 = shtAns2 * rng3

        If lblOp3.Text = "+" Then
            shtAns3 = shtAns1 + shtAns2
        ElseIf lblOp3.Text = "-" Then
            shtAns3 = shtAns1 - shtAns2
        ElseIf lblOp3.Text = "*" Then
            shtAns3 = shtAns1 * shtAns2
        ElseIf lblOp3.Text = "÷" Then
            shtAns3 = shtAns1 / shtAns2
        End If
        Label4.Text = shtAns3
        'Check 
        If IsNumeric(txtAnswer.Text) Then
            If txtAnswer.Text = shtAns3 Then
                MsgBox("Correct!")
            Else
                MsgBox("Incorrect")
            End If
        Else
            txtAnswer.Text = ""
        End If
        'Regen Problem
        rng1 = CInt(Int(9 * Rnd()) + 1)
        rng2 = CInt(Int(9 * Rnd()) + 1)
        rng3 = CInt(Int(9 * Rnd()) + 1)
        rng4 = CInt(Int(9 * Rnd()) + 1)
        rng5 = CInt(Int(9 * Rnd()) + 1)
        rngOp1 = CInt(Int(4 * Rnd()) + 1)
        rngOp2 = CInt(Int(4 * Rnd()) + 1)
        rngOp3 = CInt(Int(4 * Rnd()) + 1)

        If rngOp1 = 1 Then
            lblOp1.Text = "+"
        ElseIf rngOp1 = 2
            lblOp1.Text = "-"
        ElseIf rngOp1 = 3
            lblOp1.Text = "x"
        ElseIf rngOp1 = 4
            lblOp1.Text = "÷"
        End If

        If rngOp1 = 1 Then
            lblOp2.Text = "+"
        ElseIf rngOp1 = 2
            lblOp2.Text = "-"
        ElseIf rngOp1 = 3
            lblOp2.Text = "x"
        ElseIf rngOp1 = 4
            lblOp2.Text = "÷"
        End If

        If rngOp3 = 1 Then
            lblOp3.Text = "+"
        ElseIf rngOp3 = 2
            lblOp1.Text = "-"
        ElseIf rngOp3 = 3
            lblOp1.Text = "x"
        ElseIf rngOp3 = 4
            lblOp1.Text = "÷"
        End If

        Num1.Text = rng1
        Num2.Text = rng2
        Num3.Text = rng3
        Num4.Text = rng4
        Num5.Text = rng5
    End Sub



End Class