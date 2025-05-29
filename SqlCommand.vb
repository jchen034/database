Friend Class SqlCommand
    Private query As String
    Private connection As SqlConnection

    Public Sub New(query As String, connection As SqlConnection)
        Me.query = query
        Me.connection = connection
    End Sub
End Class
