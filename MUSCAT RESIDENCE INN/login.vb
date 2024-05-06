Public Class login
    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        Me.Close()
    End Sub

    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs) Handles BunifuThinButton21.Click
        Dim user As String
        Dim pass As String
        user = "ridarafiq"
        pass = "rida123"
        If (user = BunifuMaterialTextbox1.Text And pass = BunifuMaterialTextbox2.Text) Then
            MessageBox.Show("Log In Succesfully!", "GREAT!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            loading.Show()
            Me.Hide()

        Else : MessageBox.Show("Inavlid username or password", "Login error!", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End If
    End Sub
End Class
