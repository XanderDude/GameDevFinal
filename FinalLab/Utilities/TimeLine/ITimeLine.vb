Public Class TimeLine
    Private _game As Game

    Protected _firstEvent As TimeLineEvent
    Public Property FirstEvent As TimeLineEvent
        Get
            Return _firstEvent
        End Get
        Private Set(value As TimeLineEvent)
            _firstEvent = value
        End Set
    End Property

    Protected _lastevent As TimeLineEvent
    Public Property LastEvent As TimeLineEvent
        Get
            Return _lastevent
        End Get
        Private Set(value As TimeLineEvent)
            _lastevent = value
        End Set
    End Property

    Sub New(game As Game)
        Me._game =game
    End Sub

    Sub New(game As Game, events As IEnumerable(Of TimeLineEvent))
        _game = game

        FirstEvent = events.LastOrDefault()
        LastEvent = events.LastOrDefault()

        ' This won't work unless there are at least one item in the array
        ' If there is no item and the any check is left out, the for loop will have an error because
        ' events.Count -2 would be negitive
        If (events.Any) Then

            ' Loop through the events
            ' Minuse 2 because 1 less than count is the amount, and we don't do the last one because
            ' we dont have anything to set the next event in it to
            For i As Integer = 0 To events.Count() - 2
                ' Set the next event
                events(i).NextEvent = events(i + 1)
            Next
        End If

    End Sub

    Public Sub AddEvent(timeLineEvent As TimeLineEvent)
        ' If there are no events set this as the first event
        If (FirstEvent Is Nothing) Then
            FirstEvent = timeLineEvent
        End If

        ' Add this event to the end
        LastEvent.NextEvent = timeLineEvent

        ' Set the last event to this event
        LastEvent = timeLineEvent
    End Sub

    Public Sub AddEvents(events As IEnumerable(Of TimeLineEvent))
        ' Not the most efficent but its more readable and relyable this way
        For Each timeLineEvent In events
            AddEvent(timeLineEvent)
        Next
    End Sub

    Public Sub Update()
        ' If there is a current event
        If (_firstEvent IsNot Nothing) Then

            ' Update the current event
            _firstEvent.Update()

            ' If the event is done, set the current event to the next event
            If (_firstEvent.EventDone) Then
                _firstEvent = _firstEvent.NextEvent
            End If
        End If
    End Sub
End Class