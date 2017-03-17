Option Strict On
Option Explicit On

Public Class CannonBall
    Inherits GameObject
    
    Private Const dblSPEED As Double = 3.5

    Private Dim gGame As frmFinalLab

    Sub New(gGame As frmFinalLab, vecPosition As Vector2D)
        Me.gGame = gGame
        Me.Position = vecPosition

        Me.bmpSprite = CType(Image.FromFile("Images/cball.jpg"), Bitmap)
    End Sub

    Public Overrides Sub Update()
        ' Continue flying
        Position.Y -= dblSPEED
        
        ' Check if it hits the bolder
        for each goGameObject as GameObject in gGame.GameObjects
            If typeof goGameObject Is Bolder
                If Collide(goGameObject)
                    Dim bBolder as Bolder = CType(goGameObject, Bolder)
                    
                    ' Damage the bolder
                    bBolder.Damage()

                    ' Delete cannon ball
                    Delete()
                end if
            End If
        Next
    End Sub
End Class