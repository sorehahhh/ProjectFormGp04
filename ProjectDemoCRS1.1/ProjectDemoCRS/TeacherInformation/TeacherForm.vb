Public Class TeacherForm
    Dim myTeacher As New Teacher
    ' Dim theTeacherGroupRecord As TeacherGroupRecord
    Dim OldTeacherRec As TeacherRecord
    Friend Sub prepareToUpdateTeacher(teacherId As String)
        MessageBox.Show("to update teacher with id" & teacherId)
        With Me
            .AddUpdateButton.Text = "Update"
        End With
        displayExistingTeacherInfo(teacherId)
    End Sub

    Private Sub displayExistingTeacherInfo(teacherId As String)
        Try
            OldTeacherRec = myTeacher.getTeacherRecord(teacherId)
            With Me
                .icNumberTextBox.Text = OldTeacherRec.ic
                .IdTextBox.Text = OldTeacherRec.id
                .nameTextBox.Text = OldTeacherRec.name
                .nameTextBox.Text = OldTeacherRec.name
                MessageBox.Show(OldTeacherRec.dob.Date.ToString)
                'displayLevel(OldTeacherGroupRec.groupLevel) 'to check suitable radio button
                '.dobDateTimePicker1.CustomFormat = "dd-MM-yyyy"
                .dobDateTimePicker1.Value = OldTeacherRec.dob.Date
                .PhoneNumberTextBox.Text = OldTeacherRec.phone
                .subjectCodeBox.Text = OldTeacherRec.subject

            End With
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try

    End Sub
    Friend Sub prepareToAddNewTeacher()
        clearTeacherForm()
        With Me
            .AddUpdateButton.Text = "Add"
        End With
    End Sub
    Private Sub AddUpdateButton_Click(sender As Object, e As EventArgs) Handles AddUpdateButton.Click
        If AddUpdateButton.Text = "Add" Then
            addThisTeacher() 'add new teacher 
        Else 'update
            updateThisTeacher(OldTeacherRec)
        End If
    End Sub
    Private Sub addThisTeacher()
        Dim theNewTeacherRec As New TeacherRecord
        Dim addOk As Boolean
        Dim messageString As String
        With theNewTeacherRec
            .ic = icNumberTextBox.Text
            .id = IdTextBox.Text
            .gender = getLevelFromRadioButton()
            .name = nameTextBox.Text
            .dob = dobDateTimePicker1.Value
            .phone = PhoneNumberTextBox.Text
            .subject = subjectCodeBox.Text
        End With

        addOk = myTeacher.addTeacher(theNewTeacherRec)
        If addOk Then
            messageString = "New teacher with id : " & theNewTeacherRec.id & " has been added"
            MessageBox.Show(messageString, "Add New Teacher ", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        End If
    End Sub
    Private Sub clearTeacherForm()
        With Me
            .IdTextBox.Clear()
            .icNumberTextBox.Clear()
            .nameTextBox.Clear()

            .subjectCodeBox.Text = ""
        End With
    End Sub

    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
        Me.Close()
    End Sub
    Private Sub updateThisTeacher(oldTeacherRec As TeacherRecord)
        Dim theNewTeacherRec As New TeacherRecord
        Dim updateOk As Boolean
        Dim messageString As String
        theNewTeacherRec.id = IdTextBox.Text
        theNewTeacherRec.ic = icNumberTextBox.Text
        theNewTeacherRec.name = nameTextBox.Text
        theNewTeacherRec.gender = getLevelFromRadioButton() 'levelTextBox.Text
        theNewTeacherRec.dob = dobDateTimePicker1.Value
        theNewTeacherRec.phone = PhoneNumberTextBox.Text
        theNewTeacherRec.subject = subjectCodeBox.Text
        updateOk = myTeacher.updateThisTeacher(oldTeacherRec, theNewTeacherRec)
        If updateOk Then
            messageString = "Teacher with id : " & theNewTeacherRec.id & " has been updated"
            MessageBox.Show(messageString, "Update", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        End If
    End Sub
    Private Function getLevelFromRadioButton() As String
        If MaleRadioButton.Checked Then
            Return "MALE"
        Else
            Return "FEMALE"
        End If
    End Function
    Private Sub displayLevel(level As String)
        If level = "MALE" Then
            MaleRadioButton.Checked = True
        Else
            FemaleRadioButton.Checked = True
        End If

    End Sub

    Private Sub StudentForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.subjectCodeBox.Items.Add("1103")
        Me.subjectCodeBox.Items.Add("1119")
        Me.subjectCodeBox.Items.Add("1223")
        Me.subjectCodeBox.Items.Add("1225")
        Me.subjectCodeBox.Items.Add("1249")
        Me.subjectCodeBox.Items.Add("1449")
        Me.subjectCodeBox.Items.Add("1511")
        Me.subjectCodeBox.Items.Add("3472")
        Me.subjectCodeBox.Items.Add("4531")
        Me.subjectCodeBox.Items.Add("4541")
        Me.subjectCodeBox.Items.Add("4551")
        Me.subjectCodeBox.Items.Add("4561")
        Me.subjectCodeBox.Items.Add("3765")
    End Sub

    Private Sub classComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles subjectCodeBox.SelectedIndexChanged
        ' Just to see a visual of what was selected
        Dim selectedItem = CType(subjectCodeBox.SelectedItem, String)
        Dim resultIndex As Integer = subjectCodeBox.FindStringExact(subjectCodeBox.SelectedItem)
        ' Me.ComboBox2.Items.RemoveAt(resultIndex)
    End Sub
End Class