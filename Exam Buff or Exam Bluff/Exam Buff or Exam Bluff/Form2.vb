Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblPassedName.Text = "Hello " + Form1.playerName + "!"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click, Button5.Click, Button4.Click, Button3.Click, Button1.Click
        Dialog1.Show()
    End Sub
End Class