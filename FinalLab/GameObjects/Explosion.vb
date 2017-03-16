Public Class Explosion
    Inherits GameObject
    Dim stopwatch As Stopwatch

    Dim gGame As Game

    Public Sub New(gGame As Game, vecPosition As Vector2D)
        Me.gGame = gGame
        Position = vecPosition

        stopwatch.Start()
    End Sub

    Public Overrides Sub Update()
        ' Play animation
        ' todo this

        ' Delete if the elapsed time is 2 seconds
        If stopwatch.Elapsed > TimeSpan.FromSeconds(2) Then
            stopwatch.Stop()
            Delete()
        End If
    End Sub
End Class
