Imports System.Text.RegularExpressions
Imports MySql.Data.MySqlClient

Public Class 註冊
    Inherits Form
    Dim connection As MySqlConnection
    Public C_ID As String

    Private Sub Back_Click_1(sender As Object, e As EventArgs) Handles Back.Click
        初始介面.Show() ' 顯示初始介面的表單
        Me.Close() ' 關閉當前表單
    End Sub

    Private Sub 顧客姓名_TextChanged(sender As Object, e As EventArgs) Handles 顧客姓名.TextChanged
        Dim 姓名 As String = 顧客姓名.Text

        ' 姓名格式驗證的正則表達式
        Dim pattern As String = "^[\u4E00-\u9FFF]{3,4}$"

        ' 驗證姓名格式，必須是3~4個字的中文名字
        If Regex.IsMatch(姓名, pattern) Then
            ' 格式正確，設定 Panel 的背景色為綠色
            Panel1.BackColor = Color.Green
        Else
            ' 格式錯誤，設定 Panel 的背景色為紅色
            Panel1.BackColor = Color.Red
        End If
    End Sub

    Private Sub 手機號碼_TextChanged(sender As Object, e As EventArgs) Handles 手機號碼.TextChanged
        Dim phoneNumber As String = 手機號碼.Text

        ' 驗證手機號碼格式，必須是台灣手機號碼的格式
        If IsPhoneNumberValid(phoneNumber) Then
            ' 手機號碼格式正確，將 Panel2的邊框顏色設為綠色
            Panel2.BackColor = Color.Green
        Else
            ' 手機號碼格式不正確，將 Panel2的邊框顏色設為紅色
            Panel2.BackColor = Color.Red
        End If
    End Sub

    Private Function IsPhoneNumberValid(phoneNumber As String) As Boolean
        Dim pattern As String = "^(09)\d{8}$"
        Dim regex As New Regex(pattern)
        Dim match As Match = regex.Match(phoneNumber)

        Return match.Success
    End Function

    Private Sub 密碼_TextChanged(sender As Object, e As EventArgs) Handles 密碼.TextChanged
        ' 密碼是否介於6~12，否則將Panel5的邊框顏色設為紅色
        If 密碼.Text.Length < 6 OrElse 密碼.Text.Length > 12 Then
            Panel5.BackColor = Color.Red
            Exit Sub
        End If

        ' 檢查密碼是否包含英文字母和數字
        Dim hasLetter As Boolean = False
        Dim hasDigit As Boolean = False
        Dim hasChinese As Boolean = False
        Dim hasSymbol As Boolean = False

        For Each c As Char In 密碼.Text
            If Char.IsLetter(c) Then
                hasLetter = True
            ElseIf Char.IsDigit(c) Then
                hasDigit = True
            ElseIf c >= ChrW(&H4E00) AndAlso c <= ChrW(&H9FFF) Then ' 判斷是否為中文字元
                hasChinese = True
            ElseIf Not Char.IsLetterOrDigit(c) Then ' 判斷是否為符號
                hasSymbol = True
                Exit For ' 如果包含符號，則直接跳出迴圈，不再進行後續判斷
            End If
        Next

        If hasLetter AndAlso hasDigit AndAlso Not hasChinese AndAlso Not hasSymbol Then
            Panel5.BackColor = Color.Green
        End If

        ' 檢查是否已輸入密碼
        If (Panel5.BackColor = Color.Red) Then
            確認密碼.Enabled = False
        Else
            確認密碼.Enabled = True
        End If
        If 密碼.Text = 確認密碼.Text AndAlso Not String.IsNullOrEmpty(確認密碼.Text) Then
            Panel3.BackColor = Color.Green
        Else
            Panel3.BackColor = Color.Red
        End If

    End Sub

    Private Sub 確認密碼_TextChanged(sender As Object, e As EventArgs) Handles 確認密碼.TextChanged
        ' 檢查是否和密碼輸入相同且密碼不為空
        If 確認密碼.Text = 密碼.Text AndAlso Not String.IsNullOrEmpty(密碼.Text) Then
            Panel3.BackColor = Color.Green
        Else
            Panel3.BackColor = Color.Red
        End If
        ' 將確認密碼文字方塊的密碼字元設定為米字號
        確認密碼.PasswordChar = "*"
    End Sub

    Private Sub 收貨地址_TextChanged(sender As Object, e As EventArgs) Handles 收貨地址.TextChanged
        ' 檢查地址是否為台灣地址
        Dim address As String = 收貨地址.Text
        Dim isValidTaiwanAddress As Boolean = IsTaiwanAddress(address)

        ' 根據檢查結果設定相應的處理邏輯
        If isValidTaiwanAddress Then
            Panel4.BackColor = Color.Green
        Else
            Panel4.BackColor = Color.Red
        End If
    End Sub

    Private Function IsTaiwanAddress(address As String) As Boolean
        ' 檢查地址是否為台灣地址的邏輯
        ' 假設檢查邏輯為判斷地址中是否包含中文字符且不包含英文字母
        Dim hasChineseCharacter As Boolean = False
        Dim hasEnglishCharacter As Boolean = False

        For Each c As Char In address
            If c >= ChrW(&H4E00) AndAlso c <= ChrW(&H9FFF) Then ' 判斷是否為中文字元
                hasChineseCharacter = True
            ElseIf Char.IsLetter(c) Then ' 判斷是否為英文字母
                hasEnglishCharacter = True
            End If
        Next
        Return hasChineseCharacter AndAlso Not hasEnglishCharacter
    End Function

    Private Sub 註冊_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PictureBox2.BackColor = Color.FromArgb(240, 243, 251)
        Dim connectionString As String = "server= 127.0.0.1;user=test;password=abc123;database=集貨樂章;"
        connection = New MySqlConnection(connectionString)
    End Sub

    Private Sub 創建帳戶_Click(sender As Object, e As EventArgs) Handles 創建帳戶.Click
        If (Panel1.BackColor = Color.Green And Panel2.BackColor = Color.Green And Panel3.BackColor = Color.Green And Panel4.BackColor = Color.Green And Panel5.BackColor = Color.Green) Then
            Dim C_name As String = 顧客姓名.Text
            Dim C_pd As String = 密碼.Text
            Dim C_phone As String = 手機號碼.Text
            Dim C_Address As String = 收貨地址.Text
            Dim query As String = "INSERT INTO 顧客資料表(C_ID,C_name, C_pd,C_phone, C_Address) VALUES (@C_ID,@C_name,@C_pd,@C_phone,@C_Address)"

            Try
                ' 產生隨機編號
                Dim random As New Random()
                Dim firstChar As Char = Chr(random.Next(Asc("A"), Asc("Z") + 1)) ' 隨機產生 A 到 Z 之間的字母
                Dim digits As String = random.Next(1000, 9999).ToString() ' 隨機產生 4 位數字
                Dim C_ID As String = $"{firstChar}{digits}"
                ' 嘗試連接資料庫並插入資料
                connection.Open()

                Dim command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@C_ID", C_ID)
                command.Parameters.AddWithValue("@C_name", C_name)
                command.Parameters.AddWithValue("@C_pd", C_pd)
                command.Parameters.AddWithValue("@C_phone", C_phone)
                command.Parameters.AddWithValue("@C_Address", C_Address)
                command.ExecuteNonQuery()
                connection.Close()

                MsgBox("註冊成功")
                Me.Hide()
                Dim 登入Form As New 登入()
                登入Form.TextBox2.Text = C_ID ' 將編號顯示在登入表單的 TextBox2 上
                登入.TextBox2.ReadOnly = True ' 設置TextBox2 只能讀
                Dim 個人資料Form As New 個人資料()
                個人資料Form.Label1.Text = C_ID ' 將 C_ID 的值設定為個人資料表單的屬性
                登入Form.ShowDialog()
                登入.Enabled = True
            Catch ex As Exception
                connection.Close()
            End Try
        Else
            MsgBox("註冊失敗")
        End If
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        MsgBox("     顧客姓名:3~4個中文字        
     手機號碼:09開頭的      
     密碼:6~12個英文(不限大小寫)+數字   
     收貨地址:台灣地址
     綠色:格式正確
     紅色:格式不正確")
    End Sub
End Class

