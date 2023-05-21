Imports System.Data.OleDb
Imports System.Windows.Forms.DataVisualization.Charting

Public Class Dashboard
    Dim conn As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Lenovo\Documents\Visual Studio 2019\New Projects\StudentInfoSystem\StudentInfoSystem\bin\Debug\RegistrationDB.mdb")

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


    Private Sub TableLayoutPanel1_Paint(sender As Object, e As PaintEventArgs)

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

    'Private Sub adminPanel_Paint(sender As Object, e As PaintEventArgs)
    '    Dim conn As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Lenovo\Documents\Visual Studio 2019\New Projects\StudentInfoSystem\StudentInfoSystem\bin\Debug\RegistrationDB.mdb")
    '    conn.Open()
    '    Dim cmd2 As New OleDbCommand("SELECT COUNT(*) FROM studTable WHERE course_major = 'BSIT'", conn)
    '    Dim count2 = Convert.ToString(cmd2.ExecuteScalar)
    '    lblTotalAdmin.Text = count2
    '    loadchart()
    '    load_chart()
    '    conn.Close()
    'End Sub

    'Private Sub userPanel_Paint(sender As Object, e As PaintEventArgs)
    '    Dim conn As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Lenovo\Documents\Visual Studio 2019\New Projects\StudentInfoSystem\StudentInfoSystem\bin\Debug\RegistrationDB.mdb")
    '    conn.Open()
    '    Dim cmd2 As New OleDbCommand("SELECT COUNT(*) FROM studTable WHERE year_section = '3B'", conn)
    '    Dim count2 = Convert.ToString(cmd2.ExecuteScalar)
    '    lblTotalUser.Text = count2
    '    loadchart()
    '    load_chart()
    '    conn.Close()
    'End Sub

    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs) Handles BunifuImageButton1.Click
        Application.Exit()
    End Sub

    Private Sub TableLayoutPanel1_Paint_1(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel1.Paint

    End Sub

    Private Sub Chart2_Click(sender As Object, e As EventArgs) Handles Chart2.Click

    End Sub

    Private Sub TableLayoutPanel2_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel2.Paint

    End Sub

    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Chart3_Click(sender As Object, e As EventArgs) Handles Chart3.Click

    End Sub

    Private Sub Chart1_Click(sender As Object, e As EventArgs) Handles Chart1.Click

    End Sub
End Class