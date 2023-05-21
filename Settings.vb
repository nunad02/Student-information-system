Imports System.Data.OleDb
Imports System.Speech.Synthesis
Public Class Settings
    Dim speech As New SpeechSynthesizer
    Dim conn As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Lenovo\Documents\Visual Studio 2019\New Projects\StudentInfoSystem\StudentInfoSystem\bin\Debug\RegistrationDB.mdb")
    Public Sub loadAccounts()
        If Not conn.State = ConnectionState.Open Then
            conn.Open()
        End If
        Dim da As New OleDb.OleDbDataAdapter("SELECT * FROM Usertbl", conn)
        Dim dt As New DataTable
        da.Fill(dt)
        Me.dtgAccounts.DataSource = dt
        dtgAccounts.Font = New Font("Arial Narrow", 11)
        dtgAccounts.Columns("Username").HeaderText = "Username"
        dtgAccounts.Columns("Username").Width = 234
        dtgAccounts.Columns("Username").ReadOnly = True

        dtgAccounts.Columns("Fullname").HeaderText = "Fullname"
        dtgAccounts.Columns("Fullname").Width = 234
        dtgAccounts.Columns("Fullname").ReadOnly = True

        dtgAccounts.Columns("Type").HeaderText = "Type"
        dtgAccounts.Columns("Type").Width = 233
        dtgAccounts.Columns("Type").ReadOnly = True

        dtgAccounts.Columns("Email").HeaderText = "Email"
        dtgAccounts.Columns("Email").Width = 234
        dtgAccounts.Columns("Email").ReadOnly = True

        dtgAccounts.Columns("ID").Visible = False
        dtgAccounts.Columns("Password").Visible = False
    End Sub
    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        If btnNew.Text = "New" Then
            btnNew.Text = "Add"
            btnDelete.Text = "Cancel"
            txtUsername.Text = ""
            txtPassword.Text = ""
            txtFullname.Text = ""
            cboType.Text = ""
            txtUsername.Enabled = True
            txtPassword.Enabled = True
            txtFullname.Enabled = True
            cboType.Enabled = True
        ElseIf btnNew.Text = "Add" Then
            Dim cmd As New OleDb.OleDbCommand

            If Not conn.State = ConnectionState.Open Then
                conn.Open()
            End If

            Using add As New OleDbCommand("INSERT INTO usertbl([Username], [Password], [Fullname], [Type]) VALUES(@Username, @Password, @Fullname, @Type)", conn)
                add.Parameters.AddWithValue("@Username", OleDbType.VarChar).Value = txtUsername.Text.Trim
                add.Parameters.AddWithValue("@Password", OleDbType.VarChar).Value = txtPassword.Text.Trim
                add.Parameters.AddWithValue("@Fullname", OleDbType.VarChar).Value = txtFullname.Text.Trim
                add.Parameters.AddWithValue("@type", OleDbType.VarChar).Value = cboType.Text.Trim

                If MessageBox.Show("Are you sure that you want to save?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                    add.ExecuteNonQuery()
                    speech.SpeakAsync("Record Successfully saved")
                    MessageBox.Show("Record successfully saved!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End Using

            Call loadAccounts()

            btnNew.Text = "New"
            btnDelete.Text = "Cancel"

            txtUsername.Text = ""
            txtPassword.Text = ""
            txtFullname.Text = ""
            cboType.Text = ""

            txtUsername.Enabled = False
            txtPassword.Enabled = False
            txtFullname.Enabled = False
            cboType.Enabled = False
        End If
        conn.Close()
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadAccounts()

        'designing the datagrid
        dtgAccounts.RowHeadersVisible = False
        dtgAccounts.AllowUserToResizeRows = False
        dtgAccounts.ScrollBars = ScrollBars.Both
        dtgAccounts.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dtgAccounts.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dtgAccounts.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dtgAccounts.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If btnDelete.Text = "Cancel" Then

            btnNew.Text = "New"
            btnDelete.Text = "Delete"

            txtUsername.Text = ""
            txtPassword.Text = ""
            txtFullname.Text = ""
            cboType.Text = ""

            txtUsername.Enabled = True
            txtPassword.Enabled = True
            txtFullname.Enabled = True
            cboType.Enabled = True
        ElseIf btnDelete.Text = "Delete" Then
            If MessageBox.Show("Are you sure?", "DELETE", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
                Dim cmd3 As New OleDbCommand("DELETE FROM usertbl WHERE ID=@ID", conn)
                cmd3.Parameters.AddWithValue("@ID", id.Text)
                If Not conn.State = ConnectionState.Open Then
                    conn.Open()
                End If
                cmd3.ExecuteNonQuery()
                speech.SpeakAsync("Deleted successfully")
                MessageBox.Show("Deleted successfully", "DELETE", MessageBoxButtons.OK, MessageBoxIcon.Information)
                id.Text = ""
                txtUsername.Text = ""
                txtPassword.Text = ""
                txtFullname.Text = ""
                cboType.Text = ""
            End If
            conn.Close()
            Call loadAccounts()
        End If
    End Sub

    Private Sub dtgAccounts_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgAccounts.CellContentClick
        id.Text = dtgAccounts.CurrentRow.Cells(0).Value.ToString()
        txtUsername.Text = dtgAccounts.CurrentRow.Cells(1).Value.ToString()
        txtPassword.Text = dtgAccounts.CurrentRow.Cells(2).Value.ToString()
        txtFullname.Text = dtgAccounts.CurrentRow.Cells(3).Value.ToString()
        cboType.Text = dtgAccounts.CurrentRow.Cells(4).Value.ToString()
    End Sub

    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs) Handles BunifuImageButton1.Click
        Application.Exit()
    End Sub
End Class