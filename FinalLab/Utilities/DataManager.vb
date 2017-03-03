Public Class DataManager
    Private Shared DataManager As DataManager = Nothing
    Public Shared Function GetManager() As DataManager
        If (DataManager Is Nothing) Then
            DataManager = New DataManager()
        End If

        Return DataManager
    End Function

    Private _ships As Dictionary(Of String, Ship)
    Private _spriteSheets As Dictionary(Of String, IGameObject)

    Public Function GetShip(shipName As String) As Ship
        Throw New NotImplementedException()
    End Function

    Private Function LoadShip(shipName As String) As Ship
        Throw New NotImplementedException()
    End Function

    Public Function GetSprite(spriteSheetName As String, spriteName As String) As Sprite
        Return GetSpriteSheet(spriteSheetName).GetSprite(spriteName)
    End Function

    Public Function GetSpriteSheet(spriteSheetName As String) As SpriteSheet
        Dim spriteSheet As SpriteSheet = Nothing

        ' Get SpriteSheet
        If (Not _spriteSheets.TryGetValue(spriteSheetName, spriteSheet)) Then
            ' Load spritesheet because it hasn't been loaded
            spriteSheet = LoadSpriteSheet(spriteSheetName)
        End If

        Return spriteSheet
    End Function

    Private Function LoadSpriteSheet(srpiteSheetName As String) As SpriteSheet
        Throw New NotImplementedException()
    End Function
End Class