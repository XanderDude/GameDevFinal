Public Class PlayerShip
    Inherits GameObject
    
    Private Const shtTOTAL_LIVES as short = 5

    Private Dim dtLastShoot As DateTime
    Private Dim intMaxLives As Integer
    Private Dim intLives As Integer

    Protected gGame As frmFinalLab
    
    Sub New(gGame As frmFinalLab)
        me.gGame = gGame
        Me.Position = New Vector2D(250, 500)
        Me.bmpSprite = Image.FromFile("Images/player_ship.jpg")

        me.dtLastShoot = Now()
        Me.intLives = shtTOTAL_LIVES
        me.intMaxLives = shtTOTAL_LIVES
    End Sub
    
    Public ReadOnly Property LastShot as DateTime
    get
            return dtLastShoot
    End Get
    End Property
    Public ReadOnly Property Lives As Integer
        Get
            Return Lives
        End Get
    End Property
    Public ReadOnly Property MaxLives As Integer
        Get
            Return MaxLives
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
        
        If (intLives < 0) Then
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
        ' End the game
        gGame.EndGame()
        
        'Spawn Explosion object
        gGame.Spawn(New Explosion(gGame, Position.Clone()))

        ' Delete the ship
        Delete()
    End Sub
End Class