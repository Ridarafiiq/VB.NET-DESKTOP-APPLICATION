Public Class Rooms
    Private Sub roomsRooms_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.RoomsTableAdapter.Fill(Me.Muscat_Residence_InnDataSet.rooms)
    End Sub
    Private Sub BunifuThinButton22_Click(sender As Object, e As EventArgs) Handles BunifuThinButton22.Click
        RoomsBindingSource.AddNew()
    End Sub

    Private Sub BunifuThinButton23_Click(sender As Object, e As EventArgs) Handles BunifuThinButton23.Click
        RoomsBindingSource.RemoveCurrent()
        RoomsTableAdapter.Update(Muscat_Residence_InnDataSet.rooms)
        MsgBox("THE RECORD HAS BEEN DELETED!")
    End Sub

    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs) Handles BunifuThinButton21.Click
        RoomsBindingSource.EndEdit()
        RoomsTableAdapter.Update(Muscat_Residence_InnDataSet.rooms)
        MsgBox("RECORD IS SAVED SUCCESSFULLY!")
    End Sub

    Private Sub tb1_OnValueChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub BunifuThinButton24_Click(sender As Object, e As EventArgs)
    End Sub
End Class

