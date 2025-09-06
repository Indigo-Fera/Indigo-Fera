Public Class Form1
    Private Sub btnAdmin_Click(sender As Object, e As EventArgs) Handles btnAdmin.Click
        Dim frmAdmin As New frmAdmin

        frmAdmin.ShowDialog()
    End Sub

    Private Sub btnAttendant_Click(sender As Object, e As EventArgs) Handles btnAttendant.Click
        Dim frmAttendant As New frmAttendant

        frmAttendant.ShowDialog
    End Sub

    Private Sub btnPilots_Click(sender As Object, e As EventArgs) Handles btnPilots.Click
        Dim frmPilot As New frmPilot

        frmPilot.ShowDialog
    End Sub

    Private Sub btnCustomer_Click(sender As Object, e As EventArgs) Handles btnCustomer.Click
        Dim frmPassenger As New frmPassenger

        frmPassenger.ShowDialog
    End Sub
End Class
