Public Class QuestionScreen
    Public GameScore As Integer = 0
    Public RoundNumber As Integer = 0
    Public CorrectAnswer As Integer
    Private Sub QuestionScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Randomiser.Random()
        QuestionLoad.FirstQuestion()
        lblGameScore.Text = "Score: " + GameScore.ToString
    End Sub

    Private Sub btnEndGame_Click(sender As Object, e As EventArgs) Handles btnEndGame.Click
        QuitDialog.Show()
    End Sub

    Private Sub btnAnswer1_Click(sender As Object, e As EventArgs) Handles btnAnswer1.Click
        If btnAnswer1.Text = CSV.questionArray(RandomQuestions(RoundNumber), CorrectAnswer) Then
            GameScore = GameScore + 1
            lblGameScore.Text = "Score: " + GameScore.ToString
            MsgBox("Correct Answer!", MsgBoxStyle.Information, "Correct")
        Else
            MsgBox("Incorrect Answer!", MsgBoxStyle.Exclamation, "Incorrect")
        End If
        QuestionLoad.NextQuestion()
    End Sub

    Private Sub btnAnswer2_Click(sender As Object, e As EventArgs) Handles btnAnswer2.Click
        If btnAnswer2.Text = CSV.questionArray(RandomQuestions(RoundNumber), CorrectAnswer) Then
            GameScore = GameScore + 1
            lblGameScore.Text = "Score: " + GameScore.ToString
            MsgBox("Correct Answer!", MsgBoxStyle.Information, "Correct")
        Else
            MsgBox("Incorrect Answer!", MsgBoxStyle.Exclamation, "Incorrect")
        End If
        QuestionLoad.NextQuestion()
    End Sub

    Private Sub btnAnswer3_Click(sender As Object, e As EventArgs) Handles btnAnswer3.Click
        If btnAnswer3.Text = CSV.questionArray(RandomQuestions(RoundNumber), CorrectAnswer) Then
            GameScore = GameScore + 1
            lblGameScore.Text = "Score: " + GameScore.ToString
            MsgBox("Correct Answer!", MsgBoxStyle.Information, "Correct")
        Else
            MsgBox("Incorrect Answer!", MsgBoxStyle.Exclamation, "Incorrect")
        End If
        QuestionLoad.NextQuestion()
    End Sub

    Private Sub btnAnswer4_Click(sender As Object, e As EventArgs) Handles btnAnswer4.Click
        If btnAnswer4.Text = CSV.questionArray(RandomQuestions(RoundNumber), CorrectAnswer) Then
            GameScore = GameScore + 1
            lblGameScore.Text = "Score: " + GameScore.ToString
            MsgBox("Correct Answer!", MsgBoxStyle.Information, "Correct")
        Else
            MsgBox("Incorrect Answer!", MsgBoxStyle.Exclamation, "Incorrect")
        End If
        QuestionLoad.NextQuestion()
    End Sub
End Class