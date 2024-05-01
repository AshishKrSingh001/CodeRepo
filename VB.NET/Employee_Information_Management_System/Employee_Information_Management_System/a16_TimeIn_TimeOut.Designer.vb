<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class a16_TimeIn_TimeOut
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(a16_TimeIn_TimeOut))
        btnTimeInTimeOut = New Button()
        txtEmpNo = New MaskedTextBox()
        PictureBox1 = New PictureBox()
        lblInfo = New Label()
        Label1 = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnTimeInTimeOut
        ' 
        btnTimeInTimeOut.BackColor = SystemColors.HotTrack
        btnTimeInTimeOut.Cursor = Cursors.Hand
        btnTimeInTimeOut.FlatStyle = FlatStyle.Flat
        btnTimeInTimeOut.ForeColor = SystemColors.Control
        btnTimeInTimeOut.Location = New Point(7, 246)
        btnTimeInTimeOut.Margin = New Padding(2)
        btnTimeInTimeOut.Name = "btnTimeInTimeOut"
        btnTimeInTimeOut.Size = New Size(348, 50)
        btnTimeInTimeOut.TabIndex = 26
        btnTimeInTimeOut.Text = "TimeIn/TimeOut"
        btnTimeInTimeOut.UseVisualStyleBackColor = False
        ' 
        ' txtEmpNo
        ' 
        txtEmpNo.Font = New Font("Segoe UI", 12F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        txtEmpNo.Location = New Point(7, 203)
        txtEmpNo.Mask = "00000"
        txtEmpNo.Name = "txtEmpNo"
        txtEmpNo.PromptChar = "#"c
        txtEmpNo.Size = New Size(348, 34)
        txtEmpNo.TabIndex = 29
        txtEmpNo.TextAlign = HorizontalAlignment.Center
        txtEmpNo.ValidatingType = GetType(Integer)
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.EmpImage1
        PictureBox1.Location = New Point(127, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(126, 117)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 31
        PictureBox1.TabStop = False
        ' 
        ' lblInfo
        ' 
        lblInfo.Location = New Point(7, 174)
        lblInfo.Name = "lblInfo"
        lblInfo.Size = New Size(348, 25)
        lblInfo.TabIndex = 32
        lblInfo.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label1
        ' 
        Label1.Location = New Point(12, 149)
        Label1.Name = "Label1"
        Label1.Size = New Size(348, 25)
        Label1.TabIndex = 33
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' a16_TimeIn_TimeOut
        ' 
        AutoScaleDimensions = New SizeF(9F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ButtonShadow
        ClientSize = New Size(370, 318)
        Controls.Add(Label1)
        Controls.Add(lblInfo)
        Controls.Add(PictureBox1)
        Controls.Add(txtEmpNo)
        Controls.Add(btnTimeInTimeOut)
        Font = New Font("Segoe UI", 9F, FontStyle.Bold Or FontStyle.Italic)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        MinimizeBox = False
        Name = "a16_TimeIn_TimeOut"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Mark Attendence"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents btnTimeInTimeOut As Button
    Friend WithEvents txtEmpNo As MaskedTextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblInfo As Label
    Friend WithEvents Label1 As Label
End Class
