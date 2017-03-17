Imports FinalLab

Public Class Bolder
    Inherits GameObject
    Dim gGame As frmFinalLab

    Public Sub New(gGame As frmFinalLab, vecPosition As Vector2D)
        Me.gGame = gGame
        Me.Position = vecPosition

        Select Case gGame.Random.Next(1, 2)
            Case 1
                bmpSprite = Image.FromFile("Images/bolder1.jpg")
            Case 2
                bmpSprite = Image.FromFile("Images/bolder2.jpg")
        End Select
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
