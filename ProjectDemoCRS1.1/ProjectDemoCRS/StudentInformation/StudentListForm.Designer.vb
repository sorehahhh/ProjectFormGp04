<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StudentListForm
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CloseButton = New System.Windows.Forms.Button()
        Me.DeleteButton = New System.Windows.Forms.Button()
        Me.SaveButton = New System.Windows.Forms.Button()
        Me.NextButton = New System.Windows.Forms.Button()
        Me.AddNewButton = New System.Windows.Forms.Button()
        Me.PreviousButton = New System.Windows.Forms.Button()
        Me.dobDateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.nameTextBox = New System.Windows.Forms.TextBox()
        Me.PhoneNumberTextBox = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.icNumberTextBox = New System.Windows.Forms.TextBox()
        Me.matricTextBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.IhsanTuitionCenterDbDataSet = New ProjectDemoCRS.ihsanTuitionCenterDbDataSet()
        Me.IhsanTuitionCenterDbDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StudentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StudentTableAdapter = New ProjectDemoCRS.ihsanTuitionCenterDbDataSetTableAdapters.studentTableAdapter()
        Me.StudentBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.MatricNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.StudentDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Search.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.IhsanTuitionCenterDbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IhsanTuitionCenterDbDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudentBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'updateStudentButton
        '
        Me.updateStudentButton.BackColor = System.Drawing.Color.Orange
        Me.updateStudentButton.Font = New System.Drawing.Font("Nirmala UI", 18.15652!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.updateStudentButton.Location = New System.Drawing.Point(469, 593)
        Me.updateStudentButton.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.updateStudentButton.Name = "updateStudentButton"
        Me.updateStudentButton.Size = New System.Drawing.Size(279, 74)
        Me.updateStudentButton.TabIndex = 12
        Me.updateStudentButton.Text = "Update Student"
        Me.updateStudentButton.UseVisualStyleBackColor = False
        '
        'AddStudentButton
        '
        Me.AddStudentButton.BackColor = System.Drawing.Color.Orange
        Me.AddStudentButton.Font = New System.Drawing.Font("Nirmala UI", 18.15652!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddStudentButton.Location = New System.Drawing.Point(175, 593)
        Me.AddStudentButton.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.AddStudentButton.Name = "AddStudentButton"
        Me.AddStudentButton.Size = New System.Drawing.Size(279, 74)
        Me.AddStudentButton.TabIndex = 11
        Me.AddStudentButton.Text = "Add New Student"
        Me.AddStudentButton.UseVisualStyleBackColor = False
        '
        'DeleteStudentButton
        '
        Me.DeleteStudentButton.BackColor = System.Drawing.Color.Orange
        Me.DeleteStudentButton.Font = New System.Drawing.Font("Nirmala UI", 18.15652!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeleteStudentButton.Location = New System.Drawing.Point(764, 593)
        Me.DeleteStudentButton.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.DeleteStudentButton.Name = "DeleteStudentButton"
        Me.DeleteStudentButton.Size = New System.Drawing.Size(304, 74)
        Me.DeleteStudentButton.TabIndex = 10
        Me.DeleteStudentButton.Text = "Delete Student"
        Me.DeleteStudentButton.UseVisualStyleBackColor = False
        '
        'StudentDataGridView
        '
        Me.StudentDataGridView.AllowUserToOrderColumns = True
        Me.StudentDataGridView.AutoGenerateColumns = False
        Me.StudentDataGridView.BackgroundColor = System.Drawing.Color.Turquoise
        Me.StudentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.StudentDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MatricNumberDataGridViewTextBoxColumn})
        Me.StudentDataGridView.DataSource = Me.StudentBindingSource
        Me.StudentDataGridView.Location = New System.Drawing.Point(672, 166)
        Me.StudentDataGridView.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.StudentDataGridView.MultiSelect = False
        Me.StudentDataGridView.Name = "StudentDataGridView"
        Me.StudentDataGridView.RowHeadersWidth = 49
        Me.StudentDataGridView.Size = New System.Drawing.Size(671, 416)
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
        Me.Search.Location = New System.Drawing.Point(137, 16)
        Me.Search.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Search.Name = "Search"
        Me.Search.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Search.Size = New System.Drawing.Size(1571, 122)
        Me.Search.TabIndex = 13
        Me.Search.TabStop = False
        Me.Search.Text = "Search"
        '
        'displayAllButton
        '
        Me.displayAllButton.Location = New System.Drawing.Point(1132, 49)
        Me.displayAllButton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.displayAllButton.Name = "displayAllButton"
        Me.displayAllButton.Size = New System.Drawing.Size(165, 44)
        Me.displayAllButton.TabIndex = 4
        Me.displayAllButton.Text = "Display All"
        Me.displayAllButton.UseVisualStyleBackColor = True
        '
        'nameButton
        '
        Me.nameButton.Location = New System.Drawing.Point(932, 46)
        Me.nameButton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.nameButton.Name = "nameButton"
        Me.nameButton.Size = New System.Drawing.Size(165, 47)
        Me.nameButton.TabIndex = 3
        Me.nameButton.Text = "By Name"
        Me.nameButton.UseVisualStyleBackColor = True
        '
        'ICButton
        '
        Me.ICButton.Location = New System.Drawing.Point(719, 49)
        Me.ICButton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ICButton.Name = "ICButton"
        Me.ICButton.Size = New System.Drawing.Size(165, 44)
        Me.ICButton.TabIndex = 2
        Me.ICButton.Text = "By IC"
        Me.ICButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(132, 49)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 31)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "IC / Name"
        '
        'searchTextBox
        '
        Me.searchTextBox.Location = New System.Drawing.Point(293, 49)
        Me.searchTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.searchTextBox.Name = "searchTextBox"
        Me.searchTextBox.Size = New System.Drawing.Size(392, 38)
        Me.searchTextBox.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CloseButton)
        Me.GroupBox1.Controls.Add(Me.DeleteButton)
        Me.GroupBox1.Controls.Add(Me.SaveButton)
        Me.GroupBox1.Controls.Add(Me.NextButton)
        Me.GroupBox1.Controls.Add(Me.AddNewButton)
        Me.GroupBox1.Controls.Add(Me.PreviousButton)
        Me.GroupBox1.Controls.Add(Me.dobDateTimePicker1)
        Me.GroupBox1.Controls.Add(Me.nameTextBox)
        Me.GroupBox1.Controls.Add(Me.PhoneNumberTextBox)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.icNumberTextBox)
        Me.GroupBox1.Controls.Add(Me.matricTextBox)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 166)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(648, 395)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'CloseButton
        '
        Me.CloseButton.Location = New System.Drawing.Point(453, 304)
        Me.CloseButton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(99, 37)
        Me.CloseButton.TabIndex = 37
        Me.CloseButton.Text = "Close"
        Me.CloseButton.UseVisualStyleBackColor = True
        '
        'DeleteButton
        '
        Me.DeleteButton.Location = New System.Drawing.Point(243, 304)
        Me.DeleteButton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DeleteButton.Name = "DeleteButton"
        Me.DeleteButton.Size = New System.Drawing.Size(99, 37)
        Me.DeleteButton.TabIndex = 36
        Me.DeleteButton.Text = "Delete"
        Me.DeleteButton.UseVisualStyleBackColor = True
        '
        'SaveButton
        '
        Me.SaveButton.Location = New System.Drawing.Point(60, 304)
        Me.SaveButton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(99, 37)
        Me.SaveButton.TabIndex = 35
        Me.SaveButton.Text = "Save"
        Me.SaveButton.UseVisualStyleBackColor = True
        '
        'NextButton
        '
        Me.NextButton.Location = New System.Drawing.Point(453, 240)
        Me.NextButton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.NextButton.Name = "NextButton"
        Me.NextButton.Size = New System.Drawing.Size(99, 37)
        Me.NextButton.TabIndex = 34
        Me.NextButton.Text = "Next"
        Me.NextButton.UseVisualStyleBackColor = True
        '
        'AddNewButton
        '
        Me.AddNewButton.Location = New System.Drawing.Point(243, 240)
        Me.AddNewButton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.AddNewButton.Name = "AddNewButton"
        Me.AddNewButton.Size = New System.Drawing.Size(99, 37)
        Me.AddNewButton.TabIndex = 33
        Me.AddNewButton.Text = "Add New"
        Me.AddNewButton.UseVisualStyleBackColor = True
        '
        'PreviousButton
        '
        Me.PreviousButton.Location = New System.Drawing.Point(60, 240)
        Me.PreviousButton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PreviousButton.Name = "PreviousButton"
        Me.PreviousButton.Size = New System.Drawing.Size(99, 37)
        Me.PreviousButton.TabIndex = 32
        Me.PreviousButton.Text = "Previous"
        Me.PreviousButton.UseVisualStyleBackColor = True
        '
        'dobDateTimePicker1
        '
        Me.dobDateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dobDateTimePicker1.Location = New System.Drawing.Point(157, 133)
        Me.dobDateTimePicker1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dobDateTimePicker1.Name = "dobDateTimePicker1"
        Me.dobDateTimePicker1.Size = New System.Drawing.Size(345, 22)
        Me.dobDateTimePicker1.TabIndex = 31
        '
        'nameTextBox
        '
        Me.nameTextBox.Location = New System.Drawing.Point(159, 97)
        Me.nameTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.nameTextBox.Name = "nameTextBox"
        Me.nameTextBox.Size = New System.Drawing.Size(348, 22)
        Me.nameTextBox.TabIndex = 30
        '
        'PhoneNumberTextBox
        '
        Me.PhoneNumberTextBox.Location = New System.Drawing.Point(159, 172)
        Me.PhoneNumberTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PhoneNumberTextBox.Name = "PhoneNumberTextBox"
        Me.PhoneNumberTextBox.Size = New System.Drawing.Size(348, 22)
        Me.PhoneNumberTextBox.TabIndex = 29
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(32, 172)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(103, 17)
        Me.Label6.TabIndex = 28
        Me.Label6.Text = "Phone Number"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(32, 133)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 17)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "Date of birth"
        '
        'icNumberTextBox
        '
        Me.icNumberTextBox.Location = New System.Drawing.Point(159, 62)
        Me.icNumberTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.icNumberTextBox.Name = "icNumberTextBox"
        Me.icNumberTextBox.Size = New System.Drawing.Size(348, 22)
        Me.icNumberTextBox.TabIndex = 26
        '
        'matricTextBox
        '
        Me.matricTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentBindingSource, "matricNumber", True))
        Me.matricTextBox.Location = New System.Drawing.Point(159, 23)
        Me.matricTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.matricTextBox.Name = "matricTextBox"
        Me.matricTextBox.Size = New System.Drawing.Size(344, 22)
        Me.matricTextBox.TabIndex = 25
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(32, 97)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 17)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(32, 62)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 17)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Ic Number"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(32, 27)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 17)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Matric Number"
        '
        'IhsanTuitionCenterDbDataSet
        '
        Me.IhsanTuitionCenterDbDataSet.DataSetName = "ihsanTuitionCenterDbDataSet"
        Me.IhsanTuitionCenterDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'IhsanTuitionCenterDbDataSetBindingSource
        '
        Me.IhsanTuitionCenterDbDataSetBindingSource.DataSource = Me.IhsanTuitionCenterDbDataSet
        Me.IhsanTuitionCenterDbDataSetBindingSource.Position = 0
        '
        'StudentBindingSource
        '
        Me.StudentBindingSource.DataMember = "student"
        Me.StudentBindingSource.DataSource = Me.IhsanTuitionCenterDbDataSetBindingSource
        '
        'StudentTableAdapter
        '
        Me.StudentTableAdapter.ClearBeforeFill = True
        '
        'StudentBindingSource1
        '
        Me.StudentBindingSource1.DataMember = "student"
        Me.StudentBindingSource1.DataSource = Me.IhsanTuitionCenterDbDataSetBindingSource
        '
        'MatricNumberDataGridViewTextBoxColumn
        '
        Me.MatricNumberDataGridViewTextBoxColumn.DataPropertyName = "matricNumber"
        Me.MatricNumberDataGridViewTextBoxColumn.HeaderText = "matricNumber"
        Me.MatricNumberDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.MatricNumberDataGridViewTextBoxColumn.Name = "MatricNumberDataGridViewTextBoxColumn"
        Me.MatricNumberDataGridViewTextBoxColumn.Width = 125
        '
        'StudentListForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1371, 750)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Search)
        Me.Controls.Add(Me.updateStudentButton)
        Me.Controls.Add(Me.AddStudentButton)
        Me.Controls.Add(Me.DeleteStudentButton)
        Me.Controls.Add(Me.StudentDataGridView)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "StudentListForm"
        Me.Text = "StudentListForm"
        CType(Me.StudentDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Search.ResumeLayout(False)
        Me.Search.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.IhsanTuitionCenterDbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IhsanTuitionCenterDbDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudentBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents CloseButton As Button
    Friend WithEvents DeleteButton As Button
    Friend WithEvents SaveButton As Button
    Friend WithEvents NextButton As Button
    Friend WithEvents AddNewButton As Button
    Friend WithEvents PreviousButton As Button
    Friend WithEvents dobDateTimePicker1 As DateTimePicker
    Friend WithEvents nameTextBox As TextBox
    Friend WithEvents PhoneNumberTextBox As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents icNumberTextBox As TextBox
    Friend WithEvents matricTextBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents IhsanTuitionCenterDbDataSetBindingSource As BindingSource
    Friend WithEvents IhsanTuitionCenterDbDataSet As ihsanTuitionCenterDbDataSet
    Friend WithEvents StudentBindingSource As BindingSource
    Friend WithEvents StudentTableAdapter As ihsanTuitionCenterDbDataSetTableAdapters.studentTableAdapter
    Friend WithEvents MatricNumberDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StudentBindingSource1 As BindingSource
End Class
