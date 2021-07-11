<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class flyCatching
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(flyCatching))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnLayEggs = New System.Windows.Forms.Button()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel8 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblEggs = New System.Windows.Forms.Label()
        Me.TableLayoutPanel7 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel6 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblPoints = New System.Windows.Forms.Label()
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnRun = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.pbSnake = New System.Windows.Forms.PictureBox()
        Me.pbFly3 = New System.Windows.Forms.PictureBox()
        Me.pbFly2 = New System.Windows.Forms.PictureBox()
        Me.pbFly1 = New System.Windows.Forms.PictureBox()
        Me.upTimer1 = New System.Windows.Forms.Timer(Me.components)
        Me.downTimer1 = New System.Windows.Forms.Timer(Me.components)
        Me.leftTimer1 = New System.Windows.Forms.Timer(Me.components)
        Me.rightTimer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Snake = New System.Windows.Forms.Timer(Me.components)
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.TableLayoutPanel8.SuspendLayout()
        Me.TableLayoutPanel7.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.TableLayoutPanel6.SuspendLayout()
        Me.TableLayoutPanel5.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.pbSnake, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbFly3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbFly2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbFly1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(944, 501)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(122, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(164, Byte), Integer))
        Me.TableLayoutPanel2.ColumnCount = 5
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.81876!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0533!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.btnLayEggs, 3, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.TableLayoutPanel4, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.TableLayoutPanel3, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.PictureBox1, 2, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.btnRun, 4, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 403)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 95.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(938, 95)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'btnLayEggs
        '
        Me.btnLayEggs.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnLayEggs.Enabled = False
        Me.btnLayEggs.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnLayEggs.Font = New System.Drawing.Font("Comic Sans MS", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLayEggs.ForeColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.btnLayEggs.Location = New System.Drawing.Point(564, 3)
        Me.btnLayEggs.Name = "btnLayEggs"
        Me.btnLayEggs.Size = New System.Drawing.Size(181, 89)
        Me.btnLayEggs.TabIndex = 5
        Me.btnLayEggs.Text = "LAY EGGS"
        Me.btnLayEggs.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 1
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.TableLayoutPanel8, 0, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.TableLayoutPanel7, 0, 0)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(142, 3)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 2
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(229, 89)
        Me.TableLayoutPanel4.TabIndex = 1
        '
        'TableLayoutPanel8
        '
        Me.TableLayoutPanel8.ColumnCount = 3
        Me.TableLayoutPanel8.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.46188!))
        Me.TableLayoutPanel8.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.79821!))
        Me.TableLayoutPanel8.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.29148!))
        Me.TableLayoutPanel8.Controls.Add(Me.lblEggs, 1, 0)
        Me.TableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel8.Location = New System.Drawing.Point(3, 47)
        Me.TableLayoutPanel8.Name = "TableLayoutPanel8"
        Me.TableLayoutPanel8.RowCount = 1
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel8.Size = New System.Drawing.Size(223, 39)
        Me.TableLayoutPanel8.TabIndex = 2
        '
        'lblEggs
        '
        Me.lblEggs.AutoSize = True
        Me.lblEggs.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEggs.ForeColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.lblEggs.Location = New System.Drawing.Point(91, 0)
        Me.lblEggs.Name = "lblEggs"
        Me.lblEggs.Size = New System.Drawing.Size(24, 26)
        Me.lblEggs.TabIndex = 0
        Me.lblEggs.Text = "0"
        '
        'TableLayoutPanel7
        '
        Me.TableLayoutPanel7.ColumnCount = 3
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.6278!))
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55.60538!))
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.31839!))
        Me.TableLayoutPanel7.Controls.Add(Me.Label3, 1, 0)
        Me.TableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel7.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel7.Name = "TableLayoutPanel7"
        Me.TableLayoutPanel7.RowCount = 1
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel7.Size = New System.Drawing.Size(223, 38)
        Me.TableLayoutPanel7.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(49, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(116, 26)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "EGGS LAID"
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 1
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.TableLayoutPanel6, 0, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.TableLayoutPanel5, 0, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 2
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(133, 89)
        Me.TableLayoutPanel3.TabIndex = 0
        '
        'TableLayoutPanel6
        '
        Me.TableLayoutPanel6.ColumnCount = 3
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.83465!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.45669!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.70866!))
        Me.TableLayoutPanel6.Controls.Add(Me.lblPoints, 1, 0)
        Me.TableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel6.Location = New System.Drawing.Point(3, 47)
        Me.TableLayoutPanel6.Name = "TableLayoutPanel6"
        Me.TableLayoutPanel6.RowCount = 1
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel6.Size = New System.Drawing.Size(127, 39)
        Me.TableLayoutPanel6.TabIndex = 1
        '
        'lblPoints
        '
        Me.lblPoints.AutoSize = True
        Me.lblPoints.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPoints.ForeColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.lblPoints.Location = New System.Drawing.Point(32, 0)
        Me.lblPoints.Name = "lblPoints"
        Me.lblPoints.Size = New System.Drawing.Size(24, 26)
        Me.lblPoints.TabIndex = 1
        Me.lblPoints.Text = "0"
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.ColumnCount = 3
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80.0!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel5.Controls.Add(Me.Label1, 1, 0)
        Me.TableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 1
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(127, 38)
        Me.TableLayoutPanel5.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(15, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 26)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "POINTS"
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(377, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(181, 89)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'btnRun
        '
        Me.btnRun.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnRun.Enabled = False
        Me.btnRun.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnRun.Font = New System.Drawing.Font("Comic Sans MS", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRun.ForeColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.btnRun.Location = New System.Drawing.Point(751, 3)
        Me.btnRun.Name = "btnRun"
        Me.btnRun.Size = New System.Drawing.Size(184, 89)
        Me.btnRun.TabIndex = 4
        Me.btnRun.Text = "RUN"
        Me.btnRun.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkOliveGreen
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Panel1.Controls.Add(Me.pbSnake)
        Me.Panel1.Controls.Add(Me.pbFly3)
        Me.Panel1.Controls.Add(Me.pbFly2)
        Me.Panel1.Controls.Add(Me.pbFly1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(938, 394)
        Me.Panel1.TabIndex = 1
        '
        'pbSnake
        '
        Me.pbSnake.BackgroundImage = CType(resources.GetObject("pbSnake.BackgroundImage"), System.Drawing.Image)
        Me.pbSnake.Image = CType(resources.GetObject("pbSnake.Image"), System.Drawing.Image)
        Me.pbSnake.Location = New System.Drawing.Point(3, 3)
        Me.pbSnake.Name = "pbSnake"
        Me.pbSnake.Size = New System.Drawing.Size(242, 209)
        Me.pbSnake.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbSnake.TabIndex = 3
        Me.pbSnake.TabStop = False
        Me.pbSnake.Visible = False
        '
        'pbFly3
        '
        Me.pbFly3.BackColor = System.Drawing.Color.DarkOliveGreen
        Me.pbFly3.BackgroundImage = CType(resources.GetObject("pbFly3.BackgroundImage"), System.Drawing.Image)
        Me.pbFly3.Image = CType(resources.GetObject("pbFly3.Image"), System.Drawing.Image)
        Me.pbFly3.Location = New System.Drawing.Point(599, 231)
        Me.pbFly3.Name = "pbFly3"
        Me.pbFly3.Size = New System.Drawing.Size(64, 50)
        Me.pbFly3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbFly3.TabIndex = 2
        Me.pbFly3.TabStop = False
        '
        'pbFly2
        '
        Me.pbFly2.BackColor = System.Drawing.Color.DarkOliveGreen
        Me.pbFly2.BackgroundImage = CType(resources.GetObject("pbFly2.BackgroundImage"), System.Drawing.Image)
        Me.pbFly2.Image = CType(resources.GetObject("pbFly2.Image"), System.Drawing.Image)
        Me.pbFly2.Location = New System.Drawing.Point(377, 106)
        Me.pbFly2.Name = "pbFly2"
        Me.pbFly2.Size = New System.Drawing.Size(64, 50)
        Me.pbFly2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbFly2.TabIndex = 1
        Me.pbFly2.TabStop = False
        '
        'pbFly1
        '
        Me.pbFly1.BackColor = System.Drawing.Color.DarkOliveGreen
        Me.pbFly1.BackgroundImage = CType(resources.GetObject("pbFly1.BackgroundImage"), System.Drawing.Image)
        Me.pbFly1.Image = CType(resources.GetObject("pbFly1.Image"), System.Drawing.Image)
        Me.pbFly1.Location = New System.Drawing.Point(142, 218)
        Me.pbFly1.Name = "pbFly1"
        Me.pbFly1.Size = New System.Drawing.Size(64, 50)
        Me.pbFly1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbFly1.TabIndex = 0
        Me.pbFly1.TabStop = False
        '
        'upTimer1
        '
        Me.upTimer1.Enabled = True
        '
        'downTimer1
        '
        '
        'leftTimer1
        '
        Me.leftTimer1.Enabled = True
        '
        'rightTimer1
        '
        '
        'Snake
        '
        Me.Snake.Interval = 800
        '
        'flyCatching
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkOliveGreen
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(944, 501)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.DoubleBuffered = True
        Me.MinimumSize = New System.Drawing.Size(960, 540)
        Me.Name = "flyCatching"
        Me.Text = "flyCatching"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel8.ResumeLayout(False)
        Me.TableLayoutPanel8.PerformLayout()
        Me.TableLayoutPanel7.ResumeLayout(False)
        Me.TableLayoutPanel7.PerformLayout()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel6.ResumeLayout(False)
        Me.TableLayoutPanel6.PerformLayout()
        Me.TableLayoutPanel5.ResumeLayout(False)
        Me.TableLayoutPanel5.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.pbSnake, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbFly3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbFly2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbFly1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel8 As TableLayoutPanel
    Friend WithEvents lblEggs As Label
    Friend WithEvents TableLayoutPanel7 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel6 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnRun As Button
    Friend WithEvents btnLayEggs As Button
    Friend WithEvents upTimer1 As Timer
    Friend WithEvents downTimer1 As Timer
    Friend WithEvents Panel1 As Panel
    Friend WithEvents pbFly1 As PictureBox
    Friend WithEvents pbFly3 As PictureBox
    Friend WithEvents pbFly2 As PictureBox
    Friend WithEvents leftTimer1 As Timer
    Friend WithEvents rightTimer1 As Timer
    Friend WithEvents Label3 As Label
    Friend WithEvents lblPoints As Label
    Friend WithEvents Snake As Timer
    Friend WithEvents pbSnake As PictureBox
End Class
