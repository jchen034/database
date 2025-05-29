Public Class 主畫面
    Private WithEvents 個人資料 As New Button()
    Public Shared Property C_ID As String ' 公共靜態屬性

    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Me.Hide()
        Dim 個人資料Form As New 個人資料()
        個人資料Form.SetC_ID(C_ID) ' 呼叫個人資料表單的 SetC_ID 方法設置 C_ID 值
        個人資料Form.LoadCustomerData() ' 載入顧客資料
        個人資料Form.ShowDialog()
    End Sub

    Private Sub 訂單確認_Click(sender As Object, e As EventArgs) Handles 訂單確認.Click
        Me.Hide()
        Dim 查詢訂單Form As New 查詢訂單()
        主畫面.C_ID = C_ID ' 將C_ID值指派給查詢訂單表單的CustomerID屬性
        ' 查詢訂單Form.Show()
        Dim 訂單確認Form As New 訂單確認()
        訂單確認Form.ShowDialog()

    End Sub

    Private Sub 物流追蹤_Click(sender As Object, e As EventArgs) Handles 物流追蹤.Click
        Me.Close()
        Dim 物流跳轉Form As New 物流跳轉()
        物流跳轉.ShowDialog()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles 付款確認.Click
        Me.Hide()
        Dim 付款確認Form As New 付款確認()
        付款確認Form.ShowDialog()
    End Sub
    Private Sub Back_Click(sender As Object, e As EventArgs) Handles Back.Click
        Me.Hide()
        Dim 初始介面Form As New 初始介面()
        初始介面Form.ShowDialog()
    End Sub
End Class