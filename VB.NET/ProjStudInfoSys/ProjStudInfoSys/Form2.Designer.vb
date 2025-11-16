<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class marksDetails
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(marksDetails))
        sub1 = New Label()
        tsub1 = New TextBox()
        ProgressBar1 = New ProgressBar()
        ErrorProvider1 = New ErrorProvider(components)
        Label1 = New Label()
        tsub2 = New TextBox()
        ProgressBar2 = New ProgressBar()
        Label2 = New Label()
        Label3 = New Label()
        tsub3 = New TextBox()
        tsub4 = New TextBox()
        Label4 = New Label()
        tsub5 = New TextBox()
        ProgressBar3 = New ProgressBar()
        ProgressBar4 = New ProgressBar()
        ProgressBar5 = New ProgressBar()
        Button1 = New Button()
        resultlable = New Label()
        lresult = New Label()
        Label5 = New Label()
        TrackBar1 = New TrackBar()
        lrate = New Label()
        Label7 = New Label()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        CType(TrackBar1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' sub1
        ' 
        sub1.AutoSize = True
        sub1.Location = New Point(60, 83)
        sub1.Name = "sub1"
        sub1.Size = New Size(102, 28)
        sub1.TabIndex = 0
        sub1.Text = "Subject 1: "
        ' 
        ' tsub1
        ' 
        tsub1.Location = New Point(168, 80)
        tsub1.Name = "tsub1"
        tsub1.Size = New Size(221, 34)
        tsub1.TabIndex = 1
        ' 
        ' ProgressBar1
        ' 
        ProgressBar1.Location = New Point(438, 82)
        ProgressBar1.Name = "ProgressBar1"
        ProgressBar1.Size = New Size(399, 29)
        ProgressBar1.Style = ProgressBarStyle.Continuous
        ProgressBar1.TabIndex = 6
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(60, 127)
        Label1.Name = "Label1"
        Label1.Size = New Size(97, 28)
        Label1.TabIndex = 0
        Label1.Text = "Subject 2:"
        ' 
        ' tsub2
        ' 
        tsub2.Location = New Point(168, 121)
        tsub2.Name = "tsub2"
        tsub2.Size = New Size(221, 34)
        tsub2.TabIndex = 2
        ' 
        ' ProgressBar2
        ' 
        ProgressBar2.Location = New Point(438, 124)
        ProgressBar2.Name = "ProgressBar2"
        ProgressBar2.Size = New Size(399, 29)
        ProgressBar2.Style = ProgressBarStyle.Continuous
        ProgressBar2.TabIndex = 7
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(60, 172)
        Label2.Name = "Label2"
        Label2.Size = New Size(102, 28)
        Label2.TabIndex = 0
        Label2.Text = "Subject 3: "
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(60, 217)
        Label3.Name = "Label3"
        Label3.Size = New Size(102, 28)
        Label3.TabIndex = 0
        Label3.Text = "Subject 4: "
        ' 
        ' tsub3
        ' 
        tsub3.Location = New Point(168, 166)
        tsub3.Name = "tsub3"
        tsub3.Size = New Size(221, 34)
        tsub3.TabIndex = 3
        ' 
        ' tsub4
        ' 
        tsub4.Location = New Point(168, 214)
        tsub4.Name = "tsub4"
        tsub4.Size = New Size(221, 34)
        tsub4.TabIndex = 4
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(60, 262)
        Label4.Name = "Label4"
        Label4.Size = New Size(102, 28)
        Label4.TabIndex = 0
        Label4.Text = "Subject 5: "
        ' 
        ' tsub5
        ' 
        tsub5.Location = New Point(168, 259)
        tsub5.Name = "tsub5"
        tsub5.Size = New Size(221, 34)
        tsub5.TabIndex = 5
        ' 
        ' ProgressBar3
        ' 
        ProgressBar3.Location = New Point(438, 171)
        ProgressBar3.Name = "ProgressBar3"
        ProgressBar3.Size = New Size(399, 29)
        ProgressBar3.Style = ProgressBarStyle.Continuous
        ProgressBar3.TabIndex = 8
        ' 
        ' ProgressBar4
        ' 
        ProgressBar4.Location = New Point(438, 221)
        ProgressBar4.Name = "ProgressBar4"
        ProgressBar4.Size = New Size(399, 29)
        ProgressBar4.Style = ProgressBarStyle.Continuous
        ProgressBar4.TabIndex = 9
        ' 
        ' ProgressBar5
        ' 
        ProgressBar5.Location = New Point(438, 264)
        ProgressBar5.Name = "ProgressBar5"
        ProgressBar5.Size = New Size(399, 29)
        ProgressBar5.Style = ProgressBarStyle.Continuous
        ProgressBar5.TabIndex = 10
        ' 
        ' Button1
        ' 
        Button1.BackColor = SystemColors.ActiveCaptionText
        Button1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.ForeColor = SystemColors.Control
        Button1.Location = New Point(223, 317)
        Button1.Name = "Button1"
        Button1.Size = New Size(140, 50)
        Button1.TabIndex = 11
        Button1.Text = "Result"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' resultlable
        ' 
        resultlable.AutoSize = True
        resultlable.Location = New Point(135, 408)
        resultlable.Name = "resultlable"
        resultlable.Size = New Size(0, 28)
        resultlable.TabIndex = 16
        ' 
        ' lresult
        ' 
        lresult.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        lresult.BorderStyle = BorderStyle.Fixed3D
        lresult.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point)
        lresult.Location = New Point(51, 385)
        lresult.Name = "lresult"
        lresult.Size = New Size(777, 74)
        lresult.TabIndex = 13
        lresult.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(60, 481)
        Label5.Name = "Label5"
        Label5.Size = New Size(166, 28)
        Label5.TabIndex = 0
        Label5.Text = "Rate Your Result : "
        ' 
        ' TrackBar1
        ' 
        TrackBar1.Location = New Point(244, 472)
        TrackBar1.Maximum = 100
        TrackBar1.Name = "TrackBar1"
        TrackBar1.Size = New Size(339, 56)
        TrackBar1.TabIndex = 12
        TrackBar1.TickFrequency = 10
        TrackBar1.TickStyle = TickStyle.Both
        ' 
        ' lrate
        ' 
        lrate.BorderStyle = BorderStyle.Fixed3D
        lrate.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point)
        lrate.Location = New Point(60, 548)
        lrate.Name = "lrate"
        lrate.Size = New Size(777, 42)
        lrate.TabIndex = 14
        lrate.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label7
        ' 
        Label7.BackColor = SystemColors.ButtonShadow
        Label7.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Label7.Location = New Point(-9, 7)
        Label7.Name = "Label7"
        Label7.Size = New Size(909, 54)
        Label7.TabIndex = 0
        Label7.Text = "Progress Report"
        Label7.TextAlign = ContentAlignment.TopCenter
        ' 
        ' marksDetails
        ' 
        AutoScaleDimensions = New SizeF(11F, 28F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(895, 628)
        Controls.Add(Label7)
        Controls.Add(lrate)
        Controls.Add(TrackBar1)
        Controls.Add(Label5)
        Controls.Add(lresult)
        Controls.Add(resultlable)
        Controls.Add(Button1)
        Controls.Add(ProgressBar5)
        Controls.Add(ProgressBar4)
        Controls.Add(ProgressBar3)
        Controls.Add(tsub5)
        Controls.Add(Label4)
        Controls.Add(tsub4)
        Controls.Add(tsub3)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(ProgressBar2)
        Controls.Add(tsub2)
        Controls.Add(Label1)
        Controls.Add(ProgressBar1)
        Controls.Add(tsub1)
        Controls.Add(sub1)
        Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Margin = New Padding(4)
        MaximizeBox = False
        MinimizeBox = False
        Name = "marksDetails"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Marks Details"
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        CType(TrackBar1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents sub1 As Label
    Friend WithEvents tsub1 As TextBox
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents tsub2 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ProgressBar2 As ProgressBar
    Friend WithEvents Label4 As Label
    Friend WithEvents tsub4 As TextBox
    Friend WithEvents tsub3 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents ProgressBar5 As ProgressBar
    Friend WithEvents ProgressBar4 As ProgressBar
    Friend WithEvents ProgressBar3 As ProgressBar
    Friend WithEvents tsub5 As TextBox
    Friend WithEvents resultlable As Label
    Friend WithEvents lresult As Label
    Friend WithEvents TrackBar1 As TrackBar
    Friend WithEvents Label5 As Label
    Friend WithEvents lrate As Label
    Friend WithEvents Label7 As Label
End Class
