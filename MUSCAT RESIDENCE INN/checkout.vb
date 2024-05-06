Public Class checkout
    Private Sub checkout_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Muscat_Residence_InnDataSet.check_in' table. You can move, or remove it, as needed.
        Me.Check_inTableAdapter.Fill(Me.Muscat_Residence_InnDataSet.check_in)

    End Sub

    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs) Handles BunifuThinButton21.Click
        CheckInBindingSource.RemoveCurrent()
        Check_inTableAdapter.Update(Muscat_Residence_InnDataSet.check_in)
    End Sub
End Class