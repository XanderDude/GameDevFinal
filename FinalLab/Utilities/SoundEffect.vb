Public Class SoundEffect
    Private _playing As Boolean = False
    Private _deleteMe As Boolean = False

    Public Sub Play()
        _playing = True
    End Sub

    Public Sub [Stop]()
        _playing = False
    End Sub

    Public Sub Delete()
        _deleteMe = True
    End Sub

    Public Property Playing As Boolean
        Get
            Return _playing
        End Get
        Protected Set(value As Boolean)
            _playing = value
        End Set
    End Property

    Public Property DeleteMe As Boolean
        Get
            Return _deleteMe
        End Get
        Protected Set(value As Boolean)
            _deleteMe = value
        End Set
    End Property
End Class