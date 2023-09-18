<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AGroupView
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
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.btnDay = New System.Windows.Forms.Button()
        Me.btnWeek = New System.Windows.Forms.Button()
        Me.btnMonth = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.cBox1 = New System.Windows.Forms.CheckBox()
        Me.cBox2 = New System.Windows.Forms.CheckBox()
        Me.cBox3 = New System.Windows.Forms.CheckBox()
        Me.cBox4 = New System.Windows.Forms.CheckBox()
        Me.cBox5 = New System.Windows.Forms.CheckBox()
        Me.cBoxL6 = New System.Windows.Forms.CheckBox()
        Me.cBoxU6 = New System.Windows.Forms.CheckBox()
        Me.lblEmpty = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(253, 19)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(159, 32)
        Me.lblTitle.TabIndex = 35
        Me.lblTitle.Text = "Select view:"
        '
        'btnDay
        '
        Me.btnDay.Location = New System.Drawing.Point(98, 170)
        Me.btnDay.Name = "btnDay"
        Me.btnDay.Size = New System.Drawing.Size(91, 35)
        Me.btnDay.TabIndex = 8
        Me.btnDay.Text = "Day comparison"
        Me.btnDay.UseVisualStyleBackColor = True
        '
        'btnWeek
        '
        Me.btnWeek.Location = New System.Drawing.Point(294, 170)
        Me.btnWeek.Name = "btnWeek"
        Me.btnWeek.Size = New System.Drawing.Size(86, 35)
        Me.btnWeek.TabIndex = 9
        Me.btnWeek.Text = "Week view"
        Me.btnWeek.UseVisualStyleBackColor = True
        '
        'btnMonth
        '
        Me.btnMonth.Location = New System.Drawing.Point(479, 170)
        Me.btnMonth.Name = "btnMonth"
        Me.btnMonth.Size = New System.Drawing.Size(88, 35)
        Me.btnMonth.TabIndex = 10
        Me.btnMonth.Text = "Month view"
        Me.btnMonth.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(12, 18)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(89, 45)
        Me.btnBack.TabIndex = 11
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'cBox1
        '
        Me.cBox1.AutoSize = True
        Me.cBox1.Location = New System.Drawing.Point(25, 116)
        Me.cBox1.Name = "cBox1"
        Me.cBox1.Size = New System.Drawing.Size(66, 17)
        Me.cBox1.TabIndex = 1
        Me.cBox1.Text = "1st Form"
        Me.cBox1.UseVisualStyleBackColor = True
        '
        'cBox2
        '
        Me.cBox2.AutoSize = True
        Me.cBox2.Location = New System.Drawing.Point(119, 116)
        Me.cBox2.Name = "cBox2"
        Me.cBox2.Size = New System.Drawing.Size(70, 17)
        Me.cBox2.TabIndex = 2
        Me.cBox2.Text = "2nd Form"
        Me.cBox2.UseVisualStyleBackColor = True
        '
        'cBox3
        '
        Me.cBox3.AutoSize = True
        Me.cBox3.Location = New System.Drawing.Point(208, 116)
        Me.cBox3.Name = "cBox3"
        Me.cBox3.Size = New System.Drawing.Size(67, 17)
        Me.cBox3.TabIndex = 3
        Me.cBox3.Text = "3rd Form"
        Me.cBox3.UseVisualStyleBackColor = True
        '
        'cBox4
        '
        Me.cBox4.AutoSize = True
        Me.cBox4.Location = New System.Drawing.Point(294, 116)
        Me.cBox4.Name = "cBox4"
        Me.cBox4.Size = New System.Drawing.Size(67, 17)
        Me.cBox4.TabIndex = 4
        Me.cBox4.Text = "4th Form"
        Me.cBox4.UseVisualStyleBackColor = True
        '
        'cBox5
        '
        Me.cBox5.AutoSize = True
        Me.cBox5.Location = New System.Drawing.Point(386, 116)
        Me.cBox5.Name = "cBox5"
        Me.cBox5.Size = New System.Drawing.Size(67, 17)
        Me.cBox5.TabIndex = 5
        Me.cBox5.Text = "5th Form"
        Me.cBox5.UseVisualStyleBackColor = True
        '
        'cBoxL6
        '
        Me.cBoxL6.AutoSize = True
        Me.cBoxL6.Location = New System.Drawing.Point(469, 116)
        Me.cBoxL6.Name = "cBoxL6"
        Me.cBoxL6.Size = New System.Drawing.Size(73, 17)
        Me.cBoxL6.TabIndex = 6
        Me.cBoxL6.Text = "Lower 6th"
        Me.cBoxL6.UseVisualStyleBackColor = True
        '
        'cBoxU6
        '
        Me.cBoxU6.AutoSize = True
        Me.cBoxU6.Location = New System.Drawing.Point(561, 116)
        Me.cBoxU6.Name = "cBoxU6"
        Me.cBoxU6.Size = New System.Drawing.Size(73, 17)
        Me.cBoxU6.TabIndex = 7
        Me.cBoxU6.Text = "Upper 6th"
        Me.cBoxU6.UseVisualStyleBackColor = True
        '
        'lblEmpty
        '
        Me.lblEmpty.AutoSize = True
        Me.lblEmpty.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmpty.ForeColor = System.Drawing.Color.Red
        Me.lblEmpty.Location = New System.Drawing.Point(270, 63)
        Me.lblEmpty.Name = "lblEmpty"
        Me.lblEmpty.Size = New System.Drawing.Size(120, 16)
        Me.lblEmpty.TabIndex = 48
        Me.lblEmpty.Text = "Select a year group"
        Me.lblEmpty.Visible = False
        '
        'AGroupView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(673, 259)
        Me.Controls.Add(Me.lblEmpty)
        Me.Controls.Add(Me.cBoxU6)
        Me.Controls.Add(Me.cBoxL6)
        Me.Controls.Add(Me.cBox5)
        Me.Controls.Add(Me.cBox4)
        Me.Controls.Add(Me.cBox3)
        Me.Controls.Add(Me.cBox2)
        Me.Controls.Add(Me.cBox1)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnMonth)
        Me.Controls.Add(Me.btnWeek)
        Me.Controls.Add(Me.btnDay)
        Me.Controls.Add(Me.lblTitle)
        Me.Name = "AGroupView"
        Me.Text = "Group View"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTitle As Label
    Friend WithEvents btnDay As Button
    Friend WithEvents btnWeek As Button
    Friend WithEvents btnMonth As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents cBox1 As CheckBox
    Friend WithEvents cBox2 As CheckBox
    Friend WithEvents cBox3 As CheckBox
    Friend WithEvents cBox4 As CheckBox
    Friend WithEvents cBox5 As CheckBox
    Friend WithEvents cBoxL6 As CheckBox
    Friend WithEvents cBoxU6 As CheckBox
    Friend WithEvents lblEmpty As Label
End Class
