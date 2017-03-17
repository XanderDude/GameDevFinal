Public Class Explosion
    Inherits GameObject

    Const intTOTAL_EXPLOSION_IMAGES as Integer = 6
    Dim Shared tsTotalExplosionTime As TimeSpan = TimeSpan.FromSeconds(2)

    Dim stopwatch As Stopwatch

    Dim gGame As frmFinalLab

    Dim Shared bmpSprites as Bitmap()

    Public Sub New(gGame As frmFinalLab, vecPosition As Vector2D)
        Me.gGame = gGame
        Position = vecPosition

        stopwatch = new Stopwatch()
        stopwatch.Start()

        ' Load spritse if they haven't been loaded before
        if bmpSprites Is nothing
            bmpSprites = New Bitmap(intTOTAL_EXPLOSION_IMAGES){}
            for i As Integer = 0 to intTOTAL_EXPLOSION_IMAGES - 1
                bmpSprites(i) = New Bitmap($"Images/explosion{CStr(i+1)}.jpg")
            Next
        End If
    End Sub

    Public Overrides Sub Update()
        ' Delete if the elapsed time is 2 seconds
        Dim tsTimeElapsed = stopwatch.Elapsed

        If tsTimeElapsed >= tsTotalExplosioNTime Then
            ' Stop the stopwatch and delete the explosion
            stopwatch.Stop()
            Delete()
        else
            ' Play animation
            Dim bytExplosionFrame As Byte = CByte(Math.Floor((tsTimeElapsed.TotalMilliseconds / tsTotalExplosioNTime.TotalMilliseconds) * intTOTAL_EXPLOSION_IMAGES))
        
            ' Weird case where if this runs between 999.5 ms and 999.99999999999998 ms that the top part won't trigger
            ' but the bottom will and crashes the program by setting intExplosionFrame to 7.
            If bytExplosionFrame >= 7
                bytExplosionFrame = 7
            End If

            bmpSprite = bmpSprites(bytExplosionFrame+1)
        End If
    End Sub
End Class
