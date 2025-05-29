<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class 訂單確認
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(訂單確認))
        PictureBox1 = New PictureBox()
        Back = New Button()
        新增訂單 = New Button()
        查詢訂單 = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(-1, -1)
        PictureBox1.Margin = New Padding(2)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(375, 704)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Back
        ' 
        Back.AutoSizeMode = AutoSizeMode.GrowAndShrink
        Back.BackColor = Color.FromArgb(CByte(240), CByte(243), CByte(251))
        Back.Image = CType(resources.GetObject("Back.Image"), Image)
        Back.Location = New Point(29, 29)
        Back.Margin = New Padding(2)
        Back.Name = "Back"
        Back.Size = New Size(43, 35)
        Back.TabIndex = 26
        Back.UseVisualStyleBackColor = False
        ' 
        ' 新增訂單
        ' 
        新增訂單.BackgroundImage = CType(resources.GetObject("新增訂單.BackgroundImage"), Image)
        新增訂單.BackgroundImageLayout = ImageLayout.Zoom
        新增訂單.ForeColor = SystemColors.ControlText
        新增訂單.Location = New Point(76, 251)
        新增訂單.Margin = New Padding(2)
        新增訂單.Name = "新增訂單"
        新增訂單.Size = New Size(223, 59)
        新增訂單.TabIndex = 27
        新增訂單.UseVisualStyleBackColor = True
        ' 
        ' 查詢訂單
        ' 
        查詢訂單.BackgroundImage = CType(resources.GetObject("查詢訂單.BackgroundImage"), Image)
        查詢訂單.BackgroundImageLayout = ImageLayout.Zoom
        查詢訂單.ForeColor = SystemColors.ControlText
        查詢訂單.Location = New Point(76, 353)
        查詢訂單.Margin = New Padding(2)
        查詢訂單.Name = "查詢訂單"
        查詢訂單.Size = New Size(223, 59)
        查詢訂單.TabIndex = 28
        查詢訂單.UseVisualStyleBackColor = True
        ' 
        ' 訂單確認
        ' 
        AutoScaleDimensions = New SizeF(9F, 19F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(370, 701)
        Controls.Add(查詢訂單)
        Controls.Add(新增訂單)
        Controls.Add(Back)
        Controls.Add(PictureBox1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Margin = New Padding(2)
        Name = "訂單確認"
        StartPosition = FormStartPosition.CenterScreen
        Text = "訂單確認"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Back As Button
    Friend WithEvents 新增訂單 As Button
    Friend WithEvents 查詢訂單 As Button
End Class
