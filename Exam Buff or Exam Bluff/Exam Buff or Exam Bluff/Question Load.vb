Module QuestionLoad
    Public Sub NextQuestion()
        QuestionScreen.RoundNumber = QuestionScreen.RoundNumber + 1
        If QuestionScreen.RoundNumber = CSV.num_rows + 1 Then
            GameEndScreen.Show()
            QuestionScreen.Close()
        Else
<<<<<<< HEAD
            QuestionScreen.lblQuestion.Text = CSV.questionArray(RandomQuestions(QuestionScreen.RoundNumber), 0)
            QuestionScreen.btnAnswer1.Text = CSV.questionArray(RandomQuestions(QuestionScreen.RoundNumber), 1)
            QuestionScreen.btnAnswer2.Text = CSV.questionArray(RandomQuestions(QuestionScreen.RoundNumber), 2)
            QuestionScreen.btnAnswer3.Text = CSV.questionArray(RandomQuestions(QuestionScreen.RoundNumber), 3)
            QuestionScreen.btnAnswer4.Text = CSV.questionArray(RandomQuestions(QuestionScreen.RoundNumber), 4)
            QuestionScreen.CorrectAnswer = CSV.questionArray(RandomQuestions(QuestionScreen.RoundNumber), 5)
=======
            QuestionScreen.lblQuestion.Text = CSV.questionArray(RandomQuestions(QuestionScreen.x), 0)
            QuestionScreen.btnAnswer1.Text = CSV.questionArray(RandomQuestions(QuestionScreen.x), 1)
            QuestionScreen.btnAnswer2.Text = CSV.questionArray(RandomQuestions(QuestionScreen.x), 2)
            QuestionScreen.btnAnswer3.Text = CSV.questionArray(RandomQuestions(QuestionScreen.x), 3)
            QuestionScreen.btnAnswer4.Text = CSV.questionArray(RandomQuestions(QuestionScreen.x), 4)
            QuestionScreen.answer = CSV.questionArray(RandomQuestions(QuestionScreen.x), 5)
>>>>>>> 7daf0caab2e801a8c8c785173fdec1afabc0b25d
        End If
    End Sub

    Public Sub FirstQuestion()
        QuestionScreen.GameScore = 0
<<<<<<< HEAD
        QuestionScreen.lblQuestion.Text = CSV.questionArray(RandomQuestions(QuestionScreen.RoundNumber), 0)
        QuestionScreen.btnAnswer1.Text = CSV.questionArray(RandomQuestions(QuestionScreen.RoundNumber), 1)
        QuestionScreen.btnAnswer2.Text = CSV.questionArray(RandomQuestions(QuestionScreen.RoundNumber), 2)
        QuestionScreen.btnAnswer3.Text = CSV.questionArray(RandomQuestions(QuestionScreen.RoundNumber), 3)
        QuestionScreen.btnAnswer4.Text = CSV.questionArray(RandomQuestions(QuestionScreen.RoundNumber), 4)
        QuestionScreen.CorrectAnswer = CSV.questionArray(RandomQuestions(QuestionScreen.RoundNumber), 5)
=======
        QuestionScreen.lblQuestion.Text = CSV.questionArray(RandomQuestions(QuestionScreen.x), 0)
        QuestionScreen.btnAnswer1.Text = CSV.questionArray(RandomQuestions(QuestionScreen.x), 1)
        QuestionScreen.btnAnswer2.Text = CSV.questionArray(RandomQuestions(QuestionScreen.x), 2)
        QuestionScreen.btnAnswer3.Text = CSV.questionArray(RandomQuestions(QuestionScreen.x), 3)
        QuestionScreen.btnAnswer4.Text = CSV.questionArray(RandomQuestions(QuestionScreen.x), 4)
        QuestionScreen.answer = CSV.questionArray(RandomQuestions(QuestionScreen.x), 5)
>>>>>>> 7daf0caab2e801a8c8c785173fdec1afabc0b25d
    End Sub
End Module
