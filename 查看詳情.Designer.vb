<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class 查看詳情
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(查看詳情))
        Back = New Button()
        Button1 = New Button()
        SuspendLayout()
        ' 
        ' Back
        ' 
        Back.AutoSizeMode = AutoSizeMode.GrowAndShrink
        Back.BackColor = Color.FromArgb(CByte(240), CByte(243), CByte(251))
        Back.Image = CType(resources.GetObject("Back.Image"), Image)
        Back.Location = New Point(169, -132)
        Back.Margin = New Padding(2)
        Back.Name = "Back"
        Back.Size = New Size(43, 35)
        Back.TabIndex = 43
        Back.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.AutoSizeMode = AutoSizeMode.GrowAndShrink
        Button1.BackColor = Color.FromArgb(CByte(240), CByte(243), CByte(251))
        Button1.Image = CType(resources.GetObject("Button1.Image"), Image)
        Button1.Location = New Point(28, 39)
        Button1.Margin = New Padding(2)
        Button1.Name = "Button1"
        Button1.Size = New Size(44, 36)
        Button1.TabIndex = 44
        Button1.UseVisualStyleBackColor = False
        ' 
        ' 查看詳情
        ' 
        AutoScaleDimensions = New SizeF(9F, 19F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(370, 701)
        Controls.Add(Button1)
        Controls.Add(Back)
        Margin = New Padding(2)
        Name = "查看詳情"
        StartPosition = FormStartPosition.CenterScreen
        Text = "查看詳情"
        ResumeLayout(False)
    End Sub
    Friend WithEvents Back As Button
    Friend WithEvents Button1 As Button
End Class
