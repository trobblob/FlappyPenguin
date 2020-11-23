<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EndPage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EndPage))
        Me.btnReplay = New System.Windows.Forms.Button()
        Me.lblFinalScore = New System.Windows.Forms.Label()
        Me.grbTopScores = New System.Windows.Forms.GroupBox()
        Me.lstScores = New System.Windows.Forms.ListBox()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.pbxFailedPenguin = New System.Windows.Forms.PictureBox()
        Me.grbTopScores.SuspendLayout()
        CType(Me.pbxFailedPenguin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnReplay
        '
        Me.btnReplay.BackColor = System.Drawing.Color.White
        Me.btnReplay.Font = New System.Drawing.Font("Segoe Print", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReplay.Location = New System.Drawing.Point(189, 357)
        Me.btnReplay.Name = "btnReplay"
        Me.btnReplay.Size = New System.Drawing.Size(100, 50)
        Me.btnReplay.TabIndex = 0
        Me.btnReplay.Text = "Replay"
        Me.btnReplay.UseVisualStyleBackColor = False
        '
        'lblFinalScore
        '
        Me.lblFinalScore.AutoSize = True
        Me.lblFinalScore.BackColor = System.Drawing.Color.Transparent
        Me.lblFinalScore.Font = New System.Drawing.Font("Segoe Print", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFinalScore.Location = New System.Drawing.Point(212, 9)
        Me.lblFinalScore.Name = "lblFinalScore"
        Me.lblFinalScore.Size = New System.Drawing.Size(261, 65)
        Me.lblFinalScore.TabIndex = 1
        Me.lblFinalScore.Text = "Final Score: "
        '
        'grbTopScores
        '
        Me.grbTopScores.BackColor = System.Drawing.Color.Transparent
        Me.grbTopScores.Controls.Add(Me.lstScores)
        Me.grbTopScores.Font = New System.Drawing.Font("Segoe Print", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grbTopScores.ForeColor = System.Drawing.SystemColors.ControlText
        Me.grbTopScores.Location = New System.Drawing.Point(471, 136)
        Me.grbTopScores.Name = "grbTopScores"
        Me.grbTopScores.Size = New System.Drawing.Size(176, 271)
        Me.grbTopScores.TabIndex = 2
        Me.grbTopScores.TabStop = False
        Me.grbTopScores.Text = "Top Scores Today"
        '
        'lstScores
        '
        Me.lstScores.Font = New System.Drawing.Font("Segoe Print", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstScores.FormattingEnabled = True
        Me.lstScores.ItemHeight = 21
        Me.lstScores.Location = New System.Drawing.Point(6, 44)
        Me.lstScores.Name = "lstScores"
        Me.lstScores.Size = New System.Drawing.Size(164, 193)
        Me.lstScores.TabIndex = 0
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.White
        Me.btnBack.Font = New System.Drawing.Font("Segoe Print", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(353, 357)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(100, 50)
        Me.btnBack.TabIndex = 3
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'pbxFailedPenguin
        '
        Me.pbxFailedPenguin.BackColor = System.Drawing.Color.Transparent
        Me.pbxFailedPenguin.Image = CType(resources.GetObject("pbxFailedPenguin.Image"), System.Drawing.Image)
        Me.pbxFailedPenguin.Location = New System.Drawing.Point(189, 61)
        Me.pbxFailedPenguin.Name = "pbxFailedPenguin"
        Me.pbxFailedPenguin.Size = New System.Drawing.Size(264, 283)
        Me.pbxFailedPenguin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxFailedPenguin.TabIndex = 4
        Me.pbxFailedPenguin.TabStop = False
        '
        'EndPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(673, 450)
        Me.Controls.Add(Me.pbxFailedPenguin)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.grbTopScores)
        Me.Controls.Add(Me.lblFinalScore)
        Me.Controls.Add(Me.btnReplay)
        Me.Name = "EndPage"
        Me.Text = "You died"
        Me.grbTopScores.ResumeLayout(False)
        CType(Me.pbxFailedPenguin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnReplay As Button
    Friend WithEvents lblFinalScore As Label
    Friend WithEvents grbTopScores As GroupBox
    Friend WithEvents lstScores As ListBox
    Friend WithEvents btnBack As Button
    Friend WithEvents pbxFailedPenguin As PictureBox
End Class
