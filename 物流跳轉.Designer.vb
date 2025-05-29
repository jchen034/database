<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class 物流跳轉
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(物流跳轉))
        Back = New Button()
        SuspendLayout()
        ' 
        ' Back
        ' 
        Back.AutoSizeMode = AutoSizeMode.GrowAndShrink
        Back.BackColor = Color.FromArgb(CByte(240), CByte(243), CByte(251))
        Back.Image = CType(resources.GetObject("Back.Image"), Image)
        Back.Location = New Point(20, 39)
        Back.Margin = New Padding(2)
        Back.Name = "Back"
        Back.Size = New Size(43, 35)
        Back.TabIndex = 36
        Back.UseVisualStyleBackColor = False
        ' 
        ' 物流跳轉
        ' 
        AutoScaleDimensions = New SizeF(9F, 19F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(370, 701)
        Controls.Add(Back)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Margin = New Padding(2)
        Name = "物流跳轉"
        StartPosition = FormStartPosition.CenterScreen
        Text = "物流跳轉"
        ResumeLayout(False)
    End Sub

    Friend WithEvents Back As Button
End Class
