<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AView
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
        Me.btnBack = New System.Windows.Forms.Button()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.btnVStudent = New System.Windows.Forms.Button()
        Me.btnVGroup = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnBack
        '
        Me.btnBack.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(22, 12)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(89, 45)
        Me.btnBack.TabIndex = 2
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(190, 21)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(151, 36)
        Me.lblTitle.TabIndex = 29
        Me.lblTitle.Text = "View data"
        '
        'btnVStudent
        '
        Me.btnVStudent.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVStudent.Location = New System.Drawing.Point(88, 160)
        Me.btnVStudent.Name = "btnVStudent"
        Me.btnVStudent.Size = New System.Drawing.Size(93, 40)
        Me.btnVStudent.TabIndex = 0
        Me.btnVStudent.Text = "Student View"
        Me.btnVStudent.UseVisualStyleBackColor = True
        '
        'btnVGroup
        '
        Me.btnVGroup.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVGroup.Location = New System.Drawing.Point(350, 160)
        Me.btnVGroup.Name = "btnVGroup"
        Me.btnVGroup.Size = New System.Drawing.Size(93, 40)
        Me.btnVGroup.TabIndex = 1
        Me.btnVGroup.Text = "Group View"
        Me.btnVGroup.UseVisualStyleBackColor = True
        '
        'AView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(529, 252)
        Me.Controls.Add(Me.btnVGroup)
        Me.Controls.Add(Me.btnVStudent)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.btnBack)
        Me.Name = "AView"
        Me.Text = "Data View - Admin"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnBack As Button
    Friend WithEvents lblTitle As Label
    Friend WithEvents btnVStudent As Button
    Friend WithEvents btnVGroup As Button
End Class
