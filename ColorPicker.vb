﻿Public Class ColorPicker

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

    'All radio button checks change the color of the penguin
    Private Sub radGrey1_CheckedChanged(sender As Object, e As EventArgs) Handles radGrey1.CheckedChanged
        strColor1 = "Grey"
        SwitchBird()
    End Sub

    Private Sub radBlue1_CheckedChanged(sender As Object, e As EventArgs) Handles radBlue1.CheckedChanged
        strColor1 = "Blue"
        SwitchBird()
    End Sub

    Private Sub radRed1_CheckedChanged(sender As Object, e As EventArgs) Handles radRed1.CheckedChanged
        strColor1 = "Red"
        SwitchBird()
    End Sub

    Private Sub radYellow1_CheckedChanged(sender As Object, e As EventArgs) Handles radYellow1.CheckedChanged
        strColor1 = "Yellow"
        SwitchBird()
    End Sub

    Private Sub radGrey2_CheckedChanged(sender As Object, e As EventArgs) Handles radGrey2.CheckedChanged
        strColor2 = "Grey"
        SwitchBird()
    End Sub

    Private Sub radBlue2_CheckedChanged(sender As Object, e As EventArgs) Handles radBlue2.CheckedChanged
        strColor2 = "Blue"
        SwitchBird()
    End Sub

    Private Sub radRed2_CheckedChanged(sender As Object, e As EventArgs) Handles radRed2.CheckedChanged
        strColor2 = "Red"
        SwitchBird()
    End Sub

    Private Sub radYellow2_CheckedChanged(sender As Object, e As EventArgs) Handles radYellow2.CheckedChanged
        strColor2 = "Yellow"
        SwitchBird()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Exits Application
        Close()
    End Sub

    Private Sub ColorPicker_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pbxPenguin.Image.RotateFlip(RotateFlipType.RotateNoneFlipX)
    End Sub
End Class
