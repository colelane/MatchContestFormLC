<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MathContestForm
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
        Me.components = New System.ComponentModel.Container()
        Me.SubmitButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.CMPGroupBox = New System.Windows.Forms.GroupBox()
        Me.SALabel = New System.Windows.Forms.Label()
        Me.SATextBox = New System.Windows.Forms.TextBox()
        Me.SNLabel = New System.Windows.Forms.Label()
        Me.FNLabel = New System.Windows.Forms.Label()
        Me.SNTextBox = New System.Windows.Forms.TextBox()
        Me.FNTextBox = New System.Windows.Forms.TextBox()
        Me.SIGroupBox = New System.Windows.Forms.GroupBox()
        Me.GradeLabel = New System.Windows.Forms.Label()
        Me.AgeLabel = New System.Windows.Forms.Label()
        Me.GradeTextBox = New System.Windows.Forms.TextBox()
        Me.AgeTextBox = New System.Windows.Forms.TextBox()
        Me.NameLabel = New System.Windows.Forms.Label()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.MPTGroupBox = New System.Windows.Forms.GroupBox()
        Me.DivideRadioButton = New System.Windows.Forms.RadioButton()
        Me.MultiplyRadioButton = New System.Windows.Forms.RadioButton()
        Me.SubtractRadioButton = New System.Windows.Forms.RadioButton()
        Me.AddRadioButton = New System.Windows.Forms.RadioButton()
        Me.SummaryButton = New System.Windows.Forms.Button()
        Me.ArrowBox2 = New System.Windows.Forms.PictureBox()
        Me.ArrowBox1 = New System.Windows.Forms.PictureBox()
        Me.ArrowBox3 = New System.Windows.Forms.PictureBox()
        Me.ArrowBox4 = New System.Windows.Forms.PictureBox()
        Me.ArrowBox5 = New System.Windows.Forms.PictureBox()
        Me.ArrowBox6 = New System.Windows.Forms.PictureBox()
        Me.ArrowBox7 = New System.Windows.Forms.PictureBox()
        Me.ArrowBox8 = New System.Windows.Forms.PictureBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.CMPGroupBox.SuspendLayout()
        Me.SIGroupBox.SuspendLayout()
        Me.MPTGroupBox.SuspendLayout()
        CType(Me.ArrowBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArrowBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArrowBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArrowBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArrowBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArrowBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArrowBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArrowBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SubmitButton
        '
        Me.SubmitButton.Location = New System.Drawing.Point(1033, 113)
        Me.SubmitButton.Name = "SubmitButton"
        Me.SubmitButton.Size = New System.Drawing.Size(205, 102)
        Me.SubmitButton.TabIndex = 5
        Me.SubmitButton.Text = "Submit"
        Me.ToolTip1.SetToolTip(Me.SubmitButton, "Submit your info & answer")
        Me.SubmitButton.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.Location = New System.Drawing.Point(1033, 329)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(205, 102)
        Me.ClearButton.TabIndex = 7
        Me.ClearButton.Text = "Clear"
        Me.ToolTip1.SetToolTip(Me.ClearButton, "Clear the textboxes")
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(1033, 437)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(205, 102)
        Me.ExitButton.TabIndex = 8
        Me.ExitButton.Text = "Exit"
        Me.ToolTip1.SetToolTip(Me.ExitButton, "Exit the program")
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'CMPGroupBox
        '
        Me.CMPGroupBox.Controls.Add(Me.SALabel)
        Me.CMPGroupBox.Controls.Add(Me.SATextBox)
        Me.CMPGroupBox.Controls.Add(Me.SNLabel)
        Me.CMPGroupBox.Controls.Add(Me.FNLabel)
        Me.CMPGroupBox.Controls.Add(Me.SNTextBox)
        Me.CMPGroupBox.Controls.Add(Me.FNTextBox)
        Me.CMPGroupBox.Location = New System.Drawing.Point(62, 221)
        Me.CMPGroupBox.Name = "CMPGroupBox"
        Me.CMPGroupBox.Size = New System.Drawing.Size(436, 318)
        Me.CMPGroupBox.TabIndex = 4
        Me.CMPGroupBox.TabStop = False
        Me.CMPGroupBox.Text = "Current Math Problem"
        '
        'SALabel
        '
        Me.SALabel.AutoSize = True
        Me.SALabel.Location = New System.Drawing.Point(6, 185)
        Me.SALabel.Name = "SALabel"
        Me.SALabel.Size = New System.Drawing.Size(163, 25)
        Me.SALabel.TabIndex = 5
        Me.SALabel.Text = "Student Answer"
        '
        'SATextBox
        '
        Me.SATextBox.Location = New System.Drawing.Point(6, 213)
        Me.SATextBox.Name = "SATextBox"
        Me.SATextBox.Size = New System.Drawing.Size(424, 31)
        Me.SATextBox.TabIndex = 4
        Me.ToolTip1.SetToolTip(Me.SATextBox, "Enter Answer Here")
        '
        'SNLabel
        '
        Me.SNLabel.AutoSize = True
        Me.SNLabel.Location = New System.Drawing.Point(7, 112)
        Me.SNLabel.Name = "SNLabel"
        Me.SNLabel.Size = New System.Drawing.Size(129, 25)
        Me.SNLabel.TabIndex = 3
        Me.SNLabel.Text = "2nd Number"
        '
        'FNLabel
        '
        Me.FNLabel.AutoSize = True
        Me.FNLabel.Location = New System.Drawing.Point(7, 42)
        Me.FNLabel.Name = "FNLabel"
        Me.FNLabel.Size = New System.Drawing.Size(122, 25)
        Me.FNLabel.TabIndex = 2
        Me.FNLabel.Text = "1st Number"
        '
        'SNTextBox
        '
        Me.SNTextBox.Enabled = False
        Me.SNTextBox.Location = New System.Drawing.Point(6, 140)
        Me.SNTextBox.Name = "SNTextBox"
        Me.SNTextBox.Size = New System.Drawing.Size(424, 31)
        Me.SNTextBox.TabIndex = 1
        Me.SNTextBox.TabStop = False
        Me.SNTextBox.Text = "10"
        '
        'FNTextBox
        '
        Me.FNTextBox.Enabled = False
        Me.FNTextBox.Location = New System.Drawing.Point(6, 70)
        Me.FNTextBox.Name = "FNTextBox"
        Me.FNTextBox.Size = New System.Drawing.Size(424, 31)
        Me.FNTextBox.TabIndex = 0
        Me.FNTextBox.TabStop = False
        Me.FNTextBox.Text = "10"
        '
        'SIGroupBox
        '
        Me.SIGroupBox.Controls.Add(Me.GradeLabel)
        Me.SIGroupBox.Controls.Add(Me.AgeLabel)
        Me.SIGroupBox.Controls.Add(Me.GradeTextBox)
        Me.SIGroupBox.Controls.Add(Me.AgeTextBox)
        Me.SIGroupBox.Controls.Add(Me.NameLabel)
        Me.SIGroupBox.Controls.Add(Me.NameTextBox)
        Me.SIGroupBox.Location = New System.Drawing.Point(62, 102)
        Me.SIGroupBox.Name = "SIGroupBox"
        Me.SIGroupBox.Size = New System.Drawing.Size(826, 113)
        Me.SIGroupBox.TabIndex = 0
        Me.SIGroupBox.TabStop = False
        Me.SIGroupBox.Text = "Student Information"
        '
        'GradeLabel
        '
        Me.GradeLabel.AutoSize = True
        Me.GradeLabel.Location = New System.Drawing.Point(534, 29)
        Me.GradeLabel.Name = "GradeLabel"
        Me.GradeLabel.Size = New System.Drawing.Size(71, 25)
        Me.GradeLabel.TabIndex = 5
        Me.GradeLabel.Text = "Grade"
        '
        'AgeLabel
        '
        Me.AgeLabel.AutoSize = True
        Me.AgeLabel.Location = New System.Drawing.Point(463, 31)
        Me.AgeLabel.Name = "AgeLabel"
        Me.AgeLabel.Size = New System.Drawing.Size(50, 25)
        Me.AgeLabel.TabIndex = 4
        Me.AgeLabel.Text = "Age"
        '
        'GradeTextBox
        '
        Me.GradeTextBox.Location = New System.Drawing.Point(539, 57)
        Me.GradeTextBox.Name = "GradeTextBox"
        Me.GradeTextBox.Size = New System.Drawing.Size(65, 31)
        Me.GradeTextBox.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.GradeTextBox, "Enter Grade Here")
        '
        'AgeTextBox
        '
        Me.AgeTextBox.Location = New System.Drawing.Point(468, 57)
        Me.AgeTextBox.Name = "AgeTextBox"
        Me.AgeTextBox.Size = New System.Drawing.Size(65, 31)
        Me.AgeTextBox.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.AgeTextBox, "Enter Age Here")
        '
        'NameLabel
        '
        Me.NameLabel.AutoSize = True
        Me.NameLabel.Location = New System.Drawing.Point(7, 29)
        Me.NameLabel.Name = "NameLabel"
        Me.NameLabel.Size = New System.Drawing.Size(68, 25)
        Me.NameLabel.TabIndex = 1
        Me.NameLabel.Text = "Name"
        '
        'NameTextBox
        '
        Me.NameTextBox.Location = New System.Drawing.Point(6, 57)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(430, 31)
        Me.NameTextBox.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.NameTextBox, "Enter Name Here")
        '
        'MPTGroupBox
        '
        Me.MPTGroupBox.Controls.Add(Me.DivideRadioButton)
        Me.MPTGroupBox.Controls.Add(Me.MultiplyRadioButton)
        Me.MPTGroupBox.Controls.Add(Me.SubtractRadioButton)
        Me.MPTGroupBox.Controls.Add(Me.AddRadioButton)
        Me.MPTGroupBox.Location = New System.Drawing.Point(530, 221)
        Me.MPTGroupBox.Name = "MPTGroupBox"
        Me.MPTGroupBox.Size = New System.Drawing.Size(358, 318)
        Me.MPTGroupBox.TabIndex = 5
        Me.MPTGroupBox.TabStop = False
        Me.MPTGroupBox.Text = "Math Problem Type"
        Me.ToolTip1.SetToolTip(Me.MPTGroupBox, "Choose an operation.")
        '
        'DivideRadioButton
        '
        Me.DivideRadioButton.AutoSize = True
        Me.DivideRadioButton.Location = New System.Drawing.Point(6, 253)
        Me.DivideRadioButton.Name = "DivideRadioButton"
        Me.DivideRadioButton.Size = New System.Drawing.Size(103, 29)
        Me.DivideRadioButton.TabIndex = 3
        Me.DivideRadioButton.Text = "&Divide"
        Me.DivideRadioButton.UseVisualStyleBackColor = True
        '
        'MultiplyRadioButton
        '
        Me.MultiplyRadioButton.AutoSize = True
        Me.MultiplyRadioButton.Location = New System.Drawing.Point(6, 181)
        Me.MultiplyRadioButton.Name = "MultiplyRadioButton"
        Me.MultiplyRadioButton.Size = New System.Drawing.Size(117, 29)
        Me.MultiplyRadioButton.TabIndex = 2
        Me.MultiplyRadioButton.Text = "&Multiply"
        Me.MultiplyRadioButton.UseVisualStyleBackColor = True
        '
        'SubtractRadioButton
        '
        Me.SubtractRadioButton.AutoSize = True
        Me.SubtractRadioButton.Location = New System.Drawing.Point(6, 108)
        Me.SubtractRadioButton.Name = "SubtractRadioButton"
        Me.SubtractRadioButton.Size = New System.Drawing.Size(123, 29)
        Me.SubtractRadioButton.TabIndex = 1
        Me.SubtractRadioButton.Text = "&Subtract"
        Me.SubtractRadioButton.UseVisualStyleBackColor = True
        '
        'AddRadioButton
        '
        Me.AddRadioButton.AutoSize = True
        Me.AddRadioButton.Location = New System.Drawing.Point(6, 37)
        Me.AddRadioButton.Name = "AddRadioButton"
        Me.AddRadioButton.Size = New System.Drawing.Size(81, 29)
        Me.AddRadioButton.TabIndex = 3
        Me.AddRadioButton.Text = "&Add"
        Me.AddRadioButton.UseVisualStyleBackColor = True
        '
        'SummaryButton
        '
        Me.SummaryButton.Location = New System.Drawing.Point(1033, 221)
        Me.SummaryButton.Name = "SummaryButton"
        Me.SummaryButton.Size = New System.Drawing.Size(205, 102)
        Me.SummaryButton.TabIndex = 6
        Me.SummaryButton.Text = "Summary"
        Me.ToolTip1.SetToolTip(Me.SummaryButton, "Compile a list of info and answers")
        Me.SummaryButton.UseVisualStyleBackColor = True
        '
        'ArrowBox2
        '
        Me.ArrowBox2.Location = New System.Drawing.Point(574, 196)
        Me.ArrowBox2.Name = "ArrowBox2"
        Me.ArrowBox2.Size = New System.Drawing.Size(1105, 768)
        Me.ArrowBox2.TabIndex = 6
        Me.ArrowBox2.TabStop = False
        Me.ArrowBox2.Visible = False
        '
        'ArrowBox1
        '
        Me.ArrowBox1.BackColor = System.Drawing.Color.Transparent
        Me.ArrowBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ArrowBox1.Location = New System.Drawing.Point(237, 196)
        Me.ArrowBox1.Name = "ArrowBox1"
        Me.ArrowBox1.Size = New System.Drawing.Size(1084, 768)
        Me.ArrowBox1.TabIndex = 7
        Me.ArrowBox1.TabStop = False
        Me.ArrowBox1.Visible = False
        '
        'ArrowBox3
        '
        Me.ArrowBox3.BackColor = System.Drawing.Color.Transparent
        Me.ArrowBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ArrowBox3.Location = New System.Drawing.Point(645, 196)
        Me.ArrowBox3.Name = "ArrowBox3"
        Me.ArrowBox3.Size = New System.Drawing.Size(1056, 768)
        Me.ArrowBox3.TabIndex = 8
        Me.ArrowBox3.TabStop = False
        Me.ArrowBox3.Visible = False
        '
        'ArrowBox4
        '
        Me.ArrowBox4.BackColor = System.Drawing.Color.Transparent
        Me.ArrowBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ArrowBox4.Location = New System.Drawing.Point(154, 520)
        Me.ArrowBox4.Name = "ArrowBox4"
        Me.ArrowBox4.Size = New System.Drawing.Size(1084, 768)
        Me.ArrowBox4.TabIndex = 9
        Me.ArrowBox4.TabStop = False
        Me.ArrowBox4.Visible = False
        '
        'ArrowBox5
        '
        Me.ArrowBox5.BackColor = System.Drawing.Color.Transparent
        Me.ArrowBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ArrowBox5.Location = New System.Drawing.Point(659, 274)
        Me.ArrowBox5.Name = "ArrowBox5"
        Me.ArrowBox5.Size = New System.Drawing.Size(1084, 768)
        Me.ArrowBox5.TabIndex = 10
        Me.ArrowBox5.TabStop = False
        Me.ArrowBox5.Visible = False
        '
        'ArrowBox6
        '
        Me.ArrowBox6.BackColor = System.Drawing.Color.Transparent
        Me.ArrowBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ArrowBox6.Location = New System.Drawing.Point(665, 351)
        Me.ArrowBox6.Name = "ArrowBox6"
        Me.ArrowBox6.Size = New System.Drawing.Size(1084, 768)
        Me.ArrowBox6.TabIndex = 11
        Me.ArrowBox6.TabStop = False
        Me.ArrowBox6.Visible = False
        '
        'ArrowBox7
        '
        Me.ArrowBox7.BackColor = System.Drawing.Color.Transparent
        Me.ArrowBox7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ArrowBox7.Location = New System.Drawing.Point(645, 425)
        Me.ArrowBox7.Name = "ArrowBox7"
        Me.ArrowBox7.Size = New System.Drawing.Size(1084, 768)
        Me.ArrowBox7.TabIndex = 12
        Me.ArrowBox7.TabStop = False
        Me.ArrowBox7.Visible = False
        '
        'ArrowBox8
        '
        Me.ArrowBox8.BackColor = System.Drawing.Color.Transparent
        Me.ArrowBox8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ArrowBox8.Location = New System.Drawing.Point(638, 494)
        Me.ArrowBox8.Name = "ArrowBox8"
        Me.ArrowBox8.Size = New System.Drawing.Size(1084, 768)
        Me.ArrowBox8.TabIndex = 13
        Me.ArrowBox8.TabStop = False
        Me.ArrowBox8.Visible = False
        '
        'MathContestForm
        '
        Me.AcceptButton = Me.SubmitButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.ExitButton
        Me.ClientSize = New System.Drawing.Size(1734, 976)
        Me.Controls.Add(Me.SummaryButton)
        Me.Controls.Add(Me.MPTGroupBox)
        Me.Controls.Add(Me.SIGroupBox)
        Me.Controls.Add(Me.CMPGroupBox)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.SubmitButton)
        Me.Controls.Add(Me.ArrowBox3)
        Me.Controls.Add(Me.ArrowBox2)
        Me.Controls.Add(Me.ArrowBox8)
        Me.Controls.Add(Me.ArrowBox4)
        Me.Controls.Add(Me.ArrowBox5)
        Me.Controls.Add(Me.ArrowBox6)
        Me.Controls.Add(Me.ArrowBox7)
        Me.Controls.Add(Me.ArrowBox1)
        Me.Name = "MathContestForm"
        Me.Text = "Math Contest"
        Me.CMPGroupBox.ResumeLayout(False)
        Me.CMPGroupBox.PerformLayout()
        Me.SIGroupBox.ResumeLayout(False)
        Me.SIGroupBox.PerformLayout()
        Me.MPTGroupBox.ResumeLayout(False)
        Me.MPTGroupBox.PerformLayout()
        CType(Me.ArrowBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArrowBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArrowBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArrowBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArrowBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArrowBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArrowBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArrowBox8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SubmitButton As Button
    Friend WithEvents ClearButton As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents CMPGroupBox As GroupBox
    Friend WithEvents SIGroupBox As GroupBox
    Friend WithEvents MPTGroupBox As GroupBox
    Friend WithEvents SALabel As Label
    Friend WithEvents SATextBox As TextBox
    Friend WithEvents SNLabel As Label
    Friend WithEvents FNLabel As Label
    Friend WithEvents SNTextBox As TextBox
    Friend WithEvents FNTextBox As TextBox
    Friend WithEvents NameLabel As Label
    Friend WithEvents NameTextBox As TextBox
    Friend WithEvents GradeLabel As Label
    Friend WithEvents AgeLabel As Label
    Friend WithEvents GradeTextBox As TextBox
    Friend WithEvents AgeTextBox As TextBox
    Friend WithEvents SummaryButton As Button
    Friend WithEvents DivideRadioButton As RadioButton
    Friend WithEvents MultiplyRadioButton As RadioButton
    Friend WithEvents SubtractRadioButton As RadioButton
    Friend WithEvents AddRadioButton As RadioButton
    Friend WithEvents ArrowBox2 As PictureBox
    Friend WithEvents ArrowBox1 As PictureBox
    Friend WithEvents ArrowBox3 As PictureBox
    Friend WithEvents ArrowBox4 As PictureBox
    Friend WithEvents ArrowBox5 As PictureBox
    Friend WithEvents ArrowBox6 As PictureBox
    Friend WithEvents ArrowBox7 As PictureBox
    Friend WithEvents ArrowBox8 As PictureBox
    Friend WithEvents ToolTip1 As ToolTip
End Class
