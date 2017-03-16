Public Class PlayerShip
    Inherits Ship
    Private gGame As Game

    Dim dtLastShoot As DateTime

    Sub New(gGame As Game)
        MyBase.New(CType(gGame, Global.FinalLab.Game), CInt(1000), CInt(1000))
        Me.gGame = gGame

        Me.Position = New Vector2D(250, 500)
        Me.Size = New Vector2D(32, 64)
        Me.bmpSprite = New Bitmap("Images/player_ship.png")

        dtLastShoot = Now()
    End Sub

    Public Overrides Sub Update()
    End Sub

    Public Sub AtemptShoot()
        Dim tsTimePerShot As TimeSpan = TimeSpan.FromSeconds(0.25)

        If (dtLastShoot + tsTimePerShot < Now()) Then
            ForcecShoot()
        End If
    End Sub

    Public Sub ForcecShoot()
        dtLastShoot = DateTime.Now()

        Dim vecBulletPosition = New Vector2D(Position.X, Position.Y)

        vecBulletPosition.X += Size.X / 2

        gGame.Spawn(New Bullet(gGame, Me, vecBulletPosition))
    End Sub
End Class