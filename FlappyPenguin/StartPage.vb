﻿Public Class StartPage
    'Final Project Flappy Penguin
    'A game where a penguin jumps through obstacles to gain points
    'Connor Hultman and Tucker Robson
    '10/26/2020

    Dim intAttempt As Integer = 1
    Dim intScores As New List(Of Integer)

    Private Sub btnUnlocks_Click(sender As Object, e As EventArgs) Handles btnColorPicker.Click
        'Creates an instance of the unlockables form
        Dim frmColorPicker As New ColorPicker
        Visible = False
        frmColorPicker.ShowDialog()
        Visible = True
        pbxPenguin.Image = frmColorPicker.pbxPenguin.Image
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'Closes the form
        Me.Close()
    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        'Creates an instance of the game
        Dim frmFlappyPenguinForm As New FlappyPenguinForm(pbxPenguin.Image, intAttempt)
        Dim frmEndPage As New Object

        Visible = False
        frmFlappyPenguinForm.ShowDialog()

        Dim intScore As Integer = frmFlappyPenguinForm.intGetScore()
        intScores.Add(intScore)
        frmEndPage = New EndPage(intScore, intScores)
        frmEndPage.ShowDialog()

        Dim blnReplay As Boolean = frmEndPage.blnGetReplay()
        If blnReplay Then
            intAttempt += 1
            btnStart_Click(sender, e)
        End If

        intAttempt = 1
        Visible = True

    End Sub

    Private Sub StartPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Flips the penguin image so it faces the other direction in the game.
        pbxPenguin.Image.RotateFlip(RotateFlipType.RotateNoneFlipX)
    End Sub
End Class
