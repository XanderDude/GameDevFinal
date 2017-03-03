Public Class PlayerShip
    Inherits Ship
    Private Dim game as game
    
    Private keyboard As Keyboard = Nothing
    Private mouse As Mouse = Nothing

    Sub New()
        MyBase.New(1000, 1000)

        game = Game.GetGame()

        keyboard = game.Keyboard
        mouse = game.Mouse
    End Sub

    Public Overrides Sub Update()
        
    End Sub

    Public Overrides Function Collide(testObject As IGameObject) As Boolean
        Throw New NotImplementedException
    End Function
End Class