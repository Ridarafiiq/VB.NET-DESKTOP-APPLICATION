Public Class welcome
    Dim ClickCount As Integer = 1
    Dim currentpanel As Form
    Public Property Guestcheckin As Form

    Sub switchpanel(ByVal panel As Form)
        Try
            If currentpanel IsNot Nothing Then
                currentpanel.Close()
            End If
            currentpanel = panel
            Panel8.Controls.Clear()
            panel.TopLevel = False
            Panel8.Controls.Add(panel)
            panel.Show()
        Catch ex As Exception

        End Try

    End Sub
    Private Sub PictureBox9_Click(sender As Object, e As EventArgs) Handles PictureBox9.Click
        Application.Exit()
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs)
        Timer1.Enabled = True

    End Sub



    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        switchpanel(BILLING)

    End Sub


    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        switchpanel(guest)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        switchpanel(checkout)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        switchpanel(hotelstatus)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        switchpanel(Rooms)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        switchpanel(newCheckIn)
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        Dim DIALOG As DialogResult
        DIALOG = MessageBox.Show("DO YOU REALLY WANT TO CLOSE THE APPLICATION?", "EXIT", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If DIALOG = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub welcome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        switchpanel(hotelstatus)
    End Sub
End Class