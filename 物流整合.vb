Imports MySql.Data.MySqlClient
Public Class 物流整合
    Inherits Form
    Private WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Private WithEvents scrollPanel As Panel
    Private WithEvents btnReturn As Button ' 新增返回按鈕控制項
    Private WithEvents 確認 As Button ' 新增確認按鈕控制項
    Public C_ID As String
    Public Shared Property D_ID As String ' 公共靜態屬性
    Private dr As MySqlDataReader
    Public Property SelectedPanels As List(Of Panel)
    Public Sub New(selectedPanels As List(Of Panel))
        InitializeComponent_()
        AddControls()
        InitializeSelectedPanels(selectedPanels)
    End Sub

    Private lblTotalWeight As Label
    Public Sub InitializeComponent_()

        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.scrollPanel = New System.Windows.Forms.Panel()
        Me.btnReturn = New Button()
        Me.確認 = New Button()
        Me.SuspendLayout()

        ' 物流整合
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.Controls.Add(Me.btnReturn)
        Me.Controls.Add(Me.確認)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(scrollPanel)
        Me.Name = "物流整合"
        Me.Text = "物流整合"
        Me.ResumeLayout(True)
        ' 設置背景圖片
        Me.BackgroundImage = Image.FromFile("C:\Users\joann\OneDrive\桌面\集貨樂章\物流整合.jpg")
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

        ' 確認按鍵
        Me.確認.Visible = True
        Me.確認.Location = New System.Drawing.Point(35, 765) ' 設定申請集運按鈕的位置
        Me.確認.Size = New System.Drawing.Size(400, 50)
        Me.確認.Padding = New Padding(0, 0, 0, 0)
        Me.確認.Text = ""
        Me.確認.Name = "確認"
        Me.確認.BackgroundImage = Image.FromFile("C:\Users\joann\OneDrive\桌面\集貨樂章\確認鍵button.png") ' 設定按鈕的背景圖片
        Me.確認.BackgroundImageLayout = ImageLayout.Stretch
        Me.確認.BackColor = Color.Transparent ' 設定按鈕的背景色為透明
        Me.確認.UseVisualStyleBackColor = True
        Me.確認.FlatStyle = FlatStyle.Flat ' 設定按鈕的樣式為無框線
        Me.確認.FlatAppearance.BorderSize = 0 ' 將按鈕的邊框大小設為0，即可去除框線
        ' 設定申請集運按鈕的點擊事件處理程式
        AddHandler Me.確認.Click, AddressOf btnApplyShipping_Click

        ' FlowLayoutPanel1
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.AutoScroll = True
        Me.FlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 0)
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

    ' 宣告 rb海運 和 rb空運 的 RadioButton 控制項
    Private rb海運 As RadioButton
    Private rb空運 As RadioButton
    Private Sub AddControls()
        Dim connectionString As String = "server=127.0.0.1;user=test;password=abc123;database=集貨樂章;"
        Dim query As String = "SELECT C_ID, C_name, C_phone, C_Address FROM 顧客資料表 WHERE C_ID = @C_ID"
        Dim count As Integer = 0

        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@C_ID", 主畫面.C_ID)

                Try
                    connection.Open()
                    count = Convert.ToInt32(command.ExecuteScalar())
                Catch ex As Exception

                End Try
            End Using
        End Using

        Dim panel As New Panel()
        With panel
            .BackColor = Color.Transparent
            .Size = New Drawing.Size(350, 200)
            .BorderStyle = BorderStyle.None
            .Location = New Drawing.Point(10, 0) ' 調整位置
        End With

        Dim 顧客資料 As New Label()
        With 顧客資料
            .Text = "顧客資料"
            .Font = New Font("微軟正黑體", 14, FontStyle.Bold)
            .AutoSize = True
            .Location = New Drawing.Point(10, 10) ' 調整位置
        End With

        Dim 顧客編號 As New Label()
        With 顧客編號
            .Font = New Font("微軟正黑體", 10, FontStyle.Bold)
            .AutoSize = True
            .Location = New Drawing.Point(10, 40) ' 調整位置
        End With

        Dim 姓名 As New Label()
        With 姓名
            .Font = New Font("微軟正黑體", 10, FontStyle.Bold)
            .AutoSize = True
            .Location = New Drawing.Point(10, 70) ' 調整位置
        End With

        Dim 電話 As New Label()
        With 電話
            .Font = New Font("微軟正黑體", 10, FontStyle.Bold)
            .AutoSize = True
            .Location = New Drawing.Point(10, 100) ' 調整位置
        End With

        Dim 收貨地址 As New Label()
        With 收貨地址
            .Font = New Font("微軟正黑體", 10, FontStyle.Bold)
            .AutoSize = True
            .Location = New Drawing.Point(10, 130) ' 調整位置
        End With

        ' 運送方式Panel
        Dim 運送方式 As New Panel()
        With 運送方式
            .BackColor = Color.Transparent
            .Size = New Size(350, 100)
            .BorderStyle = BorderStyle.None
            .Location = New Point(10, 200) ' 調整位置
        End With

        ' 運送方式Label
        Dim lbl運送方式 As New Label()
        With lbl運送方式
            .Text = "運送方式：".ToString()
            .Font = New Font("微軟正黑體", 12, FontStyle.Bold)
            .AutoSize = True
            .Location = New Point(10, 0) ' 調整位置
        End With

        Dim rb海運 As RadioButton
        Dim rb空運 As RadioButton

        rb海運 = New RadioButton()
        With rb海運
            .Text = "海運"
            .Font = New Font("微軟正黑體", 10, FontStyle.Bold)
            .AutoSize = True
            .Location = New Point(10, 30) ' 調整位置
        End With

        rb空運 = New RadioButton()
        With rb空運
            .Text = "空運"
            .Font = New Font("微軟正黑體", 10, FontStyle.Bold)
            .AutoSize = True
            .Location = New Point(10, 70) ' 調整位置
        End With

        ' 將控制項加入到運送方式Panel
        運送方式.Controls.Add(lbl運送方式)
        運送方式.Controls.Add(rb海運)
        運送方式.Controls.Add(rb空運)

        ' 將 panel 加入到 FlowLayoutPanel
        Me.FlowLayoutPanel1.Controls.Add(panel)
        Me.FlowLayoutPanel1.Controls.Add(運送方式)

        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@C_ID", 主畫面.C_ID)

                Try
                    connection.Open()

                    Using reader As MySqlDataReader = command.ExecuteReader()
                        If reader.HasRows Then
                            reader.Read()

                            Dim cId As String = reader("C_ID").ToString()
                            Dim cName As String = reader("C_name").ToString()
                            Dim cPhone As String = reader("C_phone").ToString()
                            Dim cAddress As String = reader("C_Address").ToString()

                            顧客編號.Text = "顧客編號：" & cId
                            姓名.Text = "姓名：" & cName
                            電話.Text = "電話：" & cPhone
                            收貨地址.Text = "收貨地址：" & cAddress
                        End If

                        reader.Close()
                    End Using
                Catch ex As Exception
                End Try
            End Using
        End Using

        ' 將控件加入anel
        panel.Controls.Add(顧客資料)
        panel.Controls.Add(顧客編號)
        panel.Controls.Add(姓名)
        panel.Controls.Add(電話)
        panel.Controls.Add(收貨地址)

        ' 將 panel 加入到 FlowLayoutPanel
        Me.FlowLayoutPanel1.Controls.Add(panel)
        Me.FlowLayoutPanel1.Controls.Add(運送方式)

        ' 為 rb海運 添加 CheckedChanged 事件處理程序
        AddHandler rb海運.CheckedChanged, AddressOf rbShippingMethod_CheckedChanged

        ' 為 rb空運 添加 CheckedChanged 事件處理程序
        AddHandler rb空運.CheckedChanged, AddressOf rbShippingMethod_CheckedChanged
    End Sub

    Private totalWeight As Double = 0

    Private Sub InitializeSelectedPanels(selectedPanels As List(Of Panel))
        If selectedPanels IsNot Nothing AndAlso selectedPanels.Count > 0 Then

            For Each panel As Panel In selectedPanels
                Dim orderWeight As Double = 0
                Dim orderWeightLabel As Label = panel.Controls.OfType(Of Label)().FirstOrDefault(Function(lbl) lbl.Text.StartsWith("訂單重量："))

                If orderWeightLabel IsNot Nothing Then
                    Dim weightText As String = orderWeightLabel.Text.Replace("訂單重量：", "").Replace("kg", "").Trim()
                    Double.TryParse(weightText, orderWeight)
                End If
                totalWeight += orderWeight
            Next
            ' 新增一個 Label 控制項來顯示總重量
            Dim lblTotalWeight As New Label()
            lblTotalWeight.Name = "lblTotalWeight"
            lblTotalWeight.Text = "集運重量：" + totalWeight.ToString() + "kg"
            lblTotalWeight.Font = New Font("微軟正黑體", 14, FontStyle.Bold)
            lblTotalWeight.AutoSize = True
            lblTotalWeight.Location = New Point(10, 200)
            FlowLayoutPanel1.Controls.Add(lblTotalWeight)

            For Each panel As Panel In selectedPanels
                FlowLayoutPanel1.Controls.Add(panel)
            Next
        End If
    End Sub

    Private Sub btnReturn_Click(sender As Object, e As EventArgs)
        '返回按鈕的點擊事件處理程式
        查詢訂單.Show() ' 
        Me.Hide() ' 隱藏當前表單
    End Sub

    Public shippingMethod As String
    Dim D_method As Integer
    Private Sub rbShippingMethod_CheckedChanged(sender As Object, e As EventArgs)
        Dim selectedRadioButton As RadioButton = CType(sender, RadioButton)

        If selectedRadioButton.Checked Then
            Dim selectedShippingMethod As String = selectedRadioButton.Text

            If selectedShippingMethod = "海運" Then
                ' 使用海運
                Dim Fare As Double = CalculateFare("sea", totalWeight)
                MessageBox.Show("若選擇了海運，運費為: " & Fare.ToString())
                shippingMethod = "sea"
                D_method = 0
            ElseIf selectedShippingMethod = "空運" Then
                Dim Fare As Double = CalculateFare("air", totalWeight)
                MessageBox.Show("若選擇了空運，運費為: " & Fare.ToString())
                shippingMethod = "air"
                D_method = 1
            End If
        End If
    End Sub

    ' 根據運送方式及總重量計算Fare
    Private Function CalculateFare(ByVal shippingMethod As String, ByVal totalWeight As Double) As Double
        If shippingMethod = "sea" Then
            ' 海運Fare
            Dim baseFee As Integer = 92 ' 首重Fare
            Dim additionalFeePerKg As Double = 32 ' 續重Fare（每公斤）
            Dim additionalWeight As Double = Math.Max(totalWeight - 1, 0)  ' 超過首重的重量
            Dim fare As Double = baseFee + additionalWeight * additionalFeePerKg
            Return CInt(Math.Ceiling(fare))
        End If
        If shippingMethod = "air" Then
            ' 空運Fare
            Dim baseFee As Integer = 100 ' 首重Fare
            Dim additionalFeePerKg As Double = 72 ' 續重Fare（每公斤）
            Dim additionalWeight As Double = Math.Max(totalWeight - 1, 0) ' 超過首重的重量
            Dim fare As Double = baseFee + additionalWeight * additionalFeePerKg
            Return CInt(Math.Ceiling(fare))
        Else
            Return 0.0
        End If
    End Function
    Private Sub btnApplyShipping_Click(sender As Object, e As EventArgs)
        Dim random As New Random()
        Dim logisticsNumber1 = Chr(random.Next(Asc("A"), Asc("Z") + 1)) + random.Next(1000, 9999).ToString()
        Dim logisticsNumber As String = "物流編號：" + logisticsNumber1
        Dim Fare As Integer = CalculateFare(shippingMethod, totalWeight)
        Dim FareText As String = "運費：" & Fare.ToString()
        Dim companyBank As String = "公司銀行別：700"
        Dim companyAccount As String = "公司帳號：01234560123"
        Dim customerBank As String = InputBox("請輸入您的銀行別：")
        Dim customerAccount As String = InputBox("請輸入您的帳號（末5碼）：")

        If Not IsNumeric(customerBank) OrElse customerBank.Length <> 3 Then
            MsgBox("請輸入三位數字的銀行代碼。", MsgBoxStyle.Exclamation, "錯誤")
            Exit Sub
        End If

        If Not IsNumeric(customerAccount) OrElse customerAccount.Length <> 5 Then
            MsgBox("請輸入五位數字的銀行帳號（末5碼）。", MsgBoxStyle.Exclamation, "錯誤")
            Exit Sub
        End If
        Dim connectionString As String = "server= 127.0.0.1;user=test;password=abc123;database=集貨樂章;"
        Using connection As New MySqlConnection(connectionString)
            connection.Open()
            ' 更新選定的訂單資料表中的D_ID

            Dim updateOrderQuery As String = "UPDATE 訂單資料表 SET D_ID = @D_ID WHERE O_ID = @orderID AND C_ID=@C_ID"
            ' 建立 MySqlCommand 物件
            Using updateOrderCommand As New MySqlCommand(updateOrderQuery, connection)
                ' 設定UPDATE語句的參數
                updateOrderCommand.Parameters.Add("@D_ID", MySqlDbType.VarChar) ' 根據資料庫欄位的類型調整
                updateOrderCommand.Parameters.Add("@O_ID", MySqlDbType.VarChar) ' 根據資料庫欄位的類型調整
                updateOrderCommand.Parameters.Add("@C_ID", MySqlDbType.VarChar) ' 根據資料庫欄位的類型調整

                For Each control As Control In FlowLayoutPanel1.Controls
                    If TypeOf control Is Panel Then
                        Dim panel As Panel = DirectCast(control, Panel)
                        Dim checkBox As CheckBox = panel.Controls.OfType(Of CheckBox)().FirstOrDefault()

                        If checkBox IsNot Nothing AndAlso checkBox.Checked Then
                            Dim orderIDLabel As Label = panel.Controls.OfType(Of Label)().FirstOrDefault(Function(lbl) lbl.Name = "orderID")

                            If orderIDLabel IsNot Nothing Then
                                Dim orderID As String = orderIDLabel.Text.Substring(orderIDLabel.Text.IndexOf("：") + 1)

                                ' 使用 updateOrderCommand 物件執行更新訂單資料表的操作
                                updateOrderCommand.Parameters.AddWithValue("@D_ID", logisticsNumber1)
                                updateOrderCommand.Parameters.AddWithValue("@O_ID", orderID) ' 請根據您的實際資料結構和欄位名稱替換OrderID
                                updateOrderCommand.Parameters.AddWithValue("@C_ID", 主畫面.C_ID)
                                updateOrderCommand.ExecuteNonQuery()
                            End If
                        End If
                    End If
                Next
            End Using
        End Using
        Dim message As String = logisticsNumber & vbCrLf & FareText & vbCrLf & companyBank & vbCrLf & companyAccount & vbCrLf & "您的銀行別：" & customerBank & vbCrLf & "您的銀行帳號（末5碼）：" & customerAccount
        Dim result As MsgBoxResult = MsgBox(message, MsgBoxStyle.Information + MsgBoxStyle.OkCancel, "物流資訊")
        If result = MsgBoxResult.Ok Then
            '  Dim connectionString As String = "server= 127.0.0.1;user=test;password=abc123;database=集貨樂章;"
            Using connection As New MySqlConnection(connectionString)
                connection.Open()
                Dim insertLogisticsQuery As String = "INSERT INTO 集貨資料表 (D_method,D_ID, Fare, C_ID, D_weight,PAY,D_car,Employee_ID,bank_num1,bank_num2) VALUES (@D_method,@D_ID, @Fare, @C_ID, @D_weight,@PAY,@D_car,@Employee_ID,@bank_num1,@bank_num2)"
                Using command As New MySqlCommand(insertLogisticsQuery, connection)
                    Dim PAY As Integer = random.Next(0, 2)

                    If PAY = 1 Then
                        command.Parameters.AddWithValue("@PAY", "已付款")
                    Else
                        command.Parameters.AddWithValue("@PAY", "未付款")
                    End If
                    Dim randomNumberGenerator As New Random()
                    ' Generate a random number (0, 1, or 2)
                    Dim randomNumber As Integer = random.Next(0, 3)

                    ' Assign @D_ID based on the random number
                    Select Case randomNumber
                        Case 0
                            command.Parameters.AddWithValue("@D_car", "XXAAA")
                        Case 1
                            command.Parameters.AddWithValue("@D_car", "XXBBB")
                        Case 2
                            command.Parameters.AddWithValue("@D_car", "XXCCC")
                    End Select

                    Dim randomNumberGenerator1 As New Random()
                    Select Case randomNumber
                        Case 0
                            command.Parameters.AddWithValue("@Employee_ID", "AA111")
                        Case 1
                            command.Parameters.AddWithValue("@Employee_ID", "BB222")
                        Case 2
                            command.Parameters.AddWithValue("@Employee_ID", "CC333")
                    End Select

                    command.Parameters.AddWithValue("@D_ID", logisticsNumber1)
                    command.Parameters.AddWithValue("@Fare", Fare)
                    command.Parameters.AddWithValue("@C_ID", 主畫面.C_ID)
                    command.Parameters.AddWithValue("@D_weight", totalWeight)
                    command.Parameters.AddWithValue("@bank_num1", customerBank)
                    command.Parameters.AddWithValue("@bank_num2", customerAccount)
                    command.Parameters.AddWithValue("@D_method", D_method)
                    command.ExecuteNonQuery()
                End Using
            End Using

            ' 確定按鈕被按下，進行修改
            companyBank = "公司銀行別：" & customerBank
            companyAccount = "公司帳號：" & customerAccount

            Me.Hide()
            Dim 主畫面Form As New 主畫面()
            主畫面Form.ShowDialog()
        Else
            ' 修改取消，不執行任何操作
            MsgBox("集貨未進行完成。", MsgBoxStyle.Information, "集貨取消")
        End If
    End Sub
End Class
