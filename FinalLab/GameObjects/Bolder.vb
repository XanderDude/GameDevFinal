Option Strict On
Option Explicit On

Public Class Bolder
    Inherits GameObject
    
    Private Const dblMinYSpeed  as Double= 1
    Private Const dblMaxYSpeed as Double = 3
    Private Const dblMinXSpeed as Double = -1
    Private Const dblMaxXSpeed as Double = 1
    Private Const shtTOTAL_BOLDER_TYPES As short = 2
    Private Const shtSCORE_WORTH as short = 5
    Private Const shtMinHealth as short = 3
    Private Const shtMaxHealth as short = 4

    Private Shared Dim bmpBolderSprites as Bitmap()
    
    Private Dim gGame As frmFinalLab
    private Dim shtHealth as short
    Private Dim dblSpeed As Vector2D
    Private Dim boolDestroyed as Boolean
    
    Public Sub New(gGame As frmFinalLab, vecPosition As Vector2D)
        me.grabObjectBuffer = Graphics.FromImage(gGame.Buffer)

        Me.gGame = gGame
        Me.Position = vecPosition
        me.dblSpeed = new Vector2D(
            (gGame.Random.NextDouble() * (dblMaxXSpeed-dblMinXSpeed)) + dblMinXSpeed,
            (gGame.Random.NextDouble() * (dblMaxYSpeed-dblMinYSpeed)) + dblMinYSpeed)
        boolDestroyed = false

        ' Make the health random
        me.shtHealth = CShort(frmFinalLab.Random.Next(shtMinHealth, shtMaxHealth+1))

        ' Set the bolder sprites
        if bmpBolderSprites Is nothing
            bmpBolderSprites = new Bitmap() {
                CType(Image.FromFile("Images/bolder1.jpg"), Bitmap),
                CType(Image.FromFile("Images/bolder2.jpg"), Bitmap)
            }
        End If

        ' Pick a random bolder
        Dim shtBolderSpriteNumber = CShort(frmFinalLab.Random.Next(1, bmpBolderSprites.Length + 1))

        ' Set the sprite for the bolder
        bmpSprite = bmpBolderSprites(shtBolderSpriteNumber - 1)
        
        ' Make the sprite transparrent
        me.bmpSprite.MakeTransparent(GlobalVariables.AplhaColor)
    End Sub

    public ReadOnly Property Health As short
        get
            return shtHealth
        End Get
    End Property
    Public ReadOnly Property Speed as Vector2D
        get
            Return dblSpeed
        End Get
    End Property
    Public ReadOnly Property Destroyed as Boolean
        get
            Return boolDestroyed
        End Get
    End Property
    
    Public Sub Damage(Optional intDamage As Short = 1S)
        shtHealth -= intDamage

        if shtHealth <= 0
           Destroy()
        End If
    End Sub

    Public sub Destroy()
        ' This asures that it can only be destroyed once.
        If Not boolDestroyed
            ' Set destroyed to true
            boolDestroyed = true

            ' Set health to 0
            shtHealth = 0

            ' Increse game score
            gGame.Score += shtSCORE_WORTH
        
            gGame.Spawn(new Coin(gGame, Position.Clone()))

            ' Outputs message
            gGame.OutputMessage("Bolder Destroyed! Score: " & Str(gGame.Score))
        
            ' Delete the bolder
            Delete()
        End If
    End sub
    
    Public Overrides Sub Update()
        ' Moves position
        Me.Position += dblSPEED
        
        ' Damage ship if collides
        If (Collide(gGame.PlayerShip)) Then
            Delete()
            gGame.PlayerShip.Damage()
        End If

        ' Delete if off the map
        if(Position.Y > gGame.pnlGame.Height)
            Delete()
        End If
    End Sub
End Class
