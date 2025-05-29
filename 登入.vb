Imports MySql.Data.MySqlClient

Public Class 登入
    Dim connection As MySqlConnection
    Public Property C_ID As String
    Private isFromRegisterForm As Boolean ' 是否從註冊表單進入登錄表單

    Private Sub Back_Click(sender As Object, e As EventArgs) Handles Back.Click
        初始介面.Show() ' 顯示初始介面的表單
        Me.Close() ' 關閉當前表單
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim C_ID As String = TextBox2.Text ' 從  TextBox2取得編號
        Dim C_pd As String = TextBox1.Text ' 取得輸入的密碼

        ' 撰寫程式碼以檢查編號和密碼是否與資料庫中的資料匹配
        Dim connectionString As String = "server= 127.0.0.1;user=test;password=abc123;database=集貨樂章;"
        Dim query As String = "SELECT COUNT(*) FROM 顧客資料表 WHERE C_ID = @C_ID AND C_pd = @C_pd"
        Dim count As Integer = 0

        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@C_ID", C_ID)
                command.Parameters.AddWithValue("@C_pd", C_pd)
                Try
                    connection.Open()
                    count = Convert.ToInt32(command.ExecuteScalar())
                Catch ex As Exception
                End Try
            End Using
        End Using
        ' 如果編號和密碼匹配成功，則進入主畫面表單
        If count > 0 Then
            MsgBox("登入成功")
            Dim 主畫面Form As New 主畫面()
            主畫面.C_ID = C_ID
            '主畫面Form.SetLoggedInC_ID(C_ID)
            主畫面Form.ShowDialog()
            Me.Hide()
        Else
            Panel1.BackColor = Color.Red
            MsgBox("登入失敗")
        End If
    End Sub
    Private Sub 登入_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' 檢查是否從註冊表單進入登入表單
        If Not isFromRegisterForm Then
            '從初始介面進入，允許輸入顧客編號
            TextBox2.Enabled = True
        Else
            '從註冊表單進入，禁止輸入顧客編號
            TextBox2.Enabled = False
        End If
    End Sub
    Public Sub SetIsFromRegisterForm(fromRegisterForm As Boolean)
        isFromRegisterForm = fromRegisterForm
    End Sub
End Class