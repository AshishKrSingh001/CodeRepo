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
        Label1 = New Label()
        txtSNo = New TextBox()
        TxtVNo = New TextBox()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        CheckedBox = New CheckBox()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        EDate = New DateTimePicker()
        DDate = New DateTimePicker()
        Label8 = New Label()
        Label9 = New Label()
        lbJob = New ListBox()
        DataGridView1 = New DataGridView()
        Operation = New GroupBox()
        ButtonUpdate = New Button()
        ButtonFilter = New Button()
        ButtonDelete = New Button()
        ButtonInsert = New Button()
        GroupBox1 = New GroupBox()
        ButtonColor = New Button()
        ButtonAccident = New Button()
        ButtonService = New Button()
        GroupBox2 = New GroupBox()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        TextBox1 = New TextBox()
        Button5 = New Button()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        Operation.SuspendLayout()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(17, 68)
        Label1.Name = "Label1"
        Label1.Size = New Size(120, 28)
        Label1.TabIndex = 0
        Label1.Text = "Service No : "
        ' 
        ' txtSNo
        ' 
        txtSNo.Location = New Point(176, 65)
        txtSNo.Name = "txtSNo"
        txtSNo.Size = New Size(250, 34)
        txtSNo.TabIndex = 1
        ' 
        ' TxtVNo
        ' 
        TxtVNo.Location = New Point(176, 110)
        TxtVNo.Name = "TxtVNo"
        TxtVNo.Size = New Size(250, 34)
        TxtVNo.TabIndex = 3
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(17, 113)
        Label2.Name = "Label2"
        Label2.Size = New Size(115, 28)
        Label2.TabIndex = 2
        Label2.Text = "Vehicle no : "
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(17, 299)
        Label3.Name = "Label3"
        Label3.Size = New Size(162, 28)
        Label3.TabIndex = 4
        Label3.Text = "Job Description : "
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(17, 156)
        Label4.Name = "Label4"
        Label4.Size = New Size(86, 28)
        Label4.TabIndex = 6
        Label4.Text = "Attend : "
        ' 
        ' CheckedBox
        ' 
        CheckedBox.AutoSize = True
        CheckedBox.Location = New Point(176, 156)
        CheckedBox.Name = "CheckedBox"
        CheckedBox.Size = New Size(61, 32)
        CheckedBox.TabIndex = 7
        CheckedBox.Text = "Yes"
        CheckedBox.UseVisualStyleBackColor = True
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(17, 194)
        Label5.Name = "Label5"
        Label5.Size = New Size(132, 28)
        Label5.TabIndex = 8
        Label5.Text = "Type_of_Job : "
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(17, 434)
        Label6.Name = "Label6"
        Label6.Size = New Size(117, 28)
        Label6.TabIndex = 11
        Label6.Text = "Entry Date : "
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(17, 478)
        Label7.Name = "Label7"
        Label7.Size = New Size(138, 28)
        Label7.TabIndex = 12
        Label7.Text = "Delivery Date: "
        ' 
        ' EDate
        ' 
        EDate.Location = New Point(176, 434)
        EDate.Name = "EDate"
        EDate.Size = New Size(250, 34)
        EDate.TabIndex = 13
        ' 
        ' DDate
        ' 
        DDate.Location = New Point(176, 478)
        DDate.Name = "DDate"
        DDate.Size = New Size(250, 34)
        DDate.TabIndex = 14
        ' 
        ' Label8
        ' 
        Label8.Dock = DockStyle.Top
        Label8.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Label8.Location = New Point(0, 0)
        Label8.Name = "Label8"
        Label8.Size = New Size(1372, 46)
        Label8.TabIndex = 15
        Label8.Text = "Hero Service Center"
        Label8.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label9
        ' 
        Label9.Dock = DockStyle.Bottom
        Label9.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Label9.Location = New Point(0, 610)
        Label9.Name = "Label9"
        Label9.Size = New Size(1372, 42)
        Label9.TabIndex = 16
        Label9.Text = "Visit Again"
        Label9.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lbJob
        ' 
        lbJob.FormattingEnabled = True
        lbJob.ItemHeight = 28
        lbJob.Items.AddRange(New Object() {"Service", "Color", "Accident"})
        lbJob.Location = New Point(176, 194)
        lbJob.Name = "lbJob"
        lbJob.Size = New Size(250, 88)
        lbJob.TabIndex = 18
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(436, 68)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.RowTemplate.Height = 29
        DataGridView1.Size = New Size(929, 447)
        DataGridView1.TabIndex = 19
        ' 
        ' Operation
        ' 
        Operation.Controls.Add(ButtonUpdate)
        Operation.Controls.Add(ButtonFilter)
        Operation.Controls.Add(ButtonDelete)
        Operation.Controls.Add(ButtonInsert)
        Operation.Location = New Point(17, 517)
        Operation.Name = "Operation"
        Operation.Size = New Size(409, 102)
        Operation.TabIndex = 20
        Operation.TabStop = False
        Operation.Text = "Operation"
        ' 
        ' ButtonUpdate
        ' 
        ButtonUpdate.Location = New Point(109, 42)
        ButtonUpdate.Name = "ButtonUpdate"
        ButtonUpdate.Size = New Size(94, 42)
        ButtonUpdate.TabIndex = 3
        ButtonUpdate.Text = "Update"
        ButtonUpdate.UseVisualStyleBackColor = True
        ' 
        ' ButtonFilter
        ' 
        ButtonFilter.Location = New Point(309, 42)
        ButtonFilter.Name = "ButtonFilter"
        ButtonFilter.Size = New Size(94, 42)
        ButtonFilter.TabIndex = 2
        ButtonFilter.Text = "Filter"
        ButtonFilter.UseVisualStyleBackColor = True
        ' 
        ' ButtonDelete
        ' 
        ButtonDelete.Location = New Point(209, 42)
        ButtonDelete.Name = "ButtonDelete"
        ButtonDelete.Size = New Size(94, 42)
        ButtonDelete.TabIndex = 1
        ButtonDelete.Text = "Delete"
        ButtonDelete.UseVisualStyleBackColor = True
        ' 
        ' ButtonInsert
        ' 
        ButtonInsert.Location = New Point(9, 42)
        ButtonInsert.Name = "ButtonInsert"
        ButtonInsert.Size = New Size(94, 42)
        ButtonInsert.TabIndex = 0
        ButtonInsert.Text = "Insert"
        ButtonInsert.UseVisualStyleBackColor = True
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(ButtonColor)
        GroupBox1.Controls.Add(ButtonAccident)
        GroupBox1.Controls.Add(ButtonService)
        GroupBox1.Location = New Point(908, 517)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(355, 102)
        GroupBox1.TabIndex = 21
        GroupBox1.TabStop = False
        GroupBox1.Text = "Not Attented"
        ' 
        ' ButtonColor
        ' 
        ButtonColor.Location = New Point(122, 41)
        ButtonColor.Name = "ButtonColor"
        ButtonColor.Size = New Size(110, 45)
        ButtonColor.TabIndex = 3
        ButtonColor.Text = "Color"
        ButtonColor.UseVisualStyleBackColor = True
        ' 
        ' ButtonAccident
        ' 
        ButtonAccident.Location = New Point(238, 39)
        ButtonAccident.Name = "ButtonAccident"
        ButtonAccident.Size = New Size(110, 45)
        ButtonAccident.TabIndex = 2
        ButtonAccident.Text = "Accident"
        ButtonAccident.UseVisualStyleBackColor = True
        ' 
        ' ButtonService
        ' 
        ButtonService.Location = New Point(6, 41)
        ButtonService.Name = "ButtonService"
        ButtonService.Size = New Size(110, 45)
        ButtonService.TabIndex = 0
        ButtonService.Text = "Service"
        ButtonService.UseVisualStyleBackColor = True
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(Button1)
        GroupBox2.Controls.Add(Button2)
        GroupBox2.Controls.Add(Button3)
        GroupBox2.Controls.Add(Button4)
        GroupBox2.Location = New Point(432, 517)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(470, 102)
        GroupBox2.TabIndex = 22
        GroupBox2.TabStop = False
        GroupBox2.Text = "Navigation"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(122, 42)
        Button1.Name = "Button1"
        Button1.Size = New Size(110, 45)
        Button1.TabIndex = 3
        Button1.Text = "Prev"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(354, 41)
        Button2.Name = "Button2"
        Button2.Size = New Size(110, 45)
        Button2.TabIndex = 2
        Button2.Text = "Last"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(238, 42)
        Button3.Name = "Button3"
        Button3.Size = New Size(110, 45)
        Button3.TabIndex = 1
        Button3.Text = "Next"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(6, 41)
        Button4.Name = "Button4"
        Button4.Size = New Size(110, 45)
        Button4.TabIndex = 0
        Button4.Text = "First"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(180, 296)
        TextBox1.Multiline = True
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(250, 132)
        TextBox1.TabIndex = 4
        ' 
        ' Button5
        ' 
        Button5.Location = New Point(1269, 558)
        Button5.Name = "Button5"
        Button5.Size = New Size(91, 45)
        Button5.TabIndex = 4
        Button5.Text = "Refresh"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(11F, 28F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1372, 652)
        Controls.Add(Button5)
        Controls.Add(TextBox1)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Controls.Add(Operation)
        Controls.Add(DataGridView1)
        Controls.Add(lbJob)
        Controls.Add(Label9)
        Controls.Add(Label8)
        Controls.Add(DDate)
        Controls.Add(EDate)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(CheckedBox)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(TxtVNo)
        Controls.Add(Label2)
        Controls.Add(txtSNo)
        Controls.Add(Label1)
        Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Margin = New Padding(4)
        MaximizeBox = False
        MinimizeBox = False
        Name = "Form1"
        ShowIcon = False
        StartPosition = FormStartPosition.CenterScreen
        Text = "Vehicle Service Information"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        Operation.ResumeLayout(False)
        GroupBox1.ResumeLayout(False)
        GroupBox2.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtSNo As TextBox
    Friend WithEvents TxtVNo As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents CheckedBox As CheckBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents EDate As DateTimePicker
    Friend WithEvents DDate As DateTimePicker
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents lbJob As ListBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Operation As GroupBox
    Friend WithEvents ButtonUpdate As Button
    Friend WithEvents ButtonFilter As Button
    Friend WithEvents ButtonDelete As Button
    Friend WithEvents ButtonInsert As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ButtonColor As Button
    Friend WithEvents ButtonAccident As Button
    Friend WithEvents ButtonService As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button5 As Button
End Class
