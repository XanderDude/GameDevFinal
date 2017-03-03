Public Class SpriteSheet
    Public ReadOnly Property Name As String

    Private _sprites As Dictionary(Of String, Sprite)

    Sub New(name As String)
        name = name
    End Sub

    Public Function GetSprite(spriteName As String) As Sprite
        Dim sprite As IGameObject = Nothing

        If (Not _sprites.TryGetValue(spriteName, sprite)) Then
            sprite = LoadSprite(spriteName)
        End If

        Return sprite
    End Function

    Private Function LoadSprite(spriteName As String) As Sprite
        Throw New NotImplementedException()
    End Function
End Class