<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class 新增訂單msgbox
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(新增訂單msgbox))
        X = New Button()
        確認 = New Button()
        Label4 = New Label()
        Label6 = New Label()
        Label3 = New Label()
        Label5 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' X
        ' 
        X.FlatAppearance.BorderSize = 0
        X.FlatStyle = FlatStyle.Flat
        X.Location = New Point(450, 27)
        X.Margin = New Padding(5)
        X.Name = "X"
        X.Size = New Size(47, 46)
        X.TabIndex = 22
        X.Text = "X"
        X.UseVisualStyleBackColor = True
        ' 
        ' 確認
        ' 
        確認.BackColor = Color.Transparent
        確認.BackgroundImage = CType(resources.GetObject("確認.BackgroundImage"), Image)
        確認.FlatAppearance.BorderSize = 0
        確認.FlatStyle = FlatStyle.Popup
        確認.Location = New Point(103, 486)
        確認.Margin = New Padding(5)
        確認.Name = "確認"
        確認.Size = New Size(278, 52)
        確認.TabIndex = 21
        確認.UseVisualStyleBackColor = False
        ' 
        ' Label4
        ' 
        Label4.BackColor = Color.Gainsboro
        Label4.Font = New Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(166, 132)
        Label4.Margin = New Padding(5, 0, 5, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(311, 35)
        Label4.TabIndex = 18
        Label4.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label6
        ' 
        Label6.BackColor = Color.Gainsboro
        Label6.Font = New Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label6.Location = New Point(166, 291)
        Label6.Margin = New Padding(5, 0, 5, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(311, 156)
        Label6.TabIndex = 20
        ' 
        ' Label3
        ' 
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(23, 291)
        Label3.Margin = New Padding(5, 0, 5, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(121, 35)
        Label3.TabIndex = 16
        Label3.Text = "備註:"
        Label3.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Label5
        ' 
        Label5.BackColor = Color.Gainsboro
        Label5.Font = New Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.Location = New Point(166, 210)
        Label5.Margin = New Padding(5, 0, 5, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(311, 35)
        Label5.TabIndex = 19
        Label5.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label2
        ' 
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(35, 210)
        Label2.Margin = New Padding(5, 0, 5, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(121, 35)
        Label2.TabIndex = 15
        Label2.Text = "訂單品名:"
        Label2.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label1
        ' 
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(35, 132)
        Label1.Margin = New Padding(5, 0, 5, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(121, 35)
        Label1.TabIndex = 17
        Label1.Text = "訂單編號:"
        Label1.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' 新增訂單msgbox
        ' 
        AutoScaleDimensions = New SizeF(11F, 23F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(520, 561)
        Controls.Add(X)
        Controls.Add(確認)
        Controls.Add(Label4)
        Controls.Add(Label6)
        Controls.Add(Label3)
        Controls.Add(Label5)
        Controls.Add(Label2)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.None
        Name = "新增訂單msgbox"
        StartPosition = FormStartPosition.CenterScreen
        Text = "新增訂單msgbox"
        ResumeLayout(False)
    End Sub

    Friend WithEvents X As Button
    Friend WithEvents 確認 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
