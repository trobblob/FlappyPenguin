<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ColorPicker
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ColorPicker))
        Me.grpColor1 = New System.Windows.Forms.GroupBox()
        Me.radGrey1 = New System.Windows.Forms.RadioButton()
        Me.radBlue1 = New System.Windows.Forms.RadioButton()
        Me.radRed1 = New System.Windows.Forms.RadioButton()
        Me.radYellow1 = New System.Windows.Forms.RadioButton()
        Me.grpColor2 = New System.Windows.Forms.GroupBox()
        Me.radBlue2 = New System.Windows.Forms.RadioButton()
        Me.radRed2 = New System.Windows.Forms.RadioButton()
        Me.radGrey2 = New System.Windows.Forms.RadioButton()
        Me.radYellow2 = New System.Windows.Forms.RadioButton()
        Me.pbxPenguin = New System.Windows.Forms.PictureBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.grpColor1.SuspendLayout()
        Me.grpColor2.SuspendLayout()
        CType(Me.pbxPenguin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpColor1
        '
        Me.grpColor1.Controls.Add(Me.radBlue1)
        Me.grpColor1.Controls.Add(Me.radRed1)
        Me.grpColor1.Controls.Add(Me.radGrey1)
        Me.grpColor1.Controls.Add(Me.radYellow1)
        Me.grpColor1.Location = New System.Drawing.Point(334, 115)
        Me.grpColor1.Name = "grpColor1"
        Me.grpColor1.Size = New System.Drawing.Size(213, 148)
        Me.grpColor1.TabIndex = 0
        Me.grpColor1.TabStop = False
        Me.grpColor1.Text = "First Color"
        '
        'radGrey1
        '
        Me.radGrey1.AutoSize = True
        Me.radGrey1.Location = New System.Drawing.Point(32, 39)
        Me.radGrey1.Name = "radGrey1"
        Me.radGrey1.Size = New System.Drawing.Size(47, 17)
        Me.radGrey1.TabIndex = 1
        Me.radGrey1.TabStop = True
        Me.radGrey1.Text = "Grey"
        Me.radGrey1.UseVisualStyleBackColor = True
        '
        'radBlue1
        '
        Me.radBlue1.AutoSize = True
        Me.radBlue1.Location = New System.Drawing.Point(137, 39)
        Me.radBlue1.Name = "radBlue1"
        Me.radBlue1.Size = New System.Drawing.Size(46, 17)
        Me.radBlue1.TabIndex = 2
        Me.radBlue1.TabStop = True
        Me.radBlue1.Text = "Blue"
        Me.radBlue1.UseVisualStyleBackColor = True
        '
        'radRed1
        '
        Me.radRed1.AutoSize = True
        Me.radRed1.Location = New System.Drawing.Point(32, 96)
        Me.radRed1.Name = "radRed1"
        Me.radRed1.Size = New System.Drawing.Size(45, 17)
        Me.radRed1.TabIndex = 3
        Me.radRed1.TabStop = True
        Me.radRed1.Text = "Red"
        Me.radRed1.UseVisualStyleBackColor = True
        '
        'radYellow1
        '
        Me.radYellow1.AutoSize = True
        Me.radYellow1.Location = New System.Drawing.Point(137, 96)
        Me.radYellow1.Name = "radYellow1"
        Me.radYellow1.Size = New System.Drawing.Size(56, 17)
        Me.radYellow1.TabIndex = 4
        Me.radYellow1.TabStop = True
        Me.radYellow1.Text = "Yellow"
        Me.radYellow1.UseVisualStyleBackColor = True
        '
        'grpColor2
        '
        Me.grpColor2.Controls.Add(Me.radBlue2)
        Me.grpColor2.Controls.Add(Me.radRed2)
        Me.grpColor2.Controls.Add(Me.radGrey2)
        Me.grpColor2.Controls.Add(Me.radYellow2)
        Me.grpColor2.Location = New System.Drawing.Point(334, 290)
        Me.grpColor2.Name = "grpColor2"
        Me.grpColor2.Size = New System.Drawing.Size(213, 148)
        Me.grpColor2.TabIndex = 5
        Me.grpColor2.TabStop = False
        Me.grpColor2.Text = "Second Color"
        '
        'radBlue2
        '
        Me.radBlue2.AutoSize = True
        Me.radBlue2.Location = New System.Drawing.Point(137, 39)
        Me.radBlue2.Name = "radBlue2"
        Me.radBlue2.Size = New System.Drawing.Size(46, 17)
        Me.radBlue2.TabIndex = 2
        Me.radBlue2.TabStop = True
        Me.radBlue2.Text = "Blue"
        Me.radBlue2.UseVisualStyleBackColor = True
        '
        'radRed2
        '
        Me.radRed2.AutoSize = True
        Me.radRed2.Location = New System.Drawing.Point(32, 96)
        Me.radRed2.Name = "radRed2"
        Me.radRed2.Size = New System.Drawing.Size(45, 17)
        Me.radRed2.TabIndex = 3
        Me.radRed2.TabStop = True
        Me.radRed2.Text = "Red"
        Me.radRed2.UseVisualStyleBackColor = True
        '
        'radGrey2
        '
        Me.radGrey2.AutoSize = True
        Me.radGrey2.Location = New System.Drawing.Point(32, 39)
        Me.radGrey2.Name = "radGrey2"
        Me.radGrey2.Size = New System.Drawing.Size(47, 17)
        Me.radGrey2.TabIndex = 1
        Me.radGrey2.TabStop = True
        Me.radGrey2.Text = "Grey"
        Me.radGrey2.UseVisualStyleBackColor = True
        '
        'radYellow2
        '
        Me.radYellow2.AutoSize = True
        Me.radYellow2.Location = New System.Drawing.Point(137, 96)
        Me.radYellow2.Name = "radYellow2"
        Me.radYellow2.Size = New System.Drawing.Size(56, 17)
        Me.radYellow2.TabIndex = 4
        Me.radYellow2.TabStop = True
        Me.radYellow2.Text = "Yellow"
        Me.radYellow2.UseVisualStyleBackColor = True
        '
        'pbxPenguin
        '
        Me.pbxPenguin.Image = CType(resources.GetObject("pbxPenguin.Image"), System.Drawing.Image)
        Me.pbxPenguin.Location = New System.Drawing.Point(24, 115)
        Me.pbxPenguin.Name = "pbxPenguin"
        Me.pbxPenguin.Size = New System.Drawing.Size(254, 323)
        Me.pbxPenguin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxPenguin.TabIndex = 6
        Me.pbxPenguin.TabStop = False
        '
        'lblTitle
        '
        Me.lblTitle.Font = New System.Drawing.Font("MV Boli", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(63, 30)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(454, 57)
        Me.lblTitle.TabIndex = 7
        Me.lblTitle.Text = "Penguin Color Picker"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ColorPicker
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(572, 450)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.pbxPenguin)
        Me.Controls.Add(Me.grpColor2)
        Me.Controls.Add(Me.grpColor1)
        Me.Name = "ColorPicker"
        Me.Text = "Color Picker"
        Me.grpColor1.ResumeLayout(False)
        Me.grpColor1.PerformLayout()
        Me.grpColor2.ResumeLayout(False)
        Me.grpColor2.PerformLayout()
        CType(Me.pbxPenguin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grpColor1 As GroupBox
    Friend WithEvents radBlue1 As RadioButton
    Friend WithEvents radRed1 As RadioButton
    Friend WithEvents radGrey1 As RadioButton
    Friend WithEvents radYellow1 As RadioButton
    Friend WithEvents grpColor2 As GroupBox
    Friend WithEvents radBlue2 As RadioButton
    Friend WithEvents radRed2 As RadioButton
    Friend WithEvents radGrey2 As RadioButton
    Friend WithEvents radYellow2 As RadioButton
    Friend WithEvents pbxPenguin As PictureBox
    Friend WithEvents lblTitle As Label
End Class
