Public Class BILLING
    Dim a, b, c, d As Double


    Private Sub BunifuMaterialTextbox1_OnValueChanged(sender As Object, e As EventArgs) Handles BunifuMaterialTextbox1.OnValueChanged
        BunifuMaterialTextbox1.Text = TimeOfDay
    End Sub


    Private Sub BunifuThinButton23_Click(sender As Object, e As EventArgs) Handles BunifuThinButton23.Click
        a = BunifuMetroTextbox9.Text
        b = BunifuMetroTextbox8.Text
        c = BunifuMetroTextbox10.Text

        BunifuMetroTextbox11.Text = d
        d = a + b + c




    End Sub
End Class