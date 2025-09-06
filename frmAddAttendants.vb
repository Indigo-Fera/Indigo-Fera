Public Class frmAddAttendants
    Private Sub btnAddAttendant_Click(sender As Object, e As EventArgs) Handles btnAddAttendant.Click
        Dim strFirstName As String
        Dim strLastName As String
        Dim strAttendantID As String
        Dim strUserID As String
        Dim strPassword As String

        Dim blnValidated As Boolean
        blnValidated = True

        Call Validate_Input(strFirstName, strLastName, strAttendantID, strUserID, strPassword, blnValidated)

        If blnValidated = True Then
            Call Add_Attendant(strFirstName, strLastName, strAttendantID, strUserID, strPassword)
        End If
    End Sub

    Private Sub Validate_Input(ByRef strFirstName As String, ByRef strLastName As String, ByRef strAttendantID As String, ByRef strUserID As String, ByRef strPassword As String, ByRef blnValidated As Boolean)

        Call Validate_FirstName(strFirstName, blnValidated)
        If blnValidated = True Then
            Validate_LastName(strLastName, blnValidated)
        End If
        If blnValidated = True Then
            Validate_AttendantID(strAttendantID, blnValidated)
        End If
        If blnValidated = True Then
            Validate_UserID(strUserID, blnValidated)
        End If
        If blnValidated = True Then
            Validate_Password(strPassword, blnValidated)
        End If
    End Sub

    Private Sub Validate_FirstName(ByRef strFirstName As String, ByRef blnValidated As Boolean)
        strFirstName = txtFirstName.Text
        If strFirstName = "" Then
            MessageBox.Show("First Name Is Required")
            txtFirstName.Focus()
            blnValidated = False
        End If
    End Sub

    Private Sub Validate_LastName(ByRef strLastName As String, ByRef blnValidated As Boolean)
        strLastName = txtLastName.Text
        If strLastName = "" Then
            MessageBox.Show("Last Name Is Required")
            txtLastName.Focus()
            blnValidated = False
        End If
    End Sub

    Private Sub Validate_AttendantID(ByRef strAttendantID As String, ByRef blnValidated As Boolean)
        strAttendantID = txtAttendantID.Text
        If strAttendantID = "" Then
            MessageBox.Show("AttendantID Is Required")
            txtLastName.Focus()
            blnValidated = False
        End If
    End Sub


    Private Sub Validate_UserID(ByRef strUserID As String, ByRef blnValidated As Boolean)
        strUserID = txtUserID.Text
        If strUserID = "" Then
            MessageBox.Show("Login ID Is Required")
            txtUserID.Focus()
            blnValidated = False
        End If
    End Sub

    Private Sub Validate_Password(ByRef strPassword As String, ByRef blnValidated As Boolean)
        strPassword = txtPassword.Text
        If strPassword = "" Then
            MessageBox.Show("Login ID Is Required")
            txtPassword.Focus()
            blnValidated = False
        End If
    End Sub
    Private Sub Add_Attendant(strFirstName, strLastName, strAttendantID, strUserID, strPassword)
        ' variables for new player data and select and insert statements
        Dim strSelect As String
        Dim strInsert As String

        Dim cmdSelect As OleDb.OleDbCommand ' select command object
        Dim cmdInsert As OleDb.OleDbCommand ' insert command object
        Dim drSourceTable As OleDb.OleDbDataReader ' data reader for pulling info
        Dim intNextPrimaryKey As Integer ' holds next highest PK value
        Dim intRowsAffected As Integer  ' how many rows were affected when sql executed
        Dim intNextPrimaryKeyEmployee As Integer

        Dim dtmDateHire As Date
        Dim dtmTerminationDate As Date

        dtmDateHire = dtmDateofHire.Value
        dtmTerminationDate = dtmDateofTermination.Value
        Try


            If OpenDatabaseConnectionSQLServer() = False Then

                ' No, warn the user ...
                MessageBox.Show(Me, "Database connection error." & vbNewLine &
                                    "The application will now close.",
                                    Me.Text + " Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error)

                ' and close the form/application
                Me.Close()

            End If

            strSelect = "SELECT MAX(intAttendantID) + 1 AS intNextPrimaryKey " &
                            " FROM TAttendants"

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

            strSelect = "SELECT MAX(intEmployeeID) + 1 AS intNextPrimaryKey " &
                            " FROM TEmployees"

            ' Execute command
            cmdSelect = New OleDb.OleDbCommand(strSelect, m_conAdministrator)
            drSourceTable = cmdSelect.ExecuteReader

            ' Read result( highest ID )
            drSourceTable.Read()

            ' Null? (empty table)
            If drSourceTable.IsDBNull(0) = True Then

                ' Yes, start numbering at 1
                intNextPrimaryKeyEmployee = 1

            Else

                ' No, get the next highest ID
                intNextPrimaryKeyEmployee = CInt(drSourceTable("intNextPrimaryKey"))

            End If

            strInsert = "INSERT INTO TEmployees (intEmployeeID, strEmployeeLoginID, strEmployeePassword, strEmployeeRole, intEmployeeType)" &
                " VALUES (" & intNextPrimaryKeyEmployee & ",'" & strUserID & "','" & strPassword & "','Attendant'," & intNextPrimaryKey & ")"

            MessageBox.Show(strInsert)

            ' use insert command with sql string and connection object
            cmdInsert = New OleDb.OleDbCommand(strInsert, m_conAdministrator)

            ' execute query to insert data
            intRowsAffected = cmdInsert.ExecuteNonQuery()
            ' build insert statement (columns must match DB columns in name and the # of columns)

            strInsert = "INSERT INTO TAttendants (intAttendantID, strFirstName, strLastName, strEmployeeID, dtmDateofHire, dtmDateofTermination, intEmployeeID)" &
                " VALUES (" & intNextPrimaryKey & ",'" & strFirstName & "','" & strLastName & "','" & strAttendantID & "','" & dtmDateHire & "','" & dtmTerminationDate & "', " & intNextPrimaryKeyEmployee & ")"

            MessageBox.Show(strInsert)

            ' use insert command with sql string and connection object
            cmdInsert = New OleDb.OleDbCommand(strInsert, m_conAdministrator)

            ' execute query to insert data
            intRowsAffected = cmdInsert.ExecuteNonQuery()

            ' If not 0 insert successful
            If intRowsAffected > 0 Then
                MessageBox.Show("Attendant has been added")    ' let user know success
                ' close new player form
            End If

            CloseDatabaseConnection()       ' close connection if insert didn't work
            Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        Dim frmManageAttendant As New frmManageAttendants

        frmManageAttendant.ShowDialog()
    End Sub
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub

End Class