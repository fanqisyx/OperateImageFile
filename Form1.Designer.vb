<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtInputDirectory = New System.Windows.Forms.TextBox()
        Me.txtOutputDirectory = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.trackBarQuality = New System.Windows.Forms.TrackBar()
        Me.lblQuality = New System.Windows.Forms.Label()
        Me.lblProgress = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtCropX = New System.Windows.Forms.TextBox()
        Me.txtCropY = New System.Windows.Forms.TextBox()
        Me.txtCropWidth = New System.Windows.Forms.TextBox()
        Me.txtCropHeight = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        CType(Me.trackBarQuality, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtInputDirectory
        '
        Me.txtInputDirectory.Location = New System.Drawing.Point(88, 12)
        Me.txtInputDirectory.Name = "txtInputDirectory"
        Me.txtInputDirectory.Size = New System.Drawing.Size(621, 21)
        Me.txtInputDirectory.TabIndex = 0
        '
        'txtOutputDirectory
        '
        Me.txtOutputDirectory.Location = New System.Drawing.Point(88, 40)
        Me.txtOutputDirectory.Name = "txtOutputDirectory"
        Me.txtOutputDirectory.Size = New System.Drawing.Size(621, 21)
        Me.txtOutputDirectory.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(613, 31)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(96, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "BMP 转 JPG"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(88, 68)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(621, 23)
        Me.ProgressBar1.TabIndex = 3
        Me.ProgressBar1.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 12)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "原图像目录"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(5, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 12)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "目标图像目录"
        '
        'trackBarQuality
        '
        Me.trackBarQuality.Location = New System.Drawing.Point(19, 20)
        Me.trackBarQuality.Name = "trackBarQuality"
        Me.trackBarQuality.Size = New System.Drawing.Size(401, 45)
        Me.trackBarQuality.TabIndex = 6
        '
        'lblQuality
        '
        Me.lblQuality.AutoSize = True
        Me.lblQuality.Location = New System.Drawing.Point(427, 36)
        Me.lblQuality.Name = "lblQuality"
        Me.lblQuality.Size = New System.Drawing.Size(41, 12)
        Me.lblQuality.TabIndex = 7
        Me.lblQuality.Text = "Label3"
        '
        'lblProgress
        '
        Me.lblProgress.AutoSize = True
        Me.lblProgress.Location = New System.Drawing.Point(360, 74)
        Me.lblProgress.Name = "lblProgress"
        Me.lblProgress.Size = New System.Drawing.Size(41, 12)
        Me.lblProgress.TabIndex = 8
        Me.lblProgress.Text = "Label3"
        Me.lblProgress.Visible = False
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(613, 40)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(96, 23)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "BMP图形裁剪"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(713, 76)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "图像裁切"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtCropHeight)
        Me.GroupBox2.Controls.Add(Me.txtCropWidth)
        Me.GroupBox2.Controls.Add(Me.txtCropY)
        Me.GroupBox2.Controls.Add(Me.txtCropX)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Left
        Me.GroupBox2.Location = New System.Drawing.Point(3, 17)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(515, 56)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "裁切区域"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 29)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 12)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "起始X"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(132, 29)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 12)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "起始Y"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(382, 29)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 12)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "图像高"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(254, 29)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 12)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "图形宽"
        '
        'txtCropX
        '
        Me.txtCropX.Location = New System.Drawing.Point(51, 25)
        Me.txtCropX.Name = "txtCropX"
        Me.txtCropX.Size = New System.Drawing.Size(75, 21)
        Me.txtCropX.TabIndex = 4
        Me.txtCropX.Text = "0"
        '
        'txtCropY
        '
        Me.txtCropY.Location = New System.Drawing.Point(173, 25)
        Me.txtCropY.Name = "txtCropY"
        Me.txtCropY.Size = New System.Drawing.Size(75, 21)
        Me.txtCropY.TabIndex = 5
        Me.txtCropY.Text = "0"
        '
        'txtCropWidth
        '
        Me.txtCropWidth.Location = New System.Drawing.Point(301, 25)
        Me.txtCropWidth.Name = "txtCropWidth"
        Me.txtCropWidth.Size = New System.Drawing.Size(75, 21)
        Me.txtCropWidth.TabIndex = 6
        Me.txtCropWidth.Text = "640"
        '
        'txtCropHeight
        '
        Me.txtCropHeight.Location = New System.Drawing.Point(429, 25)
        Me.txtCropHeight.Name = "txtCropHeight"
        Me.txtCropHeight.Size = New System.Drawing.Size(75, 21)
        Me.txtCropHeight.TabIndex = 7
        Me.txtCropHeight.Text = "480"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox3.Controls.Add(Me.trackBarQuality)
        Me.GroupBox3.Controls.Add(Me.Button1)
        Me.GroupBox3.Controls.Add(Me.lblQuality)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox3.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(713, 76)
        Me.GroupBox3.TabIndex = 11
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "BMP转JPG"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TabControl1.Location = New System.Drawing.Point(0, 104)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(727, 108)
        Me.TabControl1.TabIndex = 12
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GroupBox3)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(719, 82)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "BMP转JPG"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.GroupBox1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(719, 82)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "图像裁切"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(727, 212)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.lblProgress)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.txtOutputDirectory)
        Me.Controls.Add(Me.txtInputDirectory)
        Me.Name = "Form1"
        Me.Text = "图像简单处理工具箱"
        CType(Me.trackBarQuality, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtInputDirectory As TextBox
    Friend WithEvents txtOutputDirectory As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents trackBarQuality As TrackBar
    Friend WithEvents lblQuality As Label
    Friend WithEvents lblProgress As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtCropHeight As TextBox
    Friend WithEvents txtCropWidth As TextBox
    Friend WithEvents txtCropY As TextBox
    Friend WithEvents txtCropX As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
End Class
