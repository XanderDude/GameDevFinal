Public Class Score
    Public ReadOnly Property Name As String = Nothing
    Public ReadOnly Property Score As Integer = -1
    Public ReadOnly Property Time As TimeSpan = Nothing

    Public Sub New(name As String, score As Integer, time As TimeSpan)
        Me.Name = name
        Me.Score = score
        Me.Time = time
    End Sub
End Class