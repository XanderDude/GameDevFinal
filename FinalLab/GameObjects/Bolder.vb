Imports FinalLab

Public Class Bolder
    Inherits GameObject
    Dim gGame As Game

    Public Sub New(gGame As Game, vecPosition As Vector2D)
        Me.gGame = gGame
        Me.Position = vecPosition
        Me.Size = New Vector2D(64, 64)

        bmpSprite = Image.FromFile("Images/bolder.jpg")
    End Sub

    Public Sub Destroy()
        gGame.Spawn(New Coin(CoinType.Random))
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
