Public Class ADDNEWGUEST
    Private Sub ADDNEWGUEST_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Muscat_Residence_InnDataSet1.add_guest' table. You can move, or remove it, as needed.
        Me.Add_guestTableAdapter.Fill(Me.Muscat_Residence_InnDataSet1.add_guest)

    End Sub

    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs) Handles BunifuThinButton21.Click
        AddGuestBindingSource.EndEdit()
        Add_guestTableAdapter.Update(Muscat_Residence_InnDataSet1.add_guest)
        MsgBox("UPDATED SUCCESSFULLY!")
    End Sub

    Private Sub BunifuThinButton22_Click(sender As Object, e As EventArgs) Handles BunifuThinButton22.Click
        AddGuestBindingSource.AddNew()
    End Sub
End Class