Public Class WelcomeScreen
    Public playerName As String
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CSV.ReadCSVFileToArray()
        playerName = ""
    End Sub

    Private Sub btnNameConfirm_Click(sender As Object, e As EventArgs) Handles btnNameConfirm.Click
        playerName = txtNameEntry.Text
        MsgBox("Hello " + playerName + "!" + vbCrLf& + "This quiz will help you find out whether you're ready for your exams or whether a bit more practice is needed." + vbCrLf& + vbCrLf& + "Good luck!")
        QuestionScreen.Show()
        Me.Close()
    End Sub
End Class
