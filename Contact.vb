Imports System.Speech.Synthesis
Public Class Contact
    Dim speech As New SpeechSynthesizer
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        speech.SpeakAsync("Thank you for reaching out!")
        MessageBox.Show("Thank you for reaching out!", "Contact Us", MessageBoxButtons.OK, MessageBoxIcon.Information)
        MessageBox.Show("Dear " & txtName.Text & "!," & Environment.NewLine & "" & Environment.NewLine &
                        "       Thank you for contacting us. We appreciate you taking the time to reach out and we are glad that you are interested in our services." & Environment.NewLine & "" & Environment.NewLine &
                        "       We have received your message and one of our team members will get back to you as soon as possible." & Environment.NewLine & "" & Environment.NewLine &
                        "       Our goal is to respond to all inquiries within 24 hours, but please allow up to 48 hours during busy periods.", "Thank you...", MessageBoxButtons.OK)
        txtName.Text = ""
        txtEmail.Text = ""
        txtSubject.Text = ""
        txtMessage.Text = ""
    End Sub

    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs) Handles BunifuImageButton1.Click
        Application.Exit()
    End Sub
End Class