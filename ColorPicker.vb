Public Class ColorPicker

    Dim strColor1 As String = "Grey"
    Dim strColor2 As String = "Grey"
    Dim strPath As String = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "PenguinSprites")

    Sub SwitchBird()
        Try
            pbxPenguin.Image = Image.FromFile(strPath & $"\{strColor1}{strColor2}Penguin.png")
        Catch ex As Exception
            pbxPenguin.Image = Image.FromFile(strPath & "\GreyGreyPenguin.png")
        End Try

        pbxPenguin.Image.RotateFlip(RotateFlipType.RotateNoneFlipX)
    End Sub

    Private Sub radGrey1_CheckedChanged(sender As Object, e As EventArgs) Handles radGrey1.CheckedChanged
        strColor1 = radGrey1.Text
        SwitchBird()
    End Sub

    Private Sub radBlue1_CheckedChanged(sender As Object, e As EventArgs) Handles radBlue1.CheckedChanged
        strColor1 = radBlue1.Text
        SwitchBird()
    End Sub

    Private Sub radRed1_CheckedChanged(sender As Object, e As EventArgs) Handles radRed1.CheckedChanged
        strColor1 = radRed1.Text
        SwitchBird()
    End Sub

    Private Sub radYellow1_CheckedChanged(sender As Object, e As EventArgs) Handles radYellow1.CheckedChanged
        strColor1 = radYellow1.Text
        SwitchBird()
    End Sub

    Private Sub radGrey2_CheckedChanged(sender As Object, e As EventArgs) Handles radGrey2.CheckedChanged
        strColor2 = radGrey2.Text
        SwitchBird()
    End Sub

    Private Sub radBlue2_CheckedChanged(sender As Object, e As EventArgs) Handles radBlue2.CheckedChanged
        strColor2 = radBlue2.Text
        SwitchBird()
    End Sub

    Private Sub radRed2_CheckedChanged(sender As Object, e As EventArgs) Handles radRed2.CheckedChanged
        strColor2 = radRed2.Text
        SwitchBird()
    End Sub

    Private Sub radYellow2_CheckedChanged(sender As Object, e As EventArgs) Handles radYellow2.CheckedChanged
        strColor2 = radYellow2.Text
        SwitchBird()
    End Sub
End Class
