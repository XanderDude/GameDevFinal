Option Strict On
Option Explicit On

Public Class Bolder
    Inherits GameObject

    Private Const intSCORE_WORTH as Integer = 5
    Private Const shtMinHealth as short = 4
    Private Const shtMaxHealth as short = 6
    
    Private Dim gGame As frmFinalLab
    private Dim shtHealth as short

    Public Sub New(gGame As frmFinalLab, vecPosition As Vector2D)
        Me.gGame = gGame
        Me.Position = vecPosition

        ' Make the health random
        me.shtHealth = CShort(gGame.Random.Next(shtMinHealth, shtMaxHealth))

        ' Make the bolder a random bolder
        Select Case gGame.Random.Next(1, 2)
            Case 1
                bmpSprite = CType(Image.FromFile("Images/bolder1.jpg"), Bitmap)
            Case 2
                bmpSprite = CType(Image.FromFile("Images/bolder2.jpg"), Bitmap)
        End Select
    End Sub

    public ReadOnly Property Health As short
        get
            return shtHealth
        End Get
    End Property
    
    Friend Sub Damage()
        shtHealth -= 1S

        if shtHealth <= 0
            ' Increse game score
            gGame.Score += intSCORE_WORTH
            
            ' Outputs message
            gGame.OutputMessage("Bolder Destroyed! Score: " & Str(gGame.Score))

            ' Delete the bolder
            Delete()
        End If
    End Sub
    
    Public Overrides Sub Update()
        Const dblSPEED As Double = 1.75

        Me.Position.Y += dblSPEED

        If (Collide(gGame.PlayerShip)) Then
            Delete()
            gGame.PlayerShip.Damage()
        End If
    End Sub
End Class
