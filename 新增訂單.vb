Imports MySql.Data.MySqlClient

Public Class 新增訂單
    Inherits Form
    Dim connection As MySqlConnection

    Private Sub Back_Click(sender As Object, e As EventArgs) Handles Back.Click
        Me.Hide()
        Dim 訂單確認Form As New 訂單確認()
        訂單確認Form.Show()
    End Sub

    Private Sub 新增訂單_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim connectionString As String = "server=127.0.0.1;user=test;password=abc123;database=集貨樂章;"
        connection = New MySqlConnection(connectionString)
    End Sub

    Private Sub 確認_Click(sender As Object, e As EventArgs) Handles 確認.Click
        If (訂單編號.Text = "" OrElse 訂單品名.Text = "") Then
            If (訂單編號.Text = "") Then
                Dim pinkPen As New Pen(Color.Pink, 2)
                Dim graphics As Graphics = 訂單編號.CreateGraphics()
                graphics.DrawRectangle(pinkPen, New Rectangle(0, 0, 訂單編號.Width - 1, 訂單編號.Height - 1))
                pinkPen.Dispose()
                訂單編號.BackColor = Color.Pink
            End If
            If (訂單品名.Text = "") Then
                Dim pinkPen As New Pen(Color.Pink, 2)
                Dim graphics As Graphics = 訂單品名.CreateGraphics()
                graphics.DrawRectangle(pinkPen, New Rectangle(0, 0, 訂單品名.Width - 1, 訂單品名.Height - 1))
                pinkPen.Dispose()
                訂單品名.BackColor = Color.Pink
            End If
            新增訂單msgbox.Visible = False
            Return
        Else
            Dim O_ID As String = 訂單編號.Text
            Dim O_name As String = 訂單品名.Text
            Dim O_remark As String = 備註.Text
            Dim random As New Random()
            Dim O_weight As Double
            Dim O_in As Integer = random.Next(0, 2) ' 隨機產生0或1
            Dim O_intime As DateTime?

            If O_in = 1 Then
                O_intime = DateTime.Now.AddMinutes(random.Next(-30, 30)) ' 誤差30秒
                O_weight = random.NextDouble() * (3 - 0.1) + 0.1
            Else
                O_intime = Nothing
                O_weight = Nothing
            End If

            Dim query As String = "INSERT INTO 訂單資料表(C_ID, O_ID, D_ID, O_name, O_weight, O_remark, O_in, O_intime) VALUES (@C_ID, @O_ID, @D_ID, @O_name, @O_weight, @O_remark, @O_in, @O_intime) "

            Try
                connection.Open()
                Dim command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@C_ID", 主畫面.C_ID)
                command.Parameters.AddWithValue("@O_ID", O_ID)
                command.Parameters.AddWithValue("@D_ID", DBNull.Value)
                command.Parameters.AddWithValue("@O_name", O_name)
                command.Parameters.AddWithValue("@O_weight", O_weight)
                command.Parameters.AddWithValue("@O_remark", O_remark)
                command.Parameters.AddWithValue("@O_in", O_in)
                command.Parameters.AddWithValue("@O_intime", O_intime)
                command.ExecuteNonQuery()
                connection.Close()

                Dim CallForm3 As New 新增訂單msgbox()
                CallForm3.Label4.Text = 訂單編號.Text
                CallForm3.Label5.Text = 訂單品名.Text
                CallForm3.Label6.Text = 備註.Text
                CallForm3.Show()

            Catch ex As Exception
                connection.Close()
                MsgBox(ex.Message)
            End Try
        End If
        Me.Hide()
    End Sub
End Class