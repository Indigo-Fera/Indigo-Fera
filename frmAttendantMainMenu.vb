Public Class frmAttendantMainMenu
    Private Sub btnFutureFlights_Click(sender As Object, e As EventArgs) Handles btnFutureFlights.Click
        Dim frmFutureFlights As New frmAttendantsFutureFlights

        frmFutureFlights.ShowDialog()
    End Sub

    Private Sub btnPastFlights_Click(sender As Object, e As EventArgs) Handles btnPastFlights.Click
        Dim frmPastFlights As New frmAttendantPastFlights

        frmPastFlights.ShowDialog()
    End Sub

    Private Sub btnUpdateAttendant_Click(sender As Object, e As EventArgs) Handles btnUpdateAttendant.Click
        Dim frmUpdateAttendant As New frmUpdateAttendant

        frmUpdateAttendant.ShowDialog()
    End Sub
End Class