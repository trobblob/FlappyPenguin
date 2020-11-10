<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StartPage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StartPage))
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.btnUnlocks = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.pbxPenguin = New System.Windows.Forms.PictureBox()
        CType(Me.pbxPenguin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Font = New System.Drawing.Font("Segoe Print", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(151, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(409, 85)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Flappy Penguin"
        '
        'btnStart
        '
        Me.btnStart.BackColor = System.Drawing.Color.White
        Me.btnStart.Font = New System.Drawing.Font("Segoe Print", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStart.Location = New System.Drawing.Point(12, 148)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(120, 55)
        Me.btnStart.TabIndex = 1
        Me.btnStart.Text = "Start"
        Me.btnStart.UseVisualStyleBackColor = False
        '
        'btnUnlocks
        '
        Me.btnUnlocks.BackColor = System.Drawing.Color.White
        Me.btnUnlocks.Font = New System.Drawing.Font("Segoe Print", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUnlocks.Location = New System.Drawing.Point(12, 271)
        Me.btnUnlocks.Name = "btnUnlocks"
        Me.btnUnlocks.Size = New System.Drawing.Size(120, 55)
        Me.btnUnlocks.TabIndex = 2
        Me.btnUnlocks.Text = "Unlocks"
        Me.btnUnlocks.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.White
        Me.btnExit.Font = New System.Drawing.Font("Segoe Print", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(12, 396)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(120, 55)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'pbxPenguin
        '
        Me.pbxPenguin.BackColor = System.Drawing.Color.Transparent
        Me.pbxPenguin.Image = CType(resources.GetObject("pbxPenguin.Image"), System.Drawing.Image)
        Me.pbxPenguin.Location = New System.Drawing.Point(210, 100)
        Me.pbxPenguin.Name = "pbxPenguin"
        Me.pbxPenguin.Size = New System.Drawing.Size(300, 400)
        Me.pbxPenguin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxPenguin.TabIndex = 4
        Me.pbxPenguin.TabStop = False
        '
        'StartPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(794, 661)
        Me.Controls.Add(Me.pbxPenguin)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnUnlocks)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.lblTitle)
        Me.Name = "StartPage"
        Me.Text = "Flappy Penguin"
        CType(Me.pbxPenguin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents btnStart As Button
    Friend WithEvents btnUnlocks As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents pbxPenguin As PictureBox
End Class
