Imports System.IO

Module CSV
    Public num_cols As Long
    Public num_rows As Long
    Public questionArray(1, 1) As String

    Public Sub ReadCSVFileToArray()
        Dim strfilename As String
        Dim x As Integer
        Dim y As Integer

        ' Load the file.
        strfilename = "../../Questions.csv"

        'Check if file exist
        If File.Exists(strfilename) Then
            Dim tmpstream As StreamReader = File.OpenText(strfilename)
            Dim strlines() As String
            Dim strline() As String

            strlines = tmpstream.ReadToEnd().Split(Environment.NewLine)

            ' Redimension the array.
            num_rows = UBound(strlines)
            strline = strlines(0).Split(",")
            num_cols = UBound(strline)
            ReDim questionArray(num_rows, num_cols)

            ' Copy the data into the array.
            For x = 0 To num_rows
                strline = strlines(x).Split(",")
                For y = 0 To num_cols
                    questionArray(x, y) = strline(y)
                Next
            Next
        End If
    End Sub
End Module
