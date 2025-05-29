Imports System.Text.RegularExpressions
Imports MySql.Data.MySqlClient
Public Class 物流跳轉
    Inherits Form
    Private WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Private WithEvents scrollPanel As Panel
    Private WithEvents btnReturn As Button ' 新增返回按鈕控制項
    Private conn As New MySqlConnection
    Private cmd As MySqlCommand
    Private dr As MySqlDataReader
    Private selectedPanels As List(Of Panel)
    Public Sub New()
        InitializeComponent_()
        InitializeDatabaseConnection()
        LoadData()
    End Sub

    Public Sub InitializeComponent_()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.scrollPanel = New System.Windows.Forms.Panel()
        Me.btnReturn = New Button() ' 新增返回按鈕控制項
        Me.SuspendLayout()

        ' 查詢訂單
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.Controls.Add(Me.btnReturn)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(scrollPanel)
        Me.Name = "物流跳轉"
        Me.Text = "物流跳轉"
        Me.ResumeLayout(True)

        ' 設置背景圖片
        Me.BackgroundImage = Image.FromFile("C:\Users\joann\OneDrive\桌面\集貨樂章\物流追蹤.jpg")
        Me.BackgroundImageLayout = ImageLayout.Stretch
        Me.StartPosition = FormStartPosition.CenterScreen

        ' btnReturn
        Me.btnReturn.Visible = True
        Me.btnReturn.Location = New Point(39, 45) ' 設定返回按鈕的位置
        Me.btnReturn.Size = New Size(49, 45)
        Me.btnReturn.Padding = New Padding(0, 0, 0, 0)
        Me.btnReturn.Text = ""
        Me.btnReturn.Name = "返回"
        Me.btnReturn.BackgroundImage = Image.FromFile("C:\Users\joann\OneDrive\桌面\集貨樂章\Back.png") ' 設定按鈕的背景圖片
        Me.btnReturn.BackgroundImageLayout = ImageLayout.Stretch
        Me.btnReturn.BackColor = Color.Transparent ' 設定按鈕的背景色為透明
        Me.btnReturn.UseVisualStyleBackColor = True
        Me.btnReturn.FlatStyle = FlatStyle.Flat ' 設定按鈕的樣式為無框線
        Me.btnReturn.FlatAppearance.BorderSize = 0 ' 將按鈕的邊框大小設為0，即可去除框線
        ' 設定返回按鈕的點擊事件處理程式
        AddHandler Me.btnReturn.Click, AddressOf btnReturn_Click

        ' FlowLayoutPanel1
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.AutoScroll = True
        Me.FlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(20, 0)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Padding = New Padding(30, 0, 0, 0) ' 只設定上方邊界的距離
        Me.FlowLayoutPanel1.WrapContents = False ' 不換行顯示
        Me.FlowLayoutPanel1.TabIndex = 0
        Me.FlowLayoutPanel1.BackColor = Color.Transparent

        ' 卷軸面板
        Me.scrollPanel.AutoScroll = True
        Me.scrollPanel.Location = New Drawing.Point(0, 140)
        Me.scrollPanel.Padding = New Padding(0, 0, 0, 0)
        Me.scrollPanel.Name = "scrollPanel"
        Me.scrollPanel.Size = New Drawing.Size(460, 600)
        Me.scrollPanel.TabIndex = 0
        Me.scrollPanel.BackColor = Color.Transparent
        Me.FlowLayoutPanel1.HorizontalScroll.Enabled = False
        Me.FlowLayoutPanel1.HorizontalScroll.Visible = False
        Me.FlowLayoutPanel1.WrapContents = False
        Me.scrollPanel.AutoScrollMinSize = New Size(0, FlowLayoutPanel1.Height + 10000)
        Me.scrollPanel.VerticalScroll.Visible = False
        Me.scrollPanel.VerticalScroll.Enabled = False
        Me.scrollPanel.Controls.Add(FlowLayoutPanel1)
    End Sub
    Private Sub InitializeDatabaseConnection()
        Dim connectionString As String = "server=127.0.0.1;user=test;password=abc123;database=集貨樂章;"
        conn.ConnectionString = connectionString
    End Sub

    Private Sub LoadData()
        Try
            conn.Open()
            cmd = New MySqlCommand("SELECT `D_ID`, Fare FROM 集貨資料表 WHERE C_ID = @C_ID AND PAY = '已付款'", conn)
            cmd.Parameters.AddWithValue("@C_ID", 主畫面.C_ID)
            dr = cmd.ExecuteReader()

            While dr.Read()
                AddControls(dr)
            End While

            dr.Close()
        Catch ex As Exception
            MsgBox("資料庫連接錯誤: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub
    Private Sub AddControls(dr As MySqlDataReader)
        Dim panel As New Panel()
        With panel
            .BackColor = Color.White
            .Size = New Drawing.Size(300, 200)
            .BorderStyle = BorderStyle.FixedSingle
            .Margin = New Padding(50, 0, 0, 0) ' 調整位置
            .Location = New Drawing.Point(0, 0) ' 調整位置
        End With

        ' 動態生成標籤控制項
        Dim lblLogisticsInfo As New Label()
        lblLogisticsInfo.Name = "lblLogisticsInfo"
        lblLogisticsInfo.Text = "物流編號: " & dr("D_ID").ToString() & " Fare: " & dr("Fare").ToString()
        lblLogisticsInfo.Location = New Point(0, 0) ' 設定位置相對於 Panel
        lblLogisticsInfo.AutoSize = True
        lblLogisticsInfo.Visible = False
        panel.Controls.Add(lblLogisticsInfo) ' 將標籤控制項加入到 Panel 中

        Dim 物流編號 As New Label()
        With 物流編號
            .Text = "物流編號：" & dr("D_ID").ToString()
            .Font = New Font("微軟正黑體", 12, FontStyle.Bold)
            .AutoSize = True
            .Location = New Drawing.Point(80, 10) ' 調整位置
        End With

        Dim 運費 As New Label()
        With 運費
            .Text = "運費：" & dr("Fare").ToString()
            .Font = New Font("微軟正黑體", 12, FontStyle.Bold)
            .AutoSize = True
            .Location = New Drawing.Point(80, 40) ' 調整位置
        End With

        Dim 查看物流進度 As New Button()
        With 查看物流進度
            .Text = "查看物流進度"
            .Font = New Font("微軟正黑體", 12, FontStyle.Bold)
            .AutoSize = True
            .Location = New Drawing.Point(80, 80) ' 調整位置
            .Size = New Size(150, 50) ' 調整大小
        End With

        Dim 查看詳情 As New Button()
        With 查看詳情
            .Text = "查看詳情"
            .Font = New Font("微軟正黑體", 12, FontStyle.Bold)
            .AutoSize = True
            .Location = New Drawing.Point(80, 140) ' 調整位置
            .Size = New Size(150, 50) ' 調整大小
        End With

        ' 將控制項加入到 panel
        panel.Controls.Add(物流編號)
        panel.Controls.Add(運費)
        panel.Controls.Add(查看物流進度)
        panel.Controls.Add(查看詳情)
        ' 將 panel 加入到 FlowLayoutPanel
        Me.FlowLayoutPanel1.Controls.Add(panel)
        ' 查看物流進度按鈕的點擊事件處理程式
        AddHandler 查看物流進度.Click, AddressOf 查看物流進度_Click
        ' 查看詳情按鈕的點擊事件處理程式
        AddHandler 查看詳情.Click, AddressOf 查看詳情_Click

    End Sub
    Private Sub btnReturn_Click(sender As Object, e As EventArgs)
        Me.Close()
        Dim 主畫面Form As New 主畫面()
        主畫面Form.Show()
    End Sub
    Private Sub 查看物流進度_Click(sender As Object, e As EventArgs)
        ' 跳轉到查看物流進度視窗的程式碼
        Dim 查看物流進度Form As New 查看物流進度()
        查看物流進度Form.Show()
        Me.Hide()
    End Sub
    Private Sub 查看詳情_Click(sender As Object, e As EventArgs)
        Dim button As Button = DirectCast(sender, Button) ' 取得觸發事件的按钮

        Dim panel As Panel = DirectCast(button.Parent, Panel) ' 取得按鈕所在的 Panel
        Dim logisticsInfo As String = panel.Controls("lblLogisticsInfo").Text ' 取得物流信息

        Dim regex As New Regex("物流編號: (\w+) Fare:") ' 使用正則表達式匹配物流編號
        Dim match As Match = regex.Match(logisticsInfo)
        If match.Success Then
            Me.Hide()
            Dim D_ID As String = match.Groups(1).Value ' 取得物流編號 D_ID
            ' 跳轉到查看詳情畫面的代碼傳遞 D_ID 值
            Dim 詳情Form As New 查看詳情(D_ID)
            詳情Form.ShowDialog()

        End If
    End Sub
End Class