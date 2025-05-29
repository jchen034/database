<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class 註冊
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    '為 Windows Form 設計工具的必要項
    Private components As System.ComponentModel.IContainer

    '注意: 以下為 Windows Form 設計工具所需的程序
    '可以使用 Windows Form 設計工具進行修改。
    '請勿使用程式碼編輯器進行修改。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(註冊))
        PictureBox1 = New PictureBox()
        Back = New Button()
        創建帳戶 = New Button()
        Label1 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        顧客姓名 = New TextBox()
        Panel2 = New Panel()
        手機號碼 = New TextBox()
        Panel1 = New Panel()
        密碼 = New TextBox()
        Panel5 = New Panel()
        確認密碼 = New TextBox()
        Panel3 = New Panel()
        收貨地址 = New TextBox()
        Panel4 = New Panel()
        PictureBox2 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        Panel1.SuspendLayout()
        Panel5.SuspendLayout()
        Panel3.SuspendLayout()
        Panel4.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(0, 0)
        PictureBox1.Margin = New Padding(2, 2, 2, 2)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(371, 704)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Back
        ' 
        Back.AutoSizeMode = AutoSizeMode.GrowAndShrink
        Back.BackColor = Color.FromArgb(CByte(240), CByte(243), CByte(251))
        Back.Image = CType(resources.GetObject("Back.Image"), Image)
        Back.Location = New Point(31, 28)
        Back.Margin = New Padding(2, 2, 2, 2)
        Back.Name = "Back"
        Back.Size = New Size(43, 35)
        Back.TabIndex = 25
        Back.UseVisualStyleBackColor = False
        ' 
        ' 創建帳戶
        ' 
        創建帳戶.BackgroundImage = CType(resources.GetObject("創建帳戶.BackgroundImage"), Image)
        創建帳戶.BackgroundImageLayout = ImageLayout.Zoom
        創建帳戶.ForeColor = SystemColors.ControlText
        創建帳戶.Location = New Point(19, 614)
        創建帳戶.Margin = New Padding(2, 2, 2, 2)
        創建帳戶.Name = "創建帳戶"
        創建帳戶.Size = New Size(341, 56)
        創建帳戶.TabIndex = 33
        創建帳戶.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = SystemColors.ButtonHighlight
        Label1.Font = New Font("Microsoft JhengHei UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(31, 313)
        Label1.Margin = New Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(78, 22)
        Label1.TabIndex = 34
        Label1.Text = "顧客姓名"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = SystemColors.ButtonHighlight
        Label5.Font = New Font("Microsoft JhengHei UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.Location = New Point(31, 555)
        Label5.Margin = New Padding(2, 0, 2, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(78, 22)
        Label5.TabIndex = 38
        Label5.Text = "收貨地址"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = SystemColors.ButtonHighlight
        Label4.Font = New Font("Microsoft JhengHei UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(31, 496)
        Label4.Margin = New Padding(2, 0, 2, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(78, 22)
        Label4.TabIndex = 37
        Label4.Text = "確認密碼"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = SystemColors.ButtonHighlight
        Label3.Font = New Font("Microsoft JhengHei UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(31, 436)
        Label3.Margin = New Padding(2, 0, 2, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(114, 22)
        Label3.TabIndex = 36
        Label3.Text = "密碼(6~12位)"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = SystemColors.ButtonHighlight
        Label2.Font = New Font("Microsoft JhengHei UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(31, 374)
        Label2.Margin = New Padding(2, 0, 2, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(78, 22)
        Label2.TabIndex = 35
        Label2.Text = "手機號碼"
        ' 
        ' 顧客姓名
        ' 
        顧客姓名.BorderStyle = BorderStyle.FixedSingle
        顧客姓名.Location = New Point(1, 1)
        顧客姓名.Margin = New Padding(2, 2, 2, 2)
        顧客姓名.Name = "顧客姓名"
        顧客姓名.Size = New Size(234, 27)
        顧客姓名.TabIndex = 13
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(手機號碼)
        Panel2.Location = New Point(104, 373)
        Panel2.Margin = New Padding(2, 2, 2, 2)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(236, 26)
        Panel2.TabIndex = 40
        ' 
        ' 手機號碼
        ' 
        手機號碼.BorderStyle = BorderStyle.FixedSingle
        手機號碼.Location = New Point(1, 1)
        手機號碼.Margin = New Padding(2, 2, 2, 2)
        手機號碼.Name = "手機號碼"
        手機號碼.Size = New Size(234, 27)
        手機號碼.TabIndex = 13
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(顧客姓名)
        Panel1.Location = New Point(105, 311)
        Panel1.Margin = New Padding(2, 2, 2, 2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(236, 26)
        Panel1.TabIndex = 39
        ' 
        ' 密碼
        ' 
        密碼.BorderStyle = BorderStyle.FixedSingle
        密碼.Location = New Point(1, 1)
        密碼.Margin = New Padding(2, 2, 2, 2)
        密碼.Name = "密碼"
        密碼.Size = New Size(199, 27)
        密碼.TabIndex = 29
        ' 
        ' Panel5
        ' 
        Panel5.Controls.Add(密碼)
        Panel5.Location = New Point(140, 436)
        Panel5.Margin = New Padding(2, 2, 2, 2)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(200, 26)
        Panel5.TabIndex = 43
        ' 
        ' 確認密碼
        ' 
        確認密碼.BorderStyle = BorderStyle.FixedSingle
        確認密碼.Enabled = False
        確認密碼.Location = New Point(1, 1)
        確認密碼.Margin = New Padding(2, 2, 2, 2)
        確認密碼.Name = "確認密碼"
        確認密碼.Size = New Size(234, 27)
        確認密碼.TabIndex = 13
        ' 
        ' Panel3
        ' 
        Panel3.Controls.Add(確認密碼)
        Panel3.Location = New Point(106, 495)
        Panel3.Margin = New Padding(2, 2, 2, 2)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(236, 26)
        Panel3.TabIndex = 41
        ' 
        ' 收貨地址
        ' 
        收貨地址.BorderStyle = BorderStyle.FixedSingle
        收貨地址.Location = New Point(1, 1)
        收貨地址.Margin = New Padding(2, 2, 2, 2)
        收貨地址.Name = "收貨地址"
        收貨地址.Size = New Size(234, 27)
        收貨地址.TabIndex = 13
        ' 
        ' Panel4
        ' 
        Panel4.Controls.Add(收貨地址)
        Panel4.Location = New Point(106, 553)
        Panel4.Margin = New Padding(2, 2, 2, 2)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(236, 26)
        Panel4.TabIndex = 42
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.Transparent
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(254, 0)
        PictureBox2.Margin = New Padding(2, 2, 2, 2)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(117, 111)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 44
        PictureBox2.TabStop = False
        ' 
        ' 註冊
        ' 
        AutoScaleDimensions = New SizeF(9F, 19F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(370, 701)
        Controls.Add(PictureBox2)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Controls.Add(Panel5)
        Controls.Add(Panel3)
        Controls.Add(Panel4)
        Controls.Add(Label1)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(創建帳戶)
        Controls.Add(Back)
        Controls.Add(PictureBox1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Margin = New Padding(2, 2, 2, 2)
        Name = "註冊"
        StartPosition = FormStartPosition.CenterScreen
        Text = "註冊"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel5.ResumeLayout(False)
        Panel5.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Back As Button
    Friend WithEvents 創建帳戶 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents 顧客姓名 As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents 手機號碼 As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents 密碼 As TextBox
    Friend WithEvents Panel5 As Panel
    Friend WithEvents 確認密碼 As TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents 收貨地址 As TextBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents PictureBox2 As PictureBox
End Class
