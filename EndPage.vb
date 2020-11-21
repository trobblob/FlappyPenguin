﻿Public Class EndPage
    Dim intScore As Integer
    Dim pbxPenguin As Image
    Sub New(penguinImage As Image)
        ' This call is required by the designer.
        InitializeComponent()
        pbxPenguin = penguinImage

    End Sub

    Sub New(intScore1 As Integer)

        ' This call is required by the designer.
        InitializeComponent()
        intScore = intScore1

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        'Closes the EndPage form
        Close()
    End Sub

    Private Sub btnReplay_Click(sender As Object, e As EventArgs) Handles btnReplay.Click
        Dim frmFlappyPenguinForm As New FlappyPenguinForm(pbxPenguin)
        'Opens the Game window again to replay
        frmFlappyPenguinForm.ShowDialog()
    End Sub

    Private Sub EndPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class