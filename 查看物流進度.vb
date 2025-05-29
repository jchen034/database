Imports System.IO
Imports System.Threading

Public Class 查看物流進度
    Private pictureBoxes As List(Of PictureBox)
    Private timer As Timer
    Private backgroundImagePath As String = "C:\Users\joann\OneDrive\桌面\集貨樂章\物流追蹤進度.jpg" ' 背景圖片的路徑
    Private foregroundImagePath1 As String = "C:\Users\joann\OneDrive\桌面\集貨樂章\Ellipse.png" ' 第一個前景圖片的路徑(淺的點點)
    Private foregroundImagePath2 As String = "C:\Users\joann\OneDrive\桌面\集貨樂章\Ellipsed.png" ' 第二個前景圖片的路徑(深的點點)
    Private timeLabel As Label ' 顯示當前時間的標籤
    Private currentIndex As Integer = 0 ' 目前顯示的前景圖片索引

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' 設定背景圖片
        If File.Exists(backgroundImagePath) Then
            Me.BackgroundImage = Image.FromFile(backgroundImagePath)
            Me.BackgroundImageLayout = ImageLayout.Stretch ' 將背景圖片拉伸以符合視窗大小
        Else
            MessageBox.Show("找不到背景圖片！")
        End If

        ' 建立 PictureBox
        pictureBoxes = New List(Of PictureBox)()

        For i As Integer = 0 To 6
            Dim pictureBox As New PictureBox()
            pictureBox.Width = 25
            pictureBox.Height = 25
            pictureBox.Location = New Point(133, 135 + (i * 67)) ' 垂直排列，間隔為67像素
            Me.Controls.Add(pictureBox)
            pictureBoxes.Add(pictureBox)
        Next

        ' 顯示前景圖片一
        For i As Integer = 0 To 6
            SetPictureBoxImage(pictureBoxes(i), foregroundImagePath1)
        Next

        ' 設定計時器
        timer = New Timer(AddressOf TimerTick, Nothing, 5000, 5000) ' 5秒後觸發 TimerTick，之後每隔5秒觸發一次
    End Sub

    Private Sub TimerTick(state As Object)
        ' 顯示前景圖片二
        If currentIndex < pictureBoxes.Count Then
            Me.Invoke(Sub() SetPictureBoxImage(pictureBoxes(currentIndex), foregroundImagePath2))
            currentIndex += 1
        Else
            ' 所有前景圖片二都已顯示完畢，停止計時器
            timer.Dispose()
        End If

        ' 更新時間標籤的內容
        Me.Invoke(Sub()
                      Dim timeTextLabel As New Label()
                      timeTextLabel.Font = New Font("Arial", 9, FontStyle.Regular)
                      timeTextLabel.ForeColor = Color.Black
                      timeTextLabel.AutoSize = True
                      timeTextLabel.BackColor = Color.Transparent
                      timeTextLabel.Text = DateTime.Now.ToString("MM/dd") & vbCrLf & DateTime.Now.ToString("HH:mm:ss")
                      timeTextLabel.Location = New Point(pictureBoxes(currentIndex - 1).Left - 100, pictureBoxes(currentIndex - 1).Top - 8)
                      Me.Controls.Add(timeTextLabel)
                  End Sub)
    End Sub

    Private Sub SetPictureBoxImage(pictureBox As PictureBox, path As String)
        If File.Exists(path) Then
            Me.Invoke(Sub() pictureBox.Image = Image.FromFile(path))
        End If
    End Sub

    Private Sub GoToMainForm()
        主畫面.Show() ' 顯示初始介面的表單
        Me.Hide() ' 關閉當前表單
    End Sub

    Private Sub Back_Click(sender As Object, e As EventArgs) Handles Back.Click
        Me.Hide()
        Dim 物流跳轉Form As New 物流跳轉()
        物流跳轉Form.ShowDialog()
    End Sub

    Protected Overrides Sub OnFormClosing(e As FormClosingEventArgs)
        MyBase.OnFormClosing(e)
        If e.CloseReason = CloseReason.UserClosing Then
            GoToMainForm()
        End If
    End Sub
End Class
