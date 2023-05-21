Imports System.Data.OleDb
Imports System.Windows.Forms.DataVisualization.Charting
Imports System.Speech.Synthesis
Public Class MainForm
    Dim conn As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Lenovo\Documents\Visual Studio 2019\New Projects\StudentInfoSystem\StudentInfoSystem\bin\Debug\RegistrationDB.mdb")
    Dim speech As New SpeechSynthesizer
    Private Sub sidebar_Paint(sender As Object, e As PaintEventArgs) Handles sidebar.Paint

    End Sub
    Public Sub load_chart1()
        Chart1.Titles.Clear()
        With Chart1
            .Series.Clear()
            .Series.Add("Series1")
        End With

        Dim da As New OleDbDataAdapter("SELECT gender, COUNT(ID) AS Total FROM studTable GROUP BY gender", conn)
        Dim ds As New DataSet

        da.Fill(ds, "gender")
        Chart1.DataSource = ds.Tables("gender")
        Dim series2 As Series = Chart1.Series("Series1")
        series2.ChartType = SeriesChartType.Doughnut
        series2.Name = "gender"

        With Chart1
            .Series(0)("PieLabelStyle") = "Outside"
            .Series(0).BorderWidth = 2
            .Series(0).BorderColor = System.Drawing.Color.FromArgb(66, 3, 44)
            .ChartAreas(0).Area3DStyle.Enable3D = True
            .Series(series2.Name).XValueMember = "gender"
            .Series(series2.Name).YValueMembers = "Total"
            .Series(0).LabelFormat = "(#,##0)"
            .Series(0).IsValueShownAsLabel = True

            .Titles.Add("=== Gender ===")
            .Titles(0).Font = New Font("Century Gothic", 14, FontStyle.Bold)
            .Titles(0).ForeColor = Color.FromArgb(0, 0, 64)
        End With
    End Sub

    Public Sub load_chart2()
        Chart2.Titles.Clear()
        With Chart2
            .Series.Clear()
            .Series.Add("Series1")
        End With

        Dim da As New OleDbDataAdapter("SELECT year_section, COUNT(ID) AS Total FROM studTable GROUP BY year_section", conn)
        Dim ds As New DataSet

        da.Fill(ds, "year_section")
        Chart2.DataSource = ds.Tables("year_section")
        Dim series2 As Series = Chart2.Series("Series1")
        series2.ChartType = SeriesChartType.Doughnut
        series2.Name = "year_section"

        With Chart2
            .Series(0)("PieLabelStyle") = "Outside"
            .Series(0).BorderWidth = 2
            .Series(0).BorderColor = System.Drawing.Color.FromArgb(66, 3, 44)
            .ChartAreas(0).Area3DStyle.Enable3D = True
            .Series(series2.Name).XValueMember = "year_section"
            .Series(series2.Name).YValueMembers = "Total"
            .Series(0).LabelFormat = "(#,##0)"
            .Series(0).IsValueShownAsLabel = True

            .Titles.Add("=== Year / Section ===")
            .Titles(0).Font = New Font("Century Gothic", 14, FontStyle.Bold)
            .Titles(0).ForeColor = Color.FromArgb(0, 0, 64)
        End With
    End Sub
    Public Sub load_chart3()
        With Chart3
            .Series.Clear()
            .ChartAreas.Clear()
            .ChartAreas.Add("ChartArea1")
            .ChartAreas(0).AxisX.Interval = 1
            .ChartAreas(0).AxisY.LabelStyle.Format = "#,##0"
            .Legends.Clear()
            .Titles.Clear()
        End With

        Dim da As New OleDbDataAdapter("SELECT course_major, COUNT(studentId) AS Total FROM studTable GROUP BY course_major", conn)
        Dim ds As New DataSet

        da.Fill(ds, "course_major")
        Chart3.DataSource = ds.Tables("course_major")
        Dim series1 As Series = Chart3.Series.Add("Series1")
        series1.ChartType = SeriesChartType.Column
        series1.Name = "course_major"
        series1.XValueMember = "course_major"
        series1.YValueMembers = "Total"
        series1.IsValueShownAsLabel = True
        series1.LabelFormat = "#,##0"

        With Chart3
            .Series(0).Color = Color.Orange
            .Titles.Add("=== Course / Major ===")
            .Titles(0).Font = New Font("Century Gothic", 14, FontStyle.Bold)
            .Titles(0).ForeColor = Color.FromArgb(0, 0, 64)
        End With
    End Sub

    Private Sub btnSP_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        switchPanel(Dashboard)
    End Sub

    Private Sub Chart1_Click(sender As Object, e As EventArgs)

    End Sub

    Sub switchPanel(ByVal panel As Form)
        studForm.Controls.Clear()
        panel.TopLevel = False
        studForm.Controls.Add(panel)
        panel.Show()
    End Sub

    Private Sub btnStudentProfile_Click(sender As Object, e As EventArgs) Handles btnStudentProfile.Click
        switchPanel(Student_Profile)
    End Sub

    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles btnContact.Click
        switchPanel(Contact)
    End Sub

    Private Sub BunifuFlatButton2_Click(sender As Object, e As EventArgs) Handles btnAbout.Click
        switchPanel(About)
    End Sub

    Private Sub btnSettings_Click(sender As Object, e As EventArgs) Handles btnSettings.Click
        switchPanel(Settings)
    End Sub


    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        If (MessageBox.Show("Are you sure?", "LOGOUT", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes) Then
            speech.SpeakAsync("Logout successfully")
            MessageBox.Show("Logout Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.DoubleBuffered = True
            Progress2.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub studForm_Paint(sender As Object, e As PaintEventArgs) Handles studForm.Paint

    End Sub

    Private Sub studentPanel_Paint(sender As Object, e As PaintEventArgs) Handles studentPanel.Paint
        Dim conn As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Lenovo\Documents\Visual Studio 2019\New Projects\StudentInfoSystem\StudentInfoSystem\bin\Debug\RegistrationDB.mdb")
        conn.Open()
        Dim cmd1 As New OleDbCommand("SELECT COUNT(*) FROM studTable", conn)
        Dim count1 = Convert.ToString(cmd1.ExecuteScalar)
        lblTotalStudent.Text = count1
        load_chart1()
        load_chart2()
        load_chart3()
        conn.Close()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Chart3_Click(sender As Object, e As EventArgs) Handles Chart3.Click

    End Sub
End Class