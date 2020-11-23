Public Class FlappyPenguinForm

    Dim intJumpFrame As Integer = 1
    Dim rand As New Random
    Dim intPipe As Integer
    Dim intFinalScore As Integer
    Public intSavedScore(5) As Integer         'Array to hold score values
    Dim intAttempt As Integer

    Sub New(penguinImage As Image, intPassedAttempt As Integer)
        ' This call is required by the designer.
        InitializeComponent()
        pbxPenguin.Image = penguinImage
        intAttempt = intPassedAttempt
        lblAttempt.Text = "Attempt: " & intAttempt
    End Sub

    Public Function intGetScore() As Integer
        Return intFinalScore
    End Function


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'Dim Pen = CreateGraphics()
        'Pen.DrawPolygon(Pens.DarkBlue, {New PointF(pbxPenguin.Location.X - 1, pbxPenguin.Location.Y - 1),
        '                                New PointF(pbxPenguin.Location.X + pbxPenguin.Width + 1, pbxPenguin.Location.Y - 1),
        '                                New PointF(pbxPenguin.Location.X + pbxPenguin.Width + 1, pbxPenguin.Location.Y + pbxPenguin.Height + 1),
        '                                New PointF(pbxPenguin.Location.X - 1, pbxPenguin.Location.Y + pbxPenguin.Height + 1)})
        'Pen.DrawPolygon(Pens.DarkBlue, {New PointF(pbxPipe1.Location.X - 1, pbxPipe1.Location.Y - 1),
        '                                New PointF(pbxPipe1.Location.X + pbxPipe1.Width + 1, pbxPipe1.Location.Y - 1),
        '                                New PointF(pbxPipe1.Location.X + pbxPipe1.Width + 1, pbxPipe1.Location.Y + pbxPipe1.Height + 1),
        '                                New PointF(pbxPipe1.Location.X - 1, pbxPipe1.Location.Y + pbxPipe1.Height + 1)})
        'Pen.DrawPolygon(Pens.DarkBlue, {New PointF(pbxPipe2.Location.X - 1, pbxPipe2.Location.Y - 1),
        '                                New PointF(pbxPipe2.Location.X + pbxPipe2.Width + 1, pbxPipe2.Location.Y - 1),
        '                                New PointF(pbxPipe2.Location.X + pbxPipe2.Width + 1, pbxPipe2.Location.Y + pbxPipe2.Height + 1),
        '                                New PointF(pbxPipe2.Location.X - 1, pbxPipe2.Location.Y + pbxPipe2.Height + 1)})
        penguinMovement()
        pipeMovement()
        collision()
        score()
    End Sub

    Sub score()
        Dim intScore As Integer
        If pbxPipe1.Location.X = 10 Then
            intScore += 1

        End If
        lblScore.Text += intScore
        intFinalScore += intScore
    End Sub

    Sub collision()
        If pbxPenguin.Location.X + pbxPenguin.Width >= pbxPipe1.Location.X And pbxPenguin.Location.X <= pbxPipe1.Location.X Then
            If pbxPenguin.Location.Y <= pbxPipe1.Location.Y + pbxPipe1.Height Or pbxPenguin.Location.Y + pbxPenguin.Height >= pbxPipe2.Location.Y Then
                Close()
            End If
        End If

        If pbxPenguin.Location.Y + pbxPenguin.Height >= Me.Height Then
            Close()
        End If
    End Sub

    Sub penguinMovement()
        pbxPenguin.Location = New Point(pbxPenguin.Location.X, pbxPenguin.Location.Y + Math.Pow(intJumpFrame, 2) - Math.Pow(intJumpFrame - 1, 2))
        intJumpFrame += 1
    End Sub

    Sub pipeMovement()
        If pbxPipe1.Location.X + pbxPipe1.Width > 0 Then
            pbxPipe1.Location = New Point(pbxPipe1.Location.X - 10, pbxPipe1.Location.Y)
            pbxPipe2.Location = New Point(pbxPipe2.Location.X - 10, pbxPipe2.Location.Y)
        Else intPipe = rand.Next(500) - 650
            pbxPipe1.Location = New Point(Me.Width, intPipe)
            pbxPipe2.Location = New Point(Me.Width, intPipe + 950)
        End If
    End Sub

    Private Sub FlappyPenguinForm_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress
        'This subroutine makes the penguin jump
        intJumpFrame = -5
    End Sub

End Class