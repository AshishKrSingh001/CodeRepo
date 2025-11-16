<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class User
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(User))
        MenuStrip1 = New MenuStrip()
        DataEntryToolStripMenuItem1 = New ToolStripMenuItem()
        EmployeeMenuStrip = New ToolStripMenuItem()
        PayrollToolStripMenuItem = New ToolStripMenuItem()
        AttendanceToolStripMenuItem = New ToolStripMenuItem()
        TimeInTimeOutToolStripMenuItem = New ToolStripMenuItem()
        AttendanceReportToolStripMenuItem = New ToolStripMenuItem()
        ChangePToolStripMenuItem = New ToolStripMenuItem()
        ExitToolStripMenuItem = New ToolStripMenuItem()
        ExitToolStripMenuItem1 = New ToolStripMenuItem()
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        MenuStrip1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {DataEntryToolStripMenuItem1, AttendanceToolStripMenuItem, ChangePToolStripMenuItem, ExitToolStripMenuItem, ExitToolStripMenuItem1})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Padding = New Padding(5, 1, 0, 1)
        MenuStrip1.Size = New Size(718, 26)
        MenuStrip1.TabIndex = 2
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' DataEntryToolStripMenuItem1
        ' 
        DataEntryToolStripMenuItem1.DropDownItems.AddRange(New ToolStripItem() {EmployeeMenuStrip, PayrollToolStripMenuItem})
        DataEntryToolStripMenuItem1.Font = New Font("Segoe UI Black", 9F, FontStyle.Bold Or FontStyle.Italic)
        DataEntryToolStripMenuItem1.Name = "DataEntryToolStripMenuItem1"
        DataEntryToolStripMenuItem1.Size = New Size(149, 24)
        DataEntryToolStripMenuItem1.Text = "Employee Details"
        ' 
        ' EmployeeMenuStrip
        ' 
        EmployeeMenuStrip.Name = "EmployeeMenuStrip"
        EmployeeMenuStrip.Size = New Size(269, 26)
        EmployeeMenuStrip.Text = " Employee's Information"
        ' 
        ' PayrollToolStripMenuItem
        ' 
        PayrollToolStripMenuItem.Name = "PayrollToolStripMenuItem"
        PayrollToolStripMenuItem.Size = New Size(269, 26)
        PayrollToolStripMenuItem.Text = "Payroll"
        ' 
        ' AttendanceToolStripMenuItem
        ' 
        AttendanceToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {TimeInTimeOutToolStripMenuItem, AttendanceReportToolStripMenuItem})
        AttendanceToolStripMenuItem.Font = New Font("Segoe UI Black", 9F, FontStyle.Bold Or FontStyle.Italic)
        AttendanceToolStripMenuItem.Name = "AttendanceToolStripMenuItem"
        AttendanceToolStripMenuItem.Size = New Size(105, 24)
        AttendanceToolStripMenuItem.Text = "Attendance"
        ' 
        ' TimeInTimeOutToolStripMenuItem
        ' 
        TimeInTimeOutToolStripMenuItem.Font = New Font("Segoe UI Black", 9F, FontStyle.Bold Or FontStyle.Italic)
        TimeInTimeOutToolStripMenuItem.Name = "TimeInTimeOutToolStripMenuItem"
        TimeInTimeOutToolStripMenuItem.Size = New Size(226, 26)
        TimeInTimeOutToolStripMenuItem.Text = "Time In Time Out"
        ' 
        ' AttendanceReportToolStripMenuItem
        ' 
        AttendanceReportToolStripMenuItem.Font = New Font("Segoe UI Black", 9F, FontStyle.Bold Or FontStyle.Italic)
        AttendanceReportToolStripMenuItem.Name = "AttendanceReportToolStripMenuItem"
        AttendanceReportToolStripMenuItem.Size = New Size(226, 26)
        AttendanceReportToolStripMenuItem.Text = "Attendance Report"
        ' 
        ' ChangePToolStripMenuItem
        ' 
        ChangePToolStripMenuItem.Font = New Font("Segoe UI Black", 9F, FontStyle.Bold Or FontStyle.Italic)
        ChangePToolStripMenuItem.Name = "ChangePToolStripMenuItem"
        ChangePToolStripMenuItem.Size = New Size(150, 24)
        ChangePToolStripMenuItem.Text = "Change Password"
        ' 
        ' ExitToolStripMenuItem
        ' 
        ExitToolStripMenuItem.Font = New Font("Segoe UI Black", 9F, FontStyle.Bold Or FontStyle.Italic)
        ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        ExitToolStripMenuItem.Size = New Size(115, 24)
        ExitToolStripMenuItem.Text = "Admin Login"
        ' 
        ' ExitToolStripMenuItem1
        ' 
        ExitToolStripMenuItem1.Font = New Font("Segoe UI Black", 9F, FontStyle.Bold Or FontStyle.Italic)
        ExitToolStripMenuItem1.Name = "ExitToolStripMenuItem1"
        ExitToolStripMenuItem1.Size = New Size(51, 24)
        ExitToolStripMenuItem1.Text = "Exit"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        PictureBox1.BackColor = SystemColors.ActiveCaptionText
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.ErrorImage = Nothing
        PictureBox1.Location = New Point(0, 26)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(718, 418)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 6
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        PictureBox2.BackColor = SystemColors.ActiveCaptionText
        PictureBox2.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox2.ErrorImage = CType(resources.GetObject("PictureBox2.ErrorImage"), Image)
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(0, 26)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(718, 418)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 8
        PictureBox2.TabStop = False
        ' 
        ' User
        ' 
        AutoScaleDimensions = New SizeF(9F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSize = True
        BackColor = SystemColors.ButtonShadow
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(718, 444)
        Controls.Add(PictureBox2)
        Controls.Add(PictureBox1)
        Controls.Add(MenuStrip1)
        Font = New Font("Segoe UI", 9F, FontStyle.Bold Or FontStyle.Italic)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        IsMdiContainer = True
        MainMenuStrip = MenuStrip1
        Name = "User"
        StartPosition = FormStartPosition.CenterScreen
        Text = " Department & Employee Information Management"
        WindowState = FormWindowState.Maximized
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents DataEntryToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents EmployeeMenuStrip As ToolStripMenuItem
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ChangePToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PayrollToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AttendanceToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TimeInTimeOutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AttendanceReportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents PictureBox2 As PictureBox

End Class

