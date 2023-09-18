<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserEdit
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
        Dim btnEPass As System.Windows.Forms.Button
        Dim btnDelete As System.Windows.Forms.Button
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnEDets = New System.Windows.Forms.Button()
        btnEPass = New System.Windows.Forms.Button()
        btnDelete = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnEPass
        '
        btnEPass.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        btnEPass.Location = New System.Drawing.Point(56, 136)
        btnEPass.Name = "btnEPass"
        btnEPass.Size = New System.Drawing.Size(92, 48)
        btnEPass.TabIndex = 0
        btnEPass.Text = "Edit password"
        btnEPass.UseVisualStyleBackColor = True
        AddHandler btnEPass.Click, AddressOf Me.btnEPass_Click
        '
        'btnDelete
        '
        btnDelete.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        btnDelete.Location = New System.Drawing.Point(205, 136)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New System.Drawing.Size(92, 48)
        btnDelete.TabIndex = 1
        btnDelete.Text = "Delete user"
        btnDelete.UseVisualStyleBackColor = True
        AddHandler btnDelete.Click, AddressOf Me.btnDelete_Click
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(178, 35)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(140, 36)
        Me.lblTitle.TabIndex = 1
        Me.lblTitle.Text = "Edit user"
        '
        'btnBack
        '
        Me.btnBack.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(26, 26)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(80, 36)
        Me.btnBack.TabIndex = 3
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'btnEDets
        '
        Me.btnEDets.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEDets.Location = New System.Drawing.Point(355, 136)
        Me.btnEDets.Name = "btnEDets"
        Me.btnEDets.Size = New System.Drawing.Size(90, 48)
        Me.btnEDets.TabIndex = 2
        Me.btnEDets.Text = "Edit details"
        Me.btnEDets.UseVisualStyleBackColor = True
        '
        'UserEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(492, 220)
        Me.Controls.Add(btnDelete)
        Me.Controls.Add(Me.btnEDets)
        Me.Controls.Add(btnEPass)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.lblTitle)
        Me.Name = "UserEdit"
        Me.Text = "User Edit"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents btnBack As Button
    Friend WithEvents btnEDets As Button
End Class
