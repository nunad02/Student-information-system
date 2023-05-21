Public Class Progress1
    Private Sub T1_Tick(sender As Object, e As EventArgs)

    End Sub

    Private Sub T2_Tick(sender As Object, e As EventArgs)

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgBar.Value += 1
        ProgBar.Text = ProgBar.Value.ToString

        If Me.Opacity < 1 Then
            Me.Opacity += 0.05
        End If
        If ProgBar.Value = 100 Then
            Timer1.Stop()
            Timer2.Start()
        End If

        If ProgBar.Value = 10 Then
            lbl1.Text = "Loading.."
        ElseIf ProgBar.Value = 20 Then
            lbl1.Text = "Loading."
        ElseIf ProgBar.Value = 30 Then
            lbl1.Text = "Loading.."
        ElseIf ProgBar.Value = 40 Then
            lbl1.Text = "Loading..."
        ElseIf ProgBar.Value = 50 Then
            lbl1.Text = "Loading.."
        ElseIf ProgBar.Value = 60 Then
            lbl1.Text = "Loading."
        ElseIf ProgBar.Value = 70 Then
            lbl1.Text = "Loading.."
        ElseIf ProgBar.Value = 80 Then
            lbl1.Text = "Loading..."
        ElseIf ProgBar.Value = 90 Then
            lbl1.Text = "Loading..."
        ElseIf ProgBar.Value = 100 Then
            lbl1.Text = "Loading..."
        End If

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Timer2.Stop()
        Me.Close()
        MainForm.Show()
    End Sub

    Private Sub Progress1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ProgBar.Value = 0
        Me.Opacity = 0
        Timer1.Start()
    End Sub
End Class