Public Class loading
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Panel2.Width += 3
        If (Panel2.Width >= 612) Then
            Timer1.Stop()
            welcome.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub
End Class