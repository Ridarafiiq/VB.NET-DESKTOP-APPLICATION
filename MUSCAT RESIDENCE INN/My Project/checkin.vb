Public Class checkin
    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs) Handles BunifuThinButton21.Click
        BunifuMaterialTextbox1.Text = BunifuDatepicker1.Value.ToShortTimeString
    End Sub
End Class