<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class 主畫面
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(主畫面))
        PictureBox1 = New PictureBox()
        button1 = New Button()
        訂單確認 = New Button()
        物流追蹤 = New Button()
        付款確認 = New Button()
        PictureBox2 = New PictureBox()
        PictureBox3 = New PictureBox()
        PictureBox4 = New PictureBox()
        PictureBox5 = New PictureBox()
        Back = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Azure
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(0, 1)
        PictureBox1.Margin = New Padding(2)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(371, 704)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' button1
        ' 
        button1.Image = CType(resources.GetObject("button1.Image"), Image)
        button1.Location = New Point(29, 259)
        button1.Margin = New Padding(2)
        button1.Name = "button1"
        button1.Size = New Size(119, 41)
        button1.TabIndex = 1
        button1.UseVisualStyleBackColor = True
        ' 
        ' 訂單確認
        ' 
        訂單確認.Image = CType(resources.GetObject("訂單確認.Image"), Image)
        訂單確認.Location = New Point(194, 259)
        訂單確認.Margin = New Padding(2)
        訂單確認.Name = "訂單確認"
        訂單確認.Size = New Size(119, 41)
        訂單確認.TabIndex = 2
        訂單確認.UseVisualStyleBackColor = True
        ' 
        ' 物流追蹤
        ' 
        物流追蹤.Image = CType(resources.GetObject("物流追蹤.Image"), Image)
        物流追蹤.Location = New Point(29, 380)
        物流追蹤.Margin = New Padding(2)
        物流追蹤.Name = "物流追蹤"
        物流追蹤.Size = New Size(119, 41)
        物流追蹤.TabIndex = 3
        物流追蹤.UseVisualStyleBackColor = True
        ' 
        ' 付款確認
        ' 
        付款確認.Image = CType(resources.GetObject("付款確認.Image"), Image)
        付款確認.Location = New Point(194, 380)
        付款確認.Margin = New Padding(2)
        付款確認.Name = "付款確認"
        付款確認.Size = New Size(119, 41)
        付款確認.TabIndex = 4
        付款確認.UseVisualStyleBackColor = True
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = SystemColors.Window
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(132, 289)
        PictureBox2.Margin = New Padding(2)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(46, 40)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 5
        PictureBox2.TabStop = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.BackColor = SystemColors.Window
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.Location = New Point(302, 289)
        PictureBox3.Margin = New Padding(2)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(46, 40)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 6
        PictureBox3.TabStop = False
        ' 
        ' PictureBox4
        ' 
        PictureBox4.BackColor = SystemColors.Window
        PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), Image)
        PictureBox4.Location = New Point(132, 411)
        PictureBox4.Margin = New Padding(2)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(46, 42)
        PictureBox4.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox4.TabIndex = 7
        PictureBox4.TabStop = False
        ' 
        ' PictureBox5
        ' 
        PictureBox5.BackColor = SystemColors.Window
        PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), Image)
        PictureBox5.Location = New Point(302, 411)
        PictureBox5.Margin = New Padding(2)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(46, 42)
        PictureBox5.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox5.TabIndex = 8
        PictureBox5.TabStop = False
        ' 
        ' Back
        ' 
        Back.AutoSizeMode = AutoSizeMode.GrowAndShrink
        Back.BackColor = Color.FromArgb(CByte(240), CByte(243), CByte(251))
        Back.Image = CType(resources.GetObject("Back.Image"), Image)
        Back.Location = New Point(29, 22)
        Back.Margin = New Padding(2)
        Back.Name = "Back"
        Back.Size = New Size(43, 35)
        Back.TabIndex = 36
        Back.UseVisualStyleBackColor = False
        ' 
        ' 主畫面
        ' 
        AutoScaleDimensions = New SizeF(9F, 19F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(370, 701)
        Controls.Add(Back)
        Controls.Add(PictureBox5)
        Controls.Add(PictureBox4)
        Controls.Add(PictureBox3)
        Controls.Add(PictureBox2)
        Controls.Add(付款確認)
        Controls.Add(物流追蹤)
        Controls.Add(訂單確認)
        Controls.Add(button1)
        Controls.Add(PictureBox1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Margin = New Padding(2)
        Name = "主畫面"
        StartPosition = FormStartPosition.CenterScreen
        Text = "主畫面"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents button1 As Button
    Friend WithEvents 訂單確認 As Button
    Friend WithEvents 物流追蹤 As Button
    Friend WithEvents 付款確認 As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents Back As Button
End Class
