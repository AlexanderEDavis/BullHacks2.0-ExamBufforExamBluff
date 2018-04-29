Imports System.Windows.Forms

Public Class QuitDialog

    Private Sub btnEndGame_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEndGame.Click
        GameOverScreen.Show()
        QuestionScreen.Close()
        Me.Close()
    End Sub

    Private Sub btnResume_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnResume.Click
        Me.Close()
    End Sub
End Class
