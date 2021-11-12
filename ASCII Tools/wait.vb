Public Class wait
    Private Sub gio1_Tick(sender As Object, e As EventArgs) Handles gio1.Tick
        home.Show()
        Me.Hide()
        gio1.Stop()
    End Sub
End Class