Imports System.Data.OleDb
Imports System.Speech.Synthesis
Public Class Form1
    Dim conn As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Lenovo\Documents\Visual Studio 2019\New Projects\StudentInfoSystem\StudentInfoSystem\bin\Debug\RegistrationDB.mdb")
    Dim dr As OleDbDataReader
    Dim speech As New SpeechSynthesizer
    Private Sub btnLog_Click(sender As Object, e As EventArgs) Handles btnLog.Click
        Try
            conn.Open()
            Dim cmd As New OleDbCommand("SELECT * FROM Usertbl WHERE Username = '" & txtUser.Text & "' AND Password = '" & txtPass.Text & "'", conn)
            dr = cmd.ExecuteReader
            If dr.HasRows = True Then
                If MessageBox.Show("Are you sure that you want to login?", "LOGIN", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    speech.SpeakAsync("Login Successfully")
                    MessageBox.Show("Login Successfully", "WELCOME", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.Hide()
                    Progress1.Show()
                End If
            ElseIf txtUser.Text = "" And txtPass.Text = "" Then
                MessageBox.Show("Please enter your Username and Password", "Oops!!!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("The username and password is Incorrect!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
            dr.Close()
        End Try
    End Sub

    Private Sub showbtn_Click(sender As Object, e As EventArgs) Handles showbtn.Click
        txtPass.isPassword = Not txtPass.isPassword
    End Sub

    Private Sub txtPass_OnValueChanged(sender As Object, e As EventArgs) Handles txtPass.OnValueChanged

    End Sub

    Private Sub txtPass_MouseEnter(sender As Object, e As EventArgs) Handles txtPass.MouseEnter
        If txtPass.Text = "Enter password" Then
            txtPass.Text = ""
            txtPass.ForeColor = Color.Black
            txtPass.isPassword = True
        End If
    End Sub

    Private Sub txtPass_MouseLeave(sender As Object, e As EventArgs) Handles txtPass.MouseLeave
        If txtPass.Text = "" Then
            txtPass.Text = "Enter password"
            txtPass.ForeColor = Color.Black
            txtPass.isPassword = False
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BunifuImageButton2_Click(sender As Object, e As EventArgs) Handles BunifuImageButton2.Click
        Application.Exit()
    End Sub

    Private Sub forgetPass_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles forgetPass.LinkClicked
        ForgetPassword.Show()
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Me.Hide()
        SignUp.Show()
    End Sub

    Private Sub txtUser_OnValueChanged(sender As Object, e As EventArgs) Handles txtUser.OnValueChanged

    End Sub
End Class
