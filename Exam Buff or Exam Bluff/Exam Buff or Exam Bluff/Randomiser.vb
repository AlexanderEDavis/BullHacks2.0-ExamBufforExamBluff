Module Randomiser
    Private rand As New Random()
    Public Function Shuffle(Of T)(ByVal items As IList(Of T)) As IList(Of T)
        For i As Integer = items.Count - 1 To 1 Step -1
            Dim j As Integer = rand.Next(i + 1)
            Dim temp As T = items(i)
            items(i) = items(j)
            items(j) = temp
        Next
        Return items
    End Function

    Public RandomQuestions As Array
    Public Sub Random()
        RandomQuestions = Shuffle(Enumerable.Range(0, (CSV.NumberofQuestions + 1)).ToArray())
    End Sub
End Module
