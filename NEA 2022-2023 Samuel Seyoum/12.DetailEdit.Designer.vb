<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DetailEdit
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
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblGoal = New System.Windows.Forms.Label()
        Me.lblPAL = New System.Windows.Forms.Label()
        Me.lblBFP = New System.Windows.Forms.Label()
        Me.txtbxBFP = New System.Windows.Forms.TextBox()
        Me.lblWeight = New System.Windows.Forms.Label()
        Me.txtbxWeight = New System.Windows.Forms.TextBox()
        Me.lblHeight = New System.Windows.Forms.Label()
        Me.txtbxHeight = New System.Windows.Forms.TextBox()
        Me.btnConfirm = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.rbtnGain = New System.Windows.Forms.RadioButton()
        Me.rbtnMaintain = New System.Windows.Forms.RadioButton()
        Me.rbtnLose = New System.Windows.Forms.RadioButton()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.rbtnInactive = New System.Windows.Forms.RadioButton()
        Me.rbtnSedentary = New System.Windows.Forms.RadioButton()
        Me.rbtnModerate = New System.Windows.Forms.RadioButton()
        Me.rbtnExtreme = New System.Windows.Forms.RadioButton()
        Me.rbtnVigorous = New System.Windows.Forms.RadioButton()
        Me.lblVHeight = New System.Windows.Forms.Label()
        Me.lblVWeight = New System.Windows.Forms.Label()
        Me.lblEmpty = New System.Windows.Forms.Label()
        Me.lblVBFP = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(263, 38)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(174, 36)
        Me.lblTitle.TabIndex = 3
        Me.lblTitle.Text = "Edit Details"
        '
        'lblGoal
        '
        Me.lblGoal.AutoSize = True
        Me.lblGoal.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGoal.Location = New System.Drawing.Point(77, 266)
        Me.lblGoal.Name = "lblGoal"
        Me.lblGoal.Size = New System.Drawing.Size(38, 16)
        Me.lblGoal.TabIndex = 42
        Me.lblGoal.Text = "Goal:"
        '
        'lblPAL
        '
        Me.lblPAL.AutoSize = True
        Me.lblPAL.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPAL.Location = New System.Drawing.Point(26, 228)
        Me.lblPAL.Name = "lblPAL"
        Me.lblPAL.Size = New System.Drawing.Size(150, 16)
        Me.lblPAL.TabIndex = 36
        Me.lblPAL.Text = "Level of physical activity:"
        '
        'lblBFP
        '
        Me.lblBFP.AutoSize = True
        Me.lblBFP.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBFP.Location = New System.Drawing.Point(26, 192)
        Me.lblBFP.Name = "lblBFP"
        Me.lblBFP.Size = New System.Drawing.Size(127, 16)
        Me.lblBFP.TabIndex = 35
        Me.lblBFP.Text = "Body fat percentage:"
        '
        'txtbxBFP
        '
        Me.txtbxBFP.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxBFP.Location = New System.Drawing.Point(294, 192)
        Me.txtbxBFP.Name = "txtbxBFP"
        Me.txtbxBFP.Size = New System.Drawing.Size(100, 22)
        Me.txtbxBFP.TabIndex = 2
        '
        'lblWeight
        '
        Me.lblWeight.AutoSize = True
        Me.lblWeight.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWeight.Location = New System.Drawing.Point(26, 150)
        Me.lblWeight.Name = "lblWeight"
        Me.lblWeight.Size = New System.Drawing.Size(84, 16)
        Me.lblWeight.TabIndex = 33
        Me.lblWeight.Text = "Weight in kg:"
        '
        'txtbxWeight
        '
        Me.txtbxWeight.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxWeight.Location = New System.Drawing.Point(294, 150)
        Me.txtbxWeight.Name = "txtbxWeight"
        Me.txtbxWeight.Size = New System.Drawing.Size(100, 22)
        Me.txtbxWeight.TabIndex = 1
        '
        'lblHeight
        '
        Me.lblHeight.AutoSize = True
        Me.lblHeight.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeight.Location = New System.Drawing.Point(26, 113)
        Me.lblHeight.Name = "lblHeight"
        Me.lblHeight.Size = New System.Drawing.Size(84, 16)
        Me.lblHeight.TabIndex = 31
        Me.lblHeight.Text = "Height in cm:"
        '
        'txtbxHeight
        '
        Me.txtbxHeight.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxHeight.Location = New System.Drawing.Point(294, 113)
        Me.txtbxHeight.Name = "txtbxHeight"
        Me.txtbxHeight.Size = New System.Drawing.Size(100, 22)
        Me.txtbxHeight.TabIndex = 0
        '
        'btnConfirm
        '
        Me.btnConfirm.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfirm.Location = New System.Drawing.Point(310, 329)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(96, 46)
        Me.btnConfirm.TabIndex = 11
        Me.btnConfirm.Text = "Confirm"
        Me.btnConfirm.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(29, 38)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(84, 36)
        Me.btnBack.TabIndex = 12
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Panel1.Controls.Add(Me.rbtnGain)
        Me.Panel1.Controls.Add(Me.rbtnMaintain)
        Me.Panel1.Controls.Add(Me.rbtnLose)
        Me.Panel1.Location = New System.Drawing.Point(177, 262)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(292, 27)
        Me.Panel1.TabIndex = 48
        '
        'rbtnGain
        '
        Me.rbtnGain.AutoSize = True
        Me.rbtnGain.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtnGain.Location = New System.Drawing.Point(8, 4)
        Me.rbtnGain.Name = "rbtnGain"
        Me.rbtnGain.Size = New System.Drawing.Size(52, 20)
        Me.rbtnGain.TabIndex = 8
        Me.rbtnGain.TabStop = True
        Me.rbtnGain.Text = "Gain"
        Me.rbtnGain.UseVisualStyleBackColor = True
        '
        'rbtnMaintain
        '
        Me.rbtnMaintain.AutoSize = True
        Me.rbtnMaintain.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtnMaintain.Location = New System.Drawing.Point(118, 3)
        Me.rbtnMaintain.Name = "rbtnMaintain"
        Me.rbtnMaintain.Size = New System.Drawing.Size(74, 20)
        Me.rbtnMaintain.TabIndex = 9
        Me.rbtnMaintain.TabStop = True
        Me.rbtnMaintain.Text = "Maintain"
        Me.rbtnMaintain.UseVisualStyleBackColor = True
        '
        'rbtnLose
        '
        Me.rbtnLose.AutoSize = True
        Me.rbtnLose.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtnLose.Location = New System.Drawing.Point(231, 4)
        Me.rbtnLose.Name = "rbtnLose"
        Me.rbtnLose.Size = New System.Drawing.Size(53, 20)
        Me.rbtnLose.TabIndex = 10
        Me.rbtnLose.TabStop = True
        Me.rbtnLose.Text = "Lose"
        Me.rbtnLose.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Panel2.Controls.Add(Me.rbtnInactive)
        Me.Panel2.Controls.Add(Me.rbtnSedentary)
        Me.Panel2.Controls.Add(Me.rbtnModerate)
        Me.Panel2.Controls.Add(Me.rbtnExtreme)
        Me.Panel2.Controls.Add(Me.rbtnVigorous)
        Me.Panel2.Location = New System.Drawing.Point(179, 222)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(613, 32)
        Me.Panel2.TabIndex = 49
        '
        'rbtnInactive
        '
        Me.rbtnInactive.AutoSize = True
        Me.rbtnInactive.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtnInactive.Location = New System.Drawing.Point(3, 6)
        Me.rbtnInactive.Name = "rbtnInactive"
        Me.rbtnInactive.Size = New System.Drawing.Size(131, 20)
        Me.rbtnInactive.TabIndex = 3
        Me.rbtnInactive.TabStop = True
        Me.rbtnInactive.Text = "Extremely inactive"
        Me.rbtnInactive.UseVisualStyleBackColor = True
        '
        'rbtnSedentary
        '
        Me.rbtnSedentary.AutoSize = True
        Me.rbtnSedentary.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtnSedentary.Location = New System.Drawing.Point(136, 6)
        Me.rbtnSedentary.Name = "rbtnSedentary"
        Me.rbtnSedentary.Size = New System.Drawing.Size(84, 20)
        Me.rbtnSedentary.TabIndex = 4
        Me.rbtnSedentary.TabStop = True
        Me.rbtnSedentary.Text = "Sedentary"
        Me.rbtnSedentary.UseVisualStyleBackColor = True
        '
        'rbtnModerate
        '
        Me.rbtnModerate.AutoSize = True
        Me.rbtnModerate.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtnModerate.Location = New System.Drawing.Point(226, 6)
        Me.rbtnModerate.Name = "rbtnModerate"
        Me.rbtnModerate.Size = New System.Drawing.Size(126, 20)
        Me.rbtnModerate.TabIndex = 5
        Me.rbtnModerate.TabStop = True
        Me.rbtnModerate.Text = "Moderately active"
        Me.rbtnModerate.UseVisualStyleBackColor = True
        '
        'rbtnExtreme
        '
        Me.rbtnExtreme.AutoSize = True
        Me.rbtnExtreme.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtnExtreme.Location = New System.Drawing.Point(487, 6)
        Me.rbtnExtreme.Name = "rbtnExtreme"
        Me.rbtnExtreme.Size = New System.Drawing.Size(121, 20)
        Me.rbtnExtreme.TabIndex = 7
        Me.rbtnExtreme.TabStop = True
        Me.rbtnExtreme.Text = "Extremely active"
        Me.rbtnExtreme.UseVisualStyleBackColor = True
        '
        'rbtnVigorous
        '
        Me.rbtnVigorous.AutoSize = True
        Me.rbtnVigorous.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtnVigorous.Location = New System.Drawing.Point(358, 6)
        Me.rbtnVigorous.Name = "rbtnVigorous"
        Me.rbtnVigorous.Size = New System.Drawing.Size(123, 20)
        Me.rbtnVigorous.TabIndex = 6
        Me.rbtnVigorous.TabStop = True
        Me.rbtnVigorous.Text = "Vigorously active"
        Me.rbtnVigorous.UseVisualStyleBackColor = True
        '
        'lblVHeight
        '
        Me.lblVHeight.AutoSize = True
        Me.lblVHeight.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVHeight.ForeColor = System.Drawing.Color.Red
        Me.lblVHeight.Location = New System.Drawing.Point(441, 113)
        Me.lblVHeight.Name = "lblVHeight"
        Me.lblVHeight.Size = New System.Drawing.Size(117, 16)
        Me.lblVHeight.TabIndex = 52
        Me.lblVHeight.Text = "Enter a valid height"
        Me.lblVHeight.Visible = False
        '
        'lblVWeight
        '
        Me.lblVWeight.AutoSize = True
        Me.lblVWeight.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVWeight.ForeColor = System.Drawing.Color.Red
        Me.lblVWeight.Location = New System.Drawing.Point(441, 153)
        Me.lblVWeight.Name = "lblVWeight"
        Me.lblVWeight.Size = New System.Drawing.Size(119, 16)
        Me.lblVWeight.TabIndex = 51
        Me.lblVWeight.Text = "Enter a valid weight"
        Me.lblVWeight.Visible = False
        '
        'lblEmpty
        '
        Me.lblEmpty.AutoSize = True
        Me.lblEmpty.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmpty.ForeColor = System.Drawing.Color.Red
        Me.lblEmpty.Location = New System.Drawing.Point(286, 84)
        Me.lblEmpty.Name = "lblEmpty"
        Me.lblEmpty.Size = New System.Drawing.Size(120, 16)
        Me.lblEmpty.TabIndex = 53
        Me.lblEmpty.Text = "Fill out empty fields"
        Me.lblEmpty.Visible = False
        '
        'lblVBFP
        '
        Me.lblVBFP.AutoSize = True
        Me.lblVBFP.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVBFP.ForeColor = System.Drawing.Color.Red
        Me.lblVBFP.Location = New System.Drawing.Point(441, 192)
        Me.lblVBFP.Name = "lblVBFP"
        Me.lblVBFP.Size = New System.Drawing.Size(108, 16)
        Me.lblVBFP.TabIndex = 54
        Me.lblVBFP.Text = "Enter a valid BFP"
        Me.lblVBFP.Visible = False
        '
        'DetailEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(791, 391)
        Me.Controls.Add(Me.lblVBFP)
        Me.Controls.Add(Me.lblEmpty)
        Me.Controls.Add(Me.lblVHeight)
        Me.Controls.Add(Me.lblVWeight)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnConfirm)
        Me.Controls.Add(Me.lblGoal)
        Me.Controls.Add(Me.lblPAL)
        Me.Controls.Add(Me.lblBFP)
        Me.Controls.Add(Me.txtbxBFP)
        Me.Controls.Add(Me.lblWeight)
        Me.Controls.Add(Me.txtbxWeight)
        Me.Controls.Add(Me.lblHeight)
        Me.Controls.Add(Me.txtbxHeight)
        Me.Controls.Add(Me.lblTitle)
        Me.Name = "DetailEdit"
        Me.Text = "Detail Edit"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents lblGoal As Label
    Friend WithEvents lblPAL As Label
    Friend WithEvents lblBFP As Label
    Friend WithEvents txtbxBFP As TextBox
    Friend WithEvents lblWeight As Label
    Friend WithEvents txtbxWeight As TextBox
    Friend WithEvents lblHeight As Label
    Friend WithEvents txtbxHeight As TextBox
    Friend WithEvents btnConfirm As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents rbtnGain As RadioButton
    Friend WithEvents rbtnMaintain As RadioButton
    Friend WithEvents rbtnLose As RadioButton
    Friend WithEvents Panel2 As Panel
    Friend WithEvents rbtnInactive As RadioButton
    Friend WithEvents rbtnSedentary As RadioButton
    Friend WithEvents rbtnModerate As RadioButton
    Friend WithEvents rbtnExtreme As RadioButton
    Friend WithEvents rbtnVigorous As RadioButton
    Friend WithEvents lblVHeight As Label
    Friend WithEvents lblVWeight As Label
    Friend WithEvents lblEmpty As Label
    Friend WithEvents lblVBFP As Label
End Class
