<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ForgetPassword
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ForgetPassword))
        Me.pbxDelete = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Me.lblPrint = New System.Windows.Forms.Label()
        Me.txtPassword = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.txtID = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.txtType = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.txtFullname = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.txtUsername = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.resetPassbtn = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtEmail = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.pbxDelete, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pbxDelete
        '
        Me.pbxDelete.FillColor = System.Drawing.Color.DimGray
        Me.pbxDelete.Image = CType(resources.GetObject("pbxDelete.Image"), System.Drawing.Image)
        Me.pbxDelete.ImageRotate = 0!
        Me.pbxDelete.Location = New System.Drawing.Point(18, 15)
        Me.pbxDelete.Name = "pbxDelete"
        Me.pbxDelete.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.pbxDelete.Size = New System.Drawing.Size(31, 29)
        Me.pbxDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxDelete.TabIndex = 132
        Me.pbxDelete.TabStop = False
        '
        'lblPrint
        '
        Me.lblPrint.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblPrint.AutoSize = True
        Me.lblPrint.BackColor = System.Drawing.Color.Transparent
        Me.lblPrint.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrint.ForeColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(3, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.lblPrint.Location = New System.Drawing.Point(132, 302)
        Me.lblPrint.Name = "lblPrint"
        Me.lblPrint.Size = New System.Drawing.Size(28, 29)
        Me.lblPrint.TabIndex = 131
        Me.lblPrint.Text = "|"
        '
        'txtPassword
        '
        Me.txtPassword.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtPassword.BackColor = System.Drawing.Color.White
        Me.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPassword.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.ForeColor = System.Drawing.Color.White
        Me.txtPassword.HintForeColor = System.Drawing.Color.Empty
        Me.txtPassword.HintText = ""
        Me.txtPassword.isPassword = False
        Me.txtPassword.LineFocusedColor = System.Drawing.Color.White
        Me.txtPassword.LineIdleColor = System.Drawing.Color.White
        Me.txtPassword.LineMouseHoverColor = System.Drawing.Color.White
        Me.txtPassword.LineThickness = 3
        Me.txtPassword.Location = New System.Drawing.Point(348, 315)
        Me.txtPassword.Margin = New System.Windows.Forms.Padding(6, 4, 6, 4)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(45, 35)
        Me.txtPassword.TabIndex = 130
        Me.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtPassword.Visible = False
        '
        'txtID
        '
        Me.txtID.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtID.BackColor = System.Drawing.Color.White
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
        Me.txtID.Location = New System.Drawing.Point(269, 315)
        Me.txtID.Margin = New System.Windows.Forms.Padding(6, 4, 6, 4)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(45, 35)
        Me.txtID.TabIndex = 129
        Me.txtID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtID.Visible = False
        '
        'txtType
        '
        Me.txtType.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtType.BackColor = System.Drawing.Color.White
        Me.txtType.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtType.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtType.ForeColor = System.Drawing.Color.White
        Me.txtType.HintForeColor = System.Drawing.Color.Empty
        Me.txtType.HintText = ""
        Me.txtType.isPassword = False
        Me.txtType.LineFocusedColor = System.Drawing.Color.White
        Me.txtType.LineIdleColor = System.Drawing.Color.White
        Me.txtType.LineMouseHoverColor = System.Drawing.Color.White
        Me.txtType.LineThickness = 3
        Me.txtType.Location = New System.Drawing.Point(137, 315)
        Me.txtType.Margin = New System.Windows.Forms.Padding(6, 4, 6, 4)
        Me.txtType.Name = "txtType"
        Me.txtType.Size = New System.Drawing.Size(45, 35)
        Me.txtType.TabIndex = 128
        Me.txtType.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtType.Visible = False
        '
        'txtFullname
        '
        Me.txtFullname.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtFullname.BackColor = System.Drawing.Color.White
        Me.txtFullname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtFullname.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFullname.ForeColor = System.Drawing.Color.White
        Me.txtFullname.HintForeColor = System.Drawing.Color.Empty
        Me.txtFullname.HintText = ""
        Me.txtFullname.isPassword = False
        Me.txtFullname.LineFocusedColor = System.Drawing.Color.White
        Me.txtFullname.LineIdleColor = System.Drawing.Color.White
        Me.txtFullname.LineMouseHoverColor = System.Drawing.Color.White
        Me.txtFullname.LineThickness = 3
        Me.txtFullname.Location = New System.Drawing.Point(94, 315)
        Me.txtFullname.Margin = New System.Windows.Forms.Padding(6, 4, 6, 4)
        Me.txtFullname.Name = "txtFullname"
        Me.txtFullname.Size = New System.Drawing.Size(45, 35)
        Me.txtFullname.TabIndex = 127
        Me.txtFullname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtFullname.Visible = False
        '
        'txtUsername
        '
        Me.txtUsername.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtUsername.BackColor = System.Drawing.Color.White
        Me.txtUsername.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtUsername.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsername.ForeColor = System.Drawing.Color.White
        Me.txtUsername.HintForeColor = System.Drawing.Color.Empty
        Me.txtUsername.HintText = ""
        Me.txtUsername.isPassword = False
        Me.txtUsername.LineFocusedColor = System.Drawing.Color.White
        Me.txtUsername.LineIdleColor = System.Drawing.Color.White
        Me.txtUsername.LineMouseHoverColor = System.Drawing.Color.White
        Me.txtUsername.LineThickness = 3
        Me.txtUsername.Location = New System.Drawing.Point(37, 315)
        Me.txtUsername.Margin = New System.Windows.Forms.Padding(6, 4, 6, 4)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(45, 35)
        Me.txtUsername.TabIndex = 126
        Me.txtUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtUsername.Visible = False
        '
        'resetPassbtn
        '
        Me.resetPassbtn.Activecolor = System.Drawing.Color.MidnightBlue
        Me.resetPassbtn.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.resetPassbtn.BackColor = System.Drawing.Color.MidnightBlue
        Me.resetPassbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.resetPassbtn.BorderRadius = 0
        Me.resetPassbtn.ButtonText = "Reset Password"
        Me.resetPassbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.resetPassbtn.DisabledColor = System.Drawing.Color.Gray
        Me.resetPassbtn.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.resetPassbtn.ForeColor = System.Drawing.Color.White
        Me.resetPassbtn.Iconcolor = System.Drawing.Color.Transparent
        Me.resetPassbtn.Iconimage = Nothing
        Me.resetPassbtn.Iconimage_right = Nothing
        Me.resetPassbtn.Iconimage_right_Selected = Nothing
        Me.resetPassbtn.Iconimage_Selected = Nothing
        Me.resetPassbtn.IconMarginLeft = 0
        Me.resetPassbtn.IconMarginRight = 0
        Me.resetPassbtn.IconRightVisible = True
        Me.resetPassbtn.IconRightZoom = 0R
        Me.resetPassbtn.IconVisible = True
        Me.resetPassbtn.IconZoom = 90.0R
        Me.resetPassbtn.IsTab = False
        Me.resetPassbtn.Location = New System.Drawing.Point(161, 253)
        Me.resetPassbtn.Margin = New System.Windows.Forms.Padding(6, 4, 6, 4)
        Me.resetPassbtn.Name = "resetPassbtn"
        Me.resetPassbtn.Normalcolor = System.Drawing.Color.MidnightBlue
        Me.resetPassbtn.OnHovercolor = System.Drawing.Color.Blue
        Me.resetPassbtn.OnHoverTextColor = System.Drawing.Color.White
        Me.resetPassbtn.selected = False
        Me.resetPassbtn.Size = New System.Drawing.Size(288, 38)
        Me.resetPassbtn.TabIndex = 125
        Me.resetPassbtn.Text = "Reset Password"
        Me.resetPassbtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.resetPassbtn.Textcolor = System.Drawing.Color.White
        Me.resetPassbtn.TextFont = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(3, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(183, 142)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(244, 25)
        Me.Label2.TabIndex = 124
        Me.Label2.Text = "Enter your email here:"
        '
        'txtEmail
        '
        Me.txtEmail.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtEmail.BackColor = System.Drawing.Color.White
        Me.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtEmail.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.ForeColor = System.Drawing.Color.Black
        Me.txtEmail.HintForeColor = System.Drawing.Color.Empty
        Me.txtEmail.HintText = ""
        Me.txtEmail.isPassword = False
        Me.txtEmail.LineFocusedColor = System.Drawing.Color.Navy
        Me.txtEmail.LineIdleColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.txtEmail.LineMouseHoverColor = System.Drawing.Color.Navy
        Me.txtEmail.LineThickness = 3
        Me.txtEmail.Location = New System.Drawing.Point(84, 190)
        Me.txtEmail.Margin = New System.Windows.Forms.Padding(6, 4, 6, 4)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(454, 35)
        Me.txtEmail.TabIndex = 123
        Me.txtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Stencil", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Orange
        Me.Label1.Location = New System.Drawing.Point(74, 70)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(479, 57)
        Me.Label1.TabIndex = 122
        Me.Label1.Text = "Forget Password"
        '
        'ForgetPassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(622, 369)
        Me.Controls.Add(Me.pbxDelete)
        Me.Controls.Add(Me.lblPrint)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.txtType)
        Me.Controls.Add(Me.txtFullname)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.resetPassbtn)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ForgetPassword"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ForgetPassword"
        CType(Me.pbxDelete, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pbxDelete As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents lblPrint As Label
    Friend WithEvents txtPassword As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents txtID As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents txtType As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents txtFullname As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents txtUsername As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents resetPassbtn As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents Label2 As Label
    Friend WithEvents txtEmail As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label1 As Label
End Class
