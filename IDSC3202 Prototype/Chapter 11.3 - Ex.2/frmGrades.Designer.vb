<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGrades
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
        Me.lblName = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.lblSSN = New System.Windows.Forms.Label()
        Me.mtbSSN = New System.Windows.Forms.MaskedTextBox()
        Me.lblMidterm = New System.Windows.Forms.Label()
        Me.txtMidterm = New System.Windows.Forms.TextBox()
        Me.lblFinal = New System.Windows.Forms.Label()
        Me.txtFinal = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rad1099 = New System.Windows.Forms.RadioButton()
        Me.radW2 = New System.Windows.Forms.RadioButton()
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.btnDisplay = New System.Windows.Forms.Button()
        Me.Quit = New System.Windows.Forms.Button()
        Me.dgvGrades = New System.Windows.Forms.DataGridView()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvGrades, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(13, 33)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(38, 13)
        Me.lblName.TabIndex = 0
        Me.lblName.Text = "Name:"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(70, 33)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(141, 20)
        Me.txtName.TabIndex = 1
        '
        'lblSSN
        '
        Me.lblSSN.AutoSize = True
        Me.lblSSN.Location = New System.Drawing.Point(13, 72)
        Me.lblSSN.Name = "lblSSN"
        Me.lblSSN.Size = New System.Drawing.Size(32, 13)
        Me.lblSSN.TabIndex = 2
        Me.lblSSN.Text = "SSN:"
        '
        'mtbSSN
        '
        Me.mtbSSN.Location = New System.Drawing.Point(70, 72)
        Me.mtbSSN.Mask = "000-00-0000"
        Me.mtbSSN.Name = "mtbSSN"
        Me.mtbSSN.Size = New System.Drawing.Size(100, 20)
        Me.mtbSSN.TabIndex = 3
        '
        'lblMidterm
        '
        Me.lblMidterm.AutoSize = True
        Me.lblMidterm.Location = New System.Drawing.Point(177, 78)
        Me.lblMidterm.Name = "lblMidterm"
        Me.lblMidterm.Size = New System.Drawing.Size(47, 13)
        Me.lblMidterm.TabIndex = 4
        Me.lblMidterm.Text = "Midterm:"
        '
        'txtMidterm
        '
        Me.txtMidterm.Location = New System.Drawing.Point(231, 71)
        Me.txtMidterm.Name = "txtMidterm"
        Me.txtMidterm.Size = New System.Drawing.Size(100, 20)
        Me.txtMidterm.TabIndex = 5
        '
        'lblFinal
        '
        Me.lblFinal.AutoSize = True
        Me.lblFinal.Location = New System.Drawing.Point(180, 106)
        Me.lblFinal.Name = "lblFinal"
        Me.lblFinal.Size = New System.Drawing.Size(32, 13)
        Me.lblFinal.TabIndex = 6
        Me.lblFinal.Text = "Final:"
        '
        'txtFinal
        '
        Me.txtFinal.Location = New System.Drawing.Point(231, 106)
        Me.txtFinal.Name = "txtFinal"
        Me.txtFinal.Size = New System.Drawing.Size(100, 20)
        Me.txtFinal.TabIndex = 7
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rad1099)
        Me.GroupBox1.Controls.Add(Me.radW2)
        Me.GroupBox1.Location = New System.Drawing.Point(33, 150)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(191, 51)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Forms:"
        '
        'rad1099
        '
        Me.rad1099.AutoSize = True
        Me.rad1099.Location = New System.Drawing.Point(97, 20)
        Me.rad1099.Name = "rad1099"
        Me.rad1099.Size = New System.Drawing.Size(49, 17)
        Me.rad1099.TabIndex = 1
        Me.rad1099.TabStop = True
        Me.rad1099.Text = "1099"
        Me.rad1099.UseVisualStyleBackColor = True
        '
        'radW2
        '
        Me.radW2.AutoSize = True
        Me.radW2.Checked = True
        Me.radW2.Location = New System.Drawing.Point(7, 20)
        Me.radW2.Name = "radW2"
        Me.radW2.Size = New System.Drawing.Size(42, 17)
        Me.radW2.TabIndex = 0
        Me.radW2.TabStop = True
        Me.radW2.Text = "W2"
        Me.radW2.UseVisualStyleBackColor = True
        '
        'btnEnter
        '
        Me.btnEnter.Location = New System.Drawing.Point(16, 222)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(75, 23)
        Me.btnEnter.TabIndex = 9
        Me.btnEnter.Text = "Enter Information"
        Me.btnEnter.UseVisualStyleBackColor = True
        '
        'btnDisplay
        '
        Me.btnDisplay.Location = New System.Drawing.Point(130, 221)
        Me.btnDisplay.Name = "btnDisplay"
        Me.btnDisplay.Size = New System.Drawing.Size(94, 23)
        Me.btnDisplay.TabIndex = 10
        Me.btnDisplay.Text = "Display Grades"
        Me.btnDisplay.UseVisualStyleBackColor = True
        '
        'Quit
        '
        Me.Quit.Location = New System.Drawing.Point(263, 220)
        Me.Quit.Name = "Quit"
        Me.Quit.Size = New System.Drawing.Size(75, 23)
        Me.Quit.TabIndex = 11
        Me.Quit.Text = "Quit"
        Me.Quit.UseVisualStyleBackColor = True
        '
        'dgvGrades
        '
        Me.dgvGrades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvGrades.Location = New System.Drawing.Point(33, 267)
        Me.dgvGrades.Name = "dgvGrades"
        Me.dgvGrades.Size = New System.Drawing.Size(298, 85)
        Me.dgvGrades.TabIndex = 12
        '
        'frmGrades
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(437, 364)
        Me.Controls.Add(Me.dgvGrades)
        Me.Controls.Add(Me.Quit)
        Me.Controls.Add(Me.btnDisplay)
        Me.Controls.Add(Me.btnEnter)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtFinal)
        Me.Controls.Add(Me.lblFinal)
        Me.Controls.Add(Me.txtMidterm)
        Me.Controls.Add(Me.lblMidterm)
        Me.Controls.Add(Me.mtbSSN)
        Me.Controls.Add(Me.lblSSN)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.lblName)
        Me.Name = "frmGrades"
        Me.Text = "Semester Grades"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvGrades, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents lblSSN As System.Windows.Forms.Label
    Friend WithEvents mtbSSN As System.Windows.Forms.MaskedTextBox
    Friend WithEvents lblMidterm As System.Windows.Forms.Label
    Friend WithEvents txtMidterm As System.Windows.Forms.TextBox
    Friend WithEvents lblFinal As System.Windows.Forms.Label
    Friend WithEvents txtFinal As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rad1099 As System.Windows.Forms.RadioButton
    Friend WithEvents radW2 As System.Windows.Forms.RadioButton
    Friend WithEvents btnEnter As System.Windows.Forms.Button
    Friend WithEvents btnDisplay As System.Windows.Forms.Button
    Friend WithEvents Quit As System.Windows.Forms.Button
    Friend WithEvents dgvGrades As System.Windows.Forms.DataGridView

End Class
