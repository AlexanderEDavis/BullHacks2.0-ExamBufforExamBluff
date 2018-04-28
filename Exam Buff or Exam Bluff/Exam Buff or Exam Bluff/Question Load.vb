Module QuestionLoad
    Public Sub NextQuestion()
        QuestionScreen.x = QuestionScreen.x + 1
        If QuestionScreen.x = CSV.num_rows + 1 Then
            GameEndScreen.Show()
            QuestionScreen.Close()
        Else
            QuestionScreen.Label2.Text = CSV.questionArray(QuestionScreen.x, 0)
            QuestionScreen.Button1.Text = CSV.questionArray(QuestionScreen.x, 1)
            QuestionScreen.Button3.Text = CSV.questionArray(QuestionScreen.x, 2)
            QuestionScreen.Button5.Text = CSV.questionArray(QuestionScreen.x, 3)
            QuestionScreen.Button4.Text = CSV.questionArray(QuestionScreen.x, 4)
            QuestionScreen.answer = CSV.questionArray(QuestionScreen.x, 5)
        End If
    End Sub

    Public Sub FirstQuestion()
        QuestionScreen.Label2.Text = CSV.questionArray(QuestionScreen.x, 0)
        QuestionScreen.Button1.Text = CSV.questionArray(QuestionScreen.x, 1)
        QuestionScreen.Button3.Text = CSV.questionArray(QuestionScreen.x, 2)
        QuestionScreen.Button5.Text = CSV.questionArray(QuestionScreen.x, 3)
        QuestionScreen.Button4.Text = CSV.questionArray(QuestionScreen.x, 4)
        QuestionScreen.answer = CSV.questionArray(QuestionScreen.x, 5)
    End Sub
End Module
