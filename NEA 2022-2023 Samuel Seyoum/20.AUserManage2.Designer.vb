<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AUserManage2
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
        Dim btnDelete As System.Windows.Forms.Button
        Dim btnResetPass As System.Windows.Forms.Button
        Me.btnEUser = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.lblTitle = New System.Windows.Forms.Label()
        btnDelete = New System.Windows.Forms.Button()
        btnResetPass = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnDelete
        '
        btnDelete.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        btnDelete.Location = New System.Drawing.Point(203, 143)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New System.Drawing.Size(92, 48)
        btnDelete.TabIndex = 1
        btnDelete.Text = "Delete user"
        btnDelete.UseVisualStyleBackColor = True
        AddHandler btnDelete.Click, AddressOf Me.btnDelete_Click
        '
        'btnResetPass
        '
        btnResetPass.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        btnResetPass.Location = New System.Drawing.Point(48, 143)
        btnResetPass.Name = "btnResetPass"
        btnResetPass.Size = New System.Drawing.Size(92, 48)
        btnResetPass.TabIndex = 0
        btnResetPass.Text = "Reset password"
        btnResetPass.UseVisualStyleBackColor = True
        AddHandler btnResetPass.Click, AddressOf Me.btnResetPass_Click
        '
        'btnEUser
        '
        Me.btnEUser.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEUser.Location = New System.Drawing.Point(356, 143)
        Me.btnEUser.Name = "btnEUser"
        Me.btnEUser.Size = New System.Drawing.Size(90, 48)
        Me.btnEUser.TabIndex = 2
        Me.btnEUser.Text = "Edit user"
        Me.btnEUser.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(29, 26)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(80, 36)
        Me.btnBack.TabIndex = 3
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(174, 54)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(140, 36)
        Me.lblTitle.TabIndex = 9
        Me.lblTitle.Text = "Edit user"
        '
        'AUserManage2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(496, 242)
        Me.Controls.Add(btnResetPass)
        Me.Controls.Add(Me.btnEUser)
        Me.Controls.Add(btnDelete)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.lblTitle)
        Me.Name = "AUserManage2"
        Me.Text = "[STUDENT USERNAME]"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnEUser As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents lblTitle As Label
End Class
