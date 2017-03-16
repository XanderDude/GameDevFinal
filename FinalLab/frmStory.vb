Public Class frmStory
    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        My.Computer.Audio.Play("Sound\GUIButtonClicked.wav")
        Me.Close()
    End Sub
End Class