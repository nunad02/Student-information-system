<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Student_Profile
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Student_Profile))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.cboFilterData = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.btnChangeImage = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.txtCourse = New System.Windows.Forms.TextBox()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.txtGender = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.txtSchoolYear = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.txtYearSection = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BunifuImageButton1 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BunifuCustomLabel9 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel8 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel7 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.txtName = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.BunifuCustomLabel6 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel5 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel4 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel3 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.txtStudentID = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.txtTotalUnits = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.txtFilterTotalUnits = New Guna.UI2.WinForms.Guna2TextBox()
        Me.BunifuCustomLabel2 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.txtDateofreg = New System.Windows.Forms.DateTimePicker()
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.txtID = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.dtgStudentProfile = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.txtFilterStudentID = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtFilterSchoolYear = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtFilterYearSection = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtFilterCourse = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtFilterAddress = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtFilterGender = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtFilterName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.OFDpicture = New System.Windows.Forms.OpenFileDialog()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtFilterDOR = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lblStatus = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.txtFilterID = New Guna.UI2.WinForms.Guna2TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.pbxChangeImage = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Me.pbxDelete = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Me.pbxEditCancel = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Me.pbxNewSaveUpdate = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Me.pbxStudentImage = New System.Windows.Forms.PictureBox()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.pbxClear = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Me.pbxPrint = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Me.pbxSearch = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.Panel2.SuspendLayout()
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtgStudentProfile, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.pbxChangeImage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxDelete, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxEditCancel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxNewSaveUpdate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxStudentImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel7.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxClear, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxPrint, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cboFilterData
        '
        Me.cboFilterData.BackColor = System.Drawing.Color.Transparent
        Me.cboFilterData.BorderColor = System.Drawing.Color.Transparent
        Me.cboFilterData.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboFilterData.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboFilterData.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cboFilterData.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cboFilterData.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold)
        Me.cboFilterData.ForeColor = System.Drawing.Color.Black
        Me.cboFilterData.ItemHeight = 30
        Me.cboFilterData.Items.AddRange(New Object() {"All", "ID", "Student ID", "Student Name", "Gender", "Address", "Course / Major", "School Year", "Year / Section", "DOR", "Total Units"})
        Me.cboFilterData.Location = New System.Drawing.Point(36, 350)
        Me.cboFilterData.Name = "cboFilterData"
        Me.cboFilterData.Size = New System.Drawing.Size(250, 36)
        Me.cboFilterData.TabIndex = 164
        '
        'btnChangeImage
        '
        Me.btnChangeImage.Activecolor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(3, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.btnChangeImage.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(3, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.btnChangeImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnChangeImage.BorderRadius = 0
        Me.btnChangeImage.ButtonText = "Add Photo"
        Me.btnChangeImage.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnChangeImage.DisabledColor = System.Drawing.Color.Gray
        Me.btnChangeImage.Iconcolor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(3, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.btnChangeImage.Iconimage = Nothing
        Me.btnChangeImage.Iconimage_right = Nothing
        Me.btnChangeImage.Iconimage_right_Selected = Nothing
        Me.btnChangeImage.Iconimage_Selected = Nothing
        Me.btnChangeImage.IconMarginLeft = 0
        Me.btnChangeImage.IconMarginRight = 0
        Me.btnChangeImage.IconRightVisible = True
        Me.btnChangeImage.IconRightZoom = 0R
        Me.btnChangeImage.IconVisible = True
        Me.btnChangeImage.IconZoom = 50.0R
        Me.btnChangeImage.IsTab = False
        Me.btnChangeImage.Location = New System.Drawing.Point(21, 183)
        Me.btnChangeImage.Name = "btnChangeImage"
        Me.btnChangeImage.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(3, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.btnChangeImage.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.btnChangeImage.OnHoverTextColor = System.Drawing.Color.White
        Me.btnChangeImage.selected = False
        Me.btnChangeImage.Size = New System.Drawing.Size(152, 32)
        Me.btnChangeImage.TabIndex = 140
        Me.btnChangeImage.Text = "Add Photo"
        Me.btnChangeImage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnChangeImage.Textcolor = System.Drawing.Color.White
        Me.btnChangeImage.TextFont = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'txtCourse
        '
        Me.txtCourse.Enabled = False
        Me.txtCourse.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCourse.Location = New System.Drawing.Point(387, 99)
        Me.txtCourse.Multiline = True
        Me.txtCourse.Name = "txtCourse"
        Me.txtCourse.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtCourse.Size = New System.Drawing.Size(224, 61)
        Me.txtCourse.TabIndex = 139
        '
        'txtAddress
        '
        Me.txtAddress.Enabled = False
        Me.txtAddress.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddress.Location = New System.Drawing.Point(193, 99)
        Me.txtAddress.Multiline = True
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtAddress.Size = New System.Drawing.Size(157, 61)
        Me.txtAddress.TabIndex = 138
        '
        'txtGender
        '
        Me.txtGender.BackColor = System.Drawing.Color.Transparent
        Me.txtGender.BorderColor = System.Drawing.Color.Transparent
        Me.txtGender.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.txtGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtGender.Enabled = False
        Me.txtGender.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtGender.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtGender.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold)
        Me.txtGender.ForeColor = System.Drawing.Color.Black
        Me.txtGender.ItemHeight = 30
        Me.txtGender.Items.AddRange(New Object() {"Male", "Female"})
        Me.txtGender.Location = New System.Drawing.Point(649, 32)
        Me.txtGender.Name = "txtGender"
        Me.txtGender.Size = New System.Drawing.Size(181, 36)
        Me.txtGender.TabIndex = 128
        '
        'txtSchoolYear
        '
        Me.txtSchoolYear.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtSchoolYear.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSchoolYear.Enabled = False
        Me.txtSchoolYear.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSchoolYear.ForeColor = System.Drawing.Color.Black
        Me.txtSchoolYear.HintForeColor = System.Drawing.Color.Empty
        Me.txtSchoolYear.HintText = ""
        Me.txtSchoolYear.isPassword = False
        Me.txtSchoolYear.LineFocusedColor = System.Drawing.Color.Navy
        Me.txtSchoolYear.LineIdleColor = System.Drawing.Color.Black
        Me.txtSchoolYear.LineMouseHoverColor = System.Drawing.Color.Navy
        Me.txtSchoolYear.LineThickness = 3
        Me.txtSchoolYear.Location = New System.Drawing.Point(193, 178)
        Me.txtSchoolYear.Margin = New System.Windows.Forms.Padding(6, 4, 6, 4)
        Me.txtSchoolYear.Name = "txtSchoolYear"
        Me.txtSchoolYear.Size = New System.Drawing.Size(161, 35)
        Me.txtSchoolYear.TabIndex = 122
        Me.txtSchoolYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtYearSection
        '
        Me.txtYearSection.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtYearSection.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtYearSection.Enabled = False
        Me.txtYearSection.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtYearSection.ForeColor = System.Drawing.Color.Black
        Me.txtYearSection.HintForeColor = System.Drawing.Color.Empty
        Me.txtYearSection.HintText = ""
        Me.txtYearSection.isPassword = False
        Me.txtYearSection.LineFocusedColor = System.Drawing.Color.Navy
        Me.txtYearSection.LineIdleColor = System.Drawing.Color.Black
        Me.txtYearSection.LineMouseHoverColor = System.Drawing.Color.Navy
        Me.txtYearSection.LineThickness = 3
        Me.txtYearSection.Location = New System.Drawing.Point(649, 105)
        Me.txtYearSection.Margin = New System.Windows.Forms.Padding(6, 4, 6, 4)
        Me.txtYearSection.Name = "txtYearSection"
        Me.txtYearSection.Size = New System.Drawing.Size(181, 35)
        Me.txtYearSection.TabIndex = 123
        Me.txtYearSection.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(3, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.Panel2.Controls.Add(Me.BunifuImageButton1)
        Me.Panel2.Controls.Add(Me.PictureBox2)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(954, 70)
        Me.Panel2.TabIndex = 165
        '
        'BunifuImageButton1
        '
        Me.BunifuImageButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BunifuImageButton1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuImageButton1.Image = CType(resources.GetObject("BunifuImageButton1.Image"), System.Drawing.Image)
        Me.BunifuImageButton1.ImageActive = CType(resources.GetObject("BunifuImageButton1.ImageActive"), System.Drawing.Image)
        Me.BunifuImageButton1.Location = New System.Drawing.Point(914, 4)
        Me.BunifuImageButton1.Name = "BunifuImageButton1"
        Me.BunifuImageButton1.Size = New System.Drawing.Size(35, 30)
        Me.BunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuImageButton1.TabIndex = 94
        Me.BunifuImageButton1.TabStop = False
        Me.BunifuImageButton1.Zoom = 10
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(13, 12)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(56, 47)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 90
        Me.PictureBox2.TabStop = False
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label4.Font = New System.Drawing.Font("Algerian", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(176, 5)
        Me.Label4.Name = "Label4"
        Me.Label4.Padding = New System.Windows.Forms.Padding(0, 10, 0, 10)
        Me.Label4.Size = New System.Drawing.Size(593, 61)
        Me.Label4.TabIndex = 91
        Me.Label4.Text = " STUDENT INFORMATION SYSTEM"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BunifuCustomLabel9
        '
        Me.BunifuCustomLabel9.AutoSize = True
        Me.BunifuCustomLabel9.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel9.Location = New System.Drawing.Point(193, 165)
        Me.BunifuCustomLabel9.Name = "BunifuCustomLabel9"
        Me.BunifuCustomLabel9.Size = New System.Drawing.Size(110, 14)
        Me.BunifuCustomLabel9.TabIndex = 137
        Me.BunifuCustomLabel9.Text = "SCHOOL YEAR:"
        '
        'BunifuCustomLabel8
        '
        Me.BunifuCustomLabel8.AutoSize = True
        Me.BunifuCustomLabel8.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel8.Location = New System.Drawing.Point(646, 15)
        Me.BunifuCustomLabel8.Name = "BunifuCustomLabel8"
        Me.BunifuCustomLabel8.Size = New System.Drawing.Size(67, 14)
        Me.BunifuCustomLabel8.TabIndex = 136
        Me.BunifuCustomLabel8.Text = "GENDER:"
        '
        'BunifuCustomLabel7
        '
        Me.BunifuCustomLabel7.AutoSize = True
        Me.BunifuCustomLabel7.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel7.Location = New System.Drawing.Point(384, 82)
        Me.BunifuCustomLabel7.Name = "BunifuCustomLabel7"
        Me.BunifuCustomLabel7.Size = New System.Drawing.Size(126, 14)
        Me.BunifuCustomLabel7.TabIndex = 135
        Me.BunifuCustomLabel7.Text = "COURSE / MAJOR"
        '
        'txtName
        '
        Me.txtName.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtName.Enabled = False
        Me.txtName.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.ForeColor = System.Drawing.Color.Black
        Me.txtName.HintForeColor = System.Drawing.Color.Empty
        Me.txtName.HintText = ""
        Me.txtName.isPassword = False
        Me.txtName.LineFocusedColor = System.Drawing.Color.Navy
        Me.txtName.LineIdleColor = System.Drawing.Color.Black
        Me.txtName.LineMouseHoverColor = System.Drawing.Color.Navy
        Me.txtName.LineThickness = 3
        Me.txtName.Location = New System.Drawing.Point(387, 30)
        Me.txtName.Margin = New System.Windows.Forms.Padding(6, 4, 6, 4)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(224, 35)
        Me.txtName.TabIndex = 125
        Me.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BunifuCustomLabel6
        '
        Me.BunifuCustomLabel6.AutoSize = True
        Me.BunifuCustomLabel6.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel6.Location = New System.Drawing.Point(195, 82)
        Me.BunifuCustomLabel6.Name = "BunifuCustomLabel6"
        Me.BunifuCustomLabel6.Size = New System.Drawing.Size(76, 14)
        Me.BunifuCustomLabel6.TabIndex = 134
        Me.BunifuCustomLabel6.Text = "ADDRESS:"
        '
        'BunifuCustomLabel5
        '
        Me.BunifuCustomLabel5.AutoSize = True
        Me.BunifuCustomLabel5.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel5.Location = New System.Drawing.Point(384, 18)
        Me.BunifuCustomLabel5.Name = "BunifuCustomLabel5"
        Me.BunifuCustomLabel5.Size = New System.Drawing.Size(117, 14)
        Me.BunifuCustomLabel5.TabIndex = 133
        Me.BunifuCustomLabel5.Text = "STUDENT NAME:"
        '
        'BunifuCustomLabel4
        '
        Me.BunifuCustomLabel4.AutoSize = True
        Me.BunifuCustomLabel4.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel4.Location = New System.Drawing.Point(190, 18)
        Me.BunifuCustomLabel4.Name = "BunifuCustomLabel4"
        Me.BunifuCustomLabel4.Size = New System.Drawing.Size(95, 14)
        Me.BunifuCustomLabel4.TabIndex = 132
        Me.BunifuCustomLabel4.Text = "STUDENT ID:"
        '
        'BunifuCustomLabel3
        '
        Me.BunifuCustomLabel3.AutoSize = True
        Me.BunifuCustomLabel3.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel3.Location = New System.Drawing.Point(646, 82)
        Me.BunifuCustomLabel3.Name = "BunifuCustomLabel3"
        Me.BunifuCustomLabel3.Size = New System.Drawing.Size(120, 14)
        Me.BunifuCustomLabel3.TabIndex = 131
        Me.BunifuCustomLabel3.Text = "YEAR / SECTION"
        '
        'txtStudentID
        '
        Me.txtStudentID.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtStudentID.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtStudentID.Enabled = False
        Me.txtStudentID.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStudentID.ForeColor = System.Drawing.Color.Black
        Me.txtStudentID.HintForeColor = System.Drawing.Color.Empty
        Me.txtStudentID.HintText = ""
        Me.txtStudentID.isPassword = False
        Me.txtStudentID.LineFocusedColor = System.Drawing.Color.Navy
        Me.txtStudentID.LineIdleColor = System.Drawing.Color.Black
        Me.txtStudentID.LineMouseHoverColor = System.Drawing.Color.Navy
        Me.txtStudentID.LineThickness = 3
        Me.txtStudentID.Location = New System.Drawing.Point(193, 30)
        Me.txtStudentID.Margin = New System.Windows.Forms.Padding(6, 4, 6, 4)
        Me.txtStudentID.Name = "txtStudentID"
        Me.txtStudentID.Size = New System.Drawing.Size(161, 35)
        Me.txtStudentID.TabIndex = 124
        Me.txtStudentID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtTotalUnits
        '
        Me.txtTotalUnits.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtTotalUnits.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTotalUnits.Enabled = False
        Me.txtTotalUnits.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalUnits.ForeColor = System.Drawing.Color.Black
        Me.txtTotalUnits.HintForeColor = System.Drawing.Color.Empty
        Me.txtTotalUnits.HintText = ""
        Me.txtTotalUnits.isPassword = False
        Me.txtTotalUnits.LineFocusedColor = System.Drawing.Color.Navy
        Me.txtTotalUnits.LineIdleColor = System.Drawing.Color.Black
        Me.txtTotalUnits.LineMouseHoverColor = System.Drawing.Color.Navy
        Me.txtTotalUnits.LineThickness = 3
        Me.txtTotalUnits.Location = New System.Drawing.Point(649, 178)
        Me.txtTotalUnits.Margin = New System.Windows.Forms.Padding(6, 4, 6, 4)
        Me.txtTotalUnits.Name = "txtTotalUnits"
        Me.txtTotalUnits.Size = New System.Drawing.Size(181, 35)
        Me.txtTotalUnits.TabIndex = 130
        Me.txtTotalUnits.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtFilterTotalUnits
        '
        Me.txtFilterTotalUnits.Animated = True
        Me.txtFilterTotalUnits.BorderColor = System.Drawing.Color.Black
        Me.txtFilterTotalUnits.BorderRadius = 5
        Me.txtFilterTotalUnits.BorderThickness = 2
        Me.txtFilterTotalUnits.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtFilterTotalUnits.DefaultText = ""
        Me.txtFilterTotalUnits.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtFilterTotalUnits.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtFilterTotalUnits.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtFilterTotalUnits.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtFilterTotalUnits.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtFilterTotalUnits.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold)
        Me.txtFilterTotalUnits.ForeColor = System.Drawing.Color.Black
        Me.txtFilterTotalUnits.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtFilterTotalUnits.Location = New System.Drawing.Point(376, 349)
        Me.txtFilterTotalUnits.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtFilterTotalUnits.Name = "txtFilterTotalUnits"
        Me.txtFilterTotalUnits.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFilterTotalUnits.PlaceholderText = ""
        Me.txtFilterTotalUnits.SelectedText = ""
        Me.txtFilterTotalUnits.Size = New System.Drawing.Size(247, 38)
        Me.txtFilterTotalUnits.TabIndex = 162
        '
        'BunifuCustomLabel2
        '
        Me.BunifuCustomLabel2.AutoSize = True
        Me.BunifuCustomLabel2.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel2.Location = New System.Drawing.Point(646, 165)
        Me.BunifuCustomLabel2.Name = "BunifuCustomLabel2"
        Me.BunifuCustomLabel2.Size = New System.Drawing.Size(103, 14)
        Me.BunifuCustomLabel2.TabIndex = 129
        Me.BunifuCustomLabel2.Text = "TOTAL UNITS:"
        '
        'txtDateofreg
        '
        Me.txtDateofreg.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtDateofreg.CalendarFont = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDateofreg.CalendarForeColor = System.Drawing.Color.Navy
        Me.txtDateofreg.CalendarTitleForeColor = System.Drawing.Color.Navy
        Me.txtDateofreg.CalendarTrailingForeColor = System.Drawing.Color.Navy
        Me.txtDateofreg.Enabled = False
        Me.txtDateofreg.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDateofreg.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtDateofreg.Location = New System.Drawing.Point(387, 190)
        Me.txtDateofreg.Name = "txtDateofreg"
        Me.txtDateofreg.Size = New System.Drawing.Size(224, 23)
        Me.txtDateofreg.TabIndex = 127
        Me.txtDateofreg.Value = New Date(2023, 3, 4, 9, 11, 31, 0)
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.AutoSize = True
        Me.BunifuCustomLabel1.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(384, 165)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(177, 14)
        Me.BunifuCustomLabel1.TabIndex = 126
        Me.BunifuCustomLabel1.Text = "DATE OF REGISTRATION:"
        '
        'txtID
        '
        Me.txtID.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtID.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtID.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtID.ForeColor = System.Drawing.Color.White
        Me.txtID.HintForeColor = System.Drawing.Color.Empty
        Me.txtID.HintText = ""
        Me.txtID.isPassword = False
        Me.txtID.LineFocusedColor = System.Drawing.Color.White
        Me.txtID.LineIdleColor = System.Drawing.Color.White
        Me.txtID.LineMouseHoverColor = System.Drawing.Color.White
        Me.txtID.LineThickness = 3
        Me.txtID.Location = New System.Drawing.Point(118, 0)
        Me.txtID.Margin = New System.Windows.Forms.Padding(6, 4, 6, 4)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(32, 35)
        Me.txtID.TabIndex = 121
        Me.txtID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtID.Visible = False
        '
        'dtgStudentProfile
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dtgStudentProfile.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dtgStudentProfile.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.dtgStudentProfile.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dtgStudentProfile.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(3, Byte), Integer), CType(CType(54, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(3, Byte), Integer), CType(CType(54, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtgStudentProfile.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dtgStudentProfile.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dtgStudentProfile.DefaultCellStyle = DataGridViewCellStyle3
        Me.dtgStudentProfile.DoubleBuffered = True
        Me.dtgStudentProfile.EnableHeadersVisualStyles = False
        Me.dtgStudentProfile.GridColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.dtgStudentProfile.HeaderBgColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(3, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.dtgStudentProfile.HeaderForeColor = System.Drawing.Color.White
        Me.dtgStudentProfile.Location = New System.Drawing.Point(12, 393)
        Me.dtgStudentProfile.Name = "dtgStudentProfile"
        Me.dtgStudentProfile.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dtgStudentProfile.RowHeadersWidth = 100
        Me.dtgStudentProfile.Size = New System.Drawing.Size(931, 174)
        Me.dtgStudentProfile.TabIndex = 168
        '
        'txtFilterStudentID
        '
        Me.txtFilterStudentID.Animated = True
        Me.txtFilterStudentID.BorderColor = System.Drawing.Color.Black
        Me.txtFilterStudentID.BorderRadius = 5
        Me.txtFilterStudentID.BorderThickness = 2
        Me.txtFilterStudentID.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtFilterStudentID.DefaultText = ""
        Me.txtFilterStudentID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtFilterStudentID.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtFilterStudentID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtFilterStudentID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtFilterStudentID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtFilterStudentID.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold)
        Me.txtFilterStudentID.ForeColor = System.Drawing.Color.Black
        Me.txtFilterStudentID.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtFilterStudentID.Location = New System.Drawing.Point(376, 349)
        Me.txtFilterStudentID.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtFilterStudentID.Name = "txtFilterStudentID"
        Me.txtFilterStudentID.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFilterStudentID.PlaceholderText = ""
        Me.txtFilterStudentID.SelectedText = ""
        Me.txtFilterStudentID.Size = New System.Drawing.Size(247, 38)
        Me.txtFilterStudentID.TabIndex = 163
        '
        'txtFilterSchoolYear
        '
        Me.txtFilterSchoolYear.Animated = True
        Me.txtFilterSchoolYear.BorderColor = System.Drawing.Color.Black
        Me.txtFilterSchoolYear.BorderRadius = 5
        Me.txtFilterSchoolYear.BorderThickness = 2
        Me.txtFilterSchoolYear.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtFilterSchoolYear.DefaultText = ""
        Me.txtFilterSchoolYear.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtFilterSchoolYear.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtFilterSchoolYear.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtFilterSchoolYear.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtFilterSchoolYear.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtFilterSchoolYear.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold)
        Me.txtFilterSchoolYear.ForeColor = System.Drawing.Color.Black
        Me.txtFilterSchoolYear.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtFilterSchoolYear.Location = New System.Drawing.Point(376, 349)
        Me.txtFilterSchoolYear.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtFilterSchoolYear.Name = "txtFilterSchoolYear"
        Me.txtFilterSchoolYear.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFilterSchoolYear.PlaceholderText = ""
        Me.txtFilterSchoolYear.SelectedText = ""
        Me.txtFilterSchoolYear.Size = New System.Drawing.Size(247, 38)
        Me.txtFilterSchoolYear.TabIndex = 160
        '
        'txtFilterYearSection
        '
        Me.txtFilterYearSection.Animated = True
        Me.txtFilterYearSection.BorderColor = System.Drawing.Color.Black
        Me.txtFilterYearSection.BorderRadius = 5
        Me.txtFilterYearSection.BorderThickness = 2
        Me.txtFilterYearSection.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtFilterYearSection.DefaultText = ""
        Me.txtFilterYearSection.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtFilterYearSection.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtFilterYearSection.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtFilterYearSection.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtFilterYearSection.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtFilterYearSection.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold)
        Me.txtFilterYearSection.ForeColor = System.Drawing.Color.Black
        Me.txtFilterYearSection.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtFilterYearSection.Location = New System.Drawing.Point(376, 349)
        Me.txtFilterYearSection.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtFilterYearSection.Name = "txtFilterYearSection"
        Me.txtFilterYearSection.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFilterYearSection.PlaceholderText = ""
        Me.txtFilterYearSection.SelectedText = ""
        Me.txtFilterYearSection.Size = New System.Drawing.Size(247, 38)
        Me.txtFilterYearSection.TabIndex = 159
        '
        'txtFilterCourse
        '
        Me.txtFilterCourse.Animated = True
        Me.txtFilterCourse.BorderColor = System.Drawing.Color.Black
        Me.txtFilterCourse.BorderRadius = 5
        Me.txtFilterCourse.BorderThickness = 2
        Me.txtFilterCourse.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtFilterCourse.DefaultText = ""
        Me.txtFilterCourse.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtFilterCourse.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtFilterCourse.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtFilterCourse.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtFilterCourse.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtFilterCourse.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold)
        Me.txtFilterCourse.ForeColor = System.Drawing.Color.Black
        Me.txtFilterCourse.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtFilterCourse.Location = New System.Drawing.Point(376, 349)
        Me.txtFilterCourse.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtFilterCourse.Name = "txtFilterCourse"
        Me.txtFilterCourse.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFilterCourse.PlaceholderText = ""
        Me.txtFilterCourse.SelectedText = ""
        Me.txtFilterCourse.Size = New System.Drawing.Size(247, 38)
        Me.txtFilterCourse.TabIndex = 158
        '
        'txtFilterAddress
        '
        Me.txtFilterAddress.Animated = True
        Me.txtFilterAddress.BorderColor = System.Drawing.Color.Black
        Me.txtFilterAddress.BorderRadius = 5
        Me.txtFilterAddress.BorderThickness = 2
        Me.txtFilterAddress.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtFilterAddress.DefaultText = ""
        Me.txtFilterAddress.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtFilterAddress.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtFilterAddress.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtFilterAddress.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtFilterAddress.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtFilterAddress.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold)
        Me.txtFilterAddress.ForeColor = System.Drawing.Color.Black
        Me.txtFilterAddress.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtFilterAddress.Location = New System.Drawing.Point(376, 349)
        Me.txtFilterAddress.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtFilterAddress.Name = "txtFilterAddress"
        Me.txtFilterAddress.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFilterAddress.PlaceholderText = ""
        Me.txtFilterAddress.SelectedText = ""
        Me.txtFilterAddress.Size = New System.Drawing.Size(247, 38)
        Me.txtFilterAddress.TabIndex = 157
        '
        'txtFilterGender
        '
        Me.txtFilterGender.Animated = True
        Me.txtFilterGender.BorderColor = System.Drawing.Color.Black
        Me.txtFilterGender.BorderRadius = 5
        Me.txtFilterGender.BorderThickness = 2
        Me.txtFilterGender.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtFilterGender.DefaultText = ""
        Me.txtFilterGender.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtFilterGender.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtFilterGender.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtFilterGender.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtFilterGender.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtFilterGender.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold)
        Me.txtFilterGender.ForeColor = System.Drawing.Color.Black
        Me.txtFilterGender.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtFilterGender.Location = New System.Drawing.Point(376, 349)
        Me.txtFilterGender.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtFilterGender.Name = "txtFilterGender"
        Me.txtFilterGender.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFilterGender.PlaceholderText = ""
        Me.txtFilterGender.SelectedText = ""
        Me.txtFilterGender.Size = New System.Drawing.Size(247, 38)
        Me.txtFilterGender.TabIndex = 156
        '
        'txtFilterName
        '
        Me.txtFilterName.Animated = True
        Me.txtFilterName.BorderColor = System.Drawing.Color.Black
        Me.txtFilterName.BorderRadius = 5
        Me.txtFilterName.BorderThickness = 2
        Me.txtFilterName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtFilterName.DefaultText = ""
        Me.txtFilterName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtFilterName.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtFilterName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtFilterName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtFilterName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtFilterName.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold)
        Me.txtFilterName.ForeColor = System.Drawing.Color.Black
        Me.txtFilterName.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtFilterName.Location = New System.Drawing.Point(376, 349)
        Me.txtFilterName.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtFilterName.Name = "txtFilterName"
        Me.txtFilterName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFilterName.PlaceholderText = ""
        Me.txtFilterName.SelectedText = ""
        Me.txtFilterName.Size = New System.Drawing.Size(247, 38)
        Me.txtFilterName.TabIndex = 155
        '
        'OFDpicture
        '
        Me.OFDpicture.FileName = "OpenFileDialog1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(694, 346)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 38)
        Me.Label1.TabIndex = 154
        '
        'txtFilterDOR
        '
        Me.txtFilterDOR.Animated = True
        Me.txtFilterDOR.BorderColor = System.Drawing.Color.Black
        Me.txtFilterDOR.BorderRadius = 5
        Me.txtFilterDOR.BorderThickness = 2
        Me.txtFilterDOR.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtFilterDOR.DefaultText = ""
        Me.txtFilterDOR.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtFilterDOR.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtFilterDOR.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtFilterDOR.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtFilterDOR.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtFilterDOR.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold)
        Me.txtFilterDOR.ForeColor = System.Drawing.Color.Black
        Me.txtFilterDOR.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtFilterDOR.Location = New System.Drawing.Point(376, 349)
        Me.txtFilterDOR.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtFilterDOR.Name = "txtFilterDOR"
        Me.txtFilterDOR.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFilterDOR.PlaceholderText = ""
        Me.txtFilterDOR.SelectedText = ""
        Me.txtFilterDOR.Size = New System.Drawing.Size(247, 38)
        Me.txtFilterDOR.TabIndex = 161
        '
        'lblStatus
        '
        Me.lblStatus.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(3, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.lblStatus.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.ForeColor = System.Drawing.Color.Transparent
        Me.lblStatus.Location = New System.Drawing.Point(13, 570)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(930, 30)
        Me.lblStatus.TabIndex = 153
        Me.lblStatus.Text = "Male: 0 | Female: 0 | Total Students: 0"
        Me.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtFilterID
        '
        Me.txtFilterID.Animated = True
        Me.txtFilterID.BorderColor = System.Drawing.Color.Black
        Me.txtFilterID.BorderRadius = 5
        Me.txtFilterID.BorderThickness = 2
        Me.txtFilterID.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtFilterID.DefaultText = ""
        Me.txtFilterID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtFilterID.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtFilterID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtFilterID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtFilterID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtFilterID.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold)
        Me.txtFilterID.ForeColor = System.Drawing.Color.Black
        Me.txtFilterID.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtFilterID.Location = New System.Drawing.Point(376, 349)
        Me.txtFilterID.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtFilterID.Name = "txtFilterID"
        Me.txtFilterID.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFilterID.PlaceholderText = ""
        Me.txtFilterID.SelectedText = ""
        Me.txtFilterID.Size = New System.Drawing.Size(247, 38)
        Me.txtFilterID.TabIndex = 150
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnChangeImage)
        Me.GroupBox1.Controls.Add(Me.pbxChangeImage)
        Me.GroupBox1.Controls.Add(Me.txtCourse)
        Me.GroupBox1.Controls.Add(Me.txtAddress)
        Me.GroupBox1.Controls.Add(Me.txtGender)
        Me.GroupBox1.Controls.Add(Me.txtSchoolYear)
        Me.GroupBox1.Controls.Add(Me.txtYearSection)
        Me.GroupBox1.Controls.Add(Me.BunifuCustomLabel9)
        Me.GroupBox1.Controls.Add(Me.BunifuCustomLabel8)
        Me.GroupBox1.Controls.Add(Me.BunifuCustomLabel7)
        Me.GroupBox1.Controls.Add(Me.txtName)
        Me.GroupBox1.Controls.Add(Me.BunifuCustomLabel6)
        Me.GroupBox1.Controls.Add(Me.BunifuCustomLabel5)
        Me.GroupBox1.Controls.Add(Me.BunifuCustomLabel4)
        Me.GroupBox1.Controls.Add(Me.BunifuCustomLabel3)
        Me.GroupBox1.Controls.Add(Me.txtStudentID)
        Me.GroupBox1.Controls.Add(Me.txtTotalUnits)
        Me.GroupBox1.Controls.Add(Me.BunifuCustomLabel2)
        Me.GroupBox1.Controls.Add(Me.txtDateofreg)
        Me.GroupBox1.Controls.Add(Me.BunifuCustomLabel1)
        Me.GroupBox1.Controls.Add(Me.txtID)
        Me.GroupBox1.Controls.Add(Me.pbxDelete)
        Me.GroupBox1.Controls.Add(Me.pbxEditCancel)
        Me.GroupBox1.Controls.Add(Me.pbxNewSaveUpdate)
        Me.GroupBox1.Controls.Add(Me.pbxStudentImage)
        Me.GroupBox1.Location = New System.Drawing.Point(15, 115)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(926, 229)
        Me.GroupBox1.TabIndex = 149
        Me.GroupBox1.TabStop = False
        '
        'pbxChangeImage
        '
        Me.pbxChangeImage.BackColor = System.Drawing.Color.Transparent
        Me.pbxChangeImage.FillColor = System.Drawing.Color.Transparent
        Me.pbxChangeImage.ImageRotate = 0!
        Me.pbxChangeImage.Location = New System.Drawing.Point(74, 183)
        Me.pbxChangeImage.Name = "pbxChangeImage"
        Me.pbxChangeImage.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.pbxChangeImage.Size = New System.Drawing.Size(36, 31)
        Me.pbxChangeImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbxChangeImage.TabIndex = 118
        Me.pbxChangeImage.TabStop = False
        '
        'pbxDelete
        '
        Me.pbxDelete.FillColor = System.Drawing.Color.DimGray
        Me.pbxDelete.Image = Global.StudentInfoSystem.My.Resources.Resources.delete
        Me.pbxDelete.ImageRotate = 0!
        Me.pbxDelete.Location = New System.Drawing.Point(870, 105)
        Me.pbxDelete.Name = "pbxDelete"
        Me.pbxDelete.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.pbxDelete.Size = New System.Drawing.Size(36, 37)
        Me.pbxDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxDelete.TabIndex = 120
        Me.pbxDelete.TabStop = False
        '
        'pbxEditCancel
        '
        Me.pbxEditCancel.FillColor = System.Drawing.Color.DimGray
        Me.pbxEditCancel.Image = Global.StudentInfoSystem.My.Resources.Resources.edit
        Me.pbxEditCancel.ImageRotate = 0!
        Me.pbxEditCancel.Location = New System.Drawing.Point(870, 59)
        Me.pbxEditCancel.Name = "pbxEditCancel"
        Me.pbxEditCancel.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.pbxEditCancel.Size = New System.Drawing.Size(36, 37)
        Me.pbxEditCancel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxEditCancel.TabIndex = 119
        Me.pbxEditCancel.TabStop = False
        Me.pbxEditCancel.Tag = "Edit"
        '
        'pbxNewSaveUpdate
        '
        Me.pbxNewSaveUpdate.FillColor = System.Drawing.Color.DimGray
        Me.pbxNewSaveUpdate.Image = Global.StudentInfoSystem.My.Resources.Resources.add_new
        Me.pbxNewSaveUpdate.ImageRotate = 0!
        Me.pbxNewSaveUpdate.Location = New System.Drawing.Point(869, 15)
        Me.pbxNewSaveUpdate.Name = "pbxNewSaveUpdate"
        Me.pbxNewSaveUpdate.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.pbxNewSaveUpdate.Size = New System.Drawing.Size(36, 37)
        Me.pbxNewSaveUpdate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxNewSaveUpdate.TabIndex = 118
        Me.pbxNewSaveUpdate.TabStop = False
        Me.pbxNewSaveUpdate.Tag = "New"
        '
        'pbxStudentImage
        '
        Me.pbxStudentImage.BackColor = System.Drawing.Color.White
        Me.pbxStudentImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pbxStudentImage.Image = Global.StudentInfoSystem.My.Resources.Resources.man_shape
        Me.pbxStudentImage.Location = New System.Drawing.Point(21, 36)
        Me.pbxStudentImage.Name = "pbxStudentImage"
        Me.pbxStudentImage.Size = New System.Drawing.Size(152, 141)
        Me.pbxStudentImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxStudentImage.TabIndex = 98
        Me.pbxStudentImage.TabStop = False
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(3, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.Panel7.Controls.Add(Me.Label3)
        Me.Panel7.Controls.Add(Me.PictureBox1)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel7.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel7.Location = New System.Drawing.Point(0, 70)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(954, 38)
        Me.Panel7.TabIndex = 169
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label3.Font = New System.Drawing.Font("Algerian", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Gold
        Me.Label3.Location = New System.Drawing.Point(380, 7)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(212, 21)
        Me.Label3.TabIndex = 55
        Me.Label3.Text = " STUDENT PROFILE    "
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(361, 8)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(20, 20)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 55
        Me.PictureBox1.TabStop = False
        '
        'pbxClear
        '
        Me.pbxClear.FillColor = System.Drawing.Color.DimGray
        Me.pbxClear.Image = Global.StudentInfoSystem.My.Resources.Resources.update_2
        Me.pbxClear.ImageRotate = 0!
        Me.pbxClear.Location = New System.Drawing.Point(630, 350)
        Me.pbxClear.Name = "pbxClear"
        Me.pbxClear.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.pbxClear.Size = New System.Drawing.Size(36, 37)
        Me.pbxClear.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxClear.TabIndex = 151
        Me.pbxClear.TabStop = False
        '
        'pbxPrint
        '
        Me.pbxPrint.FillColor = System.Drawing.Color.DimGray
        Me.pbxPrint.Image = Global.StudentInfoSystem.My.Resources.Resources.printing
        Me.pbxPrint.ImageRotate = 0!
        Me.pbxPrint.Location = New System.Drawing.Point(292, 350)
        Me.pbxPrint.Name = "pbxPrint"
        Me.pbxPrint.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.pbxPrint.Size = New System.Drawing.Size(36, 37)
        Me.pbxPrint.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxPrint.TabIndex = 152
        Me.pbxPrint.TabStop = False
        '
        'pbxSearch
        '
        Me.pbxSearch.FillColor = System.Drawing.Color.DimGray
        Me.pbxSearch.Image = Global.StudentInfoSystem.My.Resources.Resources.searh
        Me.pbxSearch.ImageRotate = 0!
        Me.pbxSearch.Location = New System.Drawing.Point(333, 350)
        Me.pbxSearch.Name = "pbxSearch"
        Me.pbxSearch.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.pbxSearch.Size = New System.Drawing.Size(36, 37)
        Me.pbxSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxSearch.TabIndex = 167
        Me.pbxSearch.TabStop = False
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'PrintDocument1
        '
        '
        'Student_Profile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(954, 603)
        Me.Controls.Add(Me.Panel7)
        Me.Controls.Add(Me.cboFilterData)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.txtFilterTotalUnits)
        Me.Controls.Add(Me.pbxClear)
        Me.Controls.Add(Me.dtgStudentProfile)
        Me.Controls.Add(Me.txtFilterStudentID)
        Me.Controls.Add(Me.pbxPrint)
        Me.Controls.Add(Me.txtFilterSchoolYear)
        Me.Controls.Add(Me.txtFilterYearSection)
        Me.Controls.Add(Me.txtFilterCourse)
        Me.Controls.Add(Me.txtFilterAddress)
        Me.Controls.Add(Me.txtFilterGender)
        Me.Controls.Add(Me.txtFilterName)
        Me.Controls.Add(Me.pbxSearch)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtFilterDOR)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.txtFilterID)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Student_Profile"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Student_Profile"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtgStudentProfile, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.pbxChangeImage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxDelete, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxEditCancel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxNewSaveUpdate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxStudentImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxClear, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxPrint, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxSearch, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cboFilterData As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents btnChangeImage As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents pbxChangeImage As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents txtCourse As TextBox
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents txtGender As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents txtSchoolYear As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents txtYearSection As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents BunifuCustomLabel9 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel8 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel7 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents txtName As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents BunifuCustomLabel6 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel5 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel4 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel3 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents txtStudentID As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents txtTotalUnits As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents txtFilterTotalUnits As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents BunifuCustomLabel2 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents pbxClear As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents txtDateofreg As DateTimePicker
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents txtID As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents pbxDelete As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents pbxEditCancel As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents pbxNewSaveUpdate As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents dtgStudentProfile As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents txtFilterStudentID As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents pbxPrint As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents pbxStudentImage As PictureBox
    Friend WithEvents txtFilterSchoolYear As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtFilterYearSection As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtFilterCourse As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtFilterAddress As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtFilterGender As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtFilterName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents OFDpicture As OpenFileDialog
    Friend WithEvents pbxSearch As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtFilterDOR As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblStatus As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents txtFilterID As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BunifuImageButton1 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
End Class
