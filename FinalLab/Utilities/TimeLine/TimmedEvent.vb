Imports GameLibary

Public Class TimmedEvent
    Implements ITimeLIneEvent
    ' note: there may be some delay depending on how offten update is called.
    ' This could cause the event to happen later

    Public ReadOnly Property Milliseconds As Integer = -1

    Private _startTime As Date = Nothing
    Private _expectedEndtime As Date = Nothing

    Sub New(milliseconds As Integer)
        milliseconds = milliseconds
    End Sub

    Protected Sub Start() Implements ITimeLIneEvent.Start
        StartTime = Date.Now
        ExpectedEndTime = Date.Now.AddMilliseconds(Milliseconds)
    End Sub

    Public Sub Update() Implements ITimeLIneEvent.Update
        If (Date.Now > ExpectedEndTime) Then
            FinishEvent()
        End If
    End Sub

    Public Sub FinishEvent() Implements ITimeLIneEvent.FinishEvent
        Throw New NotImplementedException()
    End Sub

    Public Property StartTime As Date
        Get
            Return _startTime
        End Get
        Private Set(value As Date)
            _startTime = value
        End Set
    End Property

    Public Property ExpectedEndTime As Date
        Get
            Return _expectedEndtime
        End Get
        Private Set(value As Date)
            _expectedEndtime = value
        End Set
    End Property
End Class