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
        Label2 = New Label()
        txtInitial = New TextBox()
        txtxFinal = New TextBox()
        btnsub = New Button()
        btnfun = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(176, 80)
        Label1.Name = "Label1"
        Label1.Size = New Size(129, 28)
        Label1.TabIndex = 0
        Label1.Text = "Initial Range :"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(176, 145)
        Label2.Name = "Label2"
        Label2.Size = New Size(122, 28)
        Label2.TabIndex = 1
        Label2.Text = "Final Range :"
        ' 
        ' txtInitial
        ' 
        txtInitial.Location = New Point(327, 77)
        txtInitial.Name = "txtInitial"
        txtInitial.Size = New Size(218, 34)
        txtInitial.TabIndex = 2
        ' 
        ' txtxFinal
        ' 
        txtxFinal.Location = New Point(327, 142)
        txtxFinal.Name = "txtxFinal"
        txtxFinal.Size = New Size(218, 34)
        txtxFinal.TabIndex = 3
        ' 
        ' btnsub
        ' 
        btnsub.Location = New Point(379, 200)
        btnsub.Name = "btnsub"
        btnsub.Size = New Size(166, 87)
        btnsub.TabIndex = 4
        btnsub.Text = "Random Function"
        btnsub.UseVisualStyleBackColor = True
        ' 
        ' btnfun
        ' 
        btnfun.Location = New Point(176, 200)
        btnfun.Name = "btnfun"
        btnfun.Size = New Size(166, 87)
        btnfun.TabIndex = 5
        btnfun.Text = "Random SubRoutine"
        btnfun.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(11F, 28F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(882, 453)
        Controls.Add(btnfun)
        Controls.Add(btnsub)
        Controls.Add(txtxFinal)
        Controls.Add(txtInitial)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Margin = New Padding(4)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Random Number"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtInitial As TextBox
    Friend WithEvents txtxFinal As TextBox
    Friend WithEvents btnsub As Button
    Friend WithEvents btnfun As Button
End Class
