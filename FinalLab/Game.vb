Public Class Game
    Public ReadOnly Property Mouse As Mouse
    Public ReadOnly Property Keyboard As Keyboard

    Public Property Money As Integer

    Dim _playerShip As PlayerShip
    Public Property PlayerShip As Ship
        Get
            Return _playerShip
        End Get
        Private Set(value As Ship)
            _playerShip = PlayerShip
        End Set
    End Property

    Private gameObjects As List(Of GameObject)

    Friend Sub Spawn(spawnObject As Explosion)
        gameObjects.Add(spawnObject)

        If gameObjects.Contains(spawnObject) Then
            Throw New Exception("The item has already been spawned.")
        End If

    End Sub

    Dim _enemyShips As List(Of Ship)
    Public ReadOnly Property EnemyShips As Ship()
        Get
            Return _enemyShips.ToArray()
        End Get
    End Property
    
    Public Sub New()
        _playerShip = New PlayerShip(me)
        gameObjects = new List(Of GameObject)
        _enemyShips = New List(Of Ship)
    End Sub

    Private Sub Update()
        ' Update player
        _playerShip.Update()

        ' Update enemies
        For Each _enemyPlayer In _enemyShips
            _enemyPlayer.Update()
        Next

        ' Update other game objects
        For Each gameObject As GameObject In gameObjects
            gameObject.Update()

            If gameObject.DeleteMe Then
                gameObjects.Remove(gameObject)
            End If
        Next
    End Sub
End Class