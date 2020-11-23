Public Class EndPage

    Dim intScore As Integer
    Dim pbxPenguin As Image
    Dim blnReplay As Boolean = False

    Sub New(intScore1 As Integer)
        ' This call is required by the designer.
        InitializeComponent()
        intScore = intScore1
    End Sub

    Public Function blnGetReplay() As Boolean
        Return blnReplay
    End Function

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        'Closes the EndPage form
        Close()
    End Sub

    Private Sub btnReplay_Click(sender As Object, e As EventArgs) Handles btnReplay.Click
        'Sets blnReplay so that the user plays the game again
        blnReplay = True
        Close()
    End Sub

    Private Sub EndPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Shows the final score
        lblFinalScore.Text = "Final Score: " & intScore
    End Sub
End Class