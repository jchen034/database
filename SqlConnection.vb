Friend Class SqlConnection
    Private connectionString As String

    Public Sub New(connectionString As String)
        Me.connectionString = connectionString
    End Sub

    Friend Sub Open()
        Throw New NotImplementedException()
    End Sub
End Class
