<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Numerator = New System.Windows.Forms.Label()
        Me.Denominator = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.AnsNum = New System.Windows.Forms.TextBox()
        Me.AnsDen = New System.Windows.Forms.TextBox()
        Me.Start = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Verdict = New System.Windows.Forms.Label()
        Me.Tally = New System.Windows.Forms.Label()
        Me.Answer = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(66, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(362, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Write the Equivalent Fraction"
        '
        'Numerator
        '
        Me.Numerator.AutoSize = True
        Me.Numerator.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Numerator.Location = New System.Drawing.Point(69, 92)
        Me.Numerator.Name = "Numerator"
        Me.Numerator.Size = New System.Drawing.Size(36, 25)
        Me.Numerator.TabIndex = 1
        Me.Numerator.Text = "00"
        '
        'Denominator
        '
        Me.Denominator.AutoSize = True
        Me.Denominator.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Denominator.Location = New System.Drawing.Point(69, 125)
        Me.Denominator.Name = "Denominator"
        Me.Denominator.Size = New System.Drawing.Size(36, 25)
        Me.Denominator.TabIndex = 2
        Me.Denominator.Text = "00"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(111, 106)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(24, 25)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "="
        '
        'AnsNum
        '
        Me.AnsNum.Location = New System.Drawing.Point(142, 92)
        Me.AnsNum.Name = "AnsNum"
        Me.AnsNum.Size = New System.Drawing.Size(31, 20)
        Me.AnsNum.TabIndex = 4
        '
        'AnsDen
        '
        Me.AnsDen.Location = New System.Drawing.Point(142, 130)
        Me.AnsDen.Name = "AnsDen"
        Me.AnsDen.Size = New System.Drawing.Size(31, 20)
        Me.AnsDen.TabIndex = 5
        '
        'Start
        '
        Me.Start.Location = New System.Drawing.Point(83, 178)
        Me.Start.Name = "Start"
        Me.Start.Size = New System.Drawing.Size(75, 23)
        Me.Start.TabIndex = 6
        Me.Start.Text = "Start"
        Me.Start.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(0, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Label3"
        '
        'Verdict
        '
        Me.Verdict.AutoSize = True
        Me.Verdict.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Verdict.Location = New System.Drawing.Point(99, 245)
        Me.Verdict.Name = "Verdict"
        Me.Verdict.Size = New System.Drawing.Size(36, 25)
        Me.Verdict.TabIndex = 8
        Me.Verdict.Text = "00"
        '
        'Tally
        '
        Me.Tally.AutoSize = True
        Me.Tally.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tally.Location = New System.Drawing.Point(33, 319)
        Me.Tally.Name = "Tally"
        Me.Tally.Size = New System.Drawing.Size(36, 25)
        Me.Tally.TabIndex = 9
        Me.Tally.Text = "00"
        '
        'Answer
        '
        Me.Answer.Location = New System.Drawing.Point(83, 207)
        Me.Answer.Name = "Answer"
        Me.Answer.Size = New System.Drawing.Size(75, 23)
        Me.Answer.TabIndex = 10
        Me.Answer.Text = "Answer"
        Me.Answer.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(67, 100)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 25)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "___"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(137, 100)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 25)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "___"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(21, 330)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 25)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "___"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(33, 355)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(36, 25)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "00"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSkyBlue
        Me.ClientSize = New System.Drawing.Size(514, 418)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Numerator)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Answer)
        Me.Controls.Add(Me.Tally)
        Me.Controls.Add(Me.Verdict)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Start)
        Me.Controls.Add(Me.AnsDen)
        Me.Controls.Add(Me.AnsNum)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Denominator)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Numerator As Label
    Friend WithEvents Denominator As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents AnsNum As TextBox
    Friend WithEvents AnsDen As TextBox
    Friend WithEvents Start As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Verdict As Label
    Friend WithEvents Tally As Label
    Friend WithEvents Answer As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
End Class
