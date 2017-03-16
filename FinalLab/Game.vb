Imports System.Threading

Public Class Game
    Public Property Money As Integer

    Dim _playerShip As PlayerShip
    Public Property PlayerShip As PlayerShip
        Get
            Return _playerShip
        End Get
        Private Set(value As PlayerShip)
            _playerShip = PlayerShip
        End Set
    End Property

    Private gameObjects As List(Of GameObject)

    Friend Sub Spawn(spawnObject As IGameObject)
        gameObjects.Add(spawnObject)
    End Sub

    Dim _enemyShips As List(Of Ship)
    Public ReadOnly Property EnemyShips As Ship()
        Get
            Return _enemyShips.ToArray()
        End Get
    End Property

    Dim dtNextBolderSpawn As Date
    Dim rngRandom As Random

    Public Sub New()
        _playerShip = New PlayerShip(Me)
        gameObjects = New List(Of GameObject)
        _enemyShips = New List(Of Ship)

        dtNextBolderSpawn = Date.MinValue
        rngRandom = New Random()
    End Sub

    Public Sub Update()
        ' Update player
        _playerShip.Update()

        ' Update the enemies
        For Each _enemyPlayer In _enemyShips
            _enemyPlayer.Update()
        Next

        ' Update other game objects
        For Each gameObject As GameObject In gameObjects
            gameObject.Update()

            ' Remove game objects that are set for deletion
            If gameObject.DeleteMe Then
                gameObjects.Remove(gameObject)
            End If
        Next

        ' Spawn Bolders

        Dim intMinBolderSpawnTime As Integer = 200
        Dim intMaxBolderSpawnTime As Integer = 2000

        If (dtNextBolderSpawn < Now()) Then
            Dim intSpawnX = rngRandom.Next(0, 500)

            Spawn(New Bolder(Me, New Vector2D(intSpawnX, 0)))

            Dim intBolderSpawnTimeInMiliseconds = rngRandom.Next(intMaxBolderSpawnTime, intMaxBolderSpawnTime)
            dtNextBolderSpawn = DateTime.Now().AddMilliseconds(intBolderSpawnTimeInMiliseconds)
        End If
    End Sub

    Public Sub Draw(grabBuffer As Graphics)
        Try
            ' Clear graphics
            grabBuffer.Clear(Color.White)

            ' Draw the player
            _playerShip.Draw(grabBuffer)

            ' Draw the enemies
            For Each _enemyPlayer In _enemyShips
                _enemyPlayer.Draw(grabBuffer)
            Next

            ' Draw other game objects
            For Each gameObject As GameObject In gameObjects
                gameObject.Draw(grabBuffer)
            Next
        Catch ex As Exception

        End Try
    End Sub
End Class