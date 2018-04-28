Imports System.Data.SqlClient

Module Data
    Public QueryResults = New List(Of List(Of Object))
    Public Sub SqlQuery()
        Dim con As New SqlConnection
        Try
            con.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\EBEBDat.mdf;Integrated Security=True"
            Dim cmd As New SqlCommand("SELECT * FROM Questions", con)
            con.Open()
            'MessageBox.Show("Connection Opened
            'Execute Query
            Dim reader As SqlDataReader = cmd.ExecuteReader()
            While reader.Read()
                Dim rowLength = reader.FieldCount()
                Dim currentRow = New Object()
                reader.GetValues(currentRow)
                QueryResults.Add(currentRow.ToList())
            End While
        Catch ex As Exception
            MessageBox.Show("Error while connecting to SQL Server. " & ex.Message)
        End Try
    End Sub
End Module
