Public Class Form1

    Private Sub Label1_ParentChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Form1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If (e.KeyCode = System.Windows.Forms.Keys.Up) Then
            'Up
        End If
        If (e.KeyCode = System.Windows.Forms.Keys.Down) Then
            'Down
        End If
        If (e.KeyCode = System.Windows.Forms.Keys.Left) Then
            'Left
        End If
        If (e.KeyCode = System.Windows.Forms.Keys.Right) Then
            'Right
        End If
        If (e.KeyCode = System.Windows.Forms.Keys.Enter) Then
            'Enter
        End If

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Randomize()

        Dim number As Integer

        Const ROCK As Integer = 1
        Const PAPER As Integer = 2
        Const SCISSORS As Integer = 3

        number = (3 * Rnd())

        If RadioButton1.Checked And number = ROCK Then
            Label1.Text = "Computer chose ROCK. Draw!"
        ElseIf RadioButton1.Checked And number = PAPER Then
            Label1.Text = "Computer chose PAPER. Loss!"
        ElseIf RadioButton1.Checked And number = SCISSORS Then
            Label1.Text = "Computer chose SCISSORS. Win!!"

        ElseIf RadioButton2.Checked And number = ROCK Then
            Label1.Text = "Computer chose SCISSORS. Loss!"
        ElseIf RadioButton2.Checked And number = PAPER Then
            Label1.Text = "Computer chose ROCK. Win!"
        ElseIf RadioButton2.Checked And number = SCISSORS Then
            Label1.Text = "Computer chose PAPER. Draw!"

        ElseIf RadioButton3.Checked And number = ROCK Then
            Label1.Text = "Computer chose PAPER. Win!"
        ElseIf RadioButton3.Checked And number = PAPER Then
            Label1.Text = "Computer chose SCISSORS. Draw!"
        ElseIf RadioButton3.Checked And number = SCISSORS Then
            Label1.Text = "Computer chose ROCK. Loss!"


        End If
    End Sub

    Private Sub Label1_ParentChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.ParentChanged

    End Sub
End Class
