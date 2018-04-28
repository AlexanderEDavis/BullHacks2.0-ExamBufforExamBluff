Public Class QuestionScreen
    Public GameScore As Integer = 0
    Public x As Integer = 0
    Public answer As Integer
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        QuestionLoad.FirstQuestion()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        QuitDialog.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Button1.Text = CSV.questionArray(x, answer) Then
            GameScore = GameScore + 1
            Label3.Text = "Score: " + GameScore.ToString
            MsgBox("Correct Answer!", MsgBoxStyle.Information, "Correct")
        Else
            MsgBox("Incorrect Answer!", MsgBoxStyle.Exclamation, "Incorrect")
        End If
        QuestionLoad.NextQuestion()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If Button3.Text = CSV.questionArray(x, answer) Then
            GameScore = GameScore + 1
            Label3.Text = "Score: " + GameScore.ToString
            MsgBox("Correct Answer!", MsgBoxStyle.Information, "Correct")
        Else
            MsgBox("Incorrect Answer!", MsgBoxStyle.Exclamation, "Incorrect")
        End If
        QuestionLoad.NextQuestion()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If Button5.Text = CSV.questionArray(x, answer) Then
            GameScore = GameScore + 1
            Label3.Text = "Score: " + GameScore.ToString
            MsgBox("Correct Answer!", MsgBoxStyle.Information, "Correct")
        Else
            MsgBox("Incorrect Answer!", MsgBoxStyle.Exclamation, "Incorrect")
        End If
        QuestionLoad.NextQuestion()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If Button4.Text = CSV.questionArray(x, answer) Then
            GameScore = GameScore + 1
            Label3.Text = "Score: " + GameScore.ToString
            MsgBox("Correct Answer!", MsgBoxStyle.Information, "Correct")
        Else
            MsgBox("Incorrect Answer!", MsgBoxStyle.Exclamation, "Incorrect")
        End If
        QuestionLoad.NextQuestion()
    End Sub
End Class