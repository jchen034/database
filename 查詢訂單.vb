Imports MySql.Data.MySqlClient
Public Class 查詢訂單
    Inherits Form
    Private WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Private WithEvents scrollPanel As Panel
    Private WithEvents btnReturn As Button ' 新增返回按鈕控制項
    Private WithEvents btnApplyShipping As Button ' 新增申請集運按鈕控制項
    Private conn As New MySqlConnection
    Private cmd As MySqlCommand
    Private dr As MySqlDataReader
    Private selectedPanels As List(Of Panel)
    Public O_D As List(Of String)
    Public Sub New()
        InitializeComponent_()
        InitializeDatabaseConnection()
        LoadData()
    End Sub

    Public Sub InitializeComponent_()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.scrollPanel = New System.Windows.Forms.Panel()
        Me.btnReturn = New Button() ' 新增返回按鈕控制項
        Me.btnApplyShipping = New Button() ' 新增申請集運按鈕控制項
        Me.SuspendLayout()

        ' 查詢訂單
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.Controls.Add(Me.btnReturn)
        Me.Controls.Add(Me.btnApplyShipping)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(scrollPanel)
        Me.Name = "查詢訂單"
        Me.Text = "查詢訂單"
        Me.ResumeLayout(True)

        ' 設置背景圖片
        Me.BackgroundImage = Image.FromFile("C:\Users\joann\OneDrive\桌面\集貨樂章\查詢訂單.jpg")
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

        ' btnApplyShipping
        Me.btnApplyShipping.Visible = True
        Me.btnApplyShipping.Location = New System.Drawing.Point(25, 670) ' 設定申請集運按鈕的位置
        Me.btnApplyShipping.Size = New System.Drawing.Size(400, 60)
        Me.btnApplyShipping.Padding = New Padding(0, 0, 0, 0)
        Me.btnApplyShipping.Text = ""
        Me.btnApplyShipping.Name = "申請集運"
        Me.btnApplyShipping.BackgroundImage = Image.FromFile("C:\Users\joann\OneDrive\桌面\集貨樂章\申請集貨button.png") ' 設定按鈕的背景圖片
        Me.btnReturn.BackColor = Color.Transparent
        Me.btnApplyShipping.BackgroundImageLayout = ImageLayout.Stretch
        Me.btnApplyShipping.BackColor = Color.Transparent ' 設定按鈕的背景色為透明
        Me.btnApplyShipping.UseVisualStyleBackColor = True
        Me.btnApplyShipping.FlatStyle = FlatStyle.Flat ' 設定按鈕的樣式為無框線
        Me.btnApplyShipping.FlatAppearance.BorderSize = 0 ' 將按鈕的邊框大小設為0，即可去除框線
        ' 設定申請集運按鈕的點擊事件處理程式
        AddHandler Me.btnApplyShipping.Click, AddressOf btnApplyShipping_Click

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
            cmd = New MySqlCommand("SELECT `O_ID`, `O_name`,`O_weight`, `O_remark`, `O_in`, O_intime FROM `訂單資料表` WHERE `C_ID` = @C_ID", conn)
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
            .Size = New Drawing.Size(390, 190)
            .BorderStyle = BorderStyle.FixedSingle
            .Location = New Drawing.Point(0, 0) ' 調整位置
        End With
        Dim checkBox As New CheckBox()
        With checkBox
            .ForeColor = Color.Transparent
            .BackColor = Color.Transparent
            .Size = New Drawing.Size(50, 50)
            .Location = New Drawing.Point(6, 66)
            .Name = "checkBox" ' 修改選取框的名稱
        End With
        Dim orderID As New Label()
        With orderID
            .Text = "訂單編號：" & dr("O_ID").ToString()
            .Font = New Font("微軟正黑體", 10, FontStyle.Bold)
            .AutoSize = True
            .Location = New Drawing.Point(60, 10) ' 調整位置
        End With
        Dim O_ID As String = dr("O_ID").ToString()
        Dim orderName As New Label()
        With orderName
            .Text = "訂單品名：" & dr("O_name").ToString()
            .Font = New Font("微軟正黑體", 10, FontStyle.Bold)
            .AutoSize = True
            .Location = New Drawing.Point(60, 40) ' 調整位置
        End With
        Dim orderweight As New Label()
        With orderweight
            .Font = New Font("微軟正黑體", 10, FontStyle.Bold)
            .AutoSize = True
            .Location = New Drawing.Point(60, 70) ' 調整位置
            If dr("O_in").ToString() = "True" Then
                .Text = "訂單重量：" & dr("O_weight").ToString() & "kg"
            Else
                .Text = "訂單重量："
            End If
        End With
        Dim orderRemark As New Label()
        With orderRemark
            .Text = "備註：" & dr("O_remark").ToString()
            .Font = New Font("微軟正黑體", 10, FontStyle.Bold)
            .AutoSize = True
            .Location = New Drawing.Point(60, 100) ' 調整位置
        End With
        Dim orderIn As New Label()
        With orderIn
            .Font = New Font("微軟正黑體", 10, FontStyle.Bold)
            .AutoSize = True
            .Location = New Drawing.Point(60, 130) ' 調整位置
            .Name = "orderIn"
            If dr("O_in").ToString() = "True" Then
                .Text = "是否入庫：已入庫"
            Else
                .Text = "是否入庫：未入庫"
            End If
        End With
        Dim orderIntime As New Label()
        With orderIntime
            .Text = "訂單入庫時間：" & dr("O_intime").ToString()
            .Font = New Font("微軟正黑體", 10, FontStyle.Bold)
            .AutoSize = True
            .Location = New Drawing.Point(60, 160) ' 調整位置
        End With

        ' 將控制項加入到 panel
        panel.Controls.Add(checkBox)
        panel.Controls.Add(orderID)
        panel.Controls.Add(orderName)
        panel.Controls.Add(orderweight)
        panel.Controls.Add(orderRemark)
        panel.Controls.Add(orderIn)
        panel.Controls.Add(orderIntime)

        ' 將 panel 加入到 FlowLayoutPanel
        Me.FlowLayoutPanel1.Controls.Add(panel)
    End Sub

    Private Sub btnReturn_Click(sender As Object, e As EventArgs)
        Me.Close()
        Dim 訂單確認Form As New 訂單確認()
        訂單確認Form.Show()
    End Sub
    Private Function GetSelectedPanels() As List(Of Panel)
        Dim selectedPanels As New List(Of Panel)

        For Each panel As Panel In FlowLayoutPanel1.Controls
            Dim checkBox As CheckBox = panel.Controls.OfType(Of CheckBox)().FirstOrDefault()
            If checkBox IsNot Nothing AndAlso checkBox.Checked Then
                selectedPanels.Add(panel)
            End If
        Next
        Return selectedPanels
    End Function
    Private Sub btnApplyShipping_Click(sender As Object, e As EventArgs)
        selectedPanels = GetSelectedPanels()
        Dim allOrdersIn As Boolean = True

        If selectedPanels.Count = 0 Then
            ' 顯示訊息提示選擇訂單
            MsgBox("請選擇要申請集貨的訂單！", MsgBoxStyle.Exclamation, "警告")
            Return
        End If

        For Each panel As Panel In selectedPanels
            Dim checkBox As CheckBox = panel.Controls.OfType(Of CheckBox)().FirstOrDefault()
            If checkBox IsNot Nothing AndAlso checkBox.Checked Then
                Dim orderInStatus As Label = panel.Controls.OfType(Of Label)().FirstOrDefault(Function(lbl) lbl.Name = "orderIn")
                Dim orderID As Label = panel.Controls.OfType(Of Label)().FirstOrDefault(Function(lbl) lbl.Name = "orderID")
                Dim orderInValue As Boolean = False
                If orderInStatus IsNot Nothing AndAlso orderInStatus.Text = "是否入庫：已入庫" Then
                    orderInValue = True

                End If
                If orderInValue = False Then
                    allOrdersIn = False
                    Exit For
                End If
            End If
        Next

        If allOrdersIn Then
            ' 顯示申請集運成功提示
            MsgBox("申請集運成功！", MsgBoxStyle.Information, "申請成功")

            ' 跳轉至申請集運表單
            Me.Hide()
            Dim applyShippingForm As New 物流整合(selectedPanels)
            applyShippingForm.Show()
        Else
            ' 提示該訂單尚未入庫，無法申請集運
            MsgBox("該訂單尚未入庫，無法申請集運！" & vbCrLf & "請重新勾選", MsgBoxStyle.Exclamation, "警告")
        End If
    End Sub
End Class


