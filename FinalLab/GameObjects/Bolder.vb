Option Strict On
Option Explicit On

Public Class Bolder
    Inherits GameObject

    Private Const intSCORE_WORTH as Integer = 5
    Private Const shtMinHealth as short = 4
    Private Const shtMaxHealth as short = 6
    
    Private Dim frmFinalLab As frmFinalLab
    private Dim shtHealth as short

    Public Sub New(frmFinalLab As frmFinalLab, vecPosition As Vector2D)
        Me.frmFinalLab = frmFinalLab
        Me.Position = vecPosition

        ' Make the health random
        me.shtHealth = CShort(frmFinalLab.Random.Next(shtMinHealth, shtMaxHealth))

        ' Make the bolder a random bolder
        Select Case frmFinalLab.Random.Next(1, 2)
            Case 1
                bmpSprite = CType(Image.FromFile("Images/bolder1.jpg"), Bitmap)
            Case 2
                bmpSprite = CType(Image.FromFile("Images/bolder2.jpg"), Bitmap)
        End Select
        
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
            frmFinalLab.Score += intSCORE_WORTH
            
            ' Outputs message
            frmFinalLab.OutputMessage("Bolder Destroyed! Score: " & Str(frmFinalLab.Score))

            ' Delete the bolder
            Delete()
        End If
    End Sub
    
    Public Overrides Sub Update()
        Const dblSPEED As Double = 1.75

        Me.Position.Y += dblSPEED

        If (Collide(frmFinalLab.PlayerShip)) Then
            Delete()
            frmFinalLab.PlayerShip.Damage()
        End If
    End Sub
End Class
