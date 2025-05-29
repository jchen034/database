<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class 物流整合
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(物流整合))
        RadioButtonAir = New RadioButton()
        RadioButtonSea = New RadioButton()
        PictureBox2 = New PictureBox()
        TextBox2 = New TextBox()
        RichTextBox1 = New RichTextBox()
        Back = New Button()
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        Label2 = New Label()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' RadioButtonAir
        ' 
        RadioButtonAir.AutoSize = True
        RadioButtonAir.Location = New Point(245, 572)
        RadioButtonAir.Margin = New Padding(2)
        RadioButtonAir.Name = "RadioButtonAir"
        RadioButtonAir.Size = New Size(60, 23)
        RadioButtonAir.TabIndex = 41
        RadioButtonAir.TabStop = True
        RadioButtonAir.Text = "空運"
        RadioButtonAir.UseVisualStyleBackColor = True
        ' 
        ' RadioButtonSea
        ' 
        RadioButtonSea.AutoSize = True
        RadioButtonSea.FlatStyle = FlatStyle.System
        RadioButtonSea.Location = New Point(66, 572)
        RadioButtonSea.Margin = New Padding(2)
        RadioButtonSea.Name = "RadioButtonSea"
        RadioButtonSea.Size = New Size(69, 24)
        RadioButtonSea.TabIndex = 40
        RadioButtonSea.TabStop = True
        RadioButtonSea.Text = "海運"
        RadioButtonSea.UseVisualStyleBackColor = True
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(17, 617)
        PictureBox2.Margin = New Padding(2)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(344, 48)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 39
        PictureBox2.TabStop = False
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(30, 460)
        TextBox2.Margin = New Padding(2)
        TextBox2.Multiline = True
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(311, 98)
        TextBox2.TabIndex = 38
        ' 
        ' RichTextBox1
        ' 
        RichTextBox1.Location = New Point(30, 272)
        RichTextBox1.Margin = New Padding(2)
        RichTextBox1.Name = "RichTextBox1"
        RichTextBox1.Size = New Size(311, 177)
        RichTextBox1.TabIndex = 37
        RichTextBox1.Text = ""
        ' 
        ' Back
        ' 
        Back.AutoSizeMode = AutoSizeMode.GrowAndShrink
        Back.BackColor = Color.FromArgb(CByte(240), CByte(243), CByte(251))
        Back.Image = CType(resources.GetObject("Back.Image"), Image)
        Back.Location = New Point(30, 29)
        Back.Margin = New Padding(2)
        Back.Name = "Back"
        Back.Size = New Size(43, 35)
        Back.TabIndex = 35
        Back.UseVisualStyleBackColor = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(0, -1)
        PictureBox1.Margin = New Padding(2)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(371, 704)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 34
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(53, 121)
        Label1.Margin = New Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(0, 19)
        Label1.TabIndex = 43
        Label1.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Location = New Point(30, 236)
        Label2.Margin = New Padding(2, 0, 2, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(72, 19)
        Label2.TabIndex = 44
        Label2.Text = "訂單資料:"
        ' 
        ' 物流整合
        ' 
        AutoScaleDimensions = New SizeF(9F, 19F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(370, 701)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(RadioButtonAir)
        Controls.Add(RadioButtonSea)
        Controls.Add(PictureBox2)
        Controls.Add(TextBox2)
        Controls.Add(RichTextBox1)
        Controls.Add(Back)
        Controls.Add(PictureBox1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Margin = New Padding(2)
        Name = "物流整合"
        StartPosition = FormStartPosition.CenterScreen
        Text = "物流整合"
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents RadioButtonAir As RadioButton
    Friend WithEvents RadioButtonSea As RadioButton
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents Back As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
