<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FoodLog2
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
        Me.lblAmount = New System.Windows.Forms.Label()
        Me.lblServe = New System.Windows.Forms.Label()
        Me.txtbxServes = New System.Windows.Forms.TextBox()
        Me.lblCalShow = New System.Windows.Forms.Label()
        Me.lblCals = New System.Windows.Forms.Label()
        Me.lblCarbs = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblProteins = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblFats = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblOr = New System.Windows.Forms.Label()
        Me.txtbxGrams = New System.Windows.Forms.TextBox()
        Me.lblUnits = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.btnLog = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.rbtnBreakfast = New System.Windows.Forms.RadioButton()
        Me.rbtnLunch = New System.Windows.Forms.RadioButton()
        Me.rbtnDinner = New System.Windows.Forms.RadioButton()
        Me.rbtnMorning = New System.Windows.Forms.RadioButton()
        Me.rbtnAfternoon = New System.Windows.Forms.RadioButton()
        Me.rbtnEvening = New System.Windows.Forms.RadioButton()
        Me.lblSnack = New System.Windows.Forms.Label()
        Me.dtpDate = New System.Windows.Forms.DateTimePicker()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblEmpty = New System.Windows.Forms.Label()
        Me.lblVAmount = New System.Windows.Forms.Label()
        Me.lblVDate = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblAmount
        '
        Me.lblAmount.AutoSize = True
        Me.lblAmount.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAmount.Location = New System.Drawing.Point(23, 101)
        Me.lblAmount.Name = "lblAmount"
        Me.lblAmount.Size = New System.Drawing.Size(56, 16)
        Me.lblAmount.TabIndex = 0
        Me.lblAmount.Text = "Amount:"
        '
        'lblServe
        '
        Me.lblServe.AutoSize = True
        Me.lblServe.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblServe.Location = New System.Drawing.Point(267, 101)
        Me.lblServe.Name = "lblServe"
        Me.lblServe.Size = New System.Drawing.Size(44, 16)
        Me.lblServe.TabIndex = 1
        Me.lblServe.Text = "serves"
        '
        'txtbxServes
        '
        Me.txtbxServes.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxServes.Location = New System.Drawing.Point(122, 101)
        Me.txtbxServes.Name = "txtbxServes"
        Me.txtbxServes.Size = New System.Drawing.Size(100, 22)
        Me.txtbxServes.TabIndex = 0
        '
        'lblCalShow
        '
        Me.lblCalShow.AutoSize = True
        Me.lblCalShow.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCalShow.Location = New System.Drawing.Point(187, 137)
        Me.lblCalShow.Name = "lblCalShow"
        Me.lblCalShow.Size = New System.Drawing.Size(54, 16)
        Me.lblCalShow.TabIndex = 3
        Me.lblCalShow.Text = "Calories"
        '
        'lblCals
        '
        Me.lblCals.AutoSize = True
        Me.lblCals.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCals.Location = New System.Drawing.Point(381, 137)
        Me.lblCals.Name = "lblCals"
        Me.lblCals.Size = New System.Drawing.Size(14, 16)
        Me.lblCals.TabIndex = 4
        Me.lblCals.Text = "0"
        '
        'lblCarbs
        '
        Me.lblCarbs.AutoSize = True
        Me.lblCarbs.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCarbs.Location = New System.Drawing.Point(381, 177)
        Me.lblCarbs.Name = "lblCarbs"
        Me.lblCarbs.Size = New System.Drawing.Size(14, 16)
        Me.lblCarbs.TabIndex = 6
        Me.lblCarbs.Text = "0"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(187, 177)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(110, 16)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Carbohydrates (g)"
        '
        'lblProteins
        '
        Me.lblProteins.AutoSize = True
        Me.lblProteins.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProteins.Location = New System.Drawing.Point(381, 214)
        Me.lblProteins.Name = "lblProteins"
        Me.lblProteins.Size = New System.Drawing.Size(14, 16)
        Me.lblProteins.TabIndex = 8
        Me.lblProteins.Text = "0"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(187, 214)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 16)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Proteins (g)"
        '
        'lblFats
        '
        Me.lblFats.AutoSize = True
        Me.lblFats.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFats.Location = New System.Drawing.Point(381, 249)
        Me.lblFats.Name = "lblFats"
        Me.lblFats.Size = New System.Drawing.Size(14, 16)
        Me.lblFats.TabIndex = 10
        Me.lblFats.Text = "0"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(187, 249)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(52, 16)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "Fats (g)"
        '
        'lblOr
        '
        Me.lblOr.AutoSize = True
        Me.lblOr.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOr.Location = New System.Drawing.Point(367, 101)
        Me.lblOr.Name = "lblOr"
        Me.lblOr.Size = New System.Drawing.Size(26, 16)
        Me.lblOr.TabIndex = 11
        Me.lblOr.Text = "or: "
        '
        'txtbxGrams
        '
        Me.txtbxGrams.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxGrams.Location = New System.Drawing.Point(443, 98)
        Me.txtbxGrams.Name = "txtbxGrams"
        Me.txtbxGrams.Size = New System.Drawing.Size(100, 22)
        Me.txtbxGrams.TabIndex = 1
        '
        'lblUnits
        '
        Me.lblUnits.AutoSize = True
        Me.lblUnits.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUnits.Location = New System.Drawing.Point(601, 101)
        Me.lblUnits.Name = "lblUnits"
        Me.lblUnits.Size = New System.Drawing.Size(14, 16)
        Me.lblUnits.TabIndex = 13
        Me.lblUnits.Text = "g"
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(193, 23)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(227, 36)
        Me.lblTitle.TabIndex = 14
        Me.lblTitle.Text = "[FOOD NAME]"
        '
        'btnLog
        '
        Me.btnLog.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLog.Location = New System.Drawing.Point(374, 395)
        Me.btnLog.Name = "btnLog"
        Me.btnLog.Size = New System.Drawing.Size(107, 46)
        Me.btnLog.TabIndex = 9
        Me.btnLog.Text = "Log Food"
        Me.btnLog.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(154, 395)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(107, 46)
        Me.btnCancel.TabIndex = 10
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.Location = New System.Drawing.Point(151, 323)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(43, 16)
        Me.lblTime.TabIndex = 17
        Me.lblTime.Text = "Meal: "
        '
        'rbtnBreakfast
        '
        Me.rbtnBreakfast.AutoSize = True
        Me.rbtnBreakfast.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtnBreakfast.Location = New System.Drawing.Point(216, 321)
        Me.rbtnBreakfast.Name = "rbtnBreakfast"
        Me.rbtnBreakfast.Size = New System.Drawing.Size(80, 20)
        Me.rbtnBreakfast.TabIndex = 3
        Me.rbtnBreakfast.TabStop = True
        Me.rbtnBreakfast.Text = "Breakfast"
        Me.rbtnBreakfast.UseVisualStyleBackColor = True
        '
        'rbtnLunch
        '
        Me.rbtnLunch.AutoSize = True
        Me.rbtnLunch.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtnLunch.Location = New System.Drawing.Point(328, 321)
        Me.rbtnLunch.Name = "rbtnLunch"
        Me.rbtnLunch.Size = New System.Drawing.Size(60, 20)
        Me.rbtnLunch.TabIndex = 4
        Me.rbtnLunch.TabStop = True
        Me.rbtnLunch.Text = "Lunch"
        Me.rbtnLunch.UseVisualStyleBackColor = True
        '
        'rbtnDinner
        '
        Me.rbtnDinner.AutoSize = True
        Me.rbtnDinner.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtnDinner.Location = New System.Drawing.Point(440, 321)
        Me.rbtnDinner.Name = "rbtnDinner"
        Me.rbtnDinner.Size = New System.Drawing.Size(62, 20)
        Me.rbtnDinner.TabIndex = 5
        Me.rbtnDinner.TabStop = True
        Me.rbtnDinner.Text = "Dinner"
        Me.rbtnDinner.UseVisualStyleBackColor = True
        '
        'rbtnMorning
        '
        Me.rbtnMorning.AutoSize = True
        Me.rbtnMorning.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtnMorning.Location = New System.Drawing.Point(216, 354)
        Me.rbtnMorning.Name = "rbtnMorning"
        Me.rbtnMorning.Size = New System.Drawing.Size(71, 20)
        Me.rbtnMorning.TabIndex = 6
        Me.rbtnMorning.TabStop = True
        Me.rbtnMorning.Text = "Morning"
        Me.rbtnMorning.UseVisualStyleBackColor = True
        '
        'rbtnAfternoon
        '
        Me.rbtnAfternoon.AutoSize = True
        Me.rbtnAfternoon.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtnAfternoon.Location = New System.Drawing.Point(328, 354)
        Me.rbtnAfternoon.Name = "rbtnAfternoon"
        Me.rbtnAfternoon.Size = New System.Drawing.Size(80, 20)
        Me.rbtnAfternoon.TabIndex = 7
        Me.rbtnAfternoon.TabStop = True
        Me.rbtnAfternoon.Text = "Afternoon"
        Me.rbtnAfternoon.UseVisualStyleBackColor = True
        '
        'rbtnEvening
        '
        Me.rbtnEvening.AutoSize = True
        Me.rbtnEvening.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtnEvening.Location = New System.Drawing.Point(440, 354)
        Me.rbtnEvening.Name = "rbtnEvening"
        Me.rbtnEvening.Size = New System.Drawing.Size(70, 20)
        Me.rbtnEvening.TabIndex = 8
        Me.rbtnEvening.TabStop = True
        Me.rbtnEvening.Text = "Evening"
        Me.rbtnEvening.UseVisualStyleBackColor = True
        '
        'lblSnack
        '
        Me.lblSnack.AutoSize = True
        Me.lblSnack.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSnack.Location = New System.Drawing.Point(151, 358)
        Me.lblSnack.Name = "lblSnack"
        Me.lblSnack.Size = New System.Drawing.Size(48, 16)
        Me.lblSnack.TabIndex = 24
        Me.lblSnack.Text = "Snack:"
        '
        'dtpDate
        '
        Me.dtpDate.Location = New System.Drawing.Point(199, 284)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Size = New System.Drawing.Size(200, 20)
        Me.dtpDate.TabIndex = 2
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.Location = New System.Drawing.Point(137, 287)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(38, 16)
        Me.lblDate.TabIndex = 37
        Me.lblDate.Text = "Date:"
        '
        'lblEmpty
        '
        Me.lblEmpty.AutoSize = True
        Me.lblEmpty.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmpty.ForeColor = System.Drawing.Color.Red
        Me.lblEmpty.Location = New System.Drawing.Point(244, 69)
        Me.lblEmpty.Name = "lblEmpty"
        Me.lblEmpty.Size = New System.Drawing.Size(120, 16)
        Me.lblEmpty.TabIndex = 34
        Me.lblEmpty.Text = "Fill out empty fields"
        Me.lblEmpty.Visible = False
        '
        'lblVAmount
        '
        Me.lblVAmount.AutoSize = True
        Me.lblVAmount.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVAmount.ForeColor = System.Drawing.Color.Red
        Me.lblVAmount.Location = New System.Drawing.Point(244, 69)
        Me.lblVAmount.Name = "lblVAmount"
        Me.lblVAmount.Size = New System.Drawing.Size(125, 16)
        Me.lblVAmount.TabIndex = 35
        Me.lblVAmount.Text = "Enter a valid amount"
        Me.lblVAmount.Visible = False
        '
        'lblVDate
        '
        Me.lblVDate.AutoSize = True
        Me.lblVDate.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVDate.ForeColor = System.Drawing.Color.Red
        Me.lblVDate.Location = New System.Drawing.Point(450, 284)
        Me.lblVDate.Name = "lblVDate"
        Me.lblVDate.Size = New System.Drawing.Size(107, 16)
        Me.lblVDate.TabIndex = 38
        Me.lblVDate.Text = "Enter a valid date"
        Me.lblVDate.Visible = False
        '
        'FoodLog2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(663, 460)
        Me.Controls.Add(Me.lblVDate)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.dtpDate)
        Me.Controls.Add(Me.lblVAmount)
        Me.Controls.Add(Me.lblEmpty)
        Me.Controls.Add(Me.lblSnack)
        Me.Controls.Add(Me.rbtnEvening)
        Me.Controls.Add(Me.rbtnAfternoon)
        Me.Controls.Add(Me.rbtnMorning)
        Me.Controls.Add(Me.rbtnDinner)
        Me.Controls.Add(Me.rbtnLunch)
        Me.Controls.Add(Me.rbtnBreakfast)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnLog)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.lblUnits)
        Me.Controls.Add(Me.txtbxGrams)
        Me.Controls.Add(Me.lblOr)
        Me.Controls.Add(Me.lblFats)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.lblProteins)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lblCarbs)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblCals)
        Me.Controls.Add(Me.lblCalShow)
        Me.Controls.Add(Me.txtbxServes)
        Me.Controls.Add(Me.lblServe)
        Me.Controls.Add(Me.lblAmount)
        Me.Name = "FoodLog2"
        Me.Text = "Food Log"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblAmount As Label
    Friend WithEvents lblServe As Label
    Friend WithEvents txtbxServes As TextBox
    Friend WithEvents lblCalShow As Label
    Friend WithEvents lblCals As Label
    Friend WithEvents lblCarbs As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblProteins As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lblFats As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents lblOr As Label
    Friend WithEvents txtbxGrams As TextBox
    Friend WithEvents lblUnits As Label
    Friend WithEvents lblTitle As Label
    Friend WithEvents btnLog As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents lblTime As Label
    Friend WithEvents rbtnBreakfast As RadioButton
    Friend WithEvents rbtnLunch As RadioButton
    Friend WithEvents rbtnDinner As RadioButton
    Friend WithEvents rbtnMorning As RadioButton
    Friend WithEvents rbtnAfternoon As RadioButton
    Friend WithEvents rbtnEvening As RadioButton
    Friend WithEvents lblSnack As Label
    Friend WithEvents dtpDate As DateTimePicker
    Friend WithEvents lblDate As Label
    Friend WithEvents lblEmpty As Label
    Friend WithEvents lblVAmount As Label
    Friend WithEvents lblVDate As Label
End Class
