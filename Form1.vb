Imports System.IO
Imports System.Drawing
Imports System.Drawing.Imaging
Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim inputDirectory As String = txtInputDirectory.Text.Trim()
        Dim outputDirectory As String = txtOutputDirectory.Text.Trim()

        ' 保存当前填写的目录值到应用程序设置
        My.Settings.InputDirectory = txtInputDirectory.Text.Trim()
        My.Settings.OutputDirectory = txtOutputDirectory.Text.Trim()
        My.Settings.qualityPercentage = trackBarQuality.Value
        My.Settings.Save()

        ' 检查输入目录是否存在
        If Not Directory.Exists(inputDirectory) Then
            MessageBox.Show("输入目录不存在。")
            Return
        End If

        ' 检查输出目录是否存在，如果不存在则创建
        If Not Directory.Exists(outputDirectory) Then
            Directory.CreateDirectory(outputDirectory)
        End If

        ' 获取输入目录下的所有BMP文件
        Dim bmpFiles As String() = Directory.GetFiles(inputDirectory, "*.bmp")

        ' 显示进度条
        ProgressBar1.Minimum = 0
        ProgressBar1.Maximum = bmpFiles.Length
        ProgressBar1.Value = 0
        ProgressBar1.Visible = True
        lblProgress.Visible = True

        Dim qualityPercentage As Integer = trackBarQuality.Value

        ' 启动后台任务
        Task.Run(Sub()
                     For i As Integer = 0 To bmpFiles.Length - 1
                         Dim bmpFile As String = bmpFiles(i)
                         Dim outputFileName As String = Path.GetFileNameWithoutExtension(bmpFile) & ".jpg"
                         Dim outputPath As String = Path.Combine(outputDirectory, outputFileName)

                         Using bmp As New Bitmap(bmpFile)
                             ' 设置JPEG质量
                             Dim encoderParams As New EncoderParameters(1)
                             Dim encoderParam As New EncoderParameter(Encoder.Quality, qualityPercentage)
                             encoderParams.Param(0) = encoderParam

                             ' 获取JPEG编码器
                             Dim jpegCodecInfo As ImageCodecInfo = ImageCodecInfo.GetImageEncoders().FirstOrDefault(Function(codec) codec.FormatID = ImageFormat.Jpeg.Guid)

                             ' 保存图像为JPEG
                             bmp.Save(outputPath, jpegCodecInfo, encoderParams)
                         End Using


                         ' 更新进度条和已完成比例
                         Dim progress As Double = (i + 1) / bmpFiles.Length * 100
                         Me.Invoke(Sub()
                                       ProgressBar1.Value = i + 1
                                       lblProgress.Text = $"已完成: {progress:F2}%"
                                   End Sub)
                     Next

                     ' 使用委托在任务完成后执行指定的操作
                     Me.Invoke(Sub()
                                   ProgressBar1.Visible = False
                                   lblProgress.Visible = False
                                   MessageBox.Show("转换完成。")
                               End Sub)
                 End Sub)
    End Sub
    Private Function GetEncoderInfo(format As ImageFormat) As ImageCodecInfo
        Dim codecs As ImageCodecInfo() = ImageCodecInfo.GetImageEncoders()
        For Each codec As ImageCodecInfo In codecs
            If codec.FormatID = format.Guid Then
                Return codec
            End If
        Next
        Return Nothing
    End Function

    ' 质量调节滑动条值改变事件
    Private Sub trackBarQuality_ValueChanged(sender As Object, e As EventArgs) Handles trackBarQuality.ValueChanged
        lblQuality.Text = $"Quality: {trackBarQuality.Value}%"
    End Sub

    ' 窗体加载事件
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        trackBarQuality.Minimum = 30
        trackBarQuality.Maximum = 100
        trackBarQuality.Value = My.Settings.qualityPercentage
        lblQuality.Text = $"Quality: {trackBarQuality.Value}%"

        lblProgress.BackColor = Color.Transparent

        ' 检查并设置输入目录的初始值
        If Not String.IsNullOrEmpty(My.Settings.InputDirectory) Then
            txtInputDirectory.Text = My.Settings.InputDirectory
        End If

        ' 检查并设置输出目录的初始值
        If Not String.IsNullOrEmpty(My.Settings.OutputDirectory) Then
            txtOutputDirectory.Text = My.Settings.OutputDirectory
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' 获取输入目录和输出目录
        Dim inputDirectory As String = txtInputDirectory.Text.Trim()
        Dim outputDirectory As String = txtOutputDirectory.Text.Trim()

        ' 检查输入目录是否存在
        If Not Directory.Exists(inputDirectory) Then
            MessageBox.Show("输入目录不存在。")
            Return
        End If

        ' 检查输出目录是否存在，如果不存在则创建
        If Not Directory.Exists(outputDirectory) Then
            Directory.CreateDirectory(outputDirectory)
        End If

        ' 获取选定的裁剪区域
        Dim x As Integer = CInt(txtCropX.Text.Trim())
        Dim y As Integer = CInt(txtCropY.Text.Trim())
        Dim width As Integer = CInt(txtCropWidth.Text.Trim())
        Dim height As Integer = CInt(txtCropHeight.Text.Trim())

        ' 获取输入目录下的所有BMP文件
        'Dim imageFiles As String() = Directory.GetFiles(inputDirectory, "*.*").Where(Function(file) file.ToLower().EndsWith(".jpg") OrElse file.ToLower().EndsWith(".png") OrElse file.ToLower().EndsWith(".bmp")).ToArray()
        Dim bmpFiles As String() = Directory.GetFiles(inputDirectory, "*.bmp")

        ' 显示进度条
        ProgressBar1.Minimum = 0
        ProgressBar1.Maximum = bmpFiles.Length
        ProgressBar1.Value = 0
        ProgressBar1.Visible = True
        lblProgress.Visible = True

        ' 启动后台任务
        Task.Run(Sub()
                     For i As Integer = 0 To bmpFiles.Length - 1
                         Dim bmpFile As String = bmpFiles(i)
                         Dim outputFileName As String = Path.GetFileNameWithoutExtension(bmpFile) & "_cropped.bmp"
                         Dim outputPath As String = Path.Combine(outputDirectory, outputFileName)

                         Using bmp As New Bitmap(bmpFile)
                             ' 创建一个新的Bitmap对象，用于存储裁剪后的图像
                             Dim croppedBmp As New Bitmap(width, height)

                             ' 创建Graphics对象，并将其绘制到裁剪后的图像上
                             Using g As Graphics = Graphics.FromImage(croppedBmp)
                                 g.DrawImage(bmp, New Rectangle(0, 0, width, height), New Rectangle(x, y, width, height), GraphicsUnit.Pixel)
                             End Using

                             ' 保存裁剪后的图像为BMP格式
                             croppedBmp.Save(outputPath, ImageFormat.Bmp)
                         End Using


                         ' 更新进度条和已完成比例
                         Dim progress As Double = (i + 1) / bmpFiles.Length * 100
                         Me.Invoke(Sub()
                                       ProgressBar1.Value = i + 1
                                       lblProgress.Text = $"已完成: {progress:F2}%"
                                   End Sub)
                     Next

                     ' 使用委托在任务完成后执行指定的操作
                     Me.Invoke(Sub()
                                   ProgressBar1.Visible = False
                                   MessageBox.Show("裁剪完成。")
                               End Sub)
                 End Sub)
    End Sub
End Class
