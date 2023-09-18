<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AGroupView2
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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.chrtView = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnPrev = New System.Windows.Forms.Button()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.lblFats = New System.Windows.Forms.Label()
        Me.lblProtein = New System.Windows.Forms.Label()
        Me.lblCarbs = New System.Windows.Forms.Label()
        Me.lblCals = New System.Windows.Forms.Label()
        CType(Me.chrtView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'chrtView
        '
        ChartArea1.Name = "ChartArea1"
        Me.chrtView.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.chrtView.Legends.Add(Legend1)
        Me.chrtView.Location = New System.Drawing.Point(87, 184)
        Me.chrtView.Name = "chrtView"
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Me.chrtView.Series.Add(Series1)
        Me.chrtView.Size = New System.Drawing.Size(617, 259)
        Me.chrtView.TabIndex = 58
        Me.chrtView.Text = "Chart1"
        '
        'btnBack
        '
        Me.btnBack.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(27, 24)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(84, 36)
        Me.btnBack.TabIndex = 2
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNext.Location = New System.Drawing.Point(510, 66)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(82, 30)
        Me.btnNext.TabIndex = 1
        Me.btnNext.Text = "-->"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'btnPrev
        '
        Me.btnPrev.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrev.Location = New System.Drawing.Point(183, 66)
        Me.btnPrev.Name = "btnPrev"
        Me.btnPrev.Size = New System.Drawing.Size(82, 30)
        Me.btnPrev.TabIndex = 0
        Me.btnPrev.Text = "<--"
        Me.btnPrev.UseVisualStyleBackColor = True
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.Location = New System.Drawing.Point(267, 68)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(116, 24)
        Me.lblTime.TabIndex = 60
        Me.lblTime.Text = "Month Year"
        '
        'lblFats
        '
        Me.lblFats.AutoSize = True
        Me.lblFats.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFats.Location = New System.Drawing.Point(429, 117)
        Me.lblFats.Name = "lblFats"
        Me.lblFats.Size = New System.Drawing.Size(107, 16)
        Me.lblFats.TabIndex = 66
        Me.lblFats.Text = "Average fats: 78g"
        '
        'lblProtein
        '
        Me.lblProtein.AutoSize = True
        Me.lblProtein.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProtein.Location = New System.Drawing.Point(429, 161)
        Me.lblProtein.Name = "lblProtein"
        Me.lblProtein.Size = New System.Drawing.Size(139, 16)
        Me.lblProtein.TabIndex = 65
        Me.lblProtein.Text = "Average proteins: 180g"
        '
        'lblCarbs
        '
        Me.lblCarbs.AutoSize = True
        Me.lblCarbs.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCarbs.Location = New System.Drawing.Point(230, 161)
        Me.lblCarbs.Name = "lblCarbs"
        Me.lblCarbs.Size = New System.Drawing.Size(179, 16)
        Me.lblCarbs.TabIndex = 64
        Me.lblCarbs.Text = "Average carbohydrates: 285g "
        '
        'lblCals
        '
        Me.lblCals.AutoSize = True
        Me.lblCals.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCals.Location = New System.Drawing.Point(230, 117)
        Me.lblCals.Name = "lblCals"
        Me.lblCals.Size = New System.Drawing.Size(117, 16)
        Me.lblCals.TabIndex = 63
        Me.lblCals.Text = "Average cals: 2806"
        '
        'AGroupView2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblFats)
        Me.Controls.Add(Me.lblProtein)
        Me.Controls.Add(Me.lblCarbs)
        Me.Controls.Add(Me.lblCals)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnPrev)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.chrtView)
        Me.Name = "AGroupView2"
        Me.Text = "[TIMEBASE] View"
        CType(Me.chrtView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents chrtView As DataVisualization.Charting.Chart
    Friend WithEvents btnBack As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents btnPrev As Button
    Friend WithEvents lblTime As Label
    Friend WithEvents lblFats As Label
    Friend WithEvents lblProtein As Label
    Friend WithEvents lblCarbs As Label
    Friend WithEvents lblCals As Label
End Class
