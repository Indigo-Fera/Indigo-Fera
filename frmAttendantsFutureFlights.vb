Public Class frmAttendantsFutureFlights
    Private Sub frmAttendantsFutureFlights_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try

            Dim intSelect As Integer
            Dim strSelect As String = ""
            Dim cmdSelect As OleDb.OleDbCommand            ' this will be used for our Select statement
            Dim drSourceTable As OleDb.OleDbDataReader     ' this will be where our result set will 
            Dim dt As DataTable = New DataTable            ' this is the table we will load from our reader
            Dim intMilesFlown As Integer


            ' open the DB
            If OpenDatabaseConnectionSQLServer() = False Then

                ' No, warn the user ...
                MessageBox.Show(Me, "Database connection error." & vbNewLine &
                                    "The application will now close.",
                                    Me.Text + " Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error)

                ' and close the form/application
                Me.Close()

            End If

            intSelect = Attendant_ID_Storage_Location()


            ' Build the select statement

            strSelect = "SELECT TP.*, TF.*, TPA.*, TPF.*, TA.* " &
                        "FROM TAttendants AS TP " &
                        "JOIN TAttendantFlights AS TPF " &
                        "ON TPF.intAttendantID = TP.intAttendantID " &
                        "JOIN TFlights AS TF " &
                        "ON TF.intFlightID = TPF.intFlightID " &
                        "JOIN TAirports AS TA " &
                        "ON TA.intAirportID = TF.intFromAirportID " &
                        "JOIN TPlanes AS TPA " &
                        "ON TPA.intPlaneID = TF.intPlaneID " &
                        "WHERE TP.intAttendantID = " & intSelect & "and " &
                        "dtmFlightDate > '4/6/2024'"

            ' Retrieve all the records 

            cmdSelect = New OleDb.OleDbCommand(strSelect, m_conAdministrator)
            drSourceTable = cmdSelect.ExecuteReader

            lstOutput.Items.Add("Roster of All Flights")
            lstOutput.Items.Add("  ")
            lstOutput.Items.Add("=======================================")

            While drSourceTable.Read()

                lstOutput.Items.Add("  ")
                lstOutput.Items.Add("Flight Date: " & vbTab & drSourceTable("dtmFlightDate"))
                lstOutput.Items.Add("Flight Number: " & vbTab & drSourceTable("strFlightNumber"))
                lstOutput.Items.Add("Departure Time: " & vbTab & drSourceTable("dtmTimeofDeparture"))
                lstOutput.Items.Add("Landing Time: " & vbTab & drSourceTable("dtmTimeOfLanding"))
                lstOutput.Items.Add("From Airport: " & vbTab & drSourceTable("strAirportCity"))
                lstOutput.Items.Add("To Airport: " & vbTab & drSourceTable("strAirportCity"))
                lstOutput.Items.Add("Miles To: " & vbTab & drSourceTable("intMilesFlown"))
                lstOutput.Items.Add("")

            End While

            strSelect = "SELECT SUM(TF.intMilesFlown) AS TotalMiles " &
                        "FROM TAttendants AS TP " &
                        "JOIN TAttendantFlights AS TPF " &
                        "ON TPF.intAttendantID = TP.intAttendantID " &
                        "JOIN TFlights AS TF " &
                        "ON TF.intFlightID = TPF.intFlightID " &
                        "JOIN TAirports AS TA " &
                        "ON TA.intAirportID = TF.intFromAirportID " &
                        "JOIN TPlanes AS TPA " &
                        "ON TPA.intPlaneID = TF.intPlaneID " &
                        "WHERE TP.intAttendantID =  " & intSelect & "and " &
                        "dtmFlightDate > '4/6/2024' "

            ' Retrieve all the records 

            cmdSelect = New OleDb.OleDbCommand(strSelect, m_conAdministrator)
            drSourceTable = cmdSelect.ExecuteReader


            While (drSourceTable.Read)
                intMilesFlown += drSourceTable("TotalMiles")
            End While

            lblTotalMiles.Text = intMilesFlown

            ' Clean up
            drSourceTable.Close()

            ' close the database connection
            CloseDatabaseConnection()

        Catch ex As Exception

            ' Log and display error message
            MessageBox.Show(ex.Message)

        End Try
    End Sub
End Class