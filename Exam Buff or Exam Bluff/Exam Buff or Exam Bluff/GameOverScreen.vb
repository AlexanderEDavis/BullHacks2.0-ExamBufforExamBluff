Public Class GameOverScreen
    Private Sub btnNo_Click(sender As Object, e As EventArgs) Handles btnNo.Click
        Application.Exit()
    End Sub

    Private Sub btnYes_Click(sender As Object, e As EventArgs) Handles btnYes.Click
        QuestionScreen.Show()
        Me.Close()
    End Sub

    Private Sub GameOverScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblFinalScore.Text = "You scored " + QuestionScreen.GameScore.ToString + " out of " + (CSV.NumberofQuestions + 1).ToString
    End Sub
End Class