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
        GroupBox1 = New GroupBox()
        ButtonSearch = New Button()
        txtSearch = New TextBox()
        Label1 = New Label()
        GroupBox2 = New GroupBox()
        txtNo = New TextBox()
        txtName = New TextBox()
        txtCost = New TextBox()
        txtQuan = New TextBox()
        Label5 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        ButtonDelete = New Button()
        ButtonReport = New Button()
        Label2 = New Label()
        ButtonUpdate = New Button()
        ButtonInsert = New Button()
        DataGridView1 = New DataGridView()
        GroupBox3 = New GroupBox()
        ButtonDesc = New Button()
        ButtonPrev = New Button()
        ButtonNext = New Button()
        ButtonLast = New Button()
        ButtonAsc = New Button()
        ButtonFirst = New Button()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox3.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(ButtonSearch)
        GroupBox1.Controls.Add(txtSearch)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Location = New Point(12, 12)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(384, 150)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "Search"
        ' 
        ' ButtonSearch
        ' 
        ButtonSearch.Location = New Point(280, 91)
        ButtonSearch.Name = "ButtonSearch"
        ButtonSearch.Size = New Size(86, 38)
        ButtonSearch.TabIndex = 4
        ButtonSearch.Text = "Search"
        ButtonSearch.UseVisualStyleBackColor = True
        ' 
        ' txtSearch
        ' 
        txtSearch.Location = New Point(188, 38)
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New Size(175, 34)
        txtSearch.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(20, 38)
        Label1.Name = "Label1"
        Label1.Size = New Size(162, 28)
        Label1.TabIndex = 0
        Label1.Text = "Enter Item Name:"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(txtNo)
        GroupBox2.Controls.Add(txtName)
        GroupBox2.Controls.Add(txtCost)
        GroupBox2.Controls.Add(txtQuan)
        GroupBox2.Controls.Add(Label5)
        GroupBox2.Controls.Add(Label3)
        GroupBox2.Controls.Add(Label4)
        GroupBox2.Controls.Add(ButtonDelete)
        GroupBox2.Controls.Add(ButtonReport)
        GroupBox2.Controls.Add(Label2)
        GroupBox2.Controls.Add(ButtonUpdate)
        GroupBox2.Controls.Add(ButtonInsert)
        GroupBox2.Location = New Point(12, 168)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(384, 260)
        GroupBox2.TabIndex = 1
        GroupBox2.TabStop = False
        GroupBox2.Text = "Operations"
        ' 
        ' txtNo
        ' 
        txtNo.Location = New Point(128, 29)
        txtNo.Name = "txtNo"
        txtNo.Size = New Size(235, 34)
        txtNo.TabIndex = 6
        ' 
        ' txtName
        ' 
        txtName.Location = New Point(128, 69)
        txtName.Name = "txtName"
        txtName.Size = New Size(235, 34)
        txtName.TabIndex = 7
        ' 
        ' txtCost
        ' 
        txtCost.Location = New Point(128, 109)
        txtCost.Name = "txtCost"
        txtCost.Size = New Size(235, 34)
        txtCost.TabIndex = 8
        ' 
        ' txtQuan
        ' 
        txtQuan.Location = New Point(128, 149)
        txtQuan.Name = "txtQuan"
        txtQuan.Size = New Size(235, 34)
        txtQuan.TabIndex = 9
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(20, 152)
        Label5.Name = "Label5"
        Label5.Size = New Size(102, 28)
        Label5.TabIndex = 8
        Label5.Text = "Quantity : "
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(20, 112)
        Label3.Name = "Label3"
        Label3.Size = New Size(65, 28)
        Label3.TabIndex = 6
        Label3.Text = "Cost : "
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(15, 72)
        Label4.Name = "Label4"
        Label4.Size = New Size(122, 28)
        Label4.TabIndex = 7
        Label4.Text = "Item Name : "
        ' 
        ' ButtonDelete
        ' 
        ButtonDelete.Location = New Point(188, 202)
        ButtonDelete.Name = "ButtonDelete"
        ButtonDelete.Size = New Size(86, 38)
        ButtonDelete.TabIndex = 3
        ButtonDelete.Text = "Delete"
        ButtonDelete.UseVisualStyleBackColor = True
        ' 
        ' ButtonReport
        ' 
        ButtonReport.Location = New Point(280, 202)
        ButtonReport.Name = "ButtonReport"
        ButtonReport.Size = New Size(86, 38)
        ButtonReport.TabIndex = 2
        ButtonReport.Text = "Report"
        ButtonReport.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(15, 32)
        Label2.Name = "Label2"
        Label2.Size = New Size(97, 28)
        Label2.TabIndex = 5
        Label2.Text = "Item No : "
        ' 
        ' ButtonUpdate
        ' 
        ButtonUpdate.Location = New Point(96, 202)
        ButtonUpdate.Name = "ButtonUpdate"
        ButtonUpdate.Size = New Size(86, 38)
        ButtonUpdate.TabIndex = 1
        ButtonUpdate.Text = "Update"
        ButtonUpdate.UseVisualStyleBackColor = True
        ' 
        ' ButtonInsert
        ' 
        ButtonInsert.Location = New Point(6, 202)
        ButtonInsert.Name = "ButtonInsert"
        ButtonInsert.Size = New Size(86, 38)
        ButtonInsert.TabIndex = 0
        ButtonInsert.Text = "Insert"
        ButtonInsert.UseVisualStyleBackColor = True
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(402, 26)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.RowTemplate.Height = 29
        DataGridView1.Size = New Size(553, 307)
        DataGridView1.TabIndex = 2
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Controls.Add(ButtonDesc)
        GroupBox3.Controls.Add(ButtonPrev)
        GroupBox3.Controls.Add(ButtonNext)
        GroupBox3.Controls.Add(ButtonLast)
        GroupBox3.Controls.Add(ButtonAsc)
        GroupBox3.Controls.Add(ButtonFirst)
        GroupBox3.Location = New Point(402, 339)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(553, 89)
        GroupBox3.TabIndex = 3
        GroupBox3.TabStop = False
        GroupBox3.Text = "Navigation"
        ' 
        ' ButtonDesc
        ' 
        ButtonDesc.Location = New Point(464, 41)
        ButtonDesc.Name = "ButtonDesc"
        ButtonDesc.Size = New Size(86, 38)
        ButtonDesc.TabIndex = 15
        ButtonDesc.Text = "Desc"
        ButtonDesc.UseVisualStyleBackColor = True
        ' 
        ' ButtonPrev
        ' 
        ButtonPrev.Location = New Point(95, 41)
        ButtonPrev.Name = "ButtonPrev"
        ButtonPrev.Size = New Size(86, 38)
        ButtonPrev.TabIndex = 14
        ButtonPrev.Text = "Prev"
        ButtonPrev.UseVisualStyleBackColor = True
        ' 
        ' ButtonNext
        ' 
        ButtonNext.Location = New Point(187, 41)
        ButtonNext.Name = "ButtonNext"
        ButtonNext.Size = New Size(86, 38)
        ButtonNext.TabIndex = 13
        ButtonNext.Text = "Next"
        ButtonNext.UseVisualStyleBackColor = True
        ' 
        ' ButtonLast
        ' 
        ButtonLast.Location = New Point(279, 41)
        ButtonLast.Name = "ButtonLast"
        ButtonLast.Size = New Size(86, 38)
        ButtonLast.TabIndex = 12
        ButtonLast.Text = "Last"
        ButtonLast.UseVisualStyleBackColor = True
        ' 
        ' ButtonAsc
        ' 
        ButtonAsc.Location = New Point(371, 41)
        ButtonAsc.Name = "ButtonAsc"
        ButtonAsc.Size = New Size(86, 38)
        ButtonAsc.TabIndex = 11
        ButtonAsc.Text = "Asc"
        ButtonAsc.UseVisualStyleBackColor = True
        ' 
        ' ButtonFirst
        ' 
        ButtonFirst.Location = New Point(3, 41)
        ButtonFirst.Name = "ButtonFirst"
        ButtonFirst.Size = New Size(86, 38)
        ButtonFirst.TabIndex = 10
        ButtonFirst.Text = "First"
        ButtonFirst.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(11F, 28F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(981, 445)
        Controls.Add(GroupBox3)
        Controls.Add(DataGridView1)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Margin = New Padding(4)
        MaximizeBox = False
        MinimizeBox = False
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Item Information Management System"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        GroupBox3.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents ButtonDelete As Button
    Friend WithEvents ButtonReport As Button
    Friend WithEvents ButtonUpdate As Button
    Friend WithEvents ButtonInsert As Button
    Friend WithEvents ButtonSearch As Button
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtNo As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtCost As TextBox
    Friend WithEvents txtQuan As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents ButtonDesc As Button
    Friend WithEvents ButtonPrev As Button
    Friend WithEvents ButtonNext As Button
    Friend WithEvents ButtonLast As Button
    Friend WithEvents ButtonAsc As Button
    Friend WithEvents ButtonFirst As Button
End Class
