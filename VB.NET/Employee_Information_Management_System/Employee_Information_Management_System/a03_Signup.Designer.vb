<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class a03_Signup
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(a03_Signup))
        GroupBox1 = New GroupBox()
        txtNo = New MaskedTextBox()
        txtPassword = New TextBox()
        Label5 = New Label()
        txtEmail = New TextBox()
        Label2 = New Label()
        txtcPassword = New TextBox()
        Label1 = New Label()
        CheckBox1 = New CheckBox()
        Label4 = New Label()
        DataGridview1 = New DataGridView()
        gbOperations = New GroupBox()
        btnClear = New Button()
        btnDelete = New Button()
        btnUpdate = New Button()
        btnInsert = New Button()
        GroupBox1.SuspendLayout()
        CType(DataGridview1, ComponentModel.ISupportInitialize).BeginInit()
        gbOperations.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = SystemColors.Control
        GroupBox1.Controls.Add(txtNo)
        GroupBox1.Controls.Add(txtPassword)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Controls.Add(txtEmail)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(txtcPassword)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(CheckBox1)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Font = New Font("Segoe UI", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        GroupBox1.Location = New Point(14, 21)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(528, 225)
        GroupBox1.TabIndex = 13
        GroupBox1.TabStop = False
        GroupBox1.Text = "Register"
        GroupBox1.UseCompatibleTextRendering = True
        ' 
        ' txtNo
        ' 
        txtNo.Location = New Point(177, 26)
        txtNo.Mask = "00000"
        txtNo.Name = "txtNo"
        txtNo.PromptChar = "#"c
        txtNo.Size = New Size(330, 27)
        txtNo.TabIndex = 29
        txtNo.ValidatingType = GetType(Integer)
        ' 
        ' txtPassword
        ' 
        txtPassword.Location = New Point(177, 107)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(330, 27)
        txtPassword.TabIndex = 8
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(21, 110)
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
        txtEmail.TabIndex = 7
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
        txtcPassword.Location = New Point(177, 171)
        txtcPassword.Name = "txtcPassword"
        txtcPassword.Size = New Size(330, 27)
        txtcPassword.TabIndex = 10
        ' 
        ' Label1
        ' 
        Label1.Location = New Point(8, 172)
        Label1.Name = "Label1"
        Label1.Size = New Size(149, 26)
        Label1.TabIndex = 10
        Label1.Text = "Confirm Password : "
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Location = New Point(362, 140)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(141, 24)
        CheckBox1.TabIndex = 9
        CheckBox1.Text = "Show Password"
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(21, 29)
        Label4.Name = "Label4"
        Label4.Size = New Size(115, 20)
        Label4.TabIndex = 4
        Label4.Text = "Employee's Id :"
        ' 
        ' DataGridview1
        ' 
        DataGridview1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridview1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridview1.Location = New Point(558, 21)
        DataGridview1.Margin = New Padding(2)
        DataGridview1.Name = "DataGridview1"
        DataGridview1.RowHeadersWidth = 51
        DataGridview1.RowTemplate.Height = 29
        DataGridview1.Size = New Size(567, 347)
        DataGridview1.TabIndex = 14
        ' 
        ' gbOperations
        ' 
        gbOperations.Controls.Add(btnClear)
        gbOperations.Controls.Add(btnDelete)
        gbOperations.Controls.Add(btnUpdate)
        gbOperations.Controls.Add(btnInsert)
        gbOperations.Location = New Point(14, 262)
        gbOperations.Margin = New Padding(2)
        gbOperations.Name = "gbOperations"
        gbOperations.Padding = New Padding(2)
        gbOperations.Size = New Size(528, 106)
        gbOperations.TabIndex = 18
        gbOperations.TabStop = False
        gbOperations.Text = "Operations"
        ' 
        ' btnClear
        ' 
        btnClear.Location = New Point(404, 41)
        btnClear.Margin = New Padding(2)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(120, 43)
        btnClear.TabIndex = 4
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' btnDelete
        ' 
        btnDelete.Location = New Point(280, 41)
        btnDelete.Margin = New Padding(2)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(120, 43)
        btnDelete.TabIndex = 3
        btnDelete.Text = "Delete"
        btnDelete.UseVisualStyleBackColor = True
        ' 
        ' btnUpdate
        ' 
        btnUpdate.Location = New Point(156, 41)
        btnUpdate.Margin = New Padding(2)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(120, 43)
        btnUpdate.TabIndex = 1
        btnUpdate.Text = "Update"
        btnUpdate.UseVisualStyleBackColor = True
        ' 
        ' btnInsert
        ' 
        btnInsert.Location = New Point(32, 41)
        btnInsert.Margin = New Padding(2)
        btnInsert.Name = "btnInsert"
        btnInsert.Size = New Size(120, 43)
        btnInsert.TabIndex = 0
        btnInsert.Text = "Insert"
        btnInsert.UseVisualStyleBackColor = True
        ' 
        ' Signup
        ' 
        AutoScaleDimensions = New SizeF(9F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1137, 389)
        Controls.Add(gbOperations)
        Controls.Add(DataGridview1)
        Controls.Add(GroupBox1)
        Font = New Font("Segoe UI", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        MinimizeBox = False
        Name = "Signup"
        StartPosition = FormStartPosition.CenterScreen
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(DataGridview1, ComponentModel.ISupportInitialize).EndInit()
        gbOperations.ResumeLayout(False)
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
    Friend WithEvents DataGridview1 As DataGridView
    Friend WithEvents gbOperations As GroupBox
    Friend WithEvents btnClear As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnInsert As Button
    Friend WithEvents txtNo As MaskedTextBox
End Class
