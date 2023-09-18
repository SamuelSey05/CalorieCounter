<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ViewHistory
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
        Dim btnVDay As System.Windows.Forms.Button
        Me.btnVWeek = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.lblTitle = New System.Windows.Forms.Label()
        btnVDay = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnVDay
        '
        btnVDay.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        btnVDay.Location = New System.Drawing.Point(83, 138)
        btnVDay.Name = "btnVDay"
        btnVDay.Size = New System.Drawing.Size(92, 48)
        btnVDay.TabIndex = 0
        btnVDay.Text = "View day"
        btnVDay.UseVisualStyleBackColor = True
        AddHandler btnVDay.Click, AddressOf Me.btnVDay_Click
        '
        'btnVWeek
        '
        Me.btnVWeek.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVWeek.Location = New System.Drawing.Point(344, 138)
        Me.btnVWeek.Name = "btnVWeek"
        Me.btnVWeek.Size = New System.Drawing.Size(90, 48)
        Me.btnVWeek.TabIndex = 1
        Me.btnVWeek.Text = "View week"
        Me.btnVWeek.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(12, 12)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(80, 36)
        Me.btnBack.TabIndex = 2
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(162, 30)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(184, 36)
        Me.lblTitle.TabIndex = 6
        Me.lblTitle.Text = "View history"
        '
        'ViewHistory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(513, 232)
        Me.Controls.Add(Me.btnVWeek)
        Me.Controls.Add(btnVDay)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.lblTitle)
        Me.Name = "ViewHistory"
        Me.Text = "[STUDENT USER]"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnVWeek As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents lblTitle As Label
End Class
