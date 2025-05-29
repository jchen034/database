Public Class 新增訂單msgbox
    Private Sub 確認_Click(sender As Object, e As EventArgs) Handles 確認.Click
        Me.Close()
        Dim 訂單確認Form As New 訂單確認()
        訂單確認Form.Show()
    End Sub
    Private Sub X_Click(sender As Object, e As EventArgs) Handles X.Click
        Me.Close()
        Dim 訂單確認Form As New 訂單確認()
        訂單確認Form.Show()
    End Sub
End Class