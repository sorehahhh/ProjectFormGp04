<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class StudentListForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StudentListForm))
        Me.updateStudentButton = New System.Windows.Forms.Button()
        Me.AddStudentButton = New System.Windows.Forms.Button()
        Me.DeleteStudentButton = New System.Windows.Forms.Button()
        Me.StudentDataGridView = New System.Windows.Forms.DataGridView()
        Me.Search = New System.Windows.Forms.GroupBox()
        Me.displayAllButton = New System.Windows.Forms.Button()
        Me.nameButton = New System.Windows.Forms.Button()
        Me.ICButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.searchTextBox = New System.Windows.Forms.TextBox()
        Me.PrintButton = New System.Windows.Forms.Button()
        Me.PageSetupDialog1 = New System.Windows.Forms.PageSetupDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        CType(Me.StudentDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Search.SuspendLayout()
        Me.SuspendLayout()
        '
        'updateStudentButton
        '
        Me.updateStudentButton.BackColor = System.Drawing.Color.Orange
        Me.updateStudentButton.Font = New System.Drawing.Font("Nirmala UI", 18.15652!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.updateStudentButton.Location = New System.Drawing.Point(347, 517)
        Me.updateStudentButton.Margin = New System.Windows.Forms.Padding(6)
        Me.updateStudentButton.Name = "updateStudentButton"
        Me.updateStudentButton.Size = New System.Drawing.Size(209, 60)
        Me.updateStudentButton.TabIndex = 12
        Me.updateStudentButton.Text = "Update Student"
        Me.updateStudentButton.UseVisualStyleBackColor = False
        '
        'AddStudentButton
        '
        Me.AddStudentButton.BackColor = System.Drawing.Color.Orange
        Me.AddStudentButton.Font = New System.Drawing.Font("Nirmala UI", 18.15652!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddStudentButton.Location = New System.Drawing.Point(126, 517)
        Me.AddStudentButton.Margin = New System.Windows.Forms.Padding(6)
        Me.AddStudentButton.Name = "AddStudentButton"
        Me.AddStudentButton.Size = New System.Drawing.Size(209, 60)
        Me.AddStudentButton.TabIndex = 11
        Me.AddStudentButton.Text = "Add New Student"
        Me.AddStudentButton.UseVisualStyleBackColor = False
        '
        'DeleteStudentButton
        '
        Me.DeleteStudentButton.BackColor = System.Drawing.Color.Orange
        Me.DeleteStudentButton.Font = New System.Drawing.Font("Nirmala UI", 18.15652!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeleteStudentButton.Location = New System.Drawing.Point(568, 517)
        Me.DeleteStudentButton.Margin = New System.Windows.Forms.Padding(6)
        Me.DeleteStudentButton.Name = "DeleteStudentButton"
        Me.DeleteStudentButton.Size = New System.Drawing.Size(228, 60)
        Me.DeleteStudentButton.TabIndex = 10
        Me.DeleteStudentButton.Text = "Delete Student"
        Me.DeleteStudentButton.UseVisualStyleBackColor = False
        '
        'StudentDataGridView
        '
        Me.StudentDataGridView.BackgroundColor = System.Drawing.Color.Turquoise
        Me.StudentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.StudentDataGridView.Location = New System.Drawing.Point(34, 154)
        Me.StudentDataGridView.MultiSelect = False
        Me.StudentDataGridView.Name = "StudentDataGridView"
        Me.StudentDataGridView.RowHeadersWidth = 49
        Me.StudentDataGridView.Size = New System.Drawing.Size(1242, 338)
        Me.StudentDataGridView.TabIndex = 9
        '
        'Search
        '
        Me.Search.BackColor = System.Drawing.Color.Pink
        Me.Search.Controls.Add(Me.displayAllButton)
        Me.Search.Controls.Add(Me.nameButton)
        Me.Search.Controls.Add(Me.ICButton)
        Me.Search.Controls.Add(Me.Label1)
        Me.Search.Controls.Add(Me.searchTextBox)
        Me.Search.Font = New System.Drawing.Font("Nirmala UI", 13.77391!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Search.Location = New System.Drawing.Point(98, 48)
        Me.Search.Name = "Search"
        Me.Search.Size = New System.Drawing.Size(1178, 99)
        Me.Search.TabIndex = 13
        Me.Search.TabStop = False
        Me.Search.Text = "Search"
        '
        'displayAllButton
        '
        Me.displayAllButton.Location = New System.Drawing.Point(849, 40)
        Me.displayAllButton.Name = "displayAllButton"
        Me.displayAllButton.Size = New System.Drawing.Size(124, 36)
        Me.displayAllButton.TabIndex = 4
        Me.displayAllButton.Text = "Display All"
        Me.displayAllButton.UseVisualStyleBackColor = True
        '
        'nameButton
        '
        Me.nameButton.Location = New System.Drawing.Point(699, 37)
        Me.nameButton.Name = "nameButton"
        Me.nameButton.Size = New System.Drawing.Size(124, 38)
        Me.nameButton.TabIndex = 3
        Me.nameButton.Text = "By Name"
        Me.nameButton.UseVisualStyleBackColor = True
        '
        'ICButton
        '
        Me.ICButton.Location = New System.Drawing.Point(539, 40)
        Me.ICButton.Name = "ICButton"
        Me.ICButton.Size = New System.Drawing.Size(124, 36)
        Me.ICButton.TabIndex = 2
        Me.ICButton.Text = "By IC"
        Me.ICButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(99, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "IC / Name"
        '
        'searchTextBox
        '
        Me.searchTextBox.Location = New System.Drawing.Point(220, 40)
        Me.searchTextBox.Name = "searchTextBox"
        Me.searchTextBox.Size = New System.Drawing.Size(295, 32)
        Me.searchTextBox.TabIndex = 0
        '
        'PrintButton
        '
        Me.PrintButton.BackColor = System.Drawing.Color.Orange
        Me.PrintButton.Font = New System.Drawing.Font("Nirmala UI", 18.15652!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PrintButton.Location = New System.Drawing.Point(808, 517)
        Me.PrintButton.Margin = New System.Windows.Forms.Padding(6)
        Me.PrintButton.Name = "PrintButton"
        Me.PrintButton.Size = New System.Drawing.Size(228, 60)
        Me.PrintButton.TabIndex = 14
        Me.PrintButton.Text = "Print"
        Me.PrintButton.UseVisualStyleBackColor = False
        '
        'PrintDocument1
        '
        '
        'StudentListForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1028, 609)
        Me.Controls.Add(Me.PrintButton)
        Me.Controls.Add(Me.Search)
        Me.Controls.Add(Me.updateStudentButton)
        Me.Controls.Add(Me.AddStudentButton)
        Me.Controls.Add(Me.DeleteStudentButton)
        Me.Controls.Add(Me.StudentDataGridView)
        Me.Name = "StudentListForm"
        Me.Text = "StudentListForm"
        CType(Me.StudentDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Search.ResumeLayout(False)
        Me.Search.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents updateStudentButton As Button
    Friend WithEvents AddStudentButton As Button
    Friend WithEvents DeleteStudentButton As Button
    Friend WithEvents StudentDataGridView As DataGridView
    Friend WithEvents Search As GroupBox
    Friend WithEvents nameButton As Button
    Friend WithEvents ICButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents searchTextBox As TextBox
    Friend WithEvents displayAllButton As Button
    Friend WithEvents PrintButton As Button
    Friend WithEvents PageSetupDialog1 As PageSetupDialog
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
End Class
