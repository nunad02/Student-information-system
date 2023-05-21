Imports System.Data.OleDb
Imports System.IO
Imports System.Speech.Synthesis
Imports System.Drawing.Printing
Public Class Student_Profile
    Dim prov As String
    Dim connstring As String
    Dim command As String
    Dim Sql As String
    Dim speech As New SpeechSynthesizer
    Dim cmd As OleDbCommand
    Dim myconn As OleDbConnection = New OleDbConnection
    Dim conn As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Lenovo\Documents\Visual Studio 2019\New Projects\StudentInfoSystem\StudentInfoSystem\bin\Debug\RegistrationDB.mdb")
    Dim selectedPicture As Boolean
    Dim HH As Integer
    Dim I_Counter As Integer
    Dim I_Start As Integer
    Dim LineNumber As Integer
    Dim lineperpage As Integer
    Private Sub Student_Profile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.DoubleBuffered = True
        dtgStudentProfile.Refresh()
        load_Student_Profile()
        searchName()
        'designing the datagrid
        dtgStudentProfile.RowHeadersVisible = False
        dtgStudentProfile.AllowUserToResizeRows = False
        dtgStudentProfile.ScrollBars = ScrollBars.Both
        dtgStudentProfile.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dtgStudentProfile.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dtgStudentProfile.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dtgStudentProfile.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
    End Sub
    Private Sub load_Student_Profile()
        Dim cmd1 As New OleDbCommand("SELECT * FROM studTable", conn)
        Dim da As New OleDbDataAdapter
        Dim table1 As New DataTable
        da.SelectCommand = cmd1
        da.Fill(table1)
        dtgStudentProfile.DataSource = table1

        'DATAGRID New INFO

        dtgStudentProfile.Columns(0).HeaderText = "ID"
        dtgStudentProfile.Columns(1).HeaderText = "Student ID"
        dtgStudentProfile.Columns(2).HeaderText = "Student Name"
        dtgStudentProfile.Columns(3).HeaderText = "Gender"
        dtgStudentProfile.Columns(4).HeaderText = "Address"
        dtgStudentProfile.Columns(6).HeaderText = "School Year"
        dtgStudentProfile.Columns(5).HeaderText = "Course / Major"
        dtgStudentProfile.Columns(7).HeaderText = "Year / Section"
        dtgStudentProfile.Columns(9).HeaderText = "Total Units"
        dtgStudentProfile.Columns(8).HeaderText = "DOR"

        dtgStudentProfile.Columns(0).Name = "ID"
        dtgStudentProfile.Columns(1).Name = "studentId"
        dtgStudentProfile.Columns(2).Name = "studentName"
        dtgStudentProfile.Columns(3).Name = "gender"
        dtgStudentProfile.Columns(4).Name = "address"
        dtgStudentProfile.Columns(6).Name = "schoolYear"
        dtgStudentProfile.Columns(5).Name = "course_major"
        dtgStudentProfile.Columns(7).Name = "year_section"
        dtgStudentProfile.Columns(9).Name = "totalUnits"
        dtgStudentProfile.Columns(8).Name = "DOR"

        dtgStudentProfile.Columns("ID").Width = 30
        dtgStudentProfile.Columns("studentId").Width = 100
        dtgStudentProfile.Columns("studentName").Width = 200
        dtgStudentProfile.Columns("gender").Width = 100
        dtgStudentProfile.Columns("address").Width = 250
        dtgStudentProfile.Columns("schoolYear").Width = 130
        dtgStudentProfile.Columns("course_major").Width = 250
        dtgStudentProfile.Columns("year_section").Width = 130
        dtgStudentProfile.Columns("totalUnits").Width = 130
        dtgStudentProfile.Columns("DOR").Width = 100

        Dim totalMale As Integer
        Dim totalFemale As Integer
        Dim totalStudents As Integer

        'total male
        If Not conn.State = ConnectionState.Open Then
            conn.Open()
        End If
        Dim da1 As New OleDb.OleDbDataAdapter("SELECT * FROM studTable WHERE gender='Male'", conn)
        Dim dt1 As New DataTable
        da1.Fill(dt1)
        totalMale = dt1.Rows.Count

        'total female
        If Not conn.State = ConnectionState.Open Then
            conn.Open()
        End If
        Dim da2 As New OleDb.OleDbDataAdapter("SELECT * FROM studTable WHERE gender='Female'", conn)
        Dim dt2 As New DataTable
        da2.Fill(dt2)
        totalFemale = dt2.Rows.Count

        totalStudents = totalMale + totalFemale

        lblStatus.Text = "Male: " & totalMale & " | Female: " & totalFemale & " | Total: " & totalStudents
    End Sub

    Private Sub dtgStudentProfile_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgStudentProfile.CellContentClick
        txtID.Text = dtgStudentProfile.CurrentRow.Cells(0).Value.ToString()
        txtStudentID.Text = dtgStudentProfile.CurrentRow.Cells(1).Value.ToString()
        txtName.Text = dtgStudentProfile.CurrentRow.Cells(2).Value.ToString()
        txtGender.Text = dtgStudentProfile.CurrentRow.Cells(3).Value.ToString()
        txtAddress.Text = dtgStudentProfile.CurrentRow.Cells(4).Value.ToString()
        txtCourse.Text = dtgStudentProfile.CurrentRow.Cells(5).Value.ToString()
        txtSchoolYear.Text = dtgStudentProfile.CurrentRow.Cells(6).Value.ToString()
        txtYearSection.Text = dtgStudentProfile.CurrentRow.Cells(7).Value.ToString()
        txtDateofreg.Text = dtgStudentProfile.CurrentRow.Cells(8).Value.ToString()
        txtTotalUnits.Text = dtgStudentProfile.CurrentRow.Cells(9).Value.ToString()

        On Error Resume Next
        ''DISPLAY PICTURE

        'CHECK IF PICTURE EXIST
        If My.Computer.FileSystem.FileExists(Application.StartupPath & "\StudentID\" & txtStudentID.Text & ".jpg") = False Then
            pbxStudentImage.Image = My.Resources.man_shape
            Exit Sub
        End If

        'SET PICTURE TO PICTURE BOX
        Dim savePicture As String
        savePicture = Application.StartupPath & "\StudentID\" & txtStudentID.Text & ".jpg"

        Dim fs As System.IO.FileStream
        fs = New System.IO.FileStream(savePicture, IO.FileMode.Open, IO.FileAccess.Read)
        pbxStudentImage.Image = System.Drawing.Image.FromStream(fs)
        fs.Dispose()
    End Sub

    Private Sub lblStatus_Click(sender As Object, e As EventArgs) Handles lblStatus.Click
        load_Student_Profile()
    End Sub

    Private Sub pbxNewSaveUpdate_Click(sender As Object, e As EventArgs) Handles pbxNewSaveUpdate.Click
        If pbxNewSaveUpdate.Tag = "New" Then
            'enable the controls
            txtStudentID.Enabled = True
            txtName.Enabled = True
            txtGender.Enabled = True
            txtAddress.Enabled = True
            txtCourse.Enabled = True
            txtYearSection.Enabled = True
            txtSchoolYear.Enabled = True
            txtDateofreg.Enabled = True
            txtTotalUnits.Enabled = True

            'clear the controls
            txtStudentID.Text = ""
            txtName.Text = ""
            txtGender.Text = ""
            txtAddress.Text = ""
            txtCourse.Text = ""
            txtYearSection.Text = ""
            txtSchoolYear.Text = ""
            txtDateofreg.Text = ""
            txtTotalUnits.Text = ""
            pbxStudentImage.Image = My.Resources.man_shape
            'pbxChangeImage.Image = My.Resources.icons8_picture_24

            txtStudentID.Focus()

            pbxNewSaveUpdate.Tag = "Save"
            pbxEditCancel.Tag = "Cancel"


            pbxNewSaveUpdate.Image = My.Resources.save
            pbxEditCancel.Image = My.Resources.Cancel
            load_Student_Profile()

        ElseIf pbxNewSaveUpdate.Tag = "Save" Then
            If Not conn.State = ConnectionState.Open Then
                conn.Open()
            End If

            Try
                Using add As New OleDbCommand("INSERT INTO studTable ([studentID], [studentName], [gender], [address], [course_major], [schoolYear], [year_section], [DOR], [totalUnits]) VALUES(@studentID, @studentName, @gender, @address, @course_major, @schoolYear, @year_section, @DOR, @totalUnits)", conn)
                    add.Parameters.AddWithValue("@studentID", txtStudentID.Text.Trim)
                    add.Parameters.AddWithValue("@studentName", txtName.Text.Trim)
                    add.Parameters.AddWithValue("@gender", txtGender.Text.Trim)
                    add.Parameters.AddWithValue("@address", txtAddress.Text.Trim)
                    add.Parameters.AddWithValue("@course_major", txtCourse.Text.Trim)
                    add.Parameters.AddWithValue("@schoolYear", txtSchoolYear.Text.Trim)
                    add.Parameters.AddWithValue("@year_section", txtYearSection.Text.Trim)
                    add.Parameters.AddWithValue("@DOR", txtDateofreg.Text.Trim)
                    add.Parameters.AddWithValue("@totalUnits", txtTotalUnits.Text.Trim)

                    If MessageBox.Show("Are you sure that you want to save?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                        add.ExecuteNonQuery()
                        speech.SpeakAsync("Record Successfully saved")
                        MessageBox.Show("Record successfully saved!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                    load_Student_Profile()
                    searchName()
                End Using

                'save picture
                Dim savePicture As String
                savePicture = Application.StartupPath & "\StudentID\" & txtStudentID.Text & ".jpg"
                pbxStudentImage.Image.Save(savePicture)

                txtStudentID.Text = ""
                txtName.Text = ""
                txtGender.Text = ""
                txtAddress.Text = ""
                txtCourse.Text = ""
                txtSchoolYear.Text = ""
                txtYearSection.Text = ""
                txtTotalUnits.Text = ""
                txtDateofreg.Text = ""
                pbxStudentImage.Image = My.Resources.man_shape
            Catch ex As Exception
                MessageBox.Show("Error saving record: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                conn.Close()
                load_Student_Profile()
                searchName()
            End Try

            pbxNewSaveUpdate.Tag = "New"
            pbxEditCancel.Tag = "Edit"

            pbxNewSaveUpdate.Image = My.Resources.add_new
            pbxEditCancel.Image = My.Resources.edit

            txtStudentID.Enabled = False
            txtName.Enabled = False
            txtGender.Enabled = False
            txtAddress.Enabled = False
            txtCourse.Enabled = False
            txtYearSection.Enabled = False
            txtSchoolYear.Enabled = False
            txtDateofreg.Enabled = False
            txtTotalUnits.Enabled = False

        ElseIf pbxNewSaveUpdate.Tag = "Update" Then
            'enable the controls
            txtStudentID.Enabled = True
            txtName.Enabled = True
            txtGender.Enabled = True
            txtAddress.Enabled = True
            txtCourse.Enabled = True
            txtYearSection.Enabled = True
            txtSchoolYear.Enabled = True
            txtDateofreg.Enabled = True
            txtTotalUnits.Enabled = True

            If Not conn.State = ConnectionState.Open Then
                conn.Open()
            End If
            prov = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Lenovo\Documents\Visual Studio 2019\New Projects\StudentInfoSystem\StudentInfoSystem\bin\Debug\RegistrationDB.mdb"
            connstring = prov
            myconn.ConnectionString = connstring
            myconn.Open()
            command = "UPDATE studTable SET [studentId] = '" & txtStudentID.Text & "', [studentName] = '" & txtName.Text & "', [gender] = '" & txtGender.Text & "', [address] = '" & txtAddress.Text & "', [course_major] = '" & txtCourse.Text & "', [schoolYear] = '" & txtSchoolYear.Text & "', [year_section] = '" & txtYearSection.Text & "', [totalUnits] = '" & txtTotalUnits.Text & "', [DOR] = '" & txtDateofreg.Text & "' WHERE [ID] = " & txtID.Text & ""
            Dim cmd As OleDbCommand = New OleDbCommand(command, myconn)
            speech.SpeakAsync("Updated Successfully")
            MessageBox.Show("Updated successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Try
                cmd.ExecuteNonQuery()
                cmd.Dispose()
                load_Student_Profile()
                searchName()
                myconn.Close()
                conn.Close()
                'save picture
                Dim savePicture As String
                savePicture = Application.StartupPath & "\StudentID\" & txtStudentID.Text & ".jpg"
                pbxStudentImage.Image.Save(savePicture)

                txtID.Text = ""
                txtStudentID.Text = ""
                txtName.Text = ""
                txtGender.Text = ""
                txtAddress.Text = ""
                txtCourse.Text = ""
                txtSchoolYear.Text = ""
                txtYearSection.Text = ""
                txtTotalUnits.Text = ""
                txtDateofreg.Text = ""
                pbxStudentImage.Image = My.Resources.man_shape
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            'disable the controls
            txtStudentID.Enabled = False
            txtName.Enabled = False
            txtGender.Enabled = False
            txtAddress.Enabled = False
            txtCourse.Enabled = False
            txtYearSection.Enabled = False
            txtSchoolYear.Enabled = False
            txtDateofreg.Enabled = False
            txtTotalUnits.Enabled = False

            pbxNewSaveUpdate.Tag = "New"
            pbxEditCancel.Tag = "Edit"
            btnChangeImage.Text = "Add Photo"

            pbxNewSaveUpdate.Image = My.Resources.add_new
            pbxEditCancel.Image = My.Resources.edit

            load_Student_Profile()
            'searchName()
        End If
    End Sub

    Private Sub pbxEditCancel_Click(sender As Object, e As EventArgs) Handles pbxEditCancel.Click
        If pbxEditCancel.Tag = "Cancel" Then
            'disable the controls
            txtStudentID.Enabled = False
            txtName.Enabled = False
            txtGender.Enabled = False
            txtAddress.Enabled = False
            txtCourse.Enabled = False
            txtYearSection.Enabled = False
            txtSchoolYear.Enabled = False
            txtDateofreg.Enabled = False
            txtTotalUnits.Enabled = False

            'clear the controls
            txtStudentID.Text = ""
            txtName.Text = ""
            txtGender.Text = ""
            txtAddress.Text = ""
            txtCourse.Text = ""
            txtYearSection.Text = ""
            txtSchoolYear.Text = ""
            txtDateofreg.Text = ""
            txtTotalUnits.Text = ""

            txtStudentID.Focus()

            pbxNewSaveUpdate.Tag = "New"
            pbxEditCancel.Tag = "Edit"
            btnChangeImage.Text = "Add Photo"

            pbxNewSaveUpdate.Image = My.Resources.add_new
            pbxEditCancel.Image = My.Resources.edit

        ElseIf pbxEditCancel.Tag = "Edit" Then
            'enable the controls
            txtStudentID.Enabled = True
            txtName.Enabled = True
            txtGender.Enabled = True
            txtAddress.Enabled = True
            txtCourse.Enabled = True
            txtYearSection.Enabled = True
            txtSchoolYear.Enabled = True
            txtDateofreg.Enabled = True
            txtTotalUnits.Enabled = True

            pbxNewSaveUpdate.Tag = "Update"
            pbxEditCancel.Tag = "Cancel"
            btnChangeImage.Text = "Change Photo"

            pbxNewSaveUpdate.Image = My.Resources.update
            pbxEditCancel.Image = My.Resources.Cancel

            load_Student_Profile()
            searchName()
        End If
    End Sub

    Private Sub pbxDelete_Click(sender As Object, e As EventArgs) Handles pbxDelete.Click
        If MessageBox.Show("Are you sure you want to delete this record?", "DELETE", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            Dim cmd3 As New OleDbCommand("DELETE FROM studTable WHERE ID=@ID", conn)
            cmd3.Parameters.AddWithValue("@ID", txtID.Text)
            If Not conn.State = ConnectionState.Open Then
                conn.Open()
            End If
            cmd3.ExecuteNonQuery()
            speech.SpeakAsync("Deleted Successfully")
            MessageBox.Show("Deleted successfully", "DELETE", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Delete student image
            Dim imagePath As String = Application.StartupPath & "\StudentID\" & txtStudentID.Text & ".jpg"
            If System.IO.File.Exists(imagePath) Then
                System.IO.File.Delete(imagePath)
            End If

            ' Reset form fields and load data
            txtID.Text = ""
            txtStudentID.Text = ""
            txtName.Text = ""
            txtGender.Text = ""
            txtAddress.Text = ""
            txtCourse.Text = ""
            txtYearSection.Text = ""
            txtSchoolYear.Text = ""
            txtDateofreg.Text = ""
            txtTotalUnits.Text = ""
            pbxStudentImage.Image = My.Resources.man_shape
            btnChangeImage.Text = "Add photo"
            load_Student_Profile()
            searchName()
            conn.Close()
        End If
    End Sub

    Private Sub pbxPrint_Click(sender As Object, e As EventArgs) Handles pbxPrint.Click
        PrintDocument1.Dispose()
        'HORIZONTAL SPACING INITIAL VALUE
        HH = 0

        'VARIABLE FOR FOR LOOP
        I_Counter = 0

        'START OF WHICH DATA TO PRINT
        I_Start = 0
        PrintDialog1.Document = PrintDocument1
        If PrintDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            'SET THE PAPER CONFIGURATION
            PrintDialog1.PrinterSettings = PrintDocument1.PrinterSettings
            Dim new_Paper As New PaperSize("A4", 1000, 1200)
            new_Paper.PaperName = PaperKind.Custom
            Dim New_Margin As New Margins
            New_Margin.Left = 0
            New_Margin.Right = 0
            New_Margin.Top = 10
            New_Margin.Bottom = 10
            With PrintDocument1
                .DefaultPageSettings.PaperSize = new_Paper
                .DefaultPageSettings.Margins = New_Margin
                .PrinterSettings.DefaultPageSettings.Landscape = True
                .Print()
            End With
        End If
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PrintDocument1.PrintPage
        If cboFilterData.Text = "All" Or cboFilterData.Text = "Gender" & txtFilterGender.Text Then
            HH = 20
            e.Graphics.DrawString("Student Information Profiling System", New Drawing.Font("Arial Narrow", 10), Brushes.Maroon, 40, HH)
            e.Graphics.DrawString("Date:" & Now, New Drawing.Font("Arial Narrow", 10), Brushes.Maroon, 910, HH)
            HH = 40
            e.Graphics.DrawString("Filtering Option: by " & cboFilterData.Text, New Drawing.Font("Arial Narrow", 10), Brushes.Maroon, 40,
           HH)
        Else
            HH = 20
            e.Graphics.DrawString("Student Information Profiling System", New Drawing.Font("Arial Narrow", 10), Brushes.Maroon, 40, HH)
            e.Graphics.DrawString("Date:" & Now, New Drawing.Font("Arial Narrow", 10), Brushes.Maroon, 910, HH)
            HH = 40
            e.Graphics.DrawString("Filtered by: " & cboFilterData.Text, New Drawing.Font("Arial Narrow", 10), Brushes.Maroon, 40, HH)
            e.Graphics.DrawString("Filtered Value: " & txtFilterGender.Text, New Drawing.Font("Arial Narrow", 10), Brushes.Maroon, 200, HH)
        End If
        HH += 40
        e.Graphics.DrawString("ID", New Drawing.Font("Arial Narrow", 10), Brushes.Black, 50, HH)
        e.Graphics.DrawString("Student ID", New Drawing.Font("Arial Narrow", 10), Brushes.Black, 130, HH)
        e.Graphics.DrawString("Student Name", New Drawing.Font("Arial Narrow", 10), Brushes.Black, 280, HH)
        e.Graphics.DrawString("Gender", New Drawing.Font("Arial Narrow", 10), Brushes.Black, 450, HH)
        e.Graphics.DrawString("Address", New Drawing.Font("Arial Narrow", 10), Brushes.Black, 590, HH)
        e.Graphics.DrawString("Course / Major", New Drawing.Font("Arial Narrow", 10), Brushes.Black, 780, HH)
        e.Graphics.DrawString("Year / Section", New Drawing.Font("Arial Narrow", 10), Brushes.Black, 930, HH)
        HH += 30
        Dim NN As Integer = HH - 5
        e.Graphics.DrawLine(Pens.Maroon, 5, NN, 1500, NN)
        For Me.I_Counter = I_Start To dtgStudentProfile.RowCount - 1

            HH += 30
            e.Graphics.DrawString(dtgStudentProfile.Rows(I_Counter).Cells(0).Value, New Drawing.Font("Arial Narrow", 8), Brushes.Black, 50, HH)
            e.Graphics.DrawString(dtgStudentProfile.Rows(I_Counter).Cells(1).Value, New Drawing.Font("Arial Narrow", 8), Brushes.Black, 130, HH)
            e.Graphics.DrawString(dtgStudentProfile.Rows(I_Counter).Cells(2).Value, New Drawing.Font("Arial Narrow", 8), Brushes.Black, 280, HH)
            e.Graphics.DrawString(dtgStudentProfile.Rows(I_Counter).Cells(3).Value, New Drawing.Font("Arial Narrow", 8), Brushes.Black, 455, HH)
            e.Graphics.DrawString(dtgStudentProfile.Rows(I_Counter).Cells(4).Value, New Drawing.Font("Arial Narrow”, 8), Brushes.Black, 550, HH)
            e.Graphics.DrawString(dtgStudentProfile.Rows(I_Counter).Cells(5).Value, New Drawing.Font("Arial Narrow”, 8), Brushes.Black, 810, HH)
            e.Graphics.DrawString(dtgStudentProfile.Rows(I_Counter).Cells(7).Value, New Drawing.Font("Arial Narrow”, 8), Brushes.Black, 955, HH)

            HH += 30
            LineNumber += 1
            If LineNumber = lineperpage Then
                LineNumber = 0
                I_Start = I_Counter + 1
                HH = 50
                e.HasMorePages = True
                Exit For
            End If
        Next
    End Sub

    Private Function GetData() As List(Of String)
        Dim connectionString As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Lenovo\Documents\Visual Studio 2019\New Projects\StudentInfoSystem\StudentInfoSystem\bin\Debug\RegistrationDB.mdb"
        Dim queryString As String = "SELECT * FROM studTable"
        Dim data As New List(Of String)()

        Using connection As New OleDbConnection(connectionString)
            Dim command As New OleDbCommand(queryString, connection)

            connection.Open()

            Using reader As OleDbDataReader = command.ExecuteReader()
                While reader.Read()
                    'Convert the data to a comma-separated string and add it to the list
                    data.Add(String.Join(", ", Enumerable.Range(0, reader.FieldCount).Select(Function(i) reader.GetValue(i))))
                End While
            End Using
        End Using

        Return data
    End Function
    Private Sub searchsID()
        Dim conn As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Lenovo\Documents\Visual Studio 2019\New Projects\StudentInfoSystem\StudentInfoSystem\bin\Debug\RegistrationDB.mdb")
        Try
            conn.Open()
            Dim searchValue As Integer
            If Integer.TryParse(txtFilterID.Text, searchValue) Then
                Dim cmd As New OleDbCommand("SELECT * FROM studTable WHERE ID = @ID", conn)
                cmd.Parameters.AddWithValue("@ID", searchValue)
                Dim adapter As New OleDbDataAdapter(cmd)
                Dim table As New DataTable()
                adapter.Fill(table)
                dtgStudentProfile.DataSource = table
                Dim count As Integer = table.Rows.Count
                Label1.Text = String.Format("{0}", count)
            Else
                MessageBox.Show("Please enter a valid ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub searchstudentID()
        Dim conn As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Lenovo\Documents\Visual Studio 2019\New Projects\StudentInfoSystem\StudentInfoSystem\bin\Debug\RegistrationDB.mdb")
        conn.Open()
        Dim cmd8 As New OleDbCommand("SELECT COUNT(studentId) FROM studTable WHERE studentId LIKE '%" & txtFilterStudentID.Text & "%'", conn)
        TryCast(dtgStudentProfile.DataSource, DataTable).DefaultView.RowFilter =
            String.Format("studentId Like '%" & txtFilterStudentID.Text & "%'")
        Dim count4 = Convert.ToString(cmd8.ExecuteScalar)
        Label1.Text = count4
        conn.Close()
    End Sub

    Private Sub searchName()
        Dim conn As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Lenovo\Documents\Visual Studio 2019\New Projects\StudentInfoSystem\StudentInfoSystem\bin\Debug\RegistrationDB.mdb")
        conn.Open()
        Dim cmd4 As New OleDbCommand("SELECT COUNT(studentName) FROM studTable WHERE studentName LIKE '%" & txtFilterName.Text & "%'", conn)
        TryCast(dtgStudentProfile.DataSource, DataTable).DefaultView.RowFilter =
            String.Format("studentName Like '%" & txtFilterName.Text & "%'")
        Dim count1 = Convert.ToString(cmd4.ExecuteScalar)
        Label1.Text = count1
        conn.Close()
    End Sub

    Private Sub searchGender()
        Dim conn As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Lenovo\Documents\Visual Studio 2019\New Projects\StudentInfoSystem\StudentInfoSystem\bin\Debug\RegistrationDB.mdb")
        conn.Open()
        TryCast(dtgStudentProfile.DataSource, DataTable).DefaultView.RowFilter =
        String.Format("gender = '{0}'", txtFilterGender.Text)
        Label1.Text = TryCast(dtgStudentProfile.DataSource, DataTable).DefaultView.Count.ToString()
        conn.Close()
    End Sub


    Private Sub searchAddress()
        Dim conn As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Lenovo\Documents\Visual Studio 2019\New Projects\StudentInfoSystem\StudentInfoSystem\bin\Debug\RegistrationDB.mdb")
        conn.Open()
        Dim cmd9 As New OleDbCommand("SELECT COUNT(address) FROM studTable WHERE address LIKE '%" & txtFilterAddress.Text & "%'", conn)
        TryCast(dtgStudentProfile.DataSource, DataTable).DefaultView.RowFilter =
            String.Format("address Like '%" & txtFilterAddress.Text & "%'")
        Dim count7 = Convert.ToString(cmd9.ExecuteScalar)
        Label1.Text = count7
        conn.Close()
    End Sub

    Private Sub searchCourse()
        Dim conn As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Lenovo\Documents\Visual Studio 2019\New Projects\StudentInfoSystem\StudentInfoSystem\bin\Debug\RegistrationDB.mdb")
        conn.Open()
        Dim cmd10 As New OleDbCommand("SELECT COUNT(course_major) FROM studTable WHERE course_major LIKE '%" & txtFilterCourse.Text & "%'", conn)
        TryCast(dtgStudentProfile.DataSource, DataTable).DefaultView.RowFilter =
            String.Format("course_major Like '%" & txtFilterCourse.Text & "%'")
        Dim count8 = Convert.ToString(cmd10.ExecuteScalar)
        Label1.Text = count8
        conn.Close()
    End Sub

    Private Sub searchSchoolyear()
        Dim conn As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Lenovo\Documents\Visual Studio 2019\New Projects\StudentInfoSystem\StudentInfoSystem\bin\Debug\RegistrationDB.mdb")
        conn.Open()
        Dim cmd11 As New OleDbCommand("SELECT COUNT(schoolYear) FROM studTable WHERE schoolYear LIKE '%" & txtFilterSchoolYear.Text & "%'", conn)
        TryCast(dtgStudentProfile.DataSource, DataTable).DefaultView.RowFilter =
            String.Format("schoolYear Like '%" & txtFilterSchoolYear.Text & "%'")
        Dim count9 = (cmd11.ExecuteScalar)
        Label1.Text = count9
        conn.Close()
    End Sub

    Private Sub searchyearsection()
        Dim conn As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Lenovo\Documents\Visual Studio 2019\New Projects\StudentInfoSystem\StudentInfoSystem\bin\Debug\RegistrationDB.mdb")
        conn.Open()
        Dim cmd12 As New OleDbCommand("SELECT year_section FROM studTable WHERE year_section = ?", conn)
        cmd12.Parameters.AddWithValue("?", txtFilterYearSection.Text)
        TryCast(dtgStudentProfile.DataSource, DataTable).DefaultView.RowFilter =
        String.Format("year_section = '{0}'", txtFilterYearSection.Text)
        Dim count10 = dtgStudentProfile.DataSource.DefaultView.Count
        Label1.Text = count10.ToString()
        conn.Close()
    End Sub

    Private Sub searchDOR()
        Dim conn As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Lenovo\Documents\Visual Studio 2019\New Projects\StudentInfoSystem\StudentInfoSystem\bin\Debug\RegistrationDB.mdb")
        conn.Open()

        Dim inputDate As DateTime
        If DateTime.TryParse(txtFilterDOR.Text, inputDate) Then
            Dim startDate As DateTime = inputDate.Date
            Dim endDate As DateTime = inputDate.Date.AddDays(1)

            Dim cmd13 As New OleDbCommand("SELECT COUNT(DOR) FROM studTable WHERE DOR BETWEEN @startDate AND @endDate", conn)
            cmd13.Parameters.AddWithValue("@startDate", startDate)
            cmd13.Parameters.AddWithValue("@endDate", endDate)

            TryCast(dtgStudentProfile.DataSource, DataTable).DefaultView.RowFilter =
            String.Format("DOR >= #{0:M/dd/yyyy}# AND DOR < #{1:M/dd/yyyy}#", startDate, endDate)

            Dim count11 = Convert.ToString(cmd13.ExecuteScalar)
            Label1.Text = count11
        Else
            MessageBox.Show("Invalid date format. Please enter a date in MM/dd/yyyy format.")
        End If
        conn.Close()
    End Sub

    Private Sub searchtotalunits()
        Dim conn As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Lenovo\Documents\Visual Studio 2019\New Projects\StudentInfoSystem\StudentInfoSystem\bin\Debug\RegistrationDB.mdb")
        Try
            conn.Open()
            Dim searchValue As Integer
            If Integer.TryParse(txtFilterTotalUnits.Text, searchValue) Then
                Dim cmd As New OleDbCommand("SELECT * FROM studTable WHERE totalUnits = @totalUnits", conn)
                cmd.Parameters.AddWithValue("@totalUnits", searchValue)
                Dim adapter As New OleDbDataAdapter(cmd)
                Dim table As New DataTable()
                adapter.Fill(table)
                dtgStudentProfile.DataSource = table
                Dim count As Integer = table.Rows.Count
                Label1.Text = String.Format("{0}", count)
            Else
                MessageBox.Show("Please enter a valid ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub cboFilterData_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboFilterData.SelectedIndexChanged
        If cboFilterData.Text = "ID" Then
            txtFilterID.Visible = True
            txtFilterStudentID.Visible = False
            txtFilterName.Visible = False
            txtFilterGender.Visible = False
            txtFilterAddress.Visible = False
            txtFilterCourse.Visible = False
            txtFilterSchoolYear.Visible = False
            txtFilterYearSection.Visible = False
            txtFilterDOR.Visible = False
            txtFilterTotalUnits.Visible = False
        ElseIf cboFilterData.Text = "Student ID" Then
            txtFilterID.Visible = False
            txtFilterStudentID.Visible = True
            txtFilterName.Visible = False
            txtFilterGender.Visible = False
            txtFilterAddress.Visible = False
            txtFilterCourse.Visible = False
            txtFilterSchoolYear.Visible = False
            txtFilterYearSection.Visible = False
            txtFilterDOR.Visible = False
            txtFilterTotalUnits.Visible = False
        ElseIf cboFilterData.Text = "Student Name" Then
            txtFilterID.Visible = False
            txtFilterStudentID.Visible = False
            txtFilterName.Visible = True
            txtFilterGender.Visible = False
            txtFilterAddress.Visible = False
            txtFilterCourse.Visible = False
            txtFilterSchoolYear.Visible = False
            txtFilterYearSection.Visible = False
            txtFilterDOR.Visible = False
            txtFilterTotalUnits.Visible = False
        ElseIf cboFilterData.Text = "Gender" Then
            txtFilterID.Visible = False
            txtFilterStudentID.Visible = False
            txtFilterName.Visible = False
            txtFilterGender.Visible = True
            txtFilterAddress.Visible = False
            txtFilterCourse.Visible = False
            txtFilterSchoolYear.Visible = False
            txtFilterYearSection.Visible = False
            txtFilterDOR.Visible = False
            txtFilterTotalUnits.Visible = False
        ElseIf cboFilterData.Text = "Address" Then
            txtFilterID.Visible = False
            txtFilterStudentID.Visible = False
            txtFilterName.Visible = False
            txtFilterGender.Visible = False
            txtFilterAddress.Visible = True
            txtFilterCourse.Visible = False
            txtFilterSchoolYear.Visible = False
            txtFilterYearSection.Visible = False
            txtFilterDOR.Visible = False
            txtFilterTotalUnits.Visible = False
        ElseIf cboFilterData.Text = "Course / Major" Then
            txtFilterID.Visible = False
            txtFilterStudentID.Visible = False
            txtFilterName.Visible = False
            txtFilterGender.Visible = False
            txtFilterAddress.Visible = False
            txtFilterCourse.Visible = True
            txtFilterSchoolYear.Visible = False
            txtFilterYearSection.Visible = False
            txtFilterDOR.Visible = False
            txtFilterTotalUnits.Visible = False
        ElseIf cboFilterData.Text = "School Year" Then
            txtFilterID.Visible = False
            txtFilterStudentID.Visible = False
            txtFilterName.Visible = False
            txtFilterGender.Visible = False
            txtFilterAddress.Visible = False
            txtFilterCourse.Visible = False
            txtFilterSchoolYear.Visible = True
            txtFilterYearSection.Visible = False
            txtFilterDOR.Visible = False
            txtFilterTotalUnits.Visible = False
        ElseIf cboFilterData.Text = "Year / Section" Then
            txtFilterID.Visible = False
            txtFilterStudentID.Visible = False
            txtFilterName.Visible = False
            txtFilterGender.Visible = False
            txtFilterAddress.Visible = False
            txtFilterCourse.Visible = False
            txtFilterSchoolYear.Visible = False
            txtFilterYearSection.Visible = True
            txtFilterDOR.Visible = False
            txtFilterTotalUnits.Visible = False
        ElseIf cboFilterData.Text = "DOR" Then
            txtFilterID.Visible = False
            txtFilterStudentID.Visible = False
            txtFilterName.Visible = False
            txtFilterGender.Visible = False
            txtFilterAddress.Visible = False
            txtFilterCourse.Visible = False
            txtFilterSchoolYear.Visible = False
            txtFilterYearSection.Visible = False
            txtFilterDOR.Visible = True
            txtFilterTotalUnits.Visible = False
        ElseIf cboFilterData.Text = "Total Units" Then
            txtFilterID.Visible = False
            txtFilterStudentID.Visible = False
            txtFilterName.Visible = False
            txtFilterGender.Visible = False
            txtFilterAddress.Visible = False
            txtFilterCourse.Visible = False
            txtFilterSchoolYear.Visible = False
            txtFilterYearSection.Visible = False
            txtFilterDOR.Visible = False
            txtFilterTotalUnits.Visible = True
        End If
    End Sub

    Private Sub Guna2CirclePictureBox1_Click(sender As Object, e As EventArgs) Handles pbxSearch.Click
        If cboFilterData.Text = "All" Then
            Dim conn As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Lenovo\Documents\Visual Studio 2019\New Projects\StudentInfoSystem\StudentInfoSystem\bin\Debug\RegistrationDB.mdb")
            Dim da As New OleDbDataAdapter("SELECT * FROM studTable", conn)
            Dim dt As New DataTable
            da.Fill(dt)
            Me.dtgStudentProfile.DataSource = dt
        ElseIf cboFilterData.Text = "ID" Then
            searchsID()
        ElseIf cboFilterData.Text = "Student ID" Then
            searchstudentID()
        ElseIf cboFilterData.Text = "Student Name" Then
            searchName()
        ElseIf cboFilterData.Text = "Gender" Then
            searchGender()
        ElseIf cboFilterData.Text = "Address" Then
            searchAddress()
        ElseIf cboFilterData.Text = "Course / Major" Then
            searchCourse()
        ElseIf cboFilterData.Text = "School Year" Then
            searchSchoolyear()
        ElseIf cboFilterData.Text = "Year / Section" Then
            searchyearsection()
        ElseIf cboFilterData.Text = "DOR" Then
            searchDOR()
        ElseIf cboFilterData.Text = "Total Units" Then
            searchtotalunits()
        End If
    End Sub

    Private Sub btnChangeImage_Click(sender As Object, e As EventArgs) Handles btnChangeImage.Click
        If btnChangeImage.Text = "NEW" Then Exit Sub

        If txtStudentID.Text = "" Then MsgBox("Please Fill out the Student ID first!!", MsgBoxStyle.Exclamation, "") : Exit Sub
        pbxChangeImage.SizeMode = PictureBoxSizeMode.StretchImage

        Dim curpiccto = OFDpicture.ShowDialog()
        pbxChangeImage.Image = My.Resources.add_image
        If curpiccto = Windows.Forms.DialogResult.Cancel Then Exit Sub
        Dim curFile As String = OFDpicture.FileName

        If File.Exists(curFile) = True Then
            pbxStudentImage.Image = Image.FromFile(OFDpicture.FileName)
            selectedPicture = True
        Else
            selectedPicture = False
            MsgBox("File not found, Please Select a Picture!", MsgBoxStyle.Exclamation, "")
            pbxStudentImage.Image = My.Resources.man_shape
            Exit Sub
        End If
    End Sub

    Private Sub pbxClear_Click(sender As Object, e As EventArgs) Handles pbxClear.Click
        searchName()
        cboFilterData.Text = ""
        txtFilterID.Text = ""
        txtFilterStudentID.Text = ""
        txtFilterName.Text = ""
        txtFilterGender.Text = ""
        txtFilterSchoolYear.Text = ""
        txtFilterCourse.Text = ""
        txtFilterYearSection.Text = ""
        txtFilterDOR.Text = ""
        txtFilterTotalUnits.Text = ""
        load_Student_Profile()
    End Sub

    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs) Handles BunifuImageButton1.Click
        Application.Exit()
    End Sub
End Class