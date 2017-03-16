Public Interface IGameObject
    ReadOnly Property Position As Vector2D
    ReadOnly Property Size As Vector2D
    ReadOnly Property Acell As Vector2D
    ReadOnly Property DeleteMe As Boolean

    Function Collide(testObject As IGameObject) As Boolean
    Sub Update()
    Sub Draw(grabBuffer As Graphics)
End Interface