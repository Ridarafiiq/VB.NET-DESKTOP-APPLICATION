Public Class guestlist
    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Muscat_Residence_InnDataSet.add_guest' table. You can move, or remove it, as needed.
        Me.Add_guestTableAdapter.Fill(Me.Muscat_Residence_InnDataSet.add_guest)
        'TODO: This line of code loads data into the 'Muscat_Residence_InnDataSet2.add_guest' table. You can move, or remove it, as needed.
        Me.Add_guestTableAdapter.Fill(Me.Muscat_Residence_InnDataSet.add_guest)


    End Sub

    Private Sub BunifuCustomDataGrid1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGrid1.CellContentClick

    End Sub

    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs) Handles BunifuThinButton21.Click
        Try
            If textbox1.Text IsNot "" Then
                AddGuestBindingSource.Filter =
               String.Format("[CUSTOMER ID] Like '%" & textbox1.Text) & "%'"
            Else
                AddGuestBindingSource.Filter = String.Empty
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub notfound()

    End Sub

    Private Sub Textbox1_OnValueChanged(sender As Object, e As EventArgs) Handles textbox1.OnValueChanged
        Try
            If textbox1.Text IsNot "" Then
                AddGuestBindingSource.Filter =
               String.Format("[CUSTOMER ID] Like '%" & textbox1.Text) & "%'"
            Else
                AddGuestBindingSource.Filter = String.Empty
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class