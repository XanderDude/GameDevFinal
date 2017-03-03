Public class Mouse
    ReadOnly Property Position As Vector2D

    sub Click()
        Throw new NotImplementedException()
    End sub
    
    Function IsKeyDown(key As EMouseKey) As Boolean
        Throw new NotImplementedException()
    End Function
End class