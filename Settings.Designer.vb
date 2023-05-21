<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Settings
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Settings))
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cboType = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.id = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.btnDelete = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnNew = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtFullname = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtPassword = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtUsername = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.dtgAccounts = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BunifuImageButton1 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Panel7.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dtgAccounts, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(3, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.Panel7.Controls.Add(Me.PictureBox1)
        Me.Panel7.Controls.Add(Me.Label6)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel7.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel7.Location = New System.Drawing.Point(0, 70)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(954, 38)
        Me.Panel7.TabIndex = 155
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label6.Font = New System.Drawing.Font("Algerian", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Gold
        Me.Label6.Location = New System.Drawing.Point(429, 8)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(104, 21)
        Me.Label6.TabIndex = 55
        Me.Label6.Text = "SETTINGS"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(3, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.Panel3.Controls.Add(Me.BunifuImageButton1)
        Me.Panel3.Controls.Add(Me.PictureBox3)
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(954, 70)
        Me.Panel3.TabIndex = 154
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label7.Font = New System.Drawing.Font("Algerian", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(176, 5)
        Me.Label7.Name = "Label7"
        Me.Label7.Padding = New System.Windows.Forms.Padding(0, 10, 0, 10)
        Me.Label7.Size = New System.Drawing.Size(593, 61)
        Me.Label7.TabIndex = 91
        Me.Label7.Text = " STUDENT INFORMATION SYSTEM"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cboType)
        Me.GroupBox1.Controls.Add(Me.id)
        Me.GroupBox1.Controls.Add(Me.btnDelete)
        Me.GroupBox1.Controls.Add(Me.btnNew)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtFullname)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtPassword)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtUsername)
        Me.GroupBox1.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(33, 114)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(891, 263)
        Me.GroupBox1.TabIndex = 153
        Me.GroupBox1.TabStop = False
        '
        'cboType
        '
        Me.cboType.BackColor = System.Drawing.Color.Transparent
        Me.cboType.BorderColor = System.Drawing.Color.Transparent
        Me.cboType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboType.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cboType.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cboType.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold)
        Me.cboType.ForeColor = System.Drawing.Color.Black
        Me.cboType.ItemHeight = 30
        Me.cboType.Items.AddRange(New Object() {"Admin", "User"})
        Me.cboType.Location = New System.Drawing.Point(483, 142)
        Me.cboType.Name = "cboType"
        Me.cboType.Size = New System.Drawing.Size(350, 36)
        Me.cboType.TabIndex = 144
        '
        'id
        '
        Me.id.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.id.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.id.ForeColor = System.Drawing.Color.White
        Me.id.HintForeColor = System.Drawing.Color.Empty
        Me.id.HintText = ""
        Me.id.isPassword = False
        Me.id.LineFocusedColor = System.Drawing.Color.White
        Me.id.LineIdleColor = System.Drawing.Color.White
        Me.id.LineMouseHoverColor = System.Drawing.Color.White
        Me.id.LineThickness = 3
        Me.id.Location = New System.Drawing.Point(278, 21)
        Me.id.Margin = New System.Windows.Forms.Padding(6, 4, 6, 4)
        Me.id.Name = "id"
        Me.id.Size = New System.Drawing.Size(36, 35)
        Me.id.TabIndex = 37
        Me.id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.id.Visible = False
        '
        'btnDelete
        '
        Me.btnDelete.Activecolor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(3, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.btnDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(3, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnDelete.BorderRadius = 0
        Me.btnDelete.ButtonText = "Delete"
        Me.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDelete.DisabledColor = System.Drawing.Color.Gray
        Me.btnDelete.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Iconcolor = System.Drawing.Color.Transparent
        Me.btnDelete.Iconimage = Nothing
        Me.btnDelete.Iconimage_right = Nothing
        Me.btnDelete.Iconimage_right_Selected = Nothing
        Me.btnDelete.Iconimage_Selected = Nothing
        Me.btnDelete.IconMarginLeft = 0
        Me.btnDelete.IconMarginRight = 0
        Me.btnDelete.IconRightVisible = True
        Me.btnDelete.IconRightZoom = 0R
        Me.btnDelete.IconVisible = True
        Me.btnDelete.IconZoom = 90.0R
        Me.btnDelete.IsTab = False
        Me.btnDelete.Location = New System.Drawing.Point(483, 194)
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(6, 4, 6, 4)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(3, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.btnDelete.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.btnDelete.OnHoverTextColor = System.Drawing.Color.White
        Me.btnDelete.selected = False
        Me.btnDelete.Size = New System.Drawing.Size(350, 38)
        Me.btnDelete.TabIndex = 35
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnDelete.Textcolor = System.Drawing.Color.White
        Me.btnDelete.TextFont = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnNew
        '
        Me.btnNew.Activecolor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(3, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.btnNew.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(3, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.btnNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnNew.BorderRadius = 0
        Me.btnNew.ButtonText = "New"
        Me.btnNew.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNew.DisabledColor = System.Drawing.Color.Gray
        Me.btnNew.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNew.Iconcolor = System.Drawing.Color.Transparent
        Me.btnNew.Iconimage = Nothing
        Me.btnNew.Iconimage_right = Nothing
        Me.btnNew.Iconimage_right_Selected = Nothing
        Me.btnNew.Iconimage_Selected = Nothing
        Me.btnNew.IconMarginLeft = 0
        Me.btnNew.IconMarginRight = 0
        Me.btnNew.IconRightVisible = True
        Me.btnNew.IconRightZoom = 0R
        Me.btnNew.IconVisible = True
        Me.btnNew.IconZoom = 90.0R
        Me.btnNew.IsTab = False
        Me.btnNew.Location = New System.Drawing.Point(56, 194)
        Me.btnNew.Margin = New System.Windows.Forms.Padding(6, 4, 6, 4)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(3, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.btnNew.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.btnNew.OnHoverTextColor = System.Drawing.Color.White
        Me.btnNew.selected = False
        Me.btnNew.Size = New System.Drawing.Size(350, 38)
        Me.btnNew.TabIndex = 34
        Me.btnNew.Text = "New"
        Me.btnNew.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnNew.Textcolor = System.Drawing.Color.White
        Me.btnNew.TextFont = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(591, 120)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(133, 18)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Account Type:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(591, 38)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(99, 18)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Full Name:"
        '
        'txtFullname
        '
        Me.txtFullname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtFullname.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFullname.ForeColor = System.Drawing.Color.Black
        Me.txtFullname.HintForeColor = System.Drawing.Color.Empty
        Me.txtFullname.HintText = ""
        Me.txtFullname.isPassword = False
        Me.txtFullname.LineFocusedColor = System.Drawing.Color.Blue
        Me.txtFullname.LineIdleColor = System.Drawing.Color.Black
        Me.txtFullname.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.txtFullname.LineThickness = 3
        Me.txtFullname.Location = New System.Drawing.Point(483, 60)
        Me.txtFullname.Margin = New System.Windows.Forms.Padding(6, 4, 6, 4)
        Me.txtFullname.Name = "txtFullname"
        Me.txtFullname.Size = New System.Drawing.Size(350, 35)
        Me.txtFullname.TabIndex = 6
        Me.txtFullname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(170, 120)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(101, 18)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Password:"
        '
        'txtPassword
        '
        Me.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPassword.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.ForeColor = System.Drawing.Color.Black
        Me.txtPassword.HintForeColor = System.Drawing.Color.Empty
        Me.txtPassword.HintText = ""
        Me.txtPassword.isPassword = True
        Me.txtPassword.LineFocusedColor = System.Drawing.Color.Blue
        Me.txtPassword.LineIdleColor = System.Drawing.Color.Black
        Me.txtPassword.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.txtPassword.LineThickness = 3
        Me.txtPassword.Location = New System.Drawing.Point(56, 142)
        Me.txtPassword.Margin = New System.Windows.Forms.Padding(6, 4, 6, 4)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(350, 35)
        Me.txtPassword.TabIndex = 4
        Me.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(170, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 18)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Username:"
        '
        'txtUsername
        '
        Me.txtUsername.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtUsername.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsername.ForeColor = System.Drawing.Color.Black
        Me.txtUsername.HintForeColor = System.Drawing.Color.Empty
        Me.txtUsername.HintText = ""
        Me.txtUsername.isPassword = False
        Me.txtUsername.LineFocusedColor = System.Drawing.Color.Blue
        Me.txtUsername.LineIdleColor = System.Drawing.Color.Black
        Me.txtUsername.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.txtUsername.LineThickness = 3
        Me.txtUsername.Location = New System.Drawing.Point(56, 60)
        Me.txtUsername.Margin = New System.Windows.Forms.Padding(6, 4, 6, 4)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(350, 35)
        Me.txtUsername.TabIndex = 2
        Me.txtUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'dtgAccounts
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dtgAccounts.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dtgAccounts.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.dtgAccounts.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dtgAccounts.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(3, Byte), Integer), CType(CType(54, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(3, Byte), Integer), CType(CType(54, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtgAccounts.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dtgAccounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dtgAccounts.DefaultCellStyle = DataGridViewCellStyle3
        Me.dtgAccounts.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dtgAccounts.DoubleBuffered = True
        Me.dtgAccounts.EnableHeadersVisualStyles = False
        Me.dtgAccounts.GridColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.dtgAccounts.HeaderBgColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(3, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.dtgAccounts.HeaderForeColor = System.Drawing.Color.White
        Me.dtgAccounts.Location = New System.Drawing.Point(0, 377)
        Me.dtgAccounts.Name = "dtgAccounts"
        Me.dtgAccounts.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dtgAccounts.RowHeadersWidth = 100
        Me.dtgAccounts.Size = New System.Drawing.Size(954, 226)
        Me.dtgAccounts.TabIndex = 156
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(409, 8)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(20, 20)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 53
        Me.PictureBox1.TabStop = False
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
        Me.BunifuImageButton1.TabIndex = 93
        Me.BunifuImageButton1.TabStop = False
        Me.BunifuImageButton1.Zoom = 10
        '
        'PictureBox3
        '
        Me.PictureBox3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(13, 12)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(56, 47)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 90
        Me.PictureBox3.TabStop = False
        '
        'Settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(954, 603)
        Me.Controls.Add(Me.dtgAccounts)
        Me.Controls.Add(Me.Panel7)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Settings"
        Me.Text = "Settings"
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dtgAccounts, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel7 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label7 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cboType As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents id As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents btnDelete As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnNew As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtFullname As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtPassword As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtUsername As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents dtgAccounts As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents BunifuImageButton1 As Bunifu.Framework.UI.BunifuImageButton
End Class
