Public Class FlappyPenguinForm

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim intCount As Integer
        pbxPenguin.Location = New Point(Me.pbxPenguin.Location.X, Me.pbxPenguin.Location.Y + 15)


        Do Until intCount = 12
            pbxPipe1.Location = New Point(Me.pbxPipe1.Location.X - 10, Me.pbxPipe1.Location.Y)
            pbxPipe2.Location = New Point(Me.pbxPipe2.Location.X - 10, Me.pbxPipe2.Location.Y)
            intCount += 1
        Loop


    End Sub

    Private Sub FlappyPenguinForm_Click(sender As Object, e As EventArgs) Handles MyBase.Click
        pbxPenguin.Location = New Point(Me.pbxPenguin.Location.X, Me.pbxPenguin.Location.Y - 90)
    End Sub

End Class