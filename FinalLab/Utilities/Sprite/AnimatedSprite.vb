Public Class AnimatedSprite
    Public ReadOnly Property _spriteSheet As SpriteSheet
    Public ReadOnly Property SpriteSheet As SpriteSheet
        Get
            Return _spriteSheet
        End Get
    End Property

    Dim _spriteName As String
    Public ReadOnly Property SpriteName As String
        Get
            Return _spriteName
        End Get
    End Property

    Dim _currentSprite As Sprite
    Public ReadOnly Property CurrentSprite As Sprite
        Get
            If (_currentSprite Is Nothing) Then
                _currentSprite = _spriteSheet.GetSprite(_spriteName)
            End If

            Return _currentSprite
        End Get
    End Property

    Dim _spritePosition As IntSquare
    Public ReadOnly Property SpritePosition As IntSquare
        Get
            Return _spritePosition
        End Get
    End Property

    Public Sub New(spriteSheet As SpriteSheet, defaultSprite As String)
        _spriteSheet = spriteSheet
        _spriteName = defaultSprite
    End Sub

    Public Sub ChangeSprite(newSprite As String)
        _spriteName = newSprite
        _currentSprite = Nothing
    End Sub
End Class