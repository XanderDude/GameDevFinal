Option Strict On
Option Explicit On

Imports Microsoft.VisualBasic.CompilerServices

Public Class CoinType
    Public Shared ReadOnly Unknown As CoinType = New CoinType("Unknown", 0, "Unknown")
    Public Shared ReadOnly Bronse As CoinType = New CoinType("Bronse", 2, "Bronse")
    Public Shared ReadOnly Silver As CoinType = New CoinType("Silver", 5, "Silver")
    Public Shared ReadOnly Gold As CoinType = New CoinType("Gold", 25, "Gold")
    Public Shared ReadOnly Platinum As CoinType = New CoinType("Platinum", 100, "Platinum")
    Public Shared ReadOnly Property Random() As CoinType
        Get
            Return GetRandomCoinType()
        End Get
    End Property
    
    Public ReadOnly Property Name As String
    Public ReadOnly Property Value As Integer
    Public ReadOnly Property SpriteName As String

    Private Sub New(strName As String, strValue As Integer, strSpriteName As String)
        Me.Name = strName
        Me.Value = strValue
        Me.SpriteName = strSpriteName
    End Sub

    Private Shared Function GetRandomCoinType() As CoinType
        Select Case New Random().Next(1, 4)
            Case 1
                Return Bronse
            Case 2
                Return Silver
            Case 3
                Return Gold
            Case 4
                Return Platinum
            case else
                Throw New InternalErrorException("There was a internal error when generating a random coin type. The random generator for the coin type returned an invalided number.")
        End Select
    End Function
End Class