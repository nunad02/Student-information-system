Imports System.Data.OleDb
Imports System.Speech.Synthesis
Public Class ForgetPassword
    Dim speech As New SpeechSynthesizer
    Private Sub resetPassbtn_Click(sender As Object, e As EventArgs) Handles resetPassbtn.Click
        'check if email is entered
        If txtEmail.Text.Trim() = "" Then
            speech.SpeakAsync("Please enter your email address.")
            MessageBox.Show("Please enter your email address.")
            Return
        End If

        'check if email exists in database
        Dim connString As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Lenovo\source\repos\StudentLoginFrm\StudentLoginFrm\bin\Debug\LogDB.mdb"
        Dim conn As New OleDbConnection(connString)
        Dim cmd As New OleDbCommand("SELECT * FROM Usertbl WHERE Email=@Email", conn)
        cmd.Parameters.AddWithValue("@Email", txtEmail.Text.Trim())
        Dim adapter As New OleDbDataAdapter(cmd)
        Dim ds As New DataSet()
        adapter.Fill(ds)

        If ds.Tables(0).Rows.Count = 0 Then
            speech.SpeakAsync("Email address not found.")
            MessageBox.Show("Email address not found.")
            Return
        End If

        Dim newPassword As String = GenerateRandomPassword()
        Dim userId As Integer = Convert.ToInt32(ds.Tables(0).Rows(0)("ID"))
        Dim cmd1 As OleDbCommand = New OleDbCommand("UPDATE Usertbl SET [Password] = @Password WHERE [ID] = @ID", conn)
        cmd1.Parameters.AddWithValue("@Password", newPassword)
        cmd1.Parameters.AddWithValue("@ID", userId)

        conn.Open()
        cmd1.ExecuteNonQuery()
        speech.SpeakAsync("Your new password has been saved to database")
        MessageBox.Show("Your new password has been saved to database", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information)
        lblPrint.Text = "Your new password is: " & newPassword
        conn.Close()
    End Sub
    Private Function GenerateRandomPassword() As String
        Dim password As String = ""
        Dim rand As New Random()
        Dim charSet As String = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789"
        For i As Integer = 0 To 3
            password &= charSet(rand.Next(0, charSet.Length))
        Next
        Return password
    End Function

    Private Sub pbxDelete_Click(sender As Object, e As EventArgs) Handles pbxDelete.Click
        Me.Close()
    End Sub
End Class