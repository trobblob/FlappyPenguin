Public Class FlappyPenguinForm

    Dim penguinBoxCollider As New Object
    Dim intJumpFrame As Integer = 1

    Sub New(penguinImage As Image)
        ' This call is required by the designer.
        InitializeComponent()
        pbxPenguin.Image = penguinImage
        penguinBoxCollider = New PenguinBoxCollider(
                                    pbxPenguin.Location.X + 25,
                                    pbxPenguin.Location.Y + 25,
                                    pbxPenguin.Width - 50,
                                    pbxPenguin.Height - 50
                                 )
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim rand As New Random
        Dim intPipe As Integer

        movement()
        penguinBoxCollider.X = pbxPenguin.Location.X
        penguinBoxCollider.Y = pbxPenguin.Location.Y

        If pbxPipe1.Location.X > 0 Then

            pbxPipe1.Location = New Point(Me.pbxPipe1.Location.X - 10, Me.pbxPipe1.Location.Y)
            pbxPipe2.Location = New Point(Me.pbxPipe2.Location.X - 10, Me.pbxPipe2.Location.Y)

        Else intPipe = rand.Next(500) - 650
            pbxPipe1.Location = New Point(500, intPipe)
            pbxPipe2.Location = New Point(500, intPipe + 950)
        End If

        collision()
    End Sub

    Sub collision()
        Dim penguinDimensions As New List(Of Integer)
        If penguinBoxCollider.X + penguinBoxCollider.Width >= pbxPipe1.Location.X And penguinBoxCollider.X <= pbxPipe1.Location.X Then
            If penguinBoxCollider.Y <= pbxPipe1.Location.Y Or penguinBoxCollider.Y + penguinBoxCollider.Height <= pbxPipe2.Location.Y Then
                Close()
            End If
        End If
    End Sub

    Sub movement()
        pbxPenguin.Location = New Point(pbxPenguin.Location.X, pbxPenguin.Location.Y + Math.Pow(intJumpFrame, 2) - Math.Pow(intJumpFrame - 1, 2))
        intJumpFrame += 1
    End Sub

    Private Sub FlappyPenguinForm_Click(sender As Object, e As EventArgs) Handles MyBase.Click
        intJumpFrame = -5
    End Sub

    Private Sub FlappyPenguinForm_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress
        intJumpFrame = -5
    End Sub
End Class

Public Class PenguinBoxCollider
    Public X As Integer
    Public Y As Integer
    Public Width As Integer
    Public Height As Integer

    Sub New(x_pos, y_pos, w, h)
        X = x_pos
        Y = y_pos
        Width = w
        Height = h
    End Sub
End Class