Public Class FlappyPenguinForm

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim rand As New Random
        Dim intPipe As Integer

        pbxPenguin.Location = New Point(Me.pbxPenguin.Location.X, Me.pbxPenguin.Location.Y + 12)

        If pbxPipe1.Location.X > 0 Then

                pbxPipe1.Location = New Point(Me.pbxPipe1.Location.X - 10, Me.pbxPipe1.Location.Y)
                pbxPipe2.Location = New Point(Me.pbxPipe2.Location.X - 10, Me.pbxPipe2.Location.Y)

        Else intPipe = rand.Next(500) - 650
            pbxPipe1.Location = New Point(500, intPipe)
                pbxPipe2.Location = New Point(500, intPipe + 950)
            End If

    End Sub

    Private Sub FlappyPenguinForm_Click(sender As Object, e As EventArgs) Handles MyBase.Click
        pbxPenguin.Location = New Point(Me.pbxPenguin.Location.X, Me.pbxPenguin.Location.Y - 210)
    End Sub

End Class