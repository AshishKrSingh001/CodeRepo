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
        DateTimePicker1 = New DateTimePicker()
        Label1 = New Label()
        Button2 = New Button()
        Label2 = New Label()
        SuspendLayout()
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Location = New Point(178, 39)
        DateTimePicker1.MaxDate = New Date(2023, 11, 18, 0, 0, 0, 0)
        DateTimePicker1.MinDate = New Date(1900, 1, 1, 0, 0, 0, 0)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(250, 34)
        DateTimePicker1.TabIndex = 1
        DateTimePicker1.Value = New Date(2023, 11, 18, 0, 0, 0, 0)
        ' 
        ' Label1
        ' 
        Label1.BackColor = SystemColors.ActiveCaptionText
        Label1.Dock = DockStyle.Fill
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = SystemColors.ButtonHighlight
        Label1.Location = New Point(0, 0)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(607, 346)
        Label1.TabIndex = 0
        Label1.Text = "Enter Your Date of Birth :"
        Label1.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Button2.ForeColor = SystemColors.ActiveCaptionText
        Button2.Location = New Point(305, 88)
        Button2.Name = "Button2"
        Button2.Size = New Size(123, 43)
        Button2.TabIndex = 3
        Button2.Text = "Calculate"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(0, 146)
        Label2.Name = "Label2"
        Label2.Size = New Size(607, 200)
        Label2.TabIndex = 4
        Label2.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(11F, 28F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaptionText
        ClientSize = New Size(607, 346)
        Controls.Add(Label2)
        Controls.Add(Button2)
        Controls.Add(DateTimePicker1)
        Controls.Add(Label1)
        Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        ForeColor = SystemColors.ButtonHighlight
        Margin = New Padding(4)
        Name = "Form1"
        Text = "Age Calculator"
        ResumeLayout(False)
    End Sub
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Label2 As Label
End Class
