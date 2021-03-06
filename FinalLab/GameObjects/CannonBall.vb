﻿Option Strict On
Option Explicit On

Public Class CannonBall
    Inherits GameObject
    
    Private Const dblSPEED As Double = 3.5

    Private Dim gGame As frmFinalLab

    Sub New(gGame As frmFinalLab, vecPosition As Vector2D)
        me.grabObjectBuffer = Graphics.FromImage(gGame.Buffer)

        Me.gGame = gGame
        Me.Position = vecPosition

        Me.bmpSprite = CType(Image.FromFile("Images/cball.jpg"), Bitmap)
        Me.bmpSprite.MakeTransparent(GlobalVariables.AplhaColor)
    End Sub

    Public Overrides Sub Update()
        ' Continue flying
        Position.Y -= dblSPEED
        
        ' Check if it hits the bolder
        For i As Integer = 0 To gGame.GameObjects.Count - 1
            Dim goGameObject As IGameObject = gGame.GameObjects(i)
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

        ' Delete if off the map
        if(Position.Y < 0)
            Delete()
        End If
    End Sub
End Class