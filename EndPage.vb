Public Class EndPage

    Dim pbxPenguin As Image

    Sub New(penguinImage As Image)
        ' This call is required by the designer.
        InitializeComponent()
        pbxPenguin = penguinImage
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Close()
    End Sub

    Private Sub btnReplay_Click(sender As Object, e As EventArgs) Handles btnReplay.Click
        Dim frmFlappyPenguinForm As New FlappyPenguinForm(pbxPenguin)
        frmFlappyPenguinForm.ShowDialog()
    End Sub
End Class