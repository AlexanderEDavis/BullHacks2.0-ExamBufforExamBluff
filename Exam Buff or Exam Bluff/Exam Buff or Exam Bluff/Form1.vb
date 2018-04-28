Public Class Form1
    Public playerName As String
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        playerName = ""
    End Sub

    Private Sub btnNameConfirm_Click(sender As Object, e As EventArgs) Handles btnNameConfirm.Click

        playerName = txtNameEntry.Text
        Form2.Show()
        Me.Close()
    End Sub
End Class
