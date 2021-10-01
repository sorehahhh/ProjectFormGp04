<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StudentForm2
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
        Dim MatricNumberLabel As System.Windows.Forms.Label
        Dim IcNumberLabel As System.Windows.Forms.Label
        Dim NameLabel As System.Windows.Forms.Label
        Dim CourseLabel As System.Windows.Forms.Label
        Dim DateOfBirthLabel As System.Windows.Forms.Label
        Dim GenderLabel As System.Windows.Forms.Label
        Dim EmailLabel As System.Windows.Forms.Label
        Dim PhoneNumberLabel As System.Windows.Forms.Label
        Dim Address1Label As System.Windows.Forms.Label
        Dim Address2Label As System.Windows.Forms.Label
        Dim CityLabel As System.Windows.Forms.Label
        Dim DistrictLabel As System.Windows.Forms.Label
        Dim StateLabel As System.Windows.Forms.Label
        Dim GroupIdLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StudentForm2))
        Me.IhsanTuitionCenterDbDataSet = New ProjectDemoCRS.ihsanTuitionCenterDbDataSet()
        Me.StudentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StudentTableAdapter = New ProjectDemoCRS.ihsanTuitionCenterDbDataSetTableAdapters.studentTableAdapter()
        Me.TableAdapterManager = New ProjectDemoCRS.ihsanTuitionCenterDbDataSetTableAdapters.TableAdapterManager()
        Me.StudentBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.StudentBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.MatricNumberTextBox = New System.Windows.Forms.TextBox()
        Me.IcNumberTextBox = New System.Windows.Forms.TextBox()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.CourseTextBox = New System.Windows.Forms.TextBox()
        Me.DateOfBirthDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.GenderTextBox = New System.Windows.Forms.TextBox()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.PhoneNumberTextBox = New System.Windows.Forms.TextBox()
        Me.Address1TextBox = New System.Windows.Forms.TextBox()
        Me.Address2TextBox = New System.Windows.Forms.TextBox()
        Me.CityTextBox = New System.Windows.Forms.TextBox()
        Me.DistrictTextBox = New System.Windows.Forms.TextBox()
        Me.StateTextBox = New System.Windows.Forms.TextBox()
        Me.GroupIdTextBox = New System.Windows.Forms.TextBox()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        MatricNumberLabel = New System.Windows.Forms.Label()
        IcNumberLabel = New System.Windows.Forms.Label()
        NameLabel = New System.Windows.Forms.Label()
        CourseLabel = New System.Windows.Forms.Label()
        DateOfBirthLabel = New System.Windows.Forms.Label()
        GenderLabel = New System.Windows.Forms.Label()
        EmailLabel = New System.Windows.Forms.Label()
        PhoneNumberLabel = New System.Windows.Forms.Label()
        Address1Label = New System.Windows.Forms.Label()
        Address2Label = New System.Windows.Forms.Label()
        CityLabel = New System.Windows.Forms.Label()
        DistrictLabel = New System.Windows.Forms.Label()
        StateLabel = New System.Windows.Forms.Label()
        GroupIdLabel = New System.Windows.Forms.Label()
        CType(Me.IhsanTuitionCenterDbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudentBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StudentBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'MatricNumberLabel
        '
        MatricNumberLabel.AutoSize = True
        MatricNumberLabel.Location = New System.Drawing.Point(244, 44)
        MatricNumberLabel.Name = "MatricNumberLabel"
        MatricNumberLabel.Size = New System.Drawing.Size(78, 13)
        MatricNumberLabel.TabIndex = 1
        MatricNumberLabel.Text = "matric Number:"
        '
        'IcNumberLabel
        '
        IcNumberLabel.AutoSize = True
        IcNumberLabel.Location = New System.Drawing.Point(244, 70)
        IcNumberLabel.Name = "IcNumberLabel"
        IcNumberLabel.Size = New System.Drawing.Size(58, 13)
        IcNumberLabel.TabIndex = 3
        IcNumberLabel.Text = "ic Number:"
        '
        'NameLabel
        '
        NameLabel.AutoSize = True
        NameLabel.Location = New System.Drawing.Point(244, 96)
        NameLabel.Name = "NameLabel"
        NameLabel.Size = New System.Drawing.Size(36, 13)
        NameLabel.TabIndex = 5
        NameLabel.Text = "name:"
        '
        'CourseLabel
        '
        CourseLabel.AutoSize = True
        CourseLabel.Location = New System.Drawing.Point(244, 122)
        CourseLabel.Name = "CourseLabel"
        CourseLabel.Size = New System.Drawing.Size(42, 13)
        CourseLabel.TabIndex = 7
        CourseLabel.Text = "course:"
        '
        'DateOfBirthLabel
        '
        DateOfBirthLabel.AutoSize = True
        DateOfBirthLabel.Location = New System.Drawing.Point(244, 149)
        DateOfBirthLabel.Name = "DateOfBirthLabel"
        DateOfBirthLabel.Size = New System.Drawing.Size(69, 13)
        DateOfBirthLabel.TabIndex = 9
        DateOfBirthLabel.Text = "date Of Birth:"
        '
        'GenderLabel
        '
        GenderLabel.AutoSize = True
        GenderLabel.Location = New System.Drawing.Point(244, 174)
        GenderLabel.Name = "GenderLabel"
        GenderLabel.Size = New System.Drawing.Size(43, 13)
        GenderLabel.TabIndex = 11
        GenderLabel.Text = "gender:"
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.Location = New System.Drawing.Point(244, 200)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(34, 13)
        EmailLabel.TabIndex = 13
        EmailLabel.Text = "email:"
        '
        'PhoneNumberLabel
        '
        PhoneNumberLabel.AutoSize = True
        PhoneNumberLabel.Location = New System.Drawing.Point(244, 226)
        PhoneNumberLabel.Name = "PhoneNumberLabel"
        PhoneNumberLabel.Size = New System.Drawing.Size(80, 13)
        PhoneNumberLabel.TabIndex = 15
        PhoneNumberLabel.Text = "phone Number:"
        '
        'Address1Label
        '
        Address1Label.AutoSize = True
        Address1Label.Location = New System.Drawing.Point(244, 252)
        Address1Label.Name = "Address1Label"
        Address1Label.Size = New System.Drawing.Size(53, 13)
        Address1Label.TabIndex = 17
        Address1Label.Text = "address1:"
        '
        'Address2Label
        '
        Address2Label.AutoSize = True
        Address2Label.Location = New System.Drawing.Point(244, 278)
        Address2Label.Name = "Address2Label"
        Address2Label.Size = New System.Drawing.Size(53, 13)
        Address2Label.TabIndex = 19
        Address2Label.Text = "address2:"
        '
        'CityLabel
        '
        CityLabel.AutoSize = True
        CityLabel.Location = New System.Drawing.Point(244, 304)
        CityLabel.Name = "CityLabel"
        CityLabel.Size = New System.Drawing.Size(26, 13)
        CityLabel.TabIndex = 21
        CityLabel.Text = "city:"
        '
        'DistrictLabel
        '
        DistrictLabel.AutoSize = True
        DistrictLabel.Location = New System.Drawing.Point(244, 330)
        DistrictLabel.Name = "DistrictLabel"
        DistrictLabel.Size = New System.Drawing.Size(40, 13)
        DistrictLabel.TabIndex = 23
        DistrictLabel.Text = "district:"
        '
        'StateLabel
        '
        StateLabel.AutoSize = True
        StateLabel.Location = New System.Drawing.Point(244, 356)
        StateLabel.Name = "StateLabel"
        StateLabel.Size = New System.Drawing.Size(33, 13)
        StateLabel.TabIndex = 25
        StateLabel.Text = "state:"
        '
        'GroupIdLabel
        '
        GroupIdLabel.AutoSize = True
        GroupIdLabel.Location = New System.Drawing.Point(244, 382)
        GroupIdLabel.Name = "GroupIdLabel"
        GroupIdLabel.Size = New System.Drawing.Size(49, 13)
        GroupIdLabel.TabIndex = 27
        GroupIdLabel.Text = "group Id:"
        '
        'IhsanTuitionCenterDbDataSet
        '
        Me.IhsanTuitionCenterDbDataSet.DataSetName = "ihsanTuitionCenterDbDataSet"
        Me.IhsanTuitionCenterDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'StudentBindingSource
        '
        Me.StudentBindingSource.DataMember = "student"
        Me.StudentBindingSource.DataSource = Me.IhsanTuitionCenterDbDataSet
        '
        'StudentTableAdapter
        '
        Me.StudentTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.studentGroupTblTableAdapter = Nothing
        Me.TableAdapterManager.studentTableAdapter = Me.StudentTableAdapter
        Me.TableAdapterManager.subjectregiststerTableAdapter = Nothing
        Me.TableAdapterManager.subjectTableAdapter = Nothing
        Me.TableAdapterManager.teacherTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = ProjectDemoCRS.ihsanTuitionCenterDbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.userTblTableAdapter = Nothing
        '
        'StudentBindingNavigator
        '
        Me.StudentBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.StudentBindingNavigator.BindingSource = Me.StudentBindingSource
        Me.StudentBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.StudentBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.StudentBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.StudentBindingNavigatorSaveItem, Me.ToolStripButton1, Me.ToolStripButton2})
        Me.StudentBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.StudentBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.StudentBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.StudentBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.StudentBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.StudentBindingNavigator.Name = "StudentBindingNavigator"
        Me.StudentBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.StudentBindingNavigator.Size = New System.Drawing.Size(800, 25)
        Me.StudentBindingNavigator.TabIndex = 0
        Me.StudentBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'StudentBindingNavigatorSaveItem
        '
        Me.StudentBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.StudentBindingNavigatorSaveItem.Image = CType(resources.GetObject("StudentBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.StudentBindingNavigatorSaveItem.Name = "StudentBindingNavigatorSaveItem"
        Me.StudentBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.StudentBindingNavigatorSaveItem.Text = "Save Data"
        '
        'MatricNumberTextBox
        '
        Me.MatricNumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentBindingSource, "matricNumber", True))
        Me.MatricNumberTextBox.Location = New System.Drawing.Point(330, 41)
        Me.MatricNumberTextBox.Name = "MatricNumberTextBox"
        Me.MatricNumberTextBox.Size = New System.Drawing.Size(200, 20)
        Me.MatricNumberTextBox.TabIndex = 2
        '
        'IcNumberTextBox
        '
        Me.IcNumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentBindingSource, "icNumber", True))
        Me.IcNumberTextBox.Location = New System.Drawing.Point(330, 67)
        Me.IcNumberTextBox.Name = "IcNumberTextBox"
        Me.IcNumberTextBox.Size = New System.Drawing.Size(200, 20)
        Me.IcNumberTextBox.TabIndex = 4
        '
        'NameTextBox
        '
        Me.NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentBindingSource, "name", True))
        Me.NameTextBox.Location = New System.Drawing.Point(330, 93)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(200, 20)
        Me.NameTextBox.TabIndex = 6
        '
        'CourseTextBox
        '
        Me.CourseTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentBindingSource, "course", True))
        Me.CourseTextBox.Location = New System.Drawing.Point(330, 119)
        Me.CourseTextBox.Name = "CourseTextBox"
        Me.CourseTextBox.Size = New System.Drawing.Size(200, 20)
        Me.CourseTextBox.TabIndex = 8
        '
        'DateOfBirthDateTimePicker
        '
        Me.DateOfBirthDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.StudentBindingSource, "dateOfBirth", True))
        Me.DateOfBirthDateTimePicker.Location = New System.Drawing.Point(330, 145)
        Me.DateOfBirthDateTimePicker.Name = "DateOfBirthDateTimePicker"
        Me.DateOfBirthDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.DateOfBirthDateTimePicker.TabIndex = 10
        '
        'GenderTextBox
        '
        Me.GenderTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentBindingSource, "gender", True))
        Me.GenderTextBox.Location = New System.Drawing.Point(330, 171)
        Me.GenderTextBox.Name = "GenderTextBox"
        Me.GenderTextBox.Size = New System.Drawing.Size(200, 20)
        Me.GenderTextBox.TabIndex = 12
        '
        'EmailTextBox
        '
        Me.EmailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentBindingSource, "email", True))
        Me.EmailTextBox.Location = New System.Drawing.Point(330, 197)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(200, 20)
        Me.EmailTextBox.TabIndex = 14
        '
        'PhoneNumberTextBox
        '
        Me.PhoneNumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentBindingSource, "phoneNumber", True))
        Me.PhoneNumberTextBox.Location = New System.Drawing.Point(330, 223)
        Me.PhoneNumberTextBox.Name = "PhoneNumberTextBox"
        Me.PhoneNumberTextBox.Size = New System.Drawing.Size(200, 20)
        Me.PhoneNumberTextBox.TabIndex = 16
        '
        'Address1TextBox
        '
        Me.Address1TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentBindingSource, "address1", True))
        Me.Address1TextBox.Location = New System.Drawing.Point(330, 249)
        Me.Address1TextBox.Name = "Address1TextBox"
        Me.Address1TextBox.Size = New System.Drawing.Size(200, 20)
        Me.Address1TextBox.TabIndex = 18
        '
        'Address2TextBox
        '
        Me.Address2TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentBindingSource, "address2", True))
        Me.Address2TextBox.Location = New System.Drawing.Point(330, 275)
        Me.Address2TextBox.Name = "Address2TextBox"
        Me.Address2TextBox.Size = New System.Drawing.Size(200, 20)
        Me.Address2TextBox.TabIndex = 20
        '
        'CityTextBox
        '
        Me.CityTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentBindingSource, "city", True))
        Me.CityTextBox.Location = New System.Drawing.Point(330, 301)
        Me.CityTextBox.Name = "CityTextBox"
        Me.CityTextBox.Size = New System.Drawing.Size(200, 20)
        Me.CityTextBox.TabIndex = 22
        '
        'DistrictTextBox
        '
        Me.DistrictTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentBindingSource, "district", True))
        Me.DistrictTextBox.Location = New System.Drawing.Point(330, 327)
        Me.DistrictTextBox.Name = "DistrictTextBox"
        Me.DistrictTextBox.Size = New System.Drawing.Size(200, 20)
        Me.DistrictTextBox.TabIndex = 24
        '
        'StateTextBox
        '
        Me.StateTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentBindingSource, "state", True))
        Me.StateTextBox.Location = New System.Drawing.Point(330, 353)
        Me.StateTextBox.Name = "StateTextBox"
        Me.StateTextBox.Size = New System.Drawing.Size(200, 20)
        Me.StateTextBox.TabIndex = 26
        '
        'GroupIdTextBox
        '
        Me.GroupIdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentBindingSource, "groupId", True))
        Me.GroupIdTextBox.Location = New System.Drawing.Point(330, 379)
        Me.GroupIdTextBox.Name = "GroupIdTextBox"
        Me.GroupIdTextBox.Size = New System.Drawing.Size(200, 20)
        Me.GroupIdTextBox.TabIndex = 28
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton1.Text = "ToolStripButton1"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton2.Text = "ToolStripButton2"
        '
        'StudentForm2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 460)
        Me.Controls.Add(MatricNumberLabel)
        Me.Controls.Add(Me.MatricNumberTextBox)
        Me.Controls.Add(IcNumberLabel)
        Me.Controls.Add(Me.IcNumberTextBox)
        Me.Controls.Add(NameLabel)
        Me.Controls.Add(Me.NameTextBox)
        Me.Controls.Add(CourseLabel)
        Me.Controls.Add(Me.CourseTextBox)
        Me.Controls.Add(DateOfBirthLabel)
        Me.Controls.Add(Me.DateOfBirthDateTimePicker)
        Me.Controls.Add(GenderLabel)
        Me.Controls.Add(Me.GenderTextBox)
        Me.Controls.Add(EmailLabel)
        Me.Controls.Add(Me.EmailTextBox)
        Me.Controls.Add(PhoneNumberLabel)
        Me.Controls.Add(Me.PhoneNumberTextBox)
        Me.Controls.Add(Address1Label)
        Me.Controls.Add(Me.Address1TextBox)
        Me.Controls.Add(Address2Label)
        Me.Controls.Add(Me.Address2TextBox)
        Me.Controls.Add(CityLabel)
        Me.Controls.Add(Me.CityTextBox)
        Me.Controls.Add(DistrictLabel)
        Me.Controls.Add(Me.DistrictTextBox)
        Me.Controls.Add(StateLabel)
        Me.Controls.Add(Me.StateTextBox)
        Me.Controls.Add(GroupIdLabel)
        Me.Controls.Add(Me.GroupIdTextBox)
        Me.Controls.Add(Me.StudentBindingNavigator)
        Me.Name = "StudentForm2"
        Me.Text = "Form1"
        CType(Me.IhsanTuitionCenterDbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudentBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StudentBindingNavigator.ResumeLayout(False)
        Me.StudentBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents IhsanTuitionCenterDbDataSet As ihsanTuitionCenterDbDataSet
    Friend WithEvents StudentBindingSource As BindingSource
    Friend WithEvents StudentTableAdapter As ihsanTuitionCenterDbDataSetTableAdapters.studentTableAdapter
    Friend WithEvents TableAdapterManager As ihsanTuitionCenterDbDataSetTableAdapters.TableAdapterManager
    Friend WithEvents StudentBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents StudentBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents MatricNumberTextBox As TextBox
    Friend WithEvents IcNumberTextBox As TextBox
    Friend WithEvents NameTextBox As TextBox
    Friend WithEvents CourseTextBox As TextBox
    Friend WithEvents DateOfBirthDateTimePicker As DateTimePicker
    Friend WithEvents GenderTextBox As TextBox
    Friend WithEvents EmailTextBox As TextBox
    Friend WithEvents PhoneNumberTextBox As TextBox
    Friend WithEvents Address1TextBox As TextBox
    Friend WithEvents Address2TextBox As TextBox
    Friend WithEvents CityTextBox As TextBox
    Friend WithEvents DistrictTextBox As TextBox
    Friend WithEvents StateTextBox As TextBox
    Friend WithEvents GroupIdTextBox As TextBox
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents ToolStripButton2 As ToolStripButton
End Class
