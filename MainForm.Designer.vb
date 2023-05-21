<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim ChartArea3 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend3 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series3 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.sidebar = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.BunifuGradientPanel1 = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnAbout = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnContact = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnExit = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnDashboard = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnSettings = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnStudentProfile = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.studForm = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Chart2 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Chart3 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.studentPanel = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblTotalStudent = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BunifuImageButton2 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.sidebar.SuspendLayout()
        Me.BunifuGradientPanel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.studForm.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        CType(Me.Chart2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.Chart3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.studentPanel.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel7.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.BunifuImageButton2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'sidebar
        '
        Me.sidebar.BackColor = System.Drawing.Color.Transparent
        Me.sidebar.BackgroundImage = CType(resources.GetObject("sidebar.BackgroundImage"), System.Drawing.Image)
        Me.sidebar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.sidebar.Controls.Add(Me.BunifuGradientPanel1)
        Me.sidebar.Controls.Add(Me.btnAbout)
        Me.sidebar.Controls.Add(Me.btnContact)
        Me.sidebar.Controls.Add(Me.btnExit)
        Me.sidebar.Controls.Add(Me.btnDashboard)
        Me.sidebar.Controls.Add(Me.btnSettings)
        Me.sidebar.Controls.Add(Me.btnStudentProfile)
        Me.sidebar.Dock = System.Windows.Forms.DockStyle.Left
        Me.sidebar.GradientBottomLeft = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(3, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.sidebar.GradientBottomRight = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(3, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.sidebar.GradientTopLeft = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(3, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.sidebar.GradientTopRight = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(3, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.sidebar.Location = New System.Drawing.Point(0, 0)
        Me.sidebar.Name = "sidebar"
        Me.sidebar.Quality = 10
        Me.sidebar.Size = New System.Drawing.Size(222, 606)
        Me.sidebar.TabIndex = 60
        '
        'BunifuGradientPanel1
        '
        Me.BunifuGradientPanel1.BackgroundImage = CType(resources.GetObject("BunifuGradientPanel1.BackgroundImage"), System.Drawing.Image)
        Me.BunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuGradientPanel1.Controls.Add(Me.PictureBox1)
        Me.BunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.BunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(3, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.BunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(3, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.BunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(3, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.BunifuGradientPanel1.GradientTopRight = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(3, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.BunifuGradientPanel1.Location = New System.Drawing.Point(0, 0)
        Me.BunifuGradientPanel1.Name = "BunifuGradientPanel1"
        Me.BunifuGradientPanel1.Quality = 10
        Me.BunifuGradientPanel1.Size = New System.Drawing.Size(222, 175)
        Me.BunifuGradientPanel1.TabIndex = 50
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(48, 29)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(123, 122)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 43
        Me.PictureBox1.TabStop = False
        '
        'btnAbout
        '
        Me.btnAbout.Activecolor = System.Drawing.Color.Transparent
        Me.btnAbout.BackColor = System.Drawing.Color.Transparent
        Me.btnAbout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAbout.BorderRadius = 0
        Me.btnAbout.ButtonText = "      About"
        Me.btnAbout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAbout.DisabledColor = System.Drawing.Color.Gray
        Me.btnAbout.Iconcolor = System.Drawing.Color.Transparent
        Me.btnAbout.Iconimage = CType(resources.GetObject("btnAbout.Iconimage"), System.Drawing.Image)
        Me.btnAbout.Iconimage_right = Nothing
        Me.btnAbout.Iconimage_right_Selected = Nothing
        Me.btnAbout.Iconimage_Selected = Nothing
        Me.btnAbout.IconMarginLeft = 22
        Me.btnAbout.IconMarginRight = 0
        Me.btnAbout.IconRightVisible = True
        Me.btnAbout.IconRightZoom = 0R
        Me.btnAbout.IconVisible = True
        Me.btnAbout.IconZoom = 50.0R
        Me.btnAbout.IsTab = False
        Me.btnAbout.Location = New System.Drawing.Point(0, 319)
        Me.btnAbout.Name = "btnAbout"
        Me.btnAbout.Normalcolor = System.Drawing.Color.Transparent
        Me.btnAbout.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.btnAbout.OnHoverTextColor = System.Drawing.Color.White
        Me.btnAbout.selected = True
        Me.btnAbout.Size = New System.Drawing.Size(224, 48)
        Me.btnAbout.TabIndex = 49
        Me.btnAbout.Text = "      About"
        Me.btnAbout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAbout.Textcolor = System.Drawing.Color.White
        Me.btnAbout.TextFont = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnContact
        '
        Me.btnContact.Activecolor = System.Drawing.Color.Transparent
        Me.btnContact.BackColor = System.Drawing.Color.Transparent
        Me.btnContact.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnContact.BorderRadius = 0
        Me.btnContact.ButtonText = "      Contact Us"
        Me.btnContact.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnContact.DisabledColor = System.Drawing.Color.Gray
        Me.btnContact.Iconcolor = System.Drawing.Color.Transparent
        Me.btnContact.Iconimage = CType(resources.GetObject("btnContact.Iconimage"), System.Drawing.Image)
        Me.btnContact.Iconimage_right = Nothing
        Me.btnContact.Iconimage_right_Selected = Nothing
        Me.btnContact.Iconimage_Selected = Nothing
        Me.btnContact.IconMarginLeft = 22
        Me.btnContact.IconMarginRight = 0
        Me.btnContact.IconRightVisible = True
        Me.btnContact.IconRightZoom = 0R
        Me.btnContact.IconVisible = True
        Me.btnContact.IconZoom = 50.0R
        Me.btnContact.IsTab = False
        Me.btnContact.Location = New System.Drawing.Point(0, 273)
        Me.btnContact.Name = "btnContact"
        Me.btnContact.Normalcolor = System.Drawing.Color.Transparent
        Me.btnContact.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.btnContact.OnHoverTextColor = System.Drawing.Color.White
        Me.btnContact.selected = False
        Me.btnContact.Size = New System.Drawing.Size(224, 48)
        Me.btnContact.TabIndex = 48
        Me.btnContact.Text = "      Contact Us"
        Me.btnContact.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnContact.Textcolor = System.Drawing.Color.White
        Me.btnContact.TextFont = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnExit
        '
        Me.btnExit.Activecolor = System.Drawing.Color.Transparent
        Me.btnExit.BackColor = System.Drawing.Color.Transparent
        Me.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnExit.BorderRadius = 0
        Me.btnExit.ButtonText = "      Logout"
        Me.btnExit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExit.DisabledColor = System.Drawing.Color.Gray
        Me.btnExit.Iconcolor = System.Drawing.Color.Transparent
        Me.btnExit.Iconimage = CType(resources.GetObject("btnExit.Iconimage"), System.Drawing.Image)
        Me.btnExit.Iconimage_right = Nothing
        Me.btnExit.Iconimage_right_Selected = Nothing
        Me.btnExit.Iconimage_Selected = Nothing
        Me.btnExit.IconMarginLeft = 22
        Me.btnExit.IconMarginRight = 0
        Me.btnExit.IconRightVisible = True
        Me.btnExit.IconRightZoom = 0R
        Me.btnExit.IconVisible = True
        Me.btnExit.IconZoom = 50.0R
        Me.btnExit.IsTab = False
        Me.btnExit.Location = New System.Drawing.Point(0, 555)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Normalcolor = System.Drawing.Color.Transparent
        Me.btnExit.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.btnExit.OnHoverTextColor = System.Drawing.Color.White
        Me.btnExit.selected = False
        Me.btnExit.Size = New System.Drawing.Size(224, 48)
        Me.btnExit.TabIndex = 46
        Me.btnExit.Text = "      Logout"
        Me.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExit.Textcolor = System.Drawing.Color.White
        Me.btnExit.TextFont = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnDashboard
        '
        Me.btnDashboard.Activecolor = System.Drawing.Color.Transparent
        Me.btnDashboard.BackColor = System.Drawing.Color.Transparent
        Me.btnDashboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnDashboard.BorderRadius = 0
        Me.btnDashboard.ButtonText = "      Dashboard"
        Me.btnDashboard.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDashboard.DisabledColor = System.Drawing.Color.Gray
        Me.btnDashboard.Iconcolor = System.Drawing.Color.Transparent
        Me.btnDashboard.Iconimage = CType(resources.GetObject("btnDashboard.Iconimage"), System.Drawing.Image)
        Me.btnDashboard.Iconimage_right = Nothing
        Me.btnDashboard.Iconimage_right_Selected = Nothing
        Me.btnDashboard.Iconimage_Selected = Nothing
        Me.btnDashboard.IconMarginLeft = 22
        Me.btnDashboard.IconMarginRight = 0
        Me.btnDashboard.IconRightVisible = True
        Me.btnDashboard.IconRightZoom = 0R
        Me.btnDashboard.IconVisible = True
        Me.btnDashboard.IconZoom = 50.0R
        Me.btnDashboard.IsTab = False
        Me.btnDashboard.Location = New System.Drawing.Point(0, 181)
        Me.btnDashboard.Name = "btnDashboard"
        Me.btnDashboard.Normalcolor = System.Drawing.Color.Transparent
        Me.btnDashboard.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.btnDashboard.OnHoverTextColor = System.Drawing.Color.White
        Me.btnDashboard.selected = False
        Me.btnDashboard.Size = New System.Drawing.Size(224, 48)
        Me.btnDashboard.TabIndex = 45
        Me.btnDashboard.Text = "      Dashboard"
        Me.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDashboard.Textcolor = System.Drawing.Color.White
        Me.btnDashboard.TextFont = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnSettings
        '
        Me.btnSettings.Activecolor = System.Drawing.Color.Transparent
        Me.btnSettings.BackColor = System.Drawing.Color.Transparent
        Me.btnSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSettings.BorderRadius = 0
        Me.btnSettings.ButtonText = "      Settings"
        Me.btnSettings.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSettings.DisabledColor = System.Drawing.Color.Gray
        Me.btnSettings.Iconcolor = System.Drawing.Color.Transparent
        Me.btnSettings.Iconimage = CType(resources.GetObject("btnSettings.Iconimage"), System.Drawing.Image)
        Me.btnSettings.Iconimage_right = Nothing
        Me.btnSettings.Iconimage_right_Selected = Nothing
        Me.btnSettings.Iconimage_Selected = Nothing
        Me.btnSettings.IconMarginLeft = 22
        Me.btnSettings.IconMarginRight = 0
        Me.btnSettings.IconRightVisible = True
        Me.btnSettings.IconRightZoom = 0R
        Me.btnSettings.IconVisible = True
        Me.btnSettings.IconZoom = 50.0R
        Me.btnSettings.IsTab = False
        Me.btnSettings.Location = New System.Drawing.Point(0, 365)
        Me.btnSettings.Name = "btnSettings"
        Me.btnSettings.Normalcolor = System.Drawing.Color.Transparent
        Me.btnSettings.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.btnSettings.OnHoverTextColor = System.Drawing.Color.White
        Me.btnSettings.selected = False
        Me.btnSettings.Size = New System.Drawing.Size(224, 48)
        Me.btnSettings.TabIndex = 44
        Me.btnSettings.Text = "      Settings"
        Me.btnSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSettings.Textcolor = System.Drawing.Color.White
        Me.btnSettings.TextFont = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnStudentProfile
        '
        Me.btnStudentProfile.Activecolor = System.Drawing.Color.Transparent
        Me.btnStudentProfile.BackColor = System.Drawing.Color.Transparent
        Me.btnStudentProfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnStudentProfile.BorderRadius = 0
        Me.btnStudentProfile.ButtonText = "      Student Profile"
        Me.btnStudentProfile.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnStudentProfile.DisabledColor = System.Drawing.Color.Gray
        Me.btnStudentProfile.Iconcolor = System.Drawing.Color.Transparent
        Me.btnStudentProfile.Iconimage = CType(resources.GetObject("btnStudentProfile.Iconimage"), System.Drawing.Image)
        Me.btnStudentProfile.Iconimage_right = Nothing
        Me.btnStudentProfile.Iconimage_right_Selected = Nothing
        Me.btnStudentProfile.Iconimage_Selected = Nothing
        Me.btnStudentProfile.IconMarginLeft = 22
        Me.btnStudentProfile.IconMarginRight = 0
        Me.btnStudentProfile.IconRightVisible = True
        Me.btnStudentProfile.IconRightZoom = 0R
        Me.btnStudentProfile.IconVisible = True
        Me.btnStudentProfile.IconZoom = 50.0R
        Me.btnStudentProfile.IsTab = False
        Me.btnStudentProfile.Location = New System.Drawing.Point(0, 227)
        Me.btnStudentProfile.Name = "btnStudentProfile"
        Me.btnStudentProfile.Normalcolor = System.Drawing.Color.Transparent
        Me.btnStudentProfile.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.btnStudentProfile.OnHoverTextColor = System.Drawing.Color.White
        Me.btnStudentProfile.selected = False
        Me.btnStudentProfile.Size = New System.Drawing.Size(224, 48)
        Me.btnStudentProfile.TabIndex = 43
        Me.btnStudentProfile.Text = "      Student Profile"
        Me.btnStudentProfile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnStudentProfile.Textcolor = System.Drawing.Color.White
        Me.btnStudentProfile.TextFont = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'studForm
        '
        Me.studForm.BackgroundImage = CType(resources.GetObject("studForm.BackgroundImage"), System.Drawing.Image)
        Me.studForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.studForm.Controls.Add(Me.TableLayoutPanel2)
        Me.studForm.Controls.Add(Me.TableLayoutPanel1)
        Me.studForm.Controls.Add(Me.Panel7)
        Me.studForm.Controls.Add(Me.Panel2)
        Me.studForm.Dock = System.Windows.Forms.DockStyle.Fill
        Me.studForm.GradientBottomLeft = System.Drawing.Color.Transparent
        Me.studForm.GradientBottomRight = System.Drawing.Color.Transparent
        Me.studForm.GradientTopLeft = System.Drawing.Color.Transparent
        Me.studForm.GradientTopRight = System.Drawing.Color.Transparent
        Me.studForm.Location = New System.Drawing.Point(222, 0)
        Me.studForm.Name = "studForm"
        Me.studForm.Quality = 10
        Me.studForm.Size = New System.Drawing.Size(953, 606)
        Me.studForm.TabIndex = 62
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.BackColor = System.Drawing.Color.White
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.99999!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.00001!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.Panel3, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Panel4, 1, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 365)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.Padding = New System.Windows.Forms.Padding(5)
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 231.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(953, 241)
        Me.TableLayoutPanel2.TabIndex = 169
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Chart1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(8, 8)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Padding = New System.Windows.Forms.Padding(5)
        Me.Panel3.Size = New System.Drawing.Size(465, 225)
        Me.Panel3.TabIndex = 0
        '
        'Chart1
        '
        ChartArea1.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea1)
        Me.Chart1.Dock = System.Windows.Forms.DockStyle.Fill
        Legend1.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend1)
        Me.Chart1.Location = New System.Drawing.Point(5, 5)
        Me.Chart1.Name = "Chart1"
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Me.Chart1.Series.Add(Series1)
        Me.Chart1.Size = New System.Drawing.Size(455, 215)
        Me.Chart1.TabIndex = 0
        Me.Chart1.Text = "Chart1"
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.Chart2)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(479, 8)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Padding = New System.Windows.Forms.Padding(5)
        Me.Panel4.Size = New System.Drawing.Size(466, 225)
        Me.Panel4.TabIndex = 1
        '
        'Chart2
        '
        ChartArea2.Name = "ChartArea1"
        Me.Chart2.ChartAreas.Add(ChartArea2)
        Me.Chart2.Dock = System.Windows.Forms.DockStyle.Fill
        Legend2.Name = "Legend1"
        Me.Chart2.Legends.Add(Legend2)
        Me.Chart2.Location = New System.Drawing.Point(5, 5)
        Me.Chart2.Name = "Chart2"
        Series2.ChartArea = "ChartArea1"
        Series2.Legend = "Legend1"
        Series2.Name = "Series1"
        Me.Chart2.Series.Add(Series2)
        Me.Chart2.Size = New System.Drawing.Size(456, 215)
        Me.Chart2.TabIndex = 0
        Me.Chart2.Text = "Chart2"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.White
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.26834!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.73166!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Chart3, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.studentPanel, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 108)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(953, 248)
        Me.TableLayoutPanel1.TabIndex = 168
        '
        'Chart3
        '
        ChartArea3.Name = "ChartArea1"
        Me.Chart3.ChartAreas.Add(ChartArea3)
        Me.Chart3.Dock = System.Windows.Forms.DockStyle.Fill
        Legend3.Name = "Legend1"
        Me.Chart3.Legends.Add(Legend3)
        Me.Chart3.Location = New System.Drawing.Point(348, 3)
        Me.Chart3.Name = "Chart3"
        Series3.ChartArea = "ChartArea1"
        Series3.Legend = "Legend1"
        Series3.Name = "Series1"
        Me.Chart3.Series.Add(Series3)
        Me.Chart3.Size = New System.Drawing.Size(602, 242)
        Me.Chart3.TabIndex = 1
        Me.Chart3.Text = "Chart3"
        '
        'studentPanel
        '
        Me.studentPanel.BackColor = System.Drawing.Color.White
        Me.studentPanel.Controls.Add(Me.Panel1)
        Me.studentPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.studentPanel.Location = New System.Drawing.Point(10, 10)
        Me.studentPanel.Margin = New System.Windows.Forms.Padding(10)
        Me.studentPanel.Name = "studentPanel"
        Me.studentPanel.Size = New System.Drawing.Size(325, 228)
        Me.studentPanel.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel1.Controls.Add(Me.lblTotalStudent)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(28, 25)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(268, 178)
        Me.Panel1.TabIndex = 3
        '
        'lblTotalStudent
        '
        Me.lblTotalStudent.AutoSize = True
        Me.lblTotalStudent.Font = New System.Drawing.Font("Verdana", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalStudent.ForeColor = System.Drawing.Color.White
        Me.lblTotalStudent.Location = New System.Drawing.Point(69, 65)
        Me.lblTotalStudent.Name = "lblTotalStudent"
        Me.lblTotalStudent.Padding = New System.Windows.Forms.Padding(60, 20, 60, 20)
        Me.lblTotalStudent.Size = New System.Drawing.Size(120, 82)
        Me.lblTotalStudent.TabIndex = 3
        Me.lblTotalStudent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(31, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(203, 25)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "TOTAL STUDENT"
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(3, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.Panel7.Controls.Add(Me.PictureBox2)
        Me.Panel7.Controls.Add(Me.Label3)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel7.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel7.Location = New System.Drawing.Point(0, 70)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(953, 38)
        Me.Panel7.TabIndex = 161
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(396, 9)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(20, 20)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 55
        Me.PictureBox2.TabStop = False
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label3.Font = New System.Drawing.Font("Algerian", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Gold
        Me.Label3.Location = New System.Drawing.Point(418, 8)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(128, 21)
        Me.Label3.TabIndex = 55
        Me.Label3.Text = "DASHBOARD"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(3, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.Panel2.Controls.Add(Me.BunifuImageButton2)
        Me.Panel2.Controls.Add(Me.PictureBox4)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(953, 70)
        Me.Panel2.TabIndex = 160
        '
        'BunifuImageButton2
        '
        Me.BunifuImageButton2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BunifuImageButton2.BackColor = System.Drawing.Color.Transparent
        Me.BunifuImageButton2.Image = CType(resources.GetObject("BunifuImageButton2.Image"), System.Drawing.Image)
        Me.BunifuImageButton2.ImageActive = CType(resources.GetObject("BunifuImageButton2.ImageActive"), System.Drawing.Image)
        Me.BunifuImageButton2.Location = New System.Drawing.Point(914, 4)
        Me.BunifuImageButton2.Name = "BunifuImageButton2"
        Me.BunifuImageButton2.Size = New System.Drawing.Size(35, 30)
        Me.BunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuImageButton2.TabIndex = 92
        Me.BunifuImageButton2.TabStop = False
        Me.BunifuImageButton2.Zoom = 10
        '
        'PictureBox4
        '
        Me.PictureBox4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox4.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(56, 47)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 90
        Me.PictureBox4.TabStop = False
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label4.Font = New System.Drawing.Font("Algerian", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(175, 5)
        Me.Label4.Name = "Label4"
        Me.Label4.Padding = New System.Windows.Forms.Padding(0, 10, 0, 10)
        Me.Label4.Size = New System.Drawing.Size(593, 61)
        Me.Label4.TabIndex = 91
        Me.Label4.Text = " STUDENT INFORMATION SYSTEM"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1175, 606)
        Me.Controls.Add(Me.studForm)
        Me.Controls.Add(Me.sidebar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MainForm"
        Me.sidebar.ResumeLayout(False)
        Me.BunifuGradientPanel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.studForm.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        CType(Me.Chart2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.Chart3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.studentPanel.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.BunifuImageButton2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents sidebar As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents BunifuGradientPanel1 As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnAbout As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnContact As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnExit As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnDashboard As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnSettings As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnStudentProfile As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents studForm As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents BunifuImageButton2 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Chart3 As DataVisualization.Charting.Chart
    Friend WithEvents studentPanel As Panel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Chart1 As DataVisualization.Charting.Chart
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Chart2 As DataVisualization.Charting.Chart
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblTotalStudent As Label
    Friend WithEvents Label2 As Label
End Class
