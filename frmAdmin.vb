Public Class frmAdmin
    Private Sub btnStats_Click(sender As Object, e As EventArgs) Handles btnStats.Click
        Dim frmStats As New frmStats

        frmStats.ShowDialog()
    End Sub

    Private Sub btnManageAttendants_Click(sender As Object, e As EventArgs) Handles btnManageAttendants.Click
        Dim frmManageAttendants As New frmManageAttendants

        frmManageAttendants.ShowDialog()
    End Sub

    Private Sub btnManagePilots_Click(sender As Object, e As EventArgs) Handles btnManagePilots.Click
        Dim frmManagePilots As New frmManagePilots

        frmManagePilots.ShowDialog()
    End Sub
End Class