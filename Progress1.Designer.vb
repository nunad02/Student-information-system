<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Progress1
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Progress1))
        Me.ProgBar = New Bunifu.Framework.UI.BunifuCircleProgressbar()
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'ProgBar
        '
        Me.ProgBar.animated = False
        Me.ProgBar.animationIterval = 5
        Me.ProgBar.animationSpeed = 300
        Me.ProgBar.BackColor = System.Drawing.Color.White
        Me.ProgBar.BackgroundImage = CType(resources.GetObject("ProgBar.BackgroundImage"), System.Drawing.Image)
        Me.ProgBar.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProgBar.ForeColor = System.Drawing.Color.Black
        Me.ProgBar.LabelVisible = True
        Me.ProgBar.LineProgressThickness = 20
        Me.ProgBar.LineThickness = 18
        Me.ProgBar.Location = New System.Drawing.Point(94, 65)
        Me.ProgBar.Margin = New System.Windows.Forms.Padding(13, 10, 13, 10)
        Me.ProgBar.MaxValue = 100
        Me.ProgBar.Name = "ProgBar"
        Me.ProgBar.ProgressBackColor = System.Drawing.Color.White
        Me.ProgBar.ProgressColor = System.Drawing.Color.MidnightBlue
        Me.ProgBar.Size = New System.Drawing.Size(257, 257)
        Me.ProgBar.TabIndex = 4
        Me.ProgBar.Value = 0
        '
        'lbl1
        '
        Me.lbl1.AutoSize = True
        Me.lbl1.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl1.ForeColor = System.Drawing.Color.Black
        Me.lbl1.Location = New System.Drawing.Point(29, 332)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(95, 18)
        Me.lbl1.TabIndex = 3
        Me.lbl1.Text = "Loading..."
        '
        'Timer1
        '
        Me.Timer1.Interval = 40
        '
        'Timer2
        '
        Me.Timer2.Interval = 40
        '
        'Progress1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(450, 383)
        Me.Controls.Add(Me.ProgBar)
        Me.Controls.Add(Me.lbl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Progress1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Progress1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ProgBar As Bunifu.Framework.UI.BunifuCircleProgressbar
    Friend WithEvents lbl1 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
End Class
