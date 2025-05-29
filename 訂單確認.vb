Public Class 訂單確認
    Private Sub 新增訂單_Click(sender As Object, e As EventArgs) Handles 新增訂單.Click
        Me.Hide()
        Dim 新增訂單Form As New 新增訂單()
        新增訂單Form.ShowDialog()
    End Sub

    Private Sub 查詢訂單_Click(sender As Object, e As EventArgs) Handles 查詢訂單.Click
        Me.Hide()
        Dim 查詢訂單Form As New 查詢訂單()
        查詢訂單Form.ShowDialog()
    End Sub

    Private Sub Back_Click(sender As Object, e As EventArgs) Handles Back.Click
        主畫面.Show() ' 顯示初始介面的表單
        Me.Hide() ' 隱藏當前表單
    End Sub
End Class