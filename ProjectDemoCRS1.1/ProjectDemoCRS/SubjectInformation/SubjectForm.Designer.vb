<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SubjectForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SubjectForm))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.subjectCodeTextBox = New System.Windows.Forms.TextBox()
        Me.AddUpdateButton = New System.Windows.Forms.Button()
        Me.CancelButton = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.creditTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.nameTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(149, 30)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Subject Code"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 101)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 30)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Name"
        '
        'subjectCodeTextBox
        '
        Me.subjectCodeTextBox.Location = New System.Drawing.Point(203, 57)
        Me.subjectCodeTextBox.Name = "subjectCodeTextBox"
        Me.subjectCodeTextBox.Size = New System.Drawing.Size(262, 36)
        Me.subjectCodeTextBox.TabIndex = 3
        '
        'AddUpdateButton
        '
        Me.AddUpdateButton.BackColor = System.Drawing.Color.Crimson
        Me.AddUpdateButton.ForeColor = System.Drawing.Color.AliceBlue
        Me.AddUpdateButton.Location = New System.Drawing.Point(190, 216)
        Me.AddUpdateButton.Name = "AddUpdateButton"
        Me.AddUpdateButton.Size = New System.Drawing.Size(117, 53)
        Me.AddUpdateButton.TabIndex = 6
        Me.AddUpdateButton.Text = "Add"
        Me.AddUpdateButton.UseVisualStyleBackColor = False
        '
        'CancelButton
        '
        Me.CancelButton.BackColor = System.Drawing.Color.Crimson
        Me.CancelButton.ForeColor = System.Drawing.Color.AliceBlue
        Me.CancelButton.Location = New System.Drawing.Point(357, 216)
        Me.CancelButton.Name = "CancelButton"
        Me.CancelButton.Size = New System.Drawing.Size(117, 53)
        Me.CancelButton.TabIndex = 7
        Me.CancelButton.Text = "Cancel"
        Me.CancelButton.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(9, 140)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 30)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Credit"
        '
        'creditTextBox
        '
        Me.creditTextBox.Location = New System.Drawing.Point(203, 140)
        Me.creditTextBox.Name = "creditTextBox"
        Me.creditTextBox.Size = New System.Drawing.Size(262, 36)
        Me.creditTextBox.TabIndex = 22
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Info
        Me.GroupBox1.Controls.Add(Me.creditTextBox)
        Me.GroupBox1.Controls.Add(Me.nameTextBox)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.CancelButton)
        Me.GroupBox1.Controls.Add(Me.AddUpdateButton)
        Me.GroupBox1.Controls.Add(Me.subjectCodeTextBox)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Nirmala UI", 16.27826!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(70, 14)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(6)
        Me.GroupBox1.Size = New System.Drawing.Size(682, 504)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Subject Information"
        '
        'nameTextBox
        '
        Me.nameTextBox.Location = New System.Drawing.Point(203, 99)
        Me.nameTextBox.Name = "nameTextBox"
        Me.nameTextBox.Size = New System.Drawing.Size(262, 36)
        Me.nameTextBox.TabIndex = 20
        '
        'SubjectForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(841, 487)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "SubjectForm"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents subjectCodeTextBox As TextBox
    Friend WithEvents AddUpdateButton As Button
    Friend WithEvents CancelButton As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents creditTextBox As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents nameTextBox As TextBox
End Class
