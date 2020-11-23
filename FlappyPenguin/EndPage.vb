Public Class EndPage

    Dim intScore As Integer
    Dim intScores As New List(Of Integer)
    Dim pbxPenguin As Image
    Dim blnReplay As Boolean = False

    Sub New(intPassedScore As Integer, intPassedScores As List(Of Integer))
        ' This call is required by the designer.
        InitializeComponent()
        intScore = intPassedScore
        intScores = lstBubbleSort(intPassedScores)
    End Sub

    Function lstBubbleSort(intToSort As List(Of Integer)) As List(Of Integer)
        Dim intListCount As Integer = intToSort.Count() - 2

        For k = 0 To intListCount
            For i = 0 To intListCount
                If intToSort(i) < intToSort(i + 1) Then
                    Dim intOldValue As Integer = intToSort(i)
                    intToSort(i) = intToSort(i + 1)
                    intToSort(i + 1) = intOldValue
                End If
            Next
        Next

        Return intToSort
    End Function

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
        For Each item In intScores
            lstScores.Items.Add(item)
        Next
    End Sub
End Class