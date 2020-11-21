Public Class StartPage
    'Final Project Flappy Penguin
    'A game where a penguin jumps through obstacles to gain points
    'Connor Hultman and Tucker Robson
    '10/26/2020

    Private Sub btnUnlocks_Click(sender As Object, e As EventArgs) Handles btnUnlocks.Click
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
        Dim frmFlappyPenguinForm As New FlappyPenguinForm(pbxPenguin.Image)
        Dim frmEndPage As New Object

        Visible = False
        frmFlappyPenguinForm.ShowDialog()

        Dim intScore As Integer = frmFlappyPenguinForm.intGetScore()
        frmEndPage = New EndPage(intScore)
        frmEndPage.ShowDialog()

        Dim blnReplay As Boolean = frmEndPage.blnGetReplay()
        If blnReplay Then
            btnStart_Click(sender, e)
        End If

        Visible = True
    End Sub

    Private Sub StartPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pbxPenguin.Image.RotateFlip(RotateFlipType.RotateNoneFlipX)
    End Sub
End Class
