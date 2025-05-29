Public Class 初始介面

    Private WithEvents 登入 As New Button()
    Private WithEvents 註冊 As New Button()

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim 登入Form As New 登入()
        登入Form.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Dim 註冊Form As New 註冊()
        註冊Form.ShowDialog()
    End Sub
End Class
