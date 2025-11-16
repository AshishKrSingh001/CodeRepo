<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formStudentDetails
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(formStudentDetails))
        Label1 = New Label()
        rollno = New Label()
        nudrollno = New NumericUpDown()
        Label2 = New Label()
        nm = New TextBox()
        Label3 = New Label()
        dob = New DateTimePicker()
        male = New RadioButton()
        female = New RadioButton()
        GroupBox1 = New GroupBox()
        Panel1 = New Panel()
        tother = New TextBox()
        cother = New CheckBox()
        cwc = New CheckBox()
        cwm = New CheckBox()
        cdance = New CheckBox()
        cread = New CheckBox()
        Label4 = New Label()
        Panel2 = New Panel()
        tcity = New TextBox()
        mstmob = New MaskedTextBox()
        Label9 = New Label()
        cmbstate = New ComboBox()
        mstpin = New MaskedTextBox()
        Label8 = New Label()
        Label7 = New Label()
        Label6 = New Label()
        address = New TextBox()
        Label5 = New Label()
        ptbphoto = New PictureBox()
        llblselect = New LinkLabel()
        OpenFileDialog1 = New OpenFileDialog()
        submitb = New Button()
        exitb = New Button()
        HelpProvider1 = New HelpProvider()
        CType(nudrollno, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        CType(ptbphoto, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.BackColor = SystemColors.AppWorkspace
        Label1.Dock = DockStyle.Top
        Label1.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Label1.Location = New Point(0, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(895, 54)
        Label1.TabIndex = 0
        Label1.Text = "Personal Information"
        Label1.TextAlign = ContentAlignment.TopCenter
        ' 
        ' rollno
        ' 
        rollno.AutoSize = True
        rollno.Location = New Point(24, 71)
        rollno.Name = "rollno"
        rollno.Size = New Size(86, 28)
        rollno.TabIndex = 1
        rollno.Text = "Roll No :"
        ' 
        ' nudrollno
        ' 
        nudrollno.Location = New Point(146, 65)
        nudrollno.Margin = New Padding(4)
        nudrollno.Maximum = New Decimal(New Integer() {60, 0, 0, 0})
        nudrollno.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        nudrollno.Name = "nudrollno"
        nudrollno.Size = New Size(265, 34)
        nudrollno.TabIndex = 2
        nudrollno.Value = New Decimal(New Integer() {1, 0, 0, 0})
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(24, 116)
        Label2.Name = "Label2"
        Label2.Size = New Size(73, 28)
        Label2.TabIndex = 3
        Label2.Text = "Name :"
        ' 
        ' nm
        ' 
        nm.Location = New Point(146, 113)
        nm.Name = "nm"
        nm.Size = New Size(265, 34)
        nm.TabIndex = 4
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(24, 162)
        Label3.Name = "Label3"
        Label3.Size = New Size(108, 28)
        Label3.TabIndex = 5
        Label3.Text = "Birth Date :"
        ' 
        ' dob
        ' 
        dob.Location = New Point(146, 162)
        dob.MaxDate = New Date(2005, 1, 1, 0, 0, 0, 0)
        dob.MinDate = New Date(2000, 1, 1, 0, 0, 0, 0)
        dob.Name = "dob"
        dob.Size = New Size(265, 34)
        dob.TabIndex = 6
        dob.Value = New Date(2005, 1, 1, 0, 0, 0, 0)
        ' 
        ' male
        ' 
        male.AutoSize = True
        male.Location = New Point(81, 28)
        male.Name = "male"
        male.Size = New Size(76, 32)
        male.TabIndex = 7
        male.TabStop = True
        male.Text = "Male"
        male.UseVisualStyleBackColor = True
        ' 
        ' female
        ' 
        female.AutoSize = True
        female.Location = New Point(181, 28)
        female.Name = "female"
        female.Size = New Size(95, 32)
        female.TabIndex = 8
        female.TabStop = True
        female.Text = "Female"
        female.UseVisualStyleBackColor = True
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(male)
        GroupBox1.Controls.Add(female)
        GroupBox1.Location = New Point(490, 226)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(363, 75)
        GroupBox1.TabIndex = 9
        GroupBox1.TabStop = False
        GroupBox1.Text = "Gender"
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(tother)
        Panel1.Controls.Add(cother)
        Panel1.Controls.Add(cwc)
        Panel1.Controls.Add(cwm)
        Panel1.Controls.Add(cdance)
        Panel1.Controls.Add(cread)
        Panel1.Controls.Add(Label4)
        Panel1.Location = New Point(490, 316)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(363, 252)
        Panel1.TabIndex = 10
        ' 
        ' tother
        ' 
        tother.Location = New Point(121, 203)
        tother.Name = "tother"
        tother.PlaceholderText = " In case of Other"
        tother.Size = New Size(220, 34)
        tother.TabIndex = 6
        ' 
        ' cother
        ' 
        cother.AutoSize = True
        cother.Location = New Point(122, 167)
        cother.Name = "cother"
        cother.Size = New Size(92, 32)
        cother.TabIndex = 5
        cother.Text = "Others"
        cother.UseVisualStyleBackColor = True
        ' 
        ' cwc
        ' 
        cwc.AutoSize = True
        cwc.Location = New Point(122, 134)
        cwc.Name = "cwc"
        cwc.Size = New Size(182, 32)
        cwc.TabIndex = 4
        cwc.Text = "Watching Cricket"
        cwc.UseVisualStyleBackColor = True
        ' 
        ' cwm
        ' 
        cwm.AutoSize = True
        cwm.Location = New Point(122, 96)
        cwm.Name = "cwm"
        cwm.Size = New Size(185, 32)
        cwm.TabIndex = 3
        cwm.Text = "Watching Movies"
        cwm.UseVisualStyleBackColor = True
        ' 
        ' cdance
        ' 
        cdance.AutoSize = True
        cdance.Location = New Point(122, 57)
        cdance.Name = "cdance"
        cdance.Size = New Size(106, 32)
        cdance.TabIndex = 2
        cdance.Text = "Dancing"
        cdance.UseVisualStyleBackColor = True
        ' 
        ' cread
        ' 
        cread.AutoSize = True
        cread.Location = New Point(122, 17)
        cread.Name = "cread"
        cread.Size = New Size(105, 32)
        cread.TabIndex = 1
        cread.Text = "Reading"
        cread.UseVisualStyleBackColor = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(14, 16)
        Label4.Name = "Label4"
        Label4.Size = New Size(94, 28)
        Label4.TabIndex = 0
        Label4.Text = "Hobbies :"
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(tcity)
        Panel2.Controls.Add(mstmob)
        Panel2.Controls.Add(Label9)
        Panel2.Controls.Add(cmbstate)
        Panel2.Controls.Add(mstpin)
        Panel2.Controls.Add(Label8)
        Panel2.Controls.Add(Label7)
        Panel2.Controls.Add(Label6)
        Panel2.Controls.Add(address)
        Panel2.Controls.Add(Label5)
        Panel2.Location = New Point(24, 202)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(408, 407)
        Panel2.TabIndex = 11
        ' 
        ' tcity
        ' 
        tcity.Location = New Point(106, 194)
        tcity.Name = "tcity"
        tcity.Size = New Size(281, 34)
        tcity.TabIndex = 11
        ' 
        ' mstmob
        ' 
        mstmob.Location = New Point(106, 355)
        mstmob.Mask = "##########"
        mstmob.Name = "mstmob"
        mstmob.PromptChar = "#"c
        mstmob.Size = New Size(281, 34)
        mstmob.TabIndex = 10
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(15, 358)
        Label9.Name = "Label9"
        Label9.Size = New Size(95, 28)
        Label9.TabIndex = 9
        Label9.Text = "Mob No :"
        ' 
        ' cmbstate
        ' 
        cmbstate.FormattingEnabled = True
        cmbstate.Items.AddRange(New Object() {"Andaman and Nicobar Islands", "Chandigarh", "Dadra & Nagar Haveli and Daman & Diu", "Delhi", "Jammu and Kashmir", "Jammu (Winter)", "Lakshadweep", "Puducherry", "Ladakh", "Andhra Pradesh", "Arunachal Pradesh", "Assam", "Bihar", "Chhattisgarh", "Goa", "Gujarat", "Haryana", "Himachal Pradesh", "Jharkhand", "Karnataka", "Kerala", "Madhya Pradesh", "Maharashtra", "Manipur", "Meghalaya", "Mizoram", "Nagaland", "Odisha", "Punjab", "Rajasthan", "Sikkim", "Tamil Nadu", "Telangana", "Tripura", "Uttar Pradesh", "Uttarakhand", "West Bengal"})
        cmbstate.Location = New Point(106, 243)
        cmbstate.Name = "cmbstate"
        cmbstate.Size = New Size(281, 36)
        cmbstate.TabIndex = 8
        ' 
        ' mstpin
        ' 
        mstpin.Location = New Point(106, 301)
        mstpin.Mask = "000000"
        mstpin.Name = "mstpin"
        mstpin.PromptChar = "#"c
        mstpin.Size = New Size(281, 34)
        mstpin.TabIndex = 7
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(15, 300)
        Label8.Name = "Label8"
        Label8.Size = New Size(94, 28)
        Label8.TabIndex = 6
        Label8.Text = "PinCode :"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(15, 246)
        Label7.Name = "Label7"
        Label7.Size = New Size(65, 28)
        Label7.TabIndex = 4
        Label7.Text = "State :"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(15, 197)
        Label6.Name = "Label6"
        Label6.Size = New Size(55, 28)
        Label6.TabIndex = 2
        Label6.Text = "City :"
        ' 
        ' address
        ' 
        address.Location = New Point(106, 15)
        address.Multiline = True
        address.Name = "address"
        address.ScrollBars = ScrollBars.Vertical
        address.Size = New Size(281, 162)
        address.TabIndex = 1
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(12, 18)
        Label5.Name = "Label5"
        Label5.Size = New Size(91, 28)
        Label5.TabIndex = 0
        Label5.Text = "Address :"
        ' 
        ' ptbphoto
        ' 
        ptbphoto.Location = New Point(728, 67)
        ptbphoto.Name = "ptbphoto"
        ptbphoto.Size = New Size(125, 125)
        ptbphoto.SizeMode = PictureBoxSizeMode.StretchImage
        ptbphoto.TabIndex = 12
        ptbphoto.TabStop = False
        ' 
        ' llblselect
        ' 
        llblselect.AutoSize = True
        llblselect.Location = New Point(731, 195)
        llblselect.Name = "llblselect"
        llblselect.Size = New Size(122, 28)
        llblselect.TabIndex = 13
        llblselect.TabStop = True
        llblselect.Text = "Select Photo"
        llblselect.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.FileName = "OpenFileDialog1"
        ' 
        ' submitb
        ' 
        submitb.BackColor = SystemColors.ActiveCaptionText
        submitb.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        submitb.ForeColor = SystemColors.ButtonHighlight
        submitb.Location = New Point(533, 572)
        submitb.Name = "submitb"
        submitb.Size = New Size(140, 50)
        submitb.TabIndex = 14
        submitb.Text = "&Submit"
        submitb.UseVisualStyleBackColor = False
        ' 
        ' exitb
        ' 
        exitb.BackColor = SystemColors.ActiveCaptionText
        exitb.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        exitb.ForeColor = SystemColors.Control
        exitb.Location = New Point(721, 572)
        exitb.Name = "exitb"
        exitb.Size = New Size(140, 50)
        exitb.TabIndex = 15
        exitb.Text = "&Close"
        exitb.UseVisualStyleBackColor = False
        ' 
        ' formStudentDetails
        ' 
        AutoScaleDimensions = New SizeF(11F, 28F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(895, 628)
        Controls.Add(exitb)
        Controls.Add(submitb)
        Controls.Add(llblselect)
        Controls.Add(ptbphoto)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Controls.Add(GroupBox1)
        Controls.Add(dob)
        Controls.Add(Label3)
        Controls.Add(nm)
        Controls.Add(Label2)
        Controls.Add(nudrollno)
        Controls.Add(rollno)
        Controls.Add(Label1)
        Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Margin = New Padding(4)
        MaximizeBox = False
        MinimizeBox = False
        Name = "formStudentDetails"
        HelpProvider1.SetShowHelp(Me, True)
        StartPosition = FormStartPosition.CenterScreen
        Text = "Student Details"
        CType(nudrollno, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(ptbphoto, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents rollno As Label
    Friend WithEvents nudrollno As NumericUpDown
    Friend WithEvents Label2 As Label
    Friend WithEvents nm As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents dob As DateTimePicker
    Friend WithEvents male As RadioButton
    Friend WithEvents female As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents cwc As CheckBox
    Friend WithEvents cwm As CheckBox
    Friend WithEvents cdance As CheckBox
    Friend WithEvents cread As CheckBox
    Friend WithEvents cother As CheckBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents address As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents mstpin As MaskedTextBox
    Friend WithEvents ptbphoto As PictureBox
    Friend WithEvents llblselect As LinkLabel
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents submitb As Button
    Friend WithEvents exitb As Button
    Friend WithEvents HelpProvider1 As HelpProvider
    Friend WithEvents cmbstate As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents mstmob As MaskedTextBox
    Friend WithEvents tother As TextBox
    Friend WithEvents tcity As TextBox
End Class
