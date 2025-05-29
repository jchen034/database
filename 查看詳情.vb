Imports MySql.Data.MySqlClient

Public Class 查看詳情
    Dim connection As MySqlConnection

    Public Property C_ID As String
    Private D_ID As String

    Public Sub New(ByVal dId As String)
        InitializeComponent()
        D_ID = dId
        connection = New MySqlConnection("server=127.0.0.1;user=test;password=abc123;database=集貨樂章;")
    End Sub

    Private Sub 查看詳情_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.StartPosition = FormStartPosition.CenterScreen
        connection.Open()
        C_ID = 主畫面.C_ID

        ' 創建顧客信息標籤和容器 Panel
        Dim customerLabel As New Label()
        customerLabel.AutoSize = True
        customerLabel.Text = "顧客資料:"
        customerLabel.Location = New Point(50, 150)
        customerLabel.BackColor = Color.FromArgb(240, 243, 251)
        customerLabel.Font = New Font("微軟正黑體", 12, FontStyle.Bold)

        Dim panel As New Panel()
        panel.AutoScroll = True
        panel.AutoSize = True
        panel.Dock = DockStyle.Fill
        panel.Location = New Point(0, 460)
        panel.BackgroundImage = Image.FromFile("C:\Users\joann\OneDrive\桌面\集貨樂章\物流追蹤.jpg")
        panel.BackgroundImageLayout = ImageLayout.Stretch

        Controls.Add(panel)

        ' 設定要從資料庫擷取顧客資料的 SQL 查詢語句
        Dim customerQuery As String = "SELECT C_ID, C_name, C_pd, C_phone, C_Address FROM 顧客資料表 WHERE C_ID = @C_ID"
        Dim customerDataTable As New DataTable()

        Using customerCommand As New MySqlCommand(customerQuery, connection)
            customerCommand.Parameters.AddWithValue("@C_ID", C_ID)
            Dim customerDataAdapter As New MySqlDataAdapter(customerCommand)
            customerDataAdapter.Fill(customerDataTable)
        End Using

        If customerDataTable.Rows.Count > 0 Then
            Dim customerName As String = customerDataTable.Rows(0)("C_name").ToString()
            Dim customerPhone As String = customerDataTable.Rows(0)("C_phone").ToString()
            Dim customerAddress As String = customerDataTable.Rows(0)("C_Address").ToString()

            Dim customerInfoLabel As New Label()
            customerInfoLabel.AutoSize = True
            customerInfoLabel.Text = "顧客編號：" & C_ID & Environment.NewLine &
                                     "姓名：" & customerName & Environment.NewLine &
                                     "電話：" & customerPhone & Environment.NewLine &
                                     "地址：" & customerAddress
            customerInfoLabel.Location = New Point(50, 200)
            customerInfoLabel.Font = New Font("微軟正黑體", 10, FontStyle.Bold)
            customerInfoLabel.BackColor = Color.FromArgb(240, 243, 251)

            panel.Controls.Add(customerLabel)
            panel.Controls.Add(customerInfoLabel)

            ' 設定要從資料庫擷取訂單資料的 SQL 查詢語句
            Dim orderQuery As String = "SELECT O_ID, O_name, O_weight, O_remark, O_in, O_intime, D_ID FROM 訂單資料表 WHERE D_ID = @D_ID"

            Dim orderDataTable As New DataTable()
            ' 創建訂單訊息標籤
            Dim yPosition As Integer = customerInfoLabel.Bottom + 40
            Using orderCommand As New MySqlCommand(orderQuery, connection)
                orderCommand.Parameters.AddWithValue("@D_ID", D_ID)
                Dim orderDataAdapter As New MySqlDataAdapter(orderCommand)
                orderDataAdapter.Fill(orderDataTable)

                For Each row As DataRow In orderDataTable.Rows
                    Dim orderInfoLabel As New Label()
                    orderInfoLabel.AutoSize = True
                    orderInfoLabel.Text = "訂單編號：" & row("O_ID").ToString() & Environment.NewLine &
                                          "訂單品名：" & row("O_name").ToString() & Environment.NewLine &
                                          "訂單重量：" & row("O_weight").ToString() & Environment.NewLine &
                                          "備註：" & row("O_remark").ToString() & Environment.NewLine &
                                          "是否入庫：" & row("O_in").ToString() & Environment.NewLine &
                                          "訂單入庫時間：" & row("O_intime").ToString()
                    orderInfoLabel.Location = New Point(50, yPosition)
                    orderInfoLabel.BackColor = Color.FromArgb(214, 226, 243)
                    orderInfoLabel.Font = New Font("微軟正黑體", 10, FontStyle.Bold)
                    panel.Controls.Add(orderInfoLabel)

                    yPosition += orderInfoLabel.Height + 60
                Next
            End Using

            Dim cargoQuery As String = "SELECT Fare, D_weight, PAY, D_car, Employee_ID, bank_num1, bank_num2, D_method FROM 集貨資料表 WHERE D_ID = @D_ID"
            Dim cargoDataTable As New DataTable()

            Using cargoCommand As New MySqlCommand(cargoQuery, connection)
                cargoCommand.Parameters.AddWithValue("@D_ID", D_ID)
                Dim cargoDataAdapter As New MySqlDataAdapter(cargoCommand)
                cargoDataAdapter.Fill(cargoDataTable)
            End Using
            ' 創建集貨訊息標籤
            If cargoDataTable.Rows.Count > 0 Then
                Dim fare As String = cargoDataTable.Rows(0)("Fare").ToString()
                Dim dWeight As String = cargoDataTable.Rows(0)("D_weight").ToString()
                Dim dCar As String = cargoDataTable.Rows(0)("D_car").ToString()
                Dim employeeID As String = cargoDataTable.Rows(0)("Employee_ID").ToString()
                Dim dMethod As String = cargoDataTable.Rows(0)("D_method").ToString()

                For Each row As DataRow In cargoDataTable.Rows
                    ' 創建集貨信息標籤和運輸方式的 RadioButton
                    Dim cargoInfoLabel As New Label()
                    cargoInfoLabel.AutoSize = True
                    cargoInfoLabel.Text = "集貨重量：" & dWeight & Environment.NewLine &
                                          "運輸車號：" & dCar & Environment.NewLine &
                                          "員工編號：" & employeeID & Environment.NewLine & "運送方式"
                    cargoInfoLabel.Location = New Point(50, yPosition)
                    cargoInfoLabel.BackColor = Color.Transparent
                    cargoInfoLabel.BackColor = Color.FromArgb(240, 243, 251)
                    cargoInfoLabel.Font = New Font("微軟正黑體", 10, FontStyle.Bold)
                    panel.Controls.Add(cargoInfoLabel)

                    ' 創建運送方式的 RadioButton
                    Dim rb海運 As RadioButton
                    Dim rb空運 As RadioButton

                    rb海運 = New RadioButton()
                    rb海運.Enabled = False

                    With rb海運
                        .Text = "海運"
                        .Font = New Font("微軟正黑體", 10, FontStyle.Bold)
                        .AutoSize = True
                        .Location = New Point(cargoInfoLabel.Right, yPosition + 140)

                    End With

                    rb空運 = New RadioButton()
                    rb空運.Enabled = False

                    With rb空運
                        .Text = "空運"
                        .Font = New Font("微軟正黑體", 10, FontStyle.Bold)
                        .AutoSize = True
                        .Location = New Point(cargoInfoLabel.Left, yPosition + 140)
                    End With

                    ' 根據 dMethod 值選擇相應的 RadioButton
                    Select Case dMethod
                        Case "1" ' 如果 dMethod 是 1，選中空運
                            rb空運.Checked = True
                        Case Else ' 否則，選中海運
                            rb海運.Checked = True
                    End Select

                    ' 將 RadioButton 控件添加到容器控件中
                    panel.Controls.Add(rb海運)
                    panel.Controls.Add(rb空運)

                    ' 更新 yPosition
                    yPosition += cargoInfoLabel.Height + 70
                Next

            End If
            ' 設置 Panel 控件的位置和大小
            panel.Location = New Point(0, 80)
            panel.Size = New Size(Me.Width, Me.Height - 160)

            ' 添加 Panel 控件到 Form 中
            Controls.Add(panel)

            connection.Close()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim 物流跳轉Form As New 物流跳轉()
        物流跳轉Form.ShowDialog()
        Me.Hide()
    End Sub
End Class
