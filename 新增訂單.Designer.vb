<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class 新增訂單
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(新增訂單))
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        PictureBox3 = New PictureBox()
        PictureBox4 = New PictureBox()
        確認 = New Button()
        Back = New Button()
        備註 = New TextBox()
        訂單品名 = New TextBox()
        訂單編號 = New TextBox()
        Panel1 = New Panel()
        Panel2 = New Panel()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(-4, -3)
        PictureBox1.Margin = New Padding(4, 4, 4, 4)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(376, 707)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 4
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(43, 171)
        PictureBox2.Margin = New Padding(2, 2, 2, 2)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(101, 33)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 8
        PictureBox2.TabStop = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.Location = New Point(43, 289)
        PictureBox3.Margin = New Padding(2, 2, 2, 2)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(97, 31)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 9
        PictureBox3.TabStop = False
        ' 
        ' PictureBox4
        ' 
        PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), Image)
        PictureBox4.Location = New Point(43, 410)
        PictureBox4.Margin = New Padding(2, 2, 2, 2)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(87, 32)
        PictureBox4.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox4.TabIndex = 10
        PictureBox4.TabStop = False
        ' 
        ' 確認
        ' 
        確認.BackgroundImage = CType(resources.GetObject("確認.BackgroundImage"), Image)
        確認.BackgroundImageLayout = ImageLayout.Zoom
        確認.ForeColor = SystemColors.ControlText
        確認.Location = New Point(16, 617)
        確認.Margin = New Padding(2, 2, 2, 2)
        確認.Name = "確認"
        確認.Size = New Size(343, 56)
        確認.TabIndex = 25
        確認.UseVisualStyleBackColor = True
        ' 
        ' Back
        ' 
        Back.AutoSizeMode = AutoSizeMode.GrowAndShrink
        Back.BackColor = Color.FromArgb(CByte(240), CByte(243), CByte(251))
        Back.Image = CType(resources.GetObject("Back.Image"), Image)
        Back.Location = New Point(32, 28)
        Back.Margin = New Padding(2, 2, 2, 2)
        Back.Name = "Back"
        Back.Size = New Size(43, 35)
        Back.TabIndex = 26
        Back.UseVisualStyleBackColor = False
        ' 
        ' 備註
        ' 
        備註.Font = New Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        備註.Location = New Point(43, 443)
        備註.Margin = New Padding(4, 4, 4, 4)
        備註.Multiline = True
        備註.Name = "備註"
        備註.Size = New Size(293, 109)
        備註.TabIndex = 7
        ' 
        ' 訂單品名
        ' 
        訂單品名.Font = New Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        訂單品名.Location = New Point(1, 1)
        訂單品名.Margin = New Padding(4, 4, 4, 4)
        訂單品名.Name = "訂單品名"
        訂單品名.Size = New Size(292, 33)
        訂單品名.TabIndex = 6
        ' 
        ' 訂單編號
        ' 
        訂單編號.Font = New Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        訂單編號.Location = New Point(1, 1)
        訂單編號.Margin = New Padding(4, 4, 4, 4)
        訂單編號.Name = "訂單編號"
        訂單編號.Size = New Size(292, 33)
        訂單編號.TabIndex = 5
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(訂單編號)
        Panel1.Location = New Point(43, 204)
        Panel1.Margin = New Padding(2, 2, 2, 2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(293, 33)
        Panel1.TabIndex = 27
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(訂單品名)
        Panel2.Location = New Point(43, 319)
        Panel2.Margin = New Padding(2, 2, 2, 2)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(293, 33)
        Panel2.TabIndex = 28
        ' 
        ' 新增訂單
        ' 
        AutoScaleDimensions = New SizeF(9F, 19F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(370, 701)
        Controls.Add(備註)
        Controls.Add(Panel2)
        Controls.Add(Back)
        Controls.Add(確認)
        Controls.Add(PictureBox4)
        Controls.Add(PictureBox3)
        Controls.Add(PictureBox2)
        Controls.Add(Panel1)
        Controls.Add(PictureBox1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Margin = New Padding(2, 2, 2, 2)
        Name = "新增訂單"
        StartPosition = FormStartPosition.CenterScreen
        Text = "新增訂單"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents 確認 As Button
    Friend WithEvents Back As Button
    Friend WithEvents 備註 As TextBox
    Friend WithEvents 訂單品名 As TextBox
    Friend WithEvents 訂單編號 As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
End Class
