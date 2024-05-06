Public Class guest

    Sub switchpanel(ByVal panel As Form)
        Panel1.Controls.Clear()
        panel.TopLevel = False
        Panel1.Controls.Add(panel)
        panel.Show()

    End Sub

    Private Sub BunifuThinButton22_Click(sender As Object, e As EventArgs) Handles BunifuThinButton22.Click
        switchpanel(ADDNEWGUEST)
    End Sub

    Private Sub b_Click(sender As Object, e As EventArgs) Handles b.Click
        switchpanel(guestlist)
    End Sub


End Class