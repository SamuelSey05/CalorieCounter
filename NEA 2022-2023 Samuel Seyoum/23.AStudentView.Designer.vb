﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AStudentView
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
        Me.txtbxStudent = New System.Windows.Forms.TextBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.dgvStudents = New System.Windows.Forms.DataGridView()
        CType(Me.dgvStudents, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnBack
        '
        Me.btnBack.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(31, 26)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(89, 45)
        Me.btnBack.TabIndex = 2
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'txtbxStudent
        '
        Me.txtbxStudent.Location = New System.Drawing.Point(66, 139)
        Me.txtbxStudent.Name = "txtbxStudent"
        Me.txtbxStudent.Size = New System.Drawing.Size(340, 20)
        Me.txtbxStudent.TabIndex = 0
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(138, 63)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(196, 32)
        Me.lblTitle.TabIndex = 34
        Me.lblTitle.Text = "Select student:"
        '
        'dgvStudents
        '
        Me.dgvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvStudents.Location = New System.Drawing.Point(66, 158)
        Me.dgvStudents.Name = "dgvStudents"
        Me.dgvStudents.Size = New System.Drawing.Size(340, 150)
        Me.dgvStudents.TabIndex = 1
        '
        'AStudentView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(509, 340)
        Me.Controls.Add(Me.txtbxStudent)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.dgvStudents)
        Me.Controls.Add(Me.btnBack)
        Me.Name = "AStudentView"
        Me.Text = "Student View - Admin"
        CType(Me.dgvStudents, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnBack As Button
    Friend WithEvents txtbxStudent As TextBox
    Friend WithEvents lblTitle As Label
    Friend WithEvents dgvStudents As DataGridView
End Class
