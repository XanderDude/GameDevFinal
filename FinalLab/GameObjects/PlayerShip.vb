Public Class PlayerShip
    Inherits GameObject

    Dim dtLastShoot As DateTime
    Dim _maxLives As Integer = -1
    Public ReadOnly Property MaxLives As Integer
        Get
            Return _maxLives
        End Get
    End Property

    Dim _lives As Integer = -1
    Public ReadOnly Property Lives As Integer
        Get
            Return _lives
        End Get
    End Property

    Protected gGame As frmFinalLab
    
    Friend Sub Damage(Optional lives As Integer = 1)
        _lives -= lives
        If (_lives < 0) Then
            Kill()
            gGame.EndGame()
            gGame.Spawn(new Explosion(gGame, Position))
        End If
    End Sub

    Sub New(gGame As frmFinalLab)
        Const shtLIVES as short = 5
        me.gGame = gGame
        Me.Position = New Vector2D(250, 500)
        Me.bmpSprite = Image.FromFile("Images/player_ship.jpg")
        Me._lives = shtLIVES
        me._maxLives = shtLIVES

        dtLastShoot = Now()
    End Sub

    Public Overrides Sub Update()
    End Sub

    Friend Sub Kill()
        'Spawn Explosion object
        gGame.Spawn(New Explosion(gGame, Position.Clone()))

        ' Delete the ship
        Delete()
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
End Class