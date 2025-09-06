Public Class frmAddFlight
    Private Sub btnAddFlight_Click(sender As Object, e As EventArgs) Handles btnAddFlight.Click
        Dim intCustomerID As Integer
        Dim intFlightID As Integer
        Dim strSeat As String

        Dim strSelect As String
        Dim strInsert As String
        Dim intRowsAffected As Integer

        Dim cmdSelect As OleDb.OleDbCommand ' select command object
        Dim cmdInsert As OleDb.OleDbCommand ' insert command object
        Dim drSourceTable As OleDb.OleDbDataReader ' data reader for pulling info
        Dim intNextPrimaryKey As Integer ' holds next highest PK value
        Dim result = MessageBox.Show(Me, "Are you sure you want to Add This Flight?", "Confirm Addition", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)

        ' this will figure out which button was selected. Cancel and No does nothing, Yes will allow deletion
        Select Case result
            Case DialogResult.Cancel
                MessageBox.Show("Action Canceled")
            Case DialogResult.No
                MessageBox.Show("Action Canceled")
            Case DialogResult.Yes


                If OpenDatabaseConnectionSQLServer() = False Then
                    ' No, warn the user ...
                    MessageBox.Show(Me, "Database connection error." & vbNewLine &
                                "The application will now close.",
                                Me.Text + " Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error)

                    ' and close the form/application
                    Me.Close()

                End If

                strSelect = "SELECT MAX(intFlightPassengerID) + 1 AS intNextPrimaryKey " &
                        " FROM TFlightPassengers"

                ' Execute command
                cmdSelect = New OleDb.OleDbCommand(strSelect, m_conAdministrator)
                drSourceTable = cmdSelect.ExecuteReader

                ' Read result( highest ID )
                drSourceTable.Read()

                ' Null? (empty table)
                If drSourceTable.IsDBNull(0) = True Then

                    ' Yes, start numbering at 1
                    intNextPrimaryKey = 1

                Else

                    ' No, get the next highest ID
                    intNextPrimaryKey = CInt(drSourceTable("intNextPrimaryKey"))

                End If
                ' build insert statement (columns must match DB columns in name and the # of columns)

                strSelect = "SELECT TF.intFlightID " &
                    "FROM TFlights as TF " &
                    "JOIN TAirports AS TA " &
                    "ON TA.intAirportID = TF.intFromAirportID " &
                    "WHERE CONVERT(VARCHAR,TF.dtmFlightDate) + ' ' + TA.strAirportCity = '" & cboFutureFlights.Text & "'"

                cmdSelect = New OleDb.OleDbCommand(strSelect, m_conAdministrator)
                drSourceTable = cmdSelect.ExecuteReader

                drSourceTable.Read()

                intFlightID = CInt(drSourceTable("intFlightID"))

                intCustomerID = CustomerID_Location()
                strSeat = "TBD"

                strInsert = "INSERT INTO TFlightPassengers (intFlightPassengerID, intFlightID, intPassengerID, strSeat) " &
            "VALUES (" & intNextPrimaryKey & "," & intFlightID & "," & intCustomerID & ",'" & strSeat & "')"

                MessageBox.Show(strInsert)

                ' use insert command with sql string and connection object
                cmdInsert = New OleDb.OleDbCommand(strInsert, m_conAdministrator)

                ' execute query to insert data
                intRowsAffected = cmdInsert.ExecuteNonQuery()

                ' If not 0 insert successful
                If intRowsAffected > 0 Then
                    MessageBox.Show("Flight has been booked")    ' let user know success
                    ' close new player form
                End If

                CloseDatabaseConnection()       ' close connection if insert didn't work
                Close()
        End Select
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub

    Private Sub frmAddFlight_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try

            ' loop through the textboxes and clear them in case they have data in them after a delete
            For Each cntrl As Control In Controls
                If TypeOf cntrl Is TextBox Then
                    cntrl.Text = String.Empty
                End If
            Next

            Dim strSelect As String = ""
            Dim cmdSelect As OleDb.OleDbCommand ' this will be used for our Select statement
            Dim drSourceTable As OleDb.OleDbDataReader ' this will be where our data is retrieved to
            Dim dt As DataTable = New DataTable ' this is the table we will load from our reader

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

            strSelect = "SELECT TF.intFlightID, CONVERT(VARCHAR,TF.dtmFlightDate) + ' ' + TA.strAirportCity AS AirportInfo " &
                        "FROM TFlights AS TF " &
                        "JOIN TAirports AS TA " &
                        "ON TA.intAirportID = TF.intFromAirportID " &
                        "WHERE TF.dtmFlightDate > '03/25/2023' "

            ' Retrieve all the records 
            cmdSelect = New OleDb.OleDbCommand(strSelect, m_conAdministrator)
            drSourceTable = cmdSelect.ExecuteReader

            ' load table from data reader
            dt.Load(drSourceTable)

            ' Add the item to the combo box. We need the player ID associated with the name so 
            ' when we click on the name we can then use the ID to pull the rest of the players data.
            ' We are binding the column name to the combo box display and value members. 
            cboFutureFlights.ValueMember = "intFlightID"
            cboFutureFlights.DisplayMember = "AirportInfo"
            cboFutureFlights.DataSource = dt
            ' Clean up
            drSourceTable.Close()

            ' close the database connection
            CloseDatabaseConnection()

        Catch excError As Exception

            ' Log and display error message
            MessageBox.Show(excError.Message)

        End Try
    End Sub
End Class