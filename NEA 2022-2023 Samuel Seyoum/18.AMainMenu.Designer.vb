<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AMainMenu
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
        Me.btnLogOut = New System.Windows.Forms.Button()
        Me.lblMainMenu = New System.Windows.Forms.Label()
        Me.btnUserMan = New System.Windows.Forms.Button()
        Me.btnView = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnLogOut
        '
        Me.btnLogOut.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogOut.Location = New System.Drawing.Point(364, 23)
        Me.btnLogOut.Name = "btnLogOut"
        Me.btnLogOut.Size = New System.Drawing.Size(97, 43)
        Me.btnLogOut.TabIndex = 2
        Me.btnLogOut.Text = "Log Out"
        Me.btnLogOut.UseVisualStyleBackColor = True
        '
        'lblMainMenu
        '
        Me.lblMainMenu.AutoSize = True
        Me.lblMainMenu.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMainMenu.Location = New System.Drawing.Point(147, 30)
        Me.lblMainMenu.Name = "lblMainMenu"
        Me.lblMainMenu.Size = New System.Drawing.Size(173, 36)
        Me.lblMainMenu.TabIndex = 6
        Me.lblMainMenu.Text = "Main Menu"
        '
        'btnUserMan
        '
        Me.btnUserMan.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUserMan.Location = New System.Drawing.Point(67, 141)
        Me.btnUserMan.Name = "btnUserMan"
        Me.btnUserMan.Size = New System.Drawing.Size(93, 40)
        Me.btnUserMan.TabIndex = 0
        Me.btnUserMan.Text = "User Management"
        Me.btnUserMan.UseVisualStyleBackColor = True
        '
        'btnView
        '
        Me.btnView.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnView.Location = New System.Drawing.Point(311, 141)
        Me.btnView.Name = "btnView"
        Me.btnView.Size = New System.Drawing.Size(93, 40)
        Me.btnView.TabIndex = 1
        Me.btnView.Text = "View Data"
        Me.btnView.UseVisualStyleBackColor = True
        '
        'AMainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(486, 208)
        Me.Controls.Add(Me.btnView)
        Me.Controls.Add(Me.btnUserMan)
        Me.Controls.Add(Me.btnLogOut)
        Me.Controls.Add(Me.lblMainMenu)
        Me.Name = "AMainMenu"
        Me.Text = "Main Menu - Admin"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnLogOut As Button
    Friend WithEvents lblMainMenu As Label
    Friend WithEvents btnUserMan As Button
    Friend WithEvents btnView As Button
End Class
