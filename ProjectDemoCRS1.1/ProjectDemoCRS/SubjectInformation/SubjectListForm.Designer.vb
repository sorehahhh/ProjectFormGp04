﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SubjectListForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SubjectListForm))
        Me.Search = New System.Windows.Forms.GroupBox()
        Me.displayAllButton = New System.Windows.Forms.Button()
        Me.nameButton = New System.Windows.Forms.Button()
        Me.ICButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.searchTextBox = New System.Windows.Forms.TextBox()
        Me.updateSubjectButton = New System.Windows.Forms.Button()
        Me.AddSubjectButton = New System.Windows.Forms.Button()
        Me.DeleteSubjectButton = New System.Windows.Forms.Button()
        Me.SubjectDataGridView = New System.Windows.Forms.DataGridView()
        Me.Search.SuspendLayout()
        CType(Me.SubjectDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Search
        '
        Me.Search.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Search.Controls.Add(Me.displayAllButton)
        Me.Search.Controls.Add(Me.nameButton)
        Me.Search.Controls.Add(Me.ICButton)
        Me.Search.Controls.Add(Me.Label1)
        Me.Search.Controls.Add(Me.searchTextBox)
        Me.Search.Font = New System.Drawing.Font("Nirmala UI", 16.27826!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Search.Location = New System.Drawing.Point(99, 31)
        Me.Search.Name = "Search"
        Me.Search.Size = New System.Drawing.Size(1178, 93)
        Me.Search.TabIndex = 18
        Me.Search.TabStop = False
        Me.Search.Text = "Search"
        '
        'displayAllButton
        '
        Me.displayAllButton.BackColor = System.Drawing.Color.PaleTurquoise
        Me.displayAllButton.Location = New System.Drawing.Point(849, 30)
        Me.displayAllButton.Name = "displayAllButton"
        Me.displayAllButton.Size = New System.Drawing.Size(124, 41)
        Me.displayAllButton.TabIndex = 4
        Me.displayAllButton.Text = "Display All"
        Me.displayAllButton.UseVisualStyleBackColor = False
        '
        'nameButton
        '
        Me.nameButton.BackColor = System.Drawing.Color.PaleTurquoise
        Me.nameButton.Location = New System.Drawing.Point(699, 30)
        Me.nameButton.Name = "nameButton"
        Me.nameButton.Size = New System.Drawing.Size(124, 41)
        Me.nameButton.TabIndex = 3
        Me.nameButton.Text = "By Name"
        Me.nameButton.UseVisualStyleBackColor = False
        '
        'ICButton
        '
        Me.ICButton.BackColor = System.Drawing.Color.PaleTurquoise
        Me.ICButton.Location = New System.Drawing.Point(534, 30)
        Me.ICButton.Name = "ICButton"
        Me.ICButton.Size = New System.Drawing.Size(146, 41)
        Me.ICButton.TabIndex = 2
        Me.ICButton.Text = "Subject Code"
        Me.ICButton.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(41, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(173, 30)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Subject / Name"
        '
        'searchTextBox
        '
        Me.searchTextBox.Location = New System.Drawing.Point(220, 40)
        Me.searchTextBox.Name = "searchTextBox"
        Me.searchTextBox.Size = New System.Drawing.Size(295, 36)
        Me.searchTextBox.TabIndex = 0
        '
        'updateSubjectButton
        '
        Me.updateSubjectButton.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.updateSubjectButton.Font = New System.Drawing.Font("Nirmala UI", 18.15652!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.updateSubjectButton.Location = New System.Drawing.Point(319, 500)
        Me.updateSubjectButton.Margin = New System.Windows.Forms.Padding(6)
        Me.updateSubjectButton.Name = "updateSubjectButton"
        Me.updateSubjectButton.Size = New System.Drawing.Size(209, 60)
        Me.updateSubjectButton.TabIndex = 17
        Me.updateSubjectButton.Text = "Update Subject"
        Me.updateSubjectButton.UseVisualStyleBackColor = False
        '
        'AddSubjectButton
        '
        Me.AddSubjectButton.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.AddSubjectButton.Font = New System.Drawing.Font("Nirmala UI", 18.15652!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddSubjectButton.Location = New System.Drawing.Point(5, 500)
        Me.AddSubjectButton.Margin = New System.Windows.Forms.Padding(6)
        Me.AddSubjectButton.Name = "AddSubjectButton"
        Me.AddSubjectButton.Size = New System.Drawing.Size(308, 60)
        Me.AddSubjectButton.TabIndex = 16
        Me.AddSubjectButton.Text = "Add New Subject"
        Me.AddSubjectButton.UseVisualStyleBackColor = False
        '
        'DeleteSubjectButton
        '
        Me.DeleteSubjectButton.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.DeleteSubjectButton.Font = New System.Drawing.Font("Nirmala UI", 18.15652!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeleteSubjectButton.Location = New System.Drawing.Point(569, 500)
        Me.DeleteSubjectButton.Margin = New System.Windows.Forms.Padding(6)
        Me.DeleteSubjectButton.Name = "DeleteSubjectButton"
        Me.DeleteSubjectButton.Size = New System.Drawing.Size(228, 60)
        Me.DeleteSubjectButton.TabIndex = 15
        Me.DeleteSubjectButton.Text = "Delete Subject"
        Me.DeleteSubjectButton.UseVisualStyleBackColor = False
        '
        'SubjectDataGridView
        '
        Me.SubjectDataGridView.BackgroundColor = System.Drawing.Color.SteelBlue
        Me.SubjectDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SubjectDataGridView.Location = New System.Drawing.Point(35, 137)
        Me.SubjectDataGridView.MultiSelect = False
        Me.SubjectDataGridView.Name = "SubjectDataGridView"
        Me.SubjectDataGridView.RowHeadersWidth = 49
        Me.SubjectDataGridView.Size = New System.Drawing.Size(1242, 353)
        Me.SubjectDataGridView.TabIndex = 14
        '
        'SubjectListForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1028, 609)
        Me.Controls.Add(Me.Search)
        Me.Controls.Add(Me.updateSubjectButton)
        Me.Controls.Add(Me.AddSubjectButton)
        Me.Controls.Add(Me.DeleteSubjectButton)
        Me.Controls.Add(Me.SubjectDataGridView)
        Me.Name = "SubjectListForm"
        Me.Text = "Form2"
        Me.Search.ResumeLayout(False)
        Me.Search.PerformLayout()
        CType(Me.SubjectDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Search As GroupBox
    Friend WithEvents displayAllButton As Button
    Friend WithEvents nameButton As Button
    Friend WithEvents ICButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents searchTextBox As TextBox
    Friend WithEvents updateSubjectButton As Button
    Friend WithEvents AddSubjectButton As Button
    Friend WithEvents DeleteSubjectButton As Button
    Friend WithEvents SubjectDataGridView As DataGridView
End Class
