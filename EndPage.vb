Public Class EndPage
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub

    Private Sub btnReplay_Click(sender As Object, e As EventArgs) Handles btnReplay.Click

        Dim frmFlappyPenguinForm As New FlappyPenguinForm(pbxFailedPenguin.Image)
        frmFlappyPenguinForm.ShowDialog()
    End Sub
End Class