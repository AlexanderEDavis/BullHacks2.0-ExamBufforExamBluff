Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblPassedName.Text = "Hello " + Form1.playerName + "!"
    End Sub
End Class