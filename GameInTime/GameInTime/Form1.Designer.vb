<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.UbuntuTheme1 = New GameInTime.UbuntuTheme()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.ListBox4 = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ListBox3 = New System.Windows.Forms.ListBox()
        Me.UbuntuTextBox1 = New GameInTime.UbuntuTextBox()
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.UbuntuButtonOrange1 = New GameInTime.UbuntuButtonOrange()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.UbuntuTheme1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        '
        'UbuntuTheme1
        '
        Me.UbuntuTheme1.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.UbuntuTheme1.Controls.Add(Me.ProgressBar1)
        Me.UbuntuTheme1.Controls.Add(Me.Panel3)
        Me.UbuntuTheme1.Controls.Add(Me.TabControl1)
        Me.UbuntuTheme1.Controls.Add(Me.Label1)
        Me.UbuntuTheme1.Controls.Add(Me.ListBox3)
        Me.UbuntuTheme1.Controls.Add(Me.UbuntuTextBox1)
        Me.UbuntuTheme1.Controls.Add(Me.WebBrowser1)
        Me.UbuntuTheme1.Controls.Add(Me.PictureBox1)
        Me.UbuntuTheme1.Controls.Add(Me.UbuntuButtonOrange1)
        Me.UbuntuTheme1.Controls.Add(Me.ListBox1)
        Me.UbuntuTheme1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UbuntuTheme1.Location = New System.Drawing.Point(0, 0)
        Me.UbuntuTheme1.Name = "UbuntuTheme1"
        Me.UbuntuTheme1.Size = New System.Drawing.Size(552, 470)
        Me.UbuntuTheme1.TabIndex = 0
        Me.UbuntuTheme1.Text = "UbuntuTheme1"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(318, 48)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(36, 23)
        Me.ProgressBar1.TabIndex = 7
        Me.ProgressBar1.Visible = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Silver
        Me.Panel3.Controls.Add(Me.PictureBox2)
        Me.Panel3.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Panel3.Location = New System.Drawing.Point(4, 454)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(379, 10)
        Me.Panel3.TabIndex = 19
        Me.Panel3.Visible = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Coral
        Me.PictureBox2.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(1, 10)
        Me.PictureBox2.TabIndex = 10
        Me.PictureBox2.TabStop = False
        Me.PictureBox2.Visible = False
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(0, 66)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(283, 382)
        Me.TabControl1.TabIndex = 11
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.Transparent
        Me.TabPage1.Controls.Add(Me.ListBox2)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(275, 356)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "PirateBay (top 100) Games"
        '
        'ListBox2
        '
        Me.ListBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.Location = New System.Drawing.Point(3, 3)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(269, 350)
        Me.ListBox2.TabIndex = 6
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.ListBox4)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(275, 356)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "MyFavourite Games "
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'ListBox4
        '
        Me.ListBox4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListBox4.FormattingEnabled = True
        Me.ListBox4.Items.AddRange(New Object() {"Assassins Creed II ", "Assassins Creed I", "Assassins Creed Black Flag", "The Witcher II", "GTA San Andreas ", "Far Cry 3", "Far Cry 4", "Speedrunners", "FrostPunk"})
        Me.ListBox4.Location = New System.Drawing.Point(3, 3)
        Me.ListBox4.Name = "ListBox4"
        Me.ListBox4.Size = New System.Drawing.Size(269, 350)
        Me.ListBox4.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(389, 447)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Label1"
        '
        'ListBox3
        '
        Me.ListBox3.FormattingEnabled = True
        Me.ListBox3.Location = New System.Drawing.Point(433, 145)
        Me.ListBox3.Name = "ListBox3"
        Me.ListBox3.Size = New System.Drawing.Size(74, 30)
        Me.ListBox3.TabIndex = 8
        Me.ListBox3.Visible = False
        '
        'UbuntuTextBox1
        '
        Me.UbuntuTextBox1.BackColor = System.Drawing.Color.White
        Me.UbuntuTextBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.UbuntuTextBox1.Location = New System.Drawing.Point(3, 34)
        Me.UbuntuTextBox1.MaxLength = 32767
        Me.UbuntuTextBox1.Name = "UbuntuTextBox1"
        Me.UbuntuTextBox1.Size = New System.Drawing.Size(164, 26)
        Me.UbuntuTextBox1.TabIndex = 7
        Me.UbuntuTextBox1.Text = "Search.."
        Me.UbuntuTextBox1.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left
        Me.UbuntuTextBox1.UseSystemPasswordChar = False
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Location = New System.Drawing.Point(419, 103)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(50, 26)
        Me.WebBrowser1.TabIndex = 5
        Me.WebBrowser1.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(289, 88)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(255, 356)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'UbuntuButtonOrange1
        '
        Me.UbuntuButtonOrange1.BackColor = System.Drawing.Color.Transparent
        Me.UbuntuButtonOrange1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.UbuntuButtonOrange1.Location = New System.Drawing.Point(171, 34)
        Me.UbuntuButtonOrange1.Name = "UbuntuButtonOrange1"
        Me.UbuntuButtonOrange1.Size = New System.Drawing.Size(112, 23)
        Me.UbuntuButtonOrange1.TabIndex = 2
        Me.UbuntuButtonOrange1.Text = "Install"
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(475, 112)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(21, 17)
        Me.ListBox1.TabIndex = 0
        Me.ListBox1.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(552, 470)
        Me.Controls.Add(Me.UbuntuTheme1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.UbuntuTheme1.ResumeLayout(False)
        Me.UbuntuTheme1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents UbuntuTheme1 As GameInTime.UbuntuTheme
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents UbuntuButtonOrange1 As GameInTime.UbuntuButtonOrange
    Friend WithEvents WebBrowser1 As System.Windows.Forms.WebBrowser
    Friend WithEvents ListBox2 As System.Windows.Forms.ListBox
    Friend WithEvents UbuntuTextBox1 As GameInTime.UbuntuTextBox
    Friend WithEvents ListBox3 As System.Windows.Forms.ListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents ListBox4 As System.Windows.Forms.ListBox

End Class
