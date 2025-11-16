<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class User02_ResetUserPassword
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(User02_ResetUserPassword))
        GroupBox1 = New GroupBox()
        btnClear = New Button()
        txtNo = New MaskedTextBox()
        txtPassword = New TextBox()
        btnInsert = New Button()
        Label5 = New Label()
        txtEmail = New TextBox()
        Label2 = New Label()
        txtcPassword = New TextBox()
        Label1 = New Label()
        CheckBox1 = New CheckBox()
        Label4 = New Label()
        PictureBox1 = New PictureBox()
        Label3 = New Label()
        txtPass = New TextBox()
        Label6 = New Label()
        GroupBox1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = SystemColors.ButtonShadow
        GroupBox1.Controls.Add(txtPass)
        GroupBox1.Controls.Add(Label6)
        GroupBox1.Controls.Add(btnClear)
        GroupBox1.Controls.Add(txtNo)
        GroupBox1.Controls.Add(txtPassword)
        GroupBox1.Controls.Add(btnInsert)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Controls.Add(txtEmail)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(txtcPassword)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(CheckBox1)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Font = New Font("Segoe UI", 9F, FontStyle.Bold Or FontStyle.Italic)
        GroupBox1.Location = New Point(12, 191)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(528, 312)
        GroupBox1.TabIndex = 13
        GroupBox1.TabStop = False
        GroupBox1.Text = "Register"
        GroupBox1.UseCompatibleTextRendering = True
        ' 
        ' btnClear
        ' 
        btnClear.BackColor = SystemColors.HotTrack
        btnClear.Cursor = Cursors.Hand
        btnClear.FlatStyle = FlatStyle.Flat
        btnClear.ForeColor = SystemColors.Control
        btnClear.Location = New Point(240, 256)
        btnClear.Margin = New Padding(2)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(120, 43)
        btnClear.TabIndex = 6
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = False
        ' 
        ' txtNo
        ' 
        txtNo.Location = New Point(177, 26)
        txtNo.Mask = "00000"
        txtNo.Name = "txtNo"
        txtNo.PromptChar = "#"c
        txtNo.Size = New Size(330, 27)
        txtNo.TabIndex = 0
        txtNo.ValidatingType = GetType(Integer)
        ' 
        ' txtPassword
        ' 
        txtPassword.Location = New Point(177, 145)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(330, 27)
        txtPassword.TabIndex = 2
        ' 
        ' btnInsert
        ' 
        btnInsert.BackColor = SystemColors.HotTrack
        btnInsert.Cursor = Cursors.Hand
        btnInsert.FlatStyle = FlatStyle.Flat
        btnInsert.ForeColor = SystemColors.Control
        btnInsert.Location = New Point(387, 256)
        btnInsert.Margin = New Padding(2)
        btnInsert.Name = "btnInsert"
        btnInsert.Size = New Size(120, 43)
        btnInsert.TabIndex = 5
        btnInsert.Text = "Insert"
        btnInsert.UseVisualStyleBackColor = False
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(21, 148)
        Label5.Name = "Label5"
        Label5.Size = New Size(85, 20)
        Label5.TabIndex = 14
        Label5.Text = "Password :"
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(177, 66)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(330, 27)
        txtEmail.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(21, 69)
        Label2.Name = "Label2"
        Label2.Size = New Size(58, 20)
        Label2.TabIndex = 12
        Label2.Text = "Email :"
        ' 
        ' txtcPassword
        ' 
        txtcPassword.Location = New Point(177, 209)
        txtcPassword.Name = "txtcPassword"
        txtcPassword.Size = New Size(330, 27)
        txtcPassword.TabIndex = 4
        ' 
        ' Label1
        ' 
        Label1.Location = New Point(8, 210)
        Label1.Name = "Label1"
        Label1.Size = New Size(149, 26)
        Label1.TabIndex = 10
        Label1.Text = "Confirm Password : "
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Location = New Point(362, 178)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(141, 24)
        CheckBox1.TabIndex = 3
        CheckBox1.Text = "Show Password"
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(21, 29)
        Label4.Name = "Label4"
        Label4.Size = New Size(115, 20)
        Label4.TabIndex = 11
        Label4.Text = "Employee's Id :"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.EmpImage1
        PictureBox1.Location = New Point(215, 68)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(126, 117)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 32
        PictureBox1.TabStop = False
        ' 
        ' Label3
        ' 
        Label3.BackColor = Color.IndianRed
        Label3.Dock = DockStyle.Top
        Label3.Font = New Font("Segoe UI", 15F, FontStyle.Bold Or FontStyle.Italic Or FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.FromArgb(CByte(0), CByte(64), CByte(0))
        Label3.Location = New Point(0, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(548, 63)
        Label3.TabIndex = 45
        Label3.Text = "Reset Password"
        Label3.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' txtPass
        ' 
        txtPass.Location = New Point(177, 106)
        txtPass.Name = "txtPass"
        txtPass.Size = New Size(330, 27)
        txtPass.TabIndex = 15
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(21, 109)
        Label6.Name = "Label6"
        Label6.Size = New Size(114, 20)
        Label6.TabIndex = 16
        Label6.Text = "Old Password :"
        ' 
        ' ResetUserPassword
        ' 
        AutoScaleDimensions = New SizeF(9F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ButtonShadow
        ClientSize = New Size(548, 515)
        Controls.Add(Label3)
        Controls.Add(PictureBox1)
        Controls.Add(GroupBox1)
        Font = New Font("Segoe UI", 9F, FontStyle.Bold Or FontStyle.Italic)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        MinimizeBox = False
        Name = "ResetUserPassword"
        StartPosition = FormStartPosition.CenterScreen
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtcPassword As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btnInsert As Button
    Friend WithEvents txtNo As MaskedTextBox
    Friend WithEvents btnClear As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtPass As TextBox
    Friend WithEvents Label6 As Label
End Class