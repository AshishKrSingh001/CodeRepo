<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
        components = New ComponentModel.Container()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form1))
        SplitContainer1 = New SplitContainer()
        Label4 = New Label()
        TextBox1 = New TextBox()
        Button1 = New Button()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        Button2 = New Button()
        Label9 = New Label()
        TextBox4 = New TextBox()
        TextBox3 = New TextBox()
        TextBox2 = New TextBox()
        Label8 = New Label()
        Label7 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        NotifyIcon1 = New NotifyIcon(components)
        CType(SplitContainer1, ComponentModel.ISupportInitialize).BeginInit()
        SplitContainer1.Panel1.SuspendLayout()
        SplitContainer1.Panel2.SuspendLayout()
        SplitContainer1.SuspendLayout()
        SuspendLayout()
        ' 
        ' SplitContainer1
        ' 
        SplitContainer1.Dock = DockStyle.Fill
        SplitContainer1.Location = New Point(0, 0)
        SplitContainer1.Margin = New Padding(4)
        SplitContainer1.Name = "SplitContainer1"
        SplitContainer1.Orientation = Orientation.Horizontal
        ' 
        ' SplitContainer1.Panel1
        ' 
        SplitContainer1.Panel1.Controls.Add(Label4)
        SplitContainer1.Panel1.Controls.Add(TextBox1)
        SplitContainer1.Panel1.Controls.Add(Button1)
        SplitContainer1.Panel1.Controls.Add(Label3)
        SplitContainer1.Panel1.Controls.Add(Label2)
        SplitContainer1.Panel1.Controls.Add(Label1)
        ' 
        ' SplitContainer1.Panel2
        ' 
        SplitContainer1.Panel2.Controls.Add(Button2)
        SplitContainer1.Panel2.Controls.Add(Label9)
        SplitContainer1.Panel2.Controls.Add(TextBox4)
        SplitContainer1.Panel2.Controls.Add(TextBox3)
        SplitContainer1.Panel2.Controls.Add(TextBox2)
        SplitContainer1.Panel2.Controls.Add(Label8)
        SplitContainer1.Panel2.Controls.Add(Label7)
        SplitContainer1.Panel2.Controls.Add(Label6)
        SplitContainer1.Panel2.Controls.Add(Label5)
        SplitContainer1.Size = New Size(897, 653)
        SplitContainer1.SplitterDistance = 334
        SplitContainer1.SplitterWidth = 6
        SplitContainer1.TabIndex = 0
        ' 
        ' Label4
        ' 
        Label4.Location = New Point(250, 213)
        Label4.Name = "Label4"
        Label4.Size = New Size(344, 47)
        Label4.TabIndex = 5
        Label4.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(333, 65)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(454, 34)
        TextBox1.TabIndex = 4
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(648, 121)
        Button1.Name = "Button1"
        Button1.Size = New Size(140, 40)
        Button1.TabIndex = 3
        Button1.Text = "Reverse"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(98, 68)
        Label3.Name = "Label3"
        Label3.Size = New Size(229, 28)
        Label3.TabIndex = 2
        Label3.Text = "Enter a String to reverse :"
        ' 
        ' Label2
        ' 
        Label2.Dock = DockStyle.Top
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(0, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(897, 28)
        Label2.TabIndex = 1
        Label2.Text = "Conversion"
        Label2.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Label1
        ' 
        Label1.Dock = DockStyle.Top
        Label1.ImageAlign = ContentAlignment.TopCenter
        Label1.Location = New Point(0, 0)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(897, 0)
        Label1.TabIndex = 0
        Label1.Text = "Conversion"
        Label1.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(410, 207)
        Button2.Name = "Button2"
        Button2.Size = New Size(200, 40)
        Button2.TabIndex = 8
        Button2.Text = "Simple Interest"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Label9
        ' 
        Label9.Location = New Point(207, 250)
        Label9.Name = "Label9"
        Label9.Size = New Size(426, 53)
        Label9.TabIndex = 7
        Label9.TextAlign = ContentAlignment.TopCenter
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(339, 155)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(271, 34)
        TextBox4.TabIndex = 6
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(339, 99)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(271, 34)
        TextBox3.TabIndex = 5
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(339, 50)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(271, 34)
        TextBox2.TabIndex = 4
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(129, 158)
        Label8.Name = "Label8"
        Label8.Size = New Size(129, 28)
        Label8.TabIndex = 3
        Label8.Text = "No. of Years : "
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(129, 102)
        Label7.Name = "Label7"
        Label7.Size = New Size(153, 28)
        Label7.TabIndex = 2
        Label7.Text = "Rate of Interest :"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(129, 53)
        Label6.Name = "Label6"
        Label6.Size = New Size(172, 28)
        Label6.TabIndex = 1
        Label6.Text = "Principle Amount :"
        ' 
        ' Label5
        ' 
        Label5.Dock = DockStyle.Top
        Label5.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.Location = New Point(0, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(897, 25)
        Label5.TabIndex = 0
        Label5.Text = "Simple Interest"
        Label5.TextAlign = ContentAlignment.TopCenter
        ' 
        ' NotifyIcon1
        ' 
        NotifyIcon1.BalloonTipIcon = ToolTipIcon.Info
        NotifyIcon1.BalloonTipTitle = "Module"
        NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), Icon)
        NotifyIcon1.Text = "Module Example"
        NotifyIcon1.Visible = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(11F, 28F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(897, 653)
        Controls.Add(SplitContainer1)
        Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Margin = New Padding(4)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "ModuleEx"
        SplitContainer1.Panel1.ResumeLayout(False)
        SplitContainer1.Panel1.PerformLayout()
        SplitContainer1.Panel2.ResumeLayout(False)
        SplitContainer1.Panel2.PerformLayout()
        CType(SplitContainer1, ComponentModel.ISupportInitialize).EndInit()
        SplitContainer1.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents Button1 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents NotifyIcon1 As NotifyIcon
End Class
