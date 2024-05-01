<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserSIgnIn
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label3 = New Label()
        Label4 = New Label()
        txtUname = New TextBox()
        txtPasswd = New TextBox()
        CheckBox1 = New CheckBox()
        Button1 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        GroupBox1 = New GroupBox()
        PictureBox1 = New PictureBox()
        Panel1 = New Panel()
        Label5 = New Label()
        GroupBox1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(44, 41)
        Label3.Name = "Label3"
        Label3.Size = New Size(89, 20)
        Label3.TabIndex = 3
        Label3.Text = "Username :"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(44, 88)
        Label4.Name = "Label4"
        Label4.Size = New Size(89, 20)
        Label4.TabIndex = 4
        Label4.Text = "Password : "
        ' 
        ' txtUname
        ' 
        txtUname.Location = New Point(152, 38)
        txtUname.Name = "txtUname"
        txtUname.Size = New Size(348, 27)
        txtUname.TabIndex = 5
        ' 
        ' txtPasswd
        ' 
        txtPasswd.Location = New Point(152, 85)
        txtPasswd.Name = "txtPasswd"
        txtPasswd.Size = New Size(348, 27)
        txtPasswd.TabIndex = 6
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Location = New Point(152, 118)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(141, 24)
        CheckBox1.TabIndex = 7
        CheckBox1.Text = "Show Password"
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.BackColor = SystemColors.HotTrack
        Button1.Cursor = Cursors.Hand
        Button1.FlatStyle = FlatStyle.Flat
        Button1.ForeColor = SystemColors.Control
        Button1.Location = New Point(392, 144)
        Button1.Name = "Button1"
        Button1.Size = New Size(120, 40)
        Button1.TabIndex = 9
        Button1.Text = "Submit"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = SystemColors.HotTrack
        Button3.Cursor = Cursors.Hand
        Button3.FlatStyle = FlatStyle.Flat
        Button3.ForeColor = SystemColors.Control
        Button3.Location = New Point(140, 144)
        Button3.Name = "Button3"
        Button3.Size = New Size(120, 40)
        Button3.TabIndex = 11
        Button3.Text = "Exit"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button4
        ' 
        Button4.BackColor = SystemColors.HotTrack
        Button4.Cursor = Cursors.Hand
        Button4.FlatStyle = FlatStyle.Flat
        Button4.ForeColor = SystemColors.Control
        Button4.Location = New Point(266, 144)
        Button4.Name = "Button4"
        Button4.Size = New Size(120, 40)
        Button4.TabIndex = 12
        Button4.Text = "Clear"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = SystemColors.ButtonShadow
        GroupBox1.Controls.Add(Button4)
        GroupBox1.Controls.Add(Button3)
        GroupBox1.Controls.Add(Button1)
        GroupBox1.Controls.Add(CheckBox1)
        GroupBox1.Controls.Add(txtPasswd)
        GroupBox1.Controls.Add(txtUname)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Font = New Font("Segoe UI", 9F, FontStyle.Bold Or FontStyle.Italic)
        GroupBox1.Location = New Point(1, 177)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(536, 219)
        GroupBox1.TabIndex = 12
        GroupBox1.TabStop = False
        GroupBox1.Text = "Login Form"
        GroupBox1.UseCompatibleTextRendering = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.EmpImage1
        PictureBox1.Location = New Point(204, 66)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(126, 117)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 33
        PictureBox1.TabStop = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(128))
        Panel1.Controls.Add(Label5)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(537, 51)
        Panel1.TabIndex = 34
        ' 
        ' Label5
        ' 
        Label5.Dock = DockStyle.Fill
        Label5.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold Or FontStyle.Italic Or FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(0, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(537, 51)
        Label5.TabIndex = 41
        Label5.Text = "EMPLOYEE'S LOGIN"
        Label5.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' UserSIgnIn
        ' 
        AutoScaleDimensions = New SizeF(9F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ButtonShadow
        ClientSize = New Size(537, 398)
        ControlBox = False
        Controls.Add(Panel1)
        Controls.Add(PictureBox1)
        Controls.Add(GroupBox1)
        Font = New Font("Segoe UI", 9F, FontStyle.Bold Or FontStyle.Italic)
        FormBorderStyle = FormBorderStyle.Fixed3D
        MaximizeBox = False
        MinimizeBox = False
        Name = "UserSIgnIn"
        StartPosition = FormStartPosition.CenterScreen
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtUname As TextBox
    Friend WithEvents txtPasswd As TextBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label5 As Label
End Class
