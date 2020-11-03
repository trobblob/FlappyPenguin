Public Class FlappyPenguinForm


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        Do
            pbxPipe1.Location = New Point(Me.pbxPipe1.Location.X - 10, Me.pbxPipe1.Location.Y)
        Loop Until pbxPipe1.Location.X
        pbxPipe2.Location = New Point(Me.pbxPipe2.Location.X - 10, Me.pbxPipe2.Location.Y)
        pbxPenguin.Location = New Point(Me.pbxPenguin.Location.X, Me.pbxPenguin.Location.Y + 10)
    End Sub

    Private Sub FlappyPenguinForm_Click(sender As Object, e As EventArgs) Handles MyBase.Click
        pbxPenguin.Location = New Point(Me.pbxPenguin.Location.X, Me.pbxPenguin.Location.Y - 70)
    End Sub

End Class