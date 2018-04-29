Public Class GameOverScreen
    Private Sub Cancel_Button_Click(sender As Object, e As EventArgs) Handles Cancel_Button.Click
        Application.Exit()
    End Sub

    Private Sub OK_Button_Click(sender As Object, e As EventArgs) Handles OK_Button.Click
        QuestionScreen.Show()
        Me.Close()
    End Sub

    Private Sub GameOverScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label2.Text = "You scored " + QuestionScreen.GameScore.ToString + " out of " + (CSV.num_rows + 1).ToString
    End Sub
End Class