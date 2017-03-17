Option Strict On
Option Explicit On

Public Class Bolder
    Inherits GameObject
    
    Private Const dblSPEED As Double = 1.75
    Private Const shtTOTAL_BOLDER_TYPES = 2
    Private Const shtSCORE_WORTH as short = 5
    Private Const shtMinHealth as short = 3
    Private Const shtMaxHealth as short = 4

    Private Shared Dim bmpBolderSprites as Bitmap()
    
    Private Dim gGame As frmFinalLab
    private Dim shtHealth as short
    
    Public Sub New(gGame As frmFinalLab, vecPosition As Vector2D)
        me.grabObjectBuffer = Graphics.FromImage(gGame.Buffer)

        Me.gGame = gGame
        Me.Position = vecPosition

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
    
    Friend Sub Damage(Optional intDamage As Short = 1S)
        shtHealth -= intDamage

        if shtHealth <= 0
            ' Increse game score
            gGame.Score += shtSCORE_WORTH
            
            ' Outputs message
            gGame.OutputMessage("Bolder Destroyed! Score: " & Str(gGame.Score))

            ' Delete the bolder
            Delete()
        End If
    End Sub
    
    Public Overrides Sub Update()
        ' Moves position
        Me.Position.Y += dblSPEED

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
