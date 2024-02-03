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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form1))
        Label1 = New Label()
        Button1 = New Button()
        Button3 = New Button()
        Button2 = New Button()
        Button4 = New Button()
        Button5 = New Button()
        Button6 = New Button()
        Button7 = New Button()
        Button8 = New Button()
        Button9 = New Button()
        lblPname = New Label()
        Resetbtn = New Button()
        Exitbtn = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.Dock = DockStyle.Top
        Label1.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Label1.ForeColor = SystemColors.InactiveCaptionText
        Label1.Location = New Point(0, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(372, 43)
        Label1.TabIndex = 0
        Label1.Text = "Player 1 : X   |   Player 2 : O"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.Location = New Point(0, 120)
        Button1.Name = "Button1"
        Button1.Size = New Size(120, 95)
        Button1.TabIndex = 1
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Font = New Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point)
        Button3.Location = New Point(252, 120)
        Button3.Name = "Button3"
        Button3.Size = New Size(120, 95)
        Button3.TabIndex = 2
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point)
        Button2.Location = New Point(126, 120)
        Button2.Name = "Button2"
        Button2.Size = New Size(120, 95)
        Button2.TabIndex = 3
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Font = New Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point)
        Button4.Location = New Point(0, 221)
        Button4.Name = "Button4"
        Button4.Size = New Size(120, 95)
        Button4.TabIndex = 4
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Button5
        ' 
        Button5.Font = New Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point)
        Button5.Location = New Point(126, 221)
        Button5.Name = "Button5"
        Button5.Size = New Size(120, 95)
        Button5.TabIndex = 5
        Button5.UseVisualStyleBackColor = True
        ' 
        ' Button6
        ' 
        Button6.Font = New Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point)
        Button6.Location = New Point(252, 221)
        Button6.Name = "Button6"
        Button6.Size = New Size(120, 95)
        Button6.TabIndex = 6
        Button6.UseVisualStyleBackColor = True
        ' 
        ' Button7
        ' 
        Button7.Font = New Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point)
        Button7.Location = New Point(0, 322)
        Button7.Name = "Button7"
        Button7.Size = New Size(120, 95)
        Button7.TabIndex = 7
        Button7.UseVisualStyleBackColor = True
        ' 
        ' Button8
        ' 
        Button8.Font = New Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point)
        Button8.Location = New Point(126, 322)
        Button8.Name = "Button8"
        Button8.Size = New Size(120, 95)
        Button8.TabIndex = 8
        Button8.UseVisualStyleBackColor = True
        ' 
        ' Button9
        ' 
        Button9.Font = New Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point)
        Button9.Location = New Point(252, 322)
        Button9.Name = "Button9"
        Button9.Size = New Size(120, 95)
        Button9.TabIndex = 9
        Button9.UseVisualStyleBackColor = True
        ' 
        ' lblPname
        ' 
        lblPname.ForeColor = SystemColors.HotTrack
        lblPname.Location = New Point(0, 63)
        lblPname.Name = "lblPname"
        lblPname.Size = New Size(372, 35)
        lblPname.TabIndex = 10
        lblPname.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Resetbtn
        ' 
        Resetbtn.Location = New Point(-2, 422)
        Resetbtn.Name = "Resetbtn"
        Resetbtn.Size = New Size(185, 50)
        Resetbtn.TabIndex = 11
        Resetbtn.Text = "Reset"
        Resetbtn.UseVisualStyleBackColor = True
        ' 
        ' Exitbtn
        ' 
        Exitbtn.Location = New Point(187, 422)
        Exitbtn.Name = "Exitbtn"
        Exitbtn.Size = New Size(185, 50)
        Exitbtn.TabIndex = 12
        Exitbtn.Text = "Exit"
        Exitbtn.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(12F, 28F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(372, 471)
        ControlBox = False
        Controls.Add(Exitbtn)
        Controls.Add(Resetbtn)
        Controls.Add(lblPname)
        Controls.Add(Button9)
        Controls.Add(Button8)
        Controls.Add(Button7)
        Controls.Add(Button6)
        Controls.Add(Button5)
        Controls.Add(Button4)
        Controls.Add(Button2)
        Controls.Add(Button3)
        Controls.Add(Button1)
        Controls.Add(Label1)
        Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Margin = New Padding(4)
        MaximizeBox = False
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Tic Tac Toe"
        ResumeLayout(False)
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents lblPname As Label
    Friend WithEvents Resetbtn As Button
    Friend WithEvents Exitbtn As Button
End Class
