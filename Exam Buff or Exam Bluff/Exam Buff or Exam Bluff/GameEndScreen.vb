Public Class GameEndScreen
    Private Sub btnNo_Click(sender As Object, e As EventArgs) Handles btnNo.Click
        Application.Exit()
    End Sub

    Private Sub btnYes_Click(sender As Object, e As EventArgs) Handles btnYes.Click
        QuestionScreen.Show()
        Me.Close()
    End Sub

    Private Sub GameEndScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblFinalScore.Text = "You scored " + QuestionScreen.GameScore.ToString + " out of " + (CSV.num_rows + 1).ToString
    End Sub
End Class