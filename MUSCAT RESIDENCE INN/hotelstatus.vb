Public Class hotelstatus
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label18.Text = DateTime.Now.ToLongTimeString()
        Label17.Text = DateTime.Now.ToLongDateString()
    End Sub

    Private Sub Hotelstatus_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Muscat_Residence_InnDataSet.add_guest' table. You can move, or remove it, as needed.
        Me.Add_guestTableAdapter.Fill(Me.Muscat_Residence_InnDataSet.add_guest)
        'TODO: This line of code loads data into the 'Muscat_Residence_InnDataSet.rooms' table. You can move, or remove it, as needed.
        Me.RoomsTableAdapter.Fill(Me.Muscat_Residence_InnDataSet.rooms)

        '' for counting rooms
        Dim totalRooms = RoomsBindingSource.Count()
        lblTotalRooms.Text = totalRooms.ToString()

        '' for counting guests
        Dim totalGuest = AddGuestBindingSource.Count()
        lblTotalGuest.Text = totalGuest.ToString()



    End Sub
End Class