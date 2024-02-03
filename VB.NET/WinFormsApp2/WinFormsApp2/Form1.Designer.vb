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
        TextBox1 = New TextBox()
        sod = New Button()
        rod = New Button()
        mood = New Button()
        eoc = New Button()
        pcc = New Button()
        sc = New Button()
        resett = New Button()
        pc = New Button()
        exitt = New Button()
        SuspendLayout()
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        TextBox1.Location = New Point(263, 118)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(325, 38)
        TextBox1.TabIndex = 0
        ' 
        ' sod
        ' 
        sod.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        sod.Location = New Point(79, 183)
        sod.Name = "sod"
        sod.Size = New Size(206, 66)
        sod.TabIndex = 1
        sod.Text = "Sum of digits"
        sod.UseVisualStyleBackColor = True
        ' 
        ' rod
        ' 
        rod.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        rod.Location = New Point(291, 183)
        rod.Name = "rod"
        rod.Size = New Size(277, 66)
        rod.TabIndex = 2
        rod.Text = "reverse of digits"
        rod.UseVisualStyleBackColor = True
        ' 
        ' mood
        ' 
        mood.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        mood.Location = New Point(574, 183)
        mood.Name = "mood"
        mood.Size = New Size(186, 66)
        mood.TabIndex = 3
        mood.Text = "mult of digits"
        mood.UseVisualStyleBackColor = True
        ' 
        ' eoc
        ' 
        eoc.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        eoc.Location = New Point(79, 255)
        eoc.Name = "eoc"
        eoc.Size = New Size(206, 62)
        eoc.TabIndex = 4
        eoc.Text = "even/odd check"
        eoc.UseVisualStyleBackColor = True
        ' 
        ' pcc
        ' 
        pcc.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        pcc.Location = New Point(291, 255)
        pcc.Name = "pcc"
        pcc.Size = New Size(277, 62)
        pcc.TabIndex = 5
        pcc.Text = "prime/composite check"
        pcc.UseVisualStyleBackColor = True
        ' 
        ' sc
        ' 
        sc.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        sc.Location = New Point(574, 255)
        sc.Name = "sc"
        sc.Size = New Size(186, 62)
        sc.TabIndex = 6
        sc.Text = "sign check"
        sc.UseVisualStyleBackColor = True
        ' 
        ' resett
        ' 
        resett.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        resett.Location = New Point(79, 323)
        resett.Name = "resett"
        resett.Size = New Size(206, 63)
        resett.TabIndex = 7
        resett.Text = "reset"
        resett.UseVisualStyleBackColor = True
        ' 
        ' pc
        ' 
        pc.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        pc.Location = New Point(291, 323)
        pc.Name = "pc"
        pc.Size = New Size(277, 63)
        pc.TabIndex = 8
        pc.Text = "palindrome check"
        pc.UseVisualStyleBackColor = True
        ' 
        ' exitt
        ' 
        exitt.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        exitt.Location = New Point(574, 323)
        exitt.Name = "exitt"
        exitt.Size = New Size(186, 63)
        exitt.TabIndex = 9
        exitt.Text = "exit"
        exitt.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(exitt)
        Controls.Add(pc)
        Controls.Add(resett)
        Controls.Add(sc)
        Controls.Add(pcc)
        Controls.Add(eoc)
        Controls.Add(mood)
        Controls.Add(rod)
        Controls.Add(sod)
        Controls.Add(TextBox1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents sod As Button
    Friend WithEvents rod As Button
    Friend WithEvents mood As Button
    Friend WithEvents eoc As Button
    Friend WithEvents pcc As Button
    Friend WithEvents sc As Button
    Friend WithEvents resett As Button
    Friend WithEvents pc As Button
    Friend WithEvents exitt As Button
End Class
