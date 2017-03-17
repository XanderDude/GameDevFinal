Option Strict On
Option Explicit On

Public Class Explosion
    Inherits GameObject
    
    private Const intTOTAL_EXPLOSION_IMAGES as Integer = 6
    private Dim Shared tsTotalExplosionTime As TimeSpan = TimeSpan.FromSeconds(2)
    private Dim Shared bmpSprites as Bitmap()

    private Dim swStopwatch As Stopwatch
    private Dim frmFinalLab As frmFinalLab

    Public Sub New(frmFinalLab As frmFinalLab, vecPosition As Vector2D)
        me.Position = vecPosition
        me.swStopwatch = new Stopwatch()
        me.swStopwatch.Start()
        Me.frmFinalLab = frmFinalLab

        ' Load spritse if they haven't been loaded before
        if bmpSprites Is nothing
            bmpSprites = New Bitmap(intTOTAL_EXPLOSION_IMAGES){}
            for i As Integer = 0 to intTOTAL_EXPLOSION_IMAGES - 1
                bmpSprites(i) = New Bitmap($"Images/explosion{CStr(i+1)}.jpg")
                bmpSprites(i).MakeTransparent(GlobalVariables.AplhaColor)
            Next
        End If
    End Sub
    
    Public Overrides Sub Update()
        ' Delete if the elapsed time is 2 seconds
        Dim tsTimeElapsed = swStopwatch.Elapsed

        If tsTimeElapsed >= tsTotalExplosioNTime Then
            ' Stop the stopwatch and delete the explosion
            swStopwatch.Stop()
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
