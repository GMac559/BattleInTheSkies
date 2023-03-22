Public Class Start
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Game.Refresh()
        Game.ShowDialog()
    End Sub
    Private Sub Start_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Refresh()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        ControlScreen.Show()
    End Sub
End Class