Imports System.Data.OleDb
Imports System.Speech.Synthesis
Public Class SignUp
    Dim speech As New SpeechSynthesizer
    Dim conn As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Lenovo\Documents\Visual Studio 2019\New Projects\StudentInfoSystem\StudentInfoSystem\bin\Debug\RegistrationDB.mdb")
    Private Sub signbtn_Click(sender As Object, e As EventArgs) Handles signbtn.Click
        If txtUsername.Text = Nothing Or txtPassword.Text = Nothing Or txtFullname.Text = Nothing Or cboType.Text = Nothing Then
            speech.SpeakAsync("Please enter empty details")
            MessageBox.Show("Please enter empty details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If

        Using create As New OleDbCommand("INSERT INTO usertbl([Username], [Password], [Fullname], [Type], [Email]) VALUES(@Username, @Password, @Fullname, @Type, @Email)", conn)
            create.Parameters.AddWithValue("@Username", OleDbType.VarChar).Value = txtUsername.Text.Trim
            create.Parameters.AddWithValue("@Password", OleDbType.VarChar).Value = txtPassword.Text.Trim
            create.Parameters.AddWithValue("@Fullname", OleDbType.VarChar).Value = txtFullname.Text.Trim
            create.Parameters.AddWithValue("@Type", OleDbType.VarChar).Value = cboType.Text.Trim
            create.Parameters.AddWithValue("@Email", OleDbType.VarChar).Value = txtEmail.Text.Trim

            If create.ExecuteNonQuery Then
                speech.SpeakAsync("Account successfully created")
                MessageBox.Show("Account successfully created", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtUsername.Text = ""
                txtFullname.Text = ""
                txtPassword.Text = ""
                cboType.Text = ""
                txtEmail.Text = ""
            Else
                speech.SpeakAsync("Registration Error")
                MessageBox.Show("Registration Error")
            End If

        End Using
        conn.Close()
    End Sub

    Private Sub showbtn_Click(sender As Object, e As EventArgs) Handles showbtn.Click
        txtPassword.isPassword = Not txtPassword.isPassword
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub BunifuImageButton2_Click(sender As Object, e As EventArgs)
        Application.Exit()
    End Sub

    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs) Handles BunifuImageButton1.Click
        Application.Exit()
    End Sub
End Class