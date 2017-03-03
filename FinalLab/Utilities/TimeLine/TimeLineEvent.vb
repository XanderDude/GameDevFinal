Public Class TimeLineEvent
    Implements ITimeLIneEvent

    Private _eventDone As Boolean
    Public Property EventDone As Boolean
        Get
            Return _eventDone
        End Get
        Private Set(value As Boolean)
            _eventDone = value
        End Set
    End Property

    Private _nextEvent As TimeLineEvent
    Public Property NextEvent As TimeLineEvent
        Get
            Return _nextEvent
        End Get
        Friend Set(value As TimeLineEvent)
            _nextEvent = value
        End Set
    End Property

    Protected Overridable Sub Start() Implements ITimeLIneEvent.Start

    End Sub
    Public Overridable Sub Update() Implements ITimeLIneEvent.Update

    End Sub

    Protected Sub FinishEvent() Implements ITimeLIneEvent.FinishEvent
        EventDone = True
    End Sub
End Class
