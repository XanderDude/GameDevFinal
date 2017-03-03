Public Class CoinType
    Public Shared Unknown As CoinType = New CoinType("Unknown", 0, "Unknown")
    Public Shared Bronse As CoinType = New CoinType("Bronse", 2, "Bronse")
    Public Shared Silver As CoinType = New CoinType("Silver", 5, "Silver")
    Public Shared Gold As CoinType = New CoinType("Gold", 25, "Gold")
    Public Shared Platinum As CoinType = New CoinType("Platinum", 100, "Platinum")

    Public ReadOnly Property Name As String
    Public ReadOnly Property Value As Integer
    Public ReadOnly Property SpriteName As String

    Private Sub New(name As String, value As Integer, spriteName As String)
        Me.Name = name
        Me.Value = value
        Me.SpriteName = spriteName
    End Sub
End Class