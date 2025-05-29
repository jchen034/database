Imports System.Text.RegularExpressions
Imports MySql.Data.MySqlClient

Public Class 個人資料
    Private connectionString As String = "server=127.0.0.1;user=test;password=abc123;database=集貨樂章;"
    Private isEditing As Boolean = False
    Public Property C_ID As String

    Public Sub SetC_ID(ByVal cID As String)
        C_ID = cID
        Label1.Text = C_ID
        LoadCustomerData()
        SetReadOnlyMode()
    End Sub
    Public Sub LoadCustomerData()
        Try
            Dim query As String = "SELECT C_ID, C_name, C_pd, C_phone, C_Address FROM 顧客資料表 WHERE C_ID = @C_ID"
            Using connection As New MySqlConnection(connectionString)
                connection.Open()
                Using command As New MySqlCommand(query, connection)
                    command.Parameters.AddWithValue("@C_ID", C_ID)
                    Dim reader As MySqlDataReader = command.ExecuteReader()
                    If reader.Read() Then
                        Label1.Text = reader("C_ID").ToString()
                        更新姓名.Text = reader("C_name").ToString()
                        更新密碼.Text = reader("C_pd").ToString()
                        更新手機號碼.Text = reader("C_phone").ToString()
                        更新收貨地址.Text = reader("C_Address").ToString()
                    End If
                    reader.Close()
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("發生錯誤: " & ex.Message)
        End Try
    End Sub
    Private Sub SetReadOnlyMode()
        更新姓名.ReadOnly = True
        更新密碼.ReadOnly = True
        更新手機號碼.ReadOnly = True
        更新收貨地址.ReadOnly = True
    End Sub
    Private Sub SetEditMode()
        更新姓名.ReadOnly = False
        更新密碼.ReadOnly = False
        更新手機號碼.ReadOnly = False
        更新收貨地址.ReadOnly = False
    End Sub
    Private Function IsPhoneNumberValid(phoneNumber As String) As Boolean
        Dim pattern As String = "^(09)\d{8}$"
        Dim regex As New Regex(pattern)
        Dim match As Match = regex.Match(phoneNumber)
        Return match.Success
    End Function
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
    Private Function CheckInputFormat() As Boolean
        Dim name As String = 更新姓名.Text.Trim()
        Dim password As String = 更新密碼.Text.Trim()
        Dim phoneNumber As String = 更新手機號碼.Text.Trim()
        Dim address As String = 更新收貨地址.Text.Trim()

        If (Panel1.BackColor = Color.Red Or Panel2.BackColor = Color.Red Or Panel3.BackColor = Color.Red Or Panel4.BackColor = Color.Red Or Panel5.BackColor = Color.Red) Then
            Return False
        Else

            Return True
        End If
    End Function

    Private Sub SaveCustomerData()
        Dim name As String = 更新姓名.Text.Trim()
        Dim password As String = 更新密碼.Text.Trim()
        Dim phoneNumber As String = 更新手機號碼.Text.Trim()
        Dim address As String = 更新收貨地址.Text.Trim()
        Try
            Dim query As String = "UPDATE 顧客資料表 SET C_name = @C_name, C_pd = @C_pd, C_phone = @C_phone, C_Address = @C_Address WHERE C_ID = @C_ID"
            Using connection As New MySqlConnection(connectionString)
                connection.Open()
                Using command As New MySqlCommand(query, connection)
                    command.Parameters.AddWithValue("@C_name", name)
                    command.Parameters.AddWithValue("@C_pd", password)
                    command.Parameters.AddWithValue("@C_phone", phoneNumber)
                    command.Parameters.AddWithValue("@C_Address", address)
                    command.Parameters.AddWithValue("@C_ID", C_ID)
                    command.ExecuteNonQuery()
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("儲存失敗：" & ex.Message)
        End Try
    End Sub
    Private Sub 編輯個人資料_Click(sender As Object, e As EventArgs) Handles 編輯個人資料.Click
        If isEditing Then
            Dim newName As String = 更新姓名.Text
            Dim newPassword As String = 更新密碼.Text
            Dim newPhoneNumber As String = 更新手機號碼.Text
            Dim newAddress As String = 更新收貨地址.Text

            If Not IsPhoneNumberValid(newPhoneNumber) Then
                MessageBox.Show("手機號碼格式不正確")
                Return
            End If
            If Not IsTaiwanAddress(newAddress) Then
                MessageBox.Show("收貨地址必須是台灣地址")
                Return
            End If
            If CheckInputFormat() Then
                SaveCustomerData()
                MessageBox.Show("儲存成功")
            Else
                MessageBox.Show("儲存失敗")
            End If
        Else
            isEditing = True
            SetEditMode()
        End If
    End Sub

    Private Sub Back_Click(sender As Object, e As EventArgs) Handles Back.Click
        主畫面.Show() ' 顯示主畫面的表單
        Me.Close() ' 關閉當前表單
    End Sub

    Private Sub 更新姓名_TextChanged(sender As Object, e As EventArgs) Handles 更新姓名.TextChanged
        If isEditing Then
            Dim 姓名 As String = 更新姓名.Text

            ' 姓名格式驗證的正則表達式
            Dim pattern As String = "^[\u4E00-\u9FFF]{3,4}$"

            ' 驗證姓名格式，必須是3~4個字的中文名字
            If Regex.IsMatch(姓名, pattern) Then
                ' 格式正確，設定 Panel 的背景色為綠色
                Panel4.BackColor = Color.Green
            Else
                ' 格式錯誤，設定 Panel 的背景色為紅色
                Panel4.BackColor = Color.Red
            End If

        End If
    End Sub

    Private Sub 更新手機號碼_TextChanged(sender As Object, e As EventArgs) Handles 更新手機號碼.TextChanged
        If isEditing Then
            ' 檢查更新手機號碼.Text 的格式
            Dim phoneNumber As String = 更新手機號碼.Text

            ' 驗證手機號碼格式，必須是台灣手機號碼的格式
            If IsPhoneNumberValid(phoneNumber) Then
                ' 手機號碼格式正確，將 Panel2的邊框顏色設為綠色
                Panel5.BackColor = Color.Green
            Else
                ' 手機號碼格式不正確，將 Panel2的邊框顏色設為紅色
                Panel5.BackColor = Color.Red
            End If
        End If
    End Sub

    Private Sub 更新密碼_TextChanged(sender As Object, e As EventArgs) Handles 更新密碼.TextChanged
        If isEditing Then
            ' 密碼是否介於6~12，否則將Panel5的邊框顏色設為紅色
            If 更新密碼.Text.Length < 6 OrElse 更新密碼.Text.Length > 12 Then
                Panel2.BackColor = Color.Red

            End If

            ' 檢查密碼是否包含英文字母和數字
            Dim hasLetter As Boolean = False
            Dim hasDigit As Boolean = False
            Dim hasChinese As Boolean = False
            Dim hasSymbol As Boolean = False

            For Each c As Char In 更新密碼.Text
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
                Panel2.BackColor = Color.Green
            End If
            ' 檢查是否已輸入密碼
            If (Panel5.BackColor = Color.Red) Then
                更新確認密碼.Enabled = False
            Else
                更新確認密碼.Enabled = True
            End If
            If 更新密碼.Text = 更新確認密碼.Text AndAlso Not String.IsNullOrEmpty(更新確認密碼.Text) Then
                Panel3.BackColor = Color.Green
            Else
                Panel3.BackColor = Color.Red
            End If
        End If
    End Sub

    Private Sub 更新確認密碼_TextChanged(sender As Object, e As EventArgs) Handles 更新確認密碼.TextChanged
        If isEditing Then
            ' 檢查是否和密碼輸入相同且密碼不為空
            If 更新確認密碼.Text = 更新密碼.Text AndAlso Not String.IsNullOrEmpty(更新密碼.Text) Then
                Panel3.BackColor = Color.Green
            Else
                Panel3.BackColor = Color.Red
            End If
            ' 將確認密碼文字方塊的密碼字元設定為米字號
            更新確認密碼.PasswordChar = "*"
        End If
    End Sub

    Private Sub 更新收貨地址_TextChanged(sender As Object, e As EventArgs) Handles 更新收貨地址.TextChanged
        If isEditing Then
            ' 檢查更新收貨地址.Text 的格式
            Dim updatedAddress As String = 更新收貨地址.Text
            ' 檢查地址是否為台灣地址
            Dim address As String = 更新收貨地址.Text
            Dim isValidTaiwanAddress As Boolean = IsTaiwanAddress(address)

            ' 根據檢查結果設定相應的處理邏輯
            If isValidTaiwanAddress Then
                Panel6.BackColor = Color.Green
            Else
                Panel6.BackColor = Color.Red
            End If
        End If
    End Sub
End Class