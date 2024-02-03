<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formMDI
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
        components = New ComponentModel.Container()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(formMDI))
        MenuStrip1 = New MenuStrip()
        DataEntryToolStripMenuItem = New ToolStripMenuItem()
        StudentDetailsToolStripMenuItem = New ToolStripMenuItem()
        SubjectDetailsToolStripMenuItem = New ToolStripMenuItem()
        MarksDetailsToolStripMenuItem = New ToolStripMenuItem()
        ReportsToolStripMenuItem = New ToolStripMenuItem()
        StatusStrip1 = New StatusStrip()
        ToolStripStatusLabel1 = New ToolStripStatusLabel()
        ToolStripStatusLabel2 = New ToolStripStatusLabel()
        ToolStripStatusLabel3 = New ToolStripStatusLabel()
        ToolStripStatusLabel4 = New ToolStripStatusLabel()
        Timer1 = New Timer(components)
        MenuStrip1.SuspendLayout()
        StatusStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {DataEntryToolStripMenuItem, ReportsToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Padding = New Padding(8, 3, 0, 3)
        MenuStrip1.Size = New Size(982, 30)
        MenuStrip1.TabIndex = 1
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' DataEntryToolStripMenuItem
        ' 
        DataEntryToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {StudentDetailsToolStripMenuItem, SubjectDetailsToolStripMenuItem, MarksDetailsToolStripMenuItem})
        DataEntryToolStripMenuItem.Name = "DataEntryToolStripMenuItem"
        DataEntryToolStripMenuItem.Size = New Size(92, 24)
        DataEntryToolStripMenuItem.Text = "Data Entry"
        ' 
        ' StudentDetailsToolStripMenuItem
        ' 
        StudentDetailsToolStripMenuItem.Name = "StudentDetailsToolStripMenuItem"
        StudentDetailsToolStripMenuItem.Size = New Size(193, 26)
        StudentDetailsToolStripMenuItem.Text = "Student Details"
        ' 
        ' SubjectDetailsToolStripMenuItem
        ' 
        SubjectDetailsToolStripMenuItem.Name = "SubjectDetailsToolStripMenuItem"
        SubjectDetailsToolStripMenuItem.Size = New Size(193, 26)
        SubjectDetailsToolStripMenuItem.Text = "Subject Details"
        ' 
        ' MarksDetailsToolStripMenuItem
        ' 
        MarksDetailsToolStripMenuItem.Name = "MarksDetailsToolStripMenuItem"
        MarksDetailsToolStripMenuItem.Size = New Size(193, 26)
        MarksDetailsToolStripMenuItem.Text = "Marks Details"
        ' 
        ' ReportsToolStripMenuItem
        ' 
        ReportsToolStripMenuItem.Name = "ReportsToolStripMenuItem"
        ReportsToolStripMenuItem.Size = New Size(74, 24)
        ReportsToolStripMenuItem.Text = "Reports"
        ' 
        ' StatusStrip1
        ' 
        StatusStrip1.ImageScalingSize = New Size(20, 20)
        StatusStrip1.Items.AddRange(New ToolStripItem() {ToolStripStatusLabel1, ToolStripStatusLabel2, ToolStripStatusLabel3, ToolStripStatusLabel4})
        StatusStrip1.Location = New Point(0, 627)
        StatusStrip1.Name = "StatusStrip1"
        StatusStrip1.Size = New Size(982, 26)
        StatusStrip1.TabIndex = 3
        StatusStrip1.Text = "StatusStrip1"
        ' 
        ' ToolStripStatusLabel1
        ' 
        ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        ToolStripStatusLabel1.Size = New Size(0, 20)
        ' 
        ' ToolStripStatusLabel2
        ' 
        ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        ToolStripStatusLabel2.Size = New Size(53, 20)
        ToolStripStatusLabel2.Text = "Admin"
        ' 
        ' ToolStripStatusLabel3
        ' 
        ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        ToolStripStatusLabel3.Size = New Size(41, 20)
        ToolStripStatusLabel3.Text = "Date"
        ' 
        ' ToolStripStatusLabel4
        ' 
        ToolStripStatusLabel4.Name = "ToolStripStatusLabel4"
        ToolStripStatusLabel4.Size = New Size(42, 20)
        ToolStripStatusLabel4.Text = "Time"
        ' 
        ' Timer1
        ' 
        Timer1.Interval = 1000
        ' 
        ' formMDI
        ' 
        AutoScaleDimensions = New SizeF(11F, 28F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(982, 653)
        Controls.Add(StatusStrip1)
        Controls.Add(MenuStrip1)
        Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        IsMdiContainer = True
        MainMenuStrip = MenuStrip1
        Margin = New Padding(4)
        Name = "formMDI"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Student Information Management System"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        StatusStrip1.ResumeLayout(False)
        StatusStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents DataEntryToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StudentDetailsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SubjectDetailsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MarksDetailsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReportsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel3 As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel4 As ToolStripStatusLabel
    Friend WithEvents Timer1 As Timer
End Class
