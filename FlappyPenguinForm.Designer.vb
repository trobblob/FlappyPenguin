<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FlappyPenguinForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FlappyPenguinForm))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.pbxPenguin = New System.Windows.Forms.PictureBox()
        Me.pbxPipe2 = New System.Windows.Forms.PictureBox()
        Me.pbxPipe1 = New System.Windows.Forms.PictureBox()
        Me.lblScore = New System.Windows.Forms.Label()
        CType(Me.pbxPenguin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxPipe2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxPipe1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 3
        '
        'pbxPenguin
        '
        Me.pbxPenguin.BackColor = System.Drawing.Color.Transparent
        Me.pbxPenguin.Image = CType(resources.GetObject("pbxPenguin.Image"), System.Drawing.Image)
        Me.pbxPenguin.Location = New System.Drawing.Point(86, 170)
        Me.pbxPenguin.Name = "pbxPenguin"
        Me.pbxPenguin.Size = New System.Drawing.Size(72, 80)
        Me.pbxPenguin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxPenguin.TabIndex = 0
        Me.pbxPenguin.TabStop = False
        '
        'pbxPipe2
        '
        Me.pbxPipe2.BackColor = System.Drawing.Color.Transparent
        Me.pbxPipe2.Image = CType(resources.GetObject("pbxPipe2.Image"), System.Drawing.Image)
        Me.pbxPipe2.Location = New System.Drawing.Point(500, 400)
        Me.pbxPipe2.Name = "pbxPipe2"
        Me.pbxPipe2.Size = New System.Drawing.Size(100, 750)
        Me.pbxPipe2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxPipe2.TabIndex = 1
        Me.pbxPipe2.TabStop = False
        '
        'pbxPipe1
        '
        Me.pbxPipe1.BackColor = System.Drawing.Color.Transparent
        Me.pbxPipe1.Image = CType(resources.GetObject("pbxPipe1.Image"), System.Drawing.Image)
        Me.pbxPipe1.Location = New System.Drawing.Point(500, -550)
        Me.pbxPipe1.Name = "pbxPipe1"
        Me.pbxPipe1.Size = New System.Drawing.Size(100, 750)
        Me.pbxPipe1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxPipe1.TabIndex = 2
        Me.pbxPipe1.TabStop = False
        '
        'lblScore
        '
        Me.lblScore.BackColor = System.Drawing.Color.Transparent
        Me.lblScore.Font = New System.Drawing.Font("Segoe Print", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScore.Location = New System.Drawing.Point(0, 0)
        Me.lblScore.Name = "lblScore"
        Me.lblScore.Size = New System.Drawing.Size(51, 65)
        Me.lblScore.TabIndex = 3
        Me.lblScore.Text = "0"
        '
        'FlappyPenguinForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(794, 761)
        Me.Controls.Add(Me.lblScore)
        Me.Controls.Add(Me.pbxPipe1)
        Me.Controls.Add(Me.pbxPipe2)
        Me.Controls.Add(Me.pbxPenguin)
        Me.Name = "FlappyPenguinForm"
        Me.Text = "Flappy Penguin"
        CType(Me.pbxPenguin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxPipe2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxPipe1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Timer1 As Timer
    Friend WithEvents pbxPenguin As PictureBox
    Friend WithEvents pbxPipe2 As PictureBox
    Friend WithEvents pbxPipe1 As PictureBox
    Friend WithEvents lblScore As Label
End Class
