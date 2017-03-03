Public Class Explosion
    Inherits GameObject
    Dim stopwatch As Stopwatch

    Public Sub New()
        stopwatch.Start()
    End Sub

    Public Overrides Sub Update()
        ' Play animation
        ' todo this

        ' Delete if the elapsed time is 2 seconds
        If stopwatch.Elapsed > TimeSpan.FromSeconds(2D) Then
            stopwatch.Stop()
            Delete()
        End If
    End Sub

End Class
