Imports MySql.Data.MySqlClient
Public Class 付款確認
    Inherits Form

    Private WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Private WithEvents scrollPanel As Panel
    Private WithEvents btnReturn As Button
    Private conn As New MySqlConnection
    Private cmd As MySqlCommand
    Public dr As MySqlDataReader
    Private selectedPanels As List(Of Panel)

    Public Sub New()
        InitializeComponent_()
        InitializeDatabaseConnection()
        LoadData()
    End Sub

    Public Sub InitializeComponent_()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.scrollPanel = New System.Windows.Forms.Panel()
        Me.btnReturn = New Button()
        Me.SuspendLayout()

        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.Controls.Add(Me.btnReturn)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.scrollPanel)
        Me.Name = "付款確認"
        Me.Text = "付款確認"
        Me.ResumeLayout(True)

        Me.BackgroundImage = Image.FromFile("C:\Users\joann\OneDrive\桌面\集貨樂章\付款確認-2.jpg")
        Me.BackgroundImageLayout = ImageLayout.Stretch
        Me.StartPosition = FormStartPosition.CenterScreen

        Me.btnReturn.Visible = True
        Me.btnReturn.Location = New Point(39, 30)
        Me.btnReturn.Size = New Size(49, 45)
        Me.btnReturn.Padding = New Padding(0, 0, 0, 0)
        Me.btnReturn.Text = ""
        Me.btnReturn.Name = "返回"
        Me.btnReturn.BackgroundImage = Image.FromFile("C:\Users\joann\OneDrive\桌面\集貨樂章\Back.png")
        Me.btnReturn.BackgroundImageLayout = ImageLayout.Stretch
        Me.btnReturn.UseVisualStyleBackColor = True
        Me.btnReturn.FlatStyle = FlatStyle.Flat
        Me.btnReturn.FlatAppearance.BorderSize = 0
        AddHandler Me.btnReturn.Click, AddressOf btnReturn_Click

        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.AutoScroll = True
        Me.FlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(20, 0)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Padding = New Padding(30, 0, 0, 0)
        Me.FlowLayoutPanel1.WrapContents = False
        Me.FlowLayoutPanel1.TabIndex = 0
        Me.FlowLayoutPanel1.BackColor = Color.Transparent

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
            cmd = New MySqlCommand("SELECT `D_ID`, `Fare`,`PAY` FROM 集貨資料表 WHERE C_ID = @C_ID", conn)
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
            .Size = New Drawing.Size(300, 150)
            .BorderStyle = BorderStyle.FixedSingle
            .Margin = New Padding(50, 0, 0, 0)
        End With

        Dim 物流編號 As New Label()
        With 物流編號
            .Text = "物流編號：" & dr("D_ID").ToString()
            .Font = New Font("微軟正黑體", 12, FontStyle.Bold)
            .AutoSize = True
            .Location = New Drawing.Point(70, 15)
        End With
        Dim D_ID As String = dr("D_ID").ToString()
        Dim 運費 As New Label()
        With 運費
            .Text = "運費：" & dr("Fare").ToString()
            .Font = New Font("微軟正黑體", 12, FontStyle.Bold)
            .AutoSize = True
            .Location = New Drawing.Point(70, 45)
        End With

        Dim 付款狀態 As New Button()
        With 付款狀態
            .Text = "付款狀態：" & dr("PAY").ToString()
            .Font = New Font("微軟正黑體", 12, FontStyle.Bold)
            .Size = New Drawing.Size(100, 50)
            .AutoSize = True
            .Location = New Drawing.Point(65, 75)
        End With

        If dr("PAY").ToString() = "未付款" Then
            付款狀態.ForeColor = Color.Red
        ElseIf dr("PAY").ToString() = "已付款" Then
            付款狀態.ForeColor = Color.Green
        End If
        panel.Controls.Add(物流編號)
        panel.Controls.Add(運費)
        panel.Controls.Add(付款狀態)

        Me.FlowLayoutPanel1.Controls.Add(panel)
        AddHandler 付款狀態.Click, Sub(sender As Object, e As EventArgs)
                                   If 付款狀態.Text = "付款狀態：未付款" Then
                                       Dim 公司銀行別 As String = "公司銀行別：700"
                                       Dim 公司帳號 As String = "公司帳號：01234560123"

                                       Dim Fare As String = ""
                                       Dim bank_num1 As String = ""
                                       Dim bank_num2 As String = ""

                                       Dim connectionString As String = "server=127.0.0.1;user=test;password=abc123;database=集貨樂章;"
                                       Dim query As String = "SELECT Fare, bank_num1, bank_num2 FROM 集貨資料表 WHERE D_ID = @D_ID"
                                       Using connection As New MySqlConnection(connectionString)
                                           connection.Open()
                                           Using command As New MySqlCommand(query, connection)
                                               command.Parameters.AddWithValue("@D_ID", D_ID)

                                               Using reader As MySqlDataReader = command.ExecuteReader()
                                                   If reader.Read() Then
                                                       Fare = reader("Fare").ToString()
                                                       bank_num1 = reader("bank_num1").ToString()
                                                       bank_num2 = reader("bank_num2").ToString()
                                                   End If
                                               End Using
                                           End Using
                                       End Using
                                       MessageBox.Show("物流編號 : " & D_ID & Environment.NewLine & "運費 : " & Fare & Environment.NewLine & 公司銀行別 & Environment.NewLine & 公司帳號 & Environment.NewLine & "您的銀行別 : " & bank_num1 & Environment.NewLine & "您的帳號（末5碼）： " & bank_num2, "物流資訊")

                                   ElseIf 付款狀態.Text = "付款狀態：已付款" Then
                                       MessageBox.Show("該筆訂單已付款", "已付款")
                                   End If
                               End Sub
    End Sub

    Private Sub btnReturn_Click(sender As Object, e As EventArgs)
        Me.Close()
        Dim 主畫面Form As New 主畫面()
        主畫面Form.Show()
    End Sub
End Class
