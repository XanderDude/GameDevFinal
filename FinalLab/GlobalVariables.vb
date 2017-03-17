Option Strict On
Option Explicit On

Public Class GlobalVariables
    Public Shared ReadOnly Property AplhaColor as Color
        get
                return Color.FromArgb(255, 0, 250, 249)
        End Get
    End Property
End Class
