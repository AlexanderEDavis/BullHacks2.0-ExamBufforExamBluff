Public Class QuestionScreen
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblPassedName.Text = "Hello " + WelcomeScreen.playerName + "!"
        GetNextRecord(Data.QueryResults)
    End Sub
    Public Iterator Function GetNextRecord(ByVal results As List(Of List(Of Object))) As System.Collections.IEnumerable
        For Each record As List(Of Object) In results
            Yield (record)
        Next
    End Function

    'Private rnd As New Random()

    'Public Sub Shuffle(items As Object())
    '    Dim j As Int32
    '    Dim temp As String

    '    For n As Int32 = items.Length - 1 To 0 Step -1
    '        j = rnd.Next(0, n + 1)
    '        'Swap
    '        temp = items(n)
    '        items(n) = items(j)
    '        items(j) = temp
    '    Next n
    'End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click, Button5.Click, Button4.Click, Button3.Click, Button1.Click
        QuitDialog.Show()
    End Sub
End Class