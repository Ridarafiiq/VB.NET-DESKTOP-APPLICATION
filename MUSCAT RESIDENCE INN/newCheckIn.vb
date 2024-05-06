Public Class newCheckIn
    Private Sub newCheckIn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Muscat_Residence_InnDataSet1.check_in' table. You can move, or remove it, as needed.
        Me.Check_inTableAdapter.Fill(Me.Muscat_Residence_InnDataSet1.check_in)
        CheckInBindingSource.AddNew()
    End Sub

    Private Sub BunifuThinButton22_Click(sender As Object, e As EventArgs) Handles BunifuThinButton22.Click
        Try
            CheckInBindingSource.EndEdit()
            Check_inTableAdapter.Update(Muscat_Residence_InnDataSet1.check_in)
            MsgBox("Updated")
        Catch ex As Exception
            MsgBox("ERROR!")
        End Try

    End Sub

    Private Sub BunifuThinButton23_Click(sender As Object, e As EventArgs) Handles BunifuThinButton23.Click
        CheckInBindingSource.AddNew()

    End Sub
End Class