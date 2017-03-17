﻿Option Strict On
Option Explicit On

Public Class PlayerShip
    Inherits GameObject
    
    Private Const shtTOTAL_LIVES as short = 5

    Private Dim dtLastShoot As DateTime
    Private Dim intMaxLives As Integer
    Private Dim intLives As Integer
    Private Dim boolDead as Boolean
    private dim gGame As frmFinalLab
    
    Sub New(gGame As frmFinalLab)
        me.grabObjectBuffer = Graphics.FromImage(gGame.Buffer)

        Me.Position = New Vector2D(250, 500)
        Me.bmpSprite = CType(Image.FromFile("Images/player_ship.jpg"), Bitmap)
        me.bmpSprite.MakeTransparent(GlobalVariables.AplhaColor)

        me.dtLastShoot = Now()
        Me.intLives = shtTOTAL_LIVES
        me.intMaxLives = shtTOTAL_LIVES
        me.gGame = gGame
    End Sub
    
    Public ReadOnly Property LastShot as DateTime
    get
            return dtLastShoot
    End Get
    End Property
    Public ReadOnly Property Lives As Integer
        Get
            Return intLives
        End Get
    End Property
    Public ReadOnly Property MaxLives As Integer
        Get
            Return intMaxLives
        End Get
    End Property
    Public ReadOnly Property Dead as Boolean
    get
        return boolDead
    End Get
    End Property
    
    Public Overrides Sub Update()
    End Sub
    
    Public Sub AtemptShoot()
        Dim tsTimePerShot As TimeSpan = TimeSpan.FromSeconds(0.25)

        If (dtLastShoot + tsTimePerShot < Now()) Then
            ForcecShoot()
        End If
    End Sub

    Public Sub ForcecShoot()
        Dim cbCannonBall As CannonBall = New CannonBall(gGame, Vector2D.Zero)

        dtLastShoot = DateTime.Now()

        ' Set cannonball to ship
        cbCannonBall.Position.X = Position.X
        cbCannonBall.Position.Y = Position.Y

        ' Account for ship offset
        cbCannonBall.Position.X += Size.X / 2.0

        ' Account for ball offset
        cbCannonBall.Position.X -= cbCannonBall.Size.X / 2.0

        ' Spawn cannon ball
        gGame.Spawn(cbCannonBall)
    End Sub

    Friend Sub Damage(Optional intDamage As Integer = 1)
        ' Damage intDamage
        intLives -= intDamage
        
        If intLives <= 0 Then
            ' The ship can't have less than 0 lives! (This probably won't matter, but just incase)
            intLives = 0

            ' Output kill message
            gGame.OutputMessage("Your ship was destroyed.")

            ' Kill the ship
            Kill()
        else
            ' Output damage message
            gGame.OutputMessage($"Your ship was damaged. You have {intLives} lives left.")
        End If
    End Sub

    Friend Sub Kill()

        ' This is to prevent muliple explosion animations if the player dies more than once in a frame.
        If Not boolDead
            'Spawn Explosion object
            gGame.Spawn(New Explosion(gGame, Position.Clone()))

            boolDead = true
        End If
        ' Delete the ship
        Delete()
    End Sub
End Class