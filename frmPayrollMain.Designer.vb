<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPayrollMain
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
        Me.btnSalariedEmployee = New System.Windows.Forms.Button()
        Me.btnHourlyEmployee = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnDailyTotals = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.StatusToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalariedToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HourlyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DailyTotalsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnSalariedEmployee
        '
        Me.btnSalariedEmployee.Location = New System.Drawing.Point(40, 36)
        Me.btnSalariedEmployee.Name = "btnSalariedEmployee"
        Me.btnSalariedEmployee.Size = New System.Drawing.Size(259, 72)
        Me.btnSalariedEmployee.TabIndex = 0
        Me.btnSalariedEmployee.Text = "Salaried Employee"
        Me.btnSalariedEmployee.UseVisualStyleBackColor = True
        '
        'btnHourlyEmployee
        '
        Me.btnHourlyEmployee.Location = New System.Drawing.Point(40, 152)
        Me.btnHourlyEmployee.Name = "btnHourlyEmployee"
        Me.btnHourlyEmployee.Size = New System.Drawing.Size(259, 72)
        Me.btnHourlyEmployee.TabIndex = 1
        Me.btnHourlyEmployee.Text = "Hourly Employee"
        Me.btnHourlyEmployee.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnHourlyEmployee)
        Me.GroupBox1.Controls.Add(Me.btnSalariedEmployee)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(35, 57)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(339, 268)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Employee Status"
        '
        'btnDailyTotals
        '
        Me.btnDailyTotals.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDailyTotals.Location = New System.Drawing.Point(35, 379)
        Me.btnDailyTotals.Name = "btnDailyTotals"
        Me.btnDailyTotals.Size = New System.Drawing.Size(138, 43)
        Me.btnDailyTotals.TabIndex = 3
        Me.btnDailyTotals.Text = "Daily Totals"
        Me.btnDailyTotals.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(236, 379)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(138, 43)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StatusToolStripMenuItem, Me.DailyTotalsToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(404, 33)
        Me.MenuStrip1.TabIndex = 5
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'StatusToolStripMenuItem
        '
        Me.StatusToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SalariedToolStripMenuItem, Me.HourlyToolStripMenuItem})
        Me.StatusToolStripMenuItem.Name = "StatusToolStripMenuItem"
        Me.StatusToolStripMenuItem.Size = New System.Drawing.Size(76, 29)
        Me.StatusToolStripMenuItem.Text = "Status"
        '
        'SalariedToolStripMenuItem
        '
        Me.SalariedToolStripMenuItem.Name = "SalariedToolStripMenuItem"
        Me.SalariedToolStripMenuItem.Size = New System.Drawing.Size(270, 34)
        Me.SalariedToolStripMenuItem.Text = "Salaried"
        '
        'HourlyToolStripMenuItem
        '
        Me.HourlyToolStripMenuItem.Name = "HourlyToolStripMenuItem"
        Me.HourlyToolStripMenuItem.Size = New System.Drawing.Size(270, 34)
        Me.HourlyToolStripMenuItem.Text = "Hourly"
        '
        'DailyTotalsToolStripMenuItem
        '
        Me.DailyTotalsToolStripMenuItem.Name = "DailyTotalsToolStripMenuItem"
        Me.DailyTotalsToolStripMenuItem.Size = New System.Drawing.Size(117, 29)
        Me.DailyTotalsToolStripMenuItem.Text = "Daily Totals"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(55, 29)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'frmPayrollMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(404, 450)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnDailyTotals)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmPayrollMain"
        Me.Text = "LSLC Payroll"
        Me.GroupBox1.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSalariedEmployee As Button
    Friend WithEvents btnHourlyEmployee As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnDailyTotals As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents StatusToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalariedToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HourlyToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DailyTotalsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
End Class
