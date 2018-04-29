Module QuestionLoad
    Public Sub NextQuestion()
        QuestionScreen.RoundNumber = QuestionScreen.RoundNumber + 1
        If QuestionScreen.RoundNumber = CSV.num_rows + 1 Then
            GameEndScreen.Show()
            QuestionScreen.Close()
        Else
            QuestionScreen.lblQuestion.Text = CSV.questionArray(RandomQuestions(QuestionScreen.RoundNumber), 0)
            QuestionScreen.btnAnswer1.Text = CSV.questionArray(RandomQuestions(QuestionScreen.RoundNumber), 1)
            QuestionScreen.btnAnswer2.Text = CSV.questionArray(RandomQuestions(QuestionScreen.RoundNumber), 2)
            QuestionScreen.btnAnswer3.Text = CSV.questionArray(RandomQuestions(QuestionScreen.RoundNumber), 3)
            QuestionScreen.btnAnswer4.Text = CSV.questionArray(RandomQuestions(QuestionScreen.RoundNumber), 4)
            QuestionScreen.CorrectAnswer = CSV.questionArray(RandomQuestions(QuestionScreen.RoundNumber), 5)
        End If
    End Sub

    Public Sub FirstQuestion()
        QuestionScreen.GameScore = 0
        QuestionScreen.lblQuestion.Text = CSV.questionArray(RandomQuestions(QuestionScreen.RoundNumber), 0)
        QuestionScreen.btnAnswer1.Text = CSV.questionArray(RandomQuestions(QuestionScreen.RoundNumber), 1)
        QuestionScreen.btnAnswer2.Text = CSV.questionArray(RandomQuestions(QuestionScreen.RoundNumber), 2)
        QuestionScreen.btnAnswer3.Text = CSV.questionArray(RandomQuestions(QuestionScreen.RoundNumber), 3)
        QuestionScreen.btnAnswer4.Text = CSV.questionArray(RandomQuestions(QuestionScreen.RoundNumber), 4)
        QuestionScreen.CorrectAnswer = CSV.questionArray(RandomQuestions(QuestionScreen.RoundNumber), 5)
    End Sub
End Module
