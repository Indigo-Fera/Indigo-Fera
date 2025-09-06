Public Class frmManagePilots
    Private Sub btnAddPilots_Click(sender As Object, e As EventArgs) Handles btnAddPilots.Click
        Dim frmAddPilots As New frmAddPilots

        frmAddPilots.ShowDialog()
    End Sub

    Private Sub btnDeletePilots_Click(sender As Object, e As EventArgs) Handles btnDeletePilots.Click
        Dim frmDeletePilots As New frmDeletePilots

        frmDeletePilots.ShowDialog()
    End Sub

    Private Sub btnAddPilotstoFlights_Click(sender As Object, e As EventArgs) Handles btnAddPilotstoFlights.Click
        Dim frmAddPilotsToFlights As New frmAddPilotsToFlights

        frmAddPilotsToFlights.ShowDialog()
    End Sub
End Class