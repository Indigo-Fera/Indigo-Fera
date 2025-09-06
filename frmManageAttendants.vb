Public Class frmManageAttendants
    Private Sub btnDeleteAttendants_Click(sender As Object, e As EventArgs) Handles btnDeleteAttendants.Click
        Dim frmDeleteAttendants As New frmDeleteAttendants

        frmDeleteAttendants.ShowDialog()
    End Sub

    Private Sub btnAddAttendants_Click(sender As Object, e As EventArgs) Handles btnAddAttendants.Click
        Dim frmAddAttendants As New frmAddAttendants

        frmAddAttendants.ShowDialog()
    End Sub

    Private Sub btnAddAttendantstoFlights_Click(sender As Object, e As EventArgs) Handles btnAddAttendantstoFlights.Click
        Dim frmAddAttendantstoFlights As New frmAddAttendantstoFlights

        frmAddAttendantstoFlights.ShowDialog()
    End Sub
End Class