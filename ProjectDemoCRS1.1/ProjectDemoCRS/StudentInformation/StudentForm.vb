Public Class StudentForm
    Dim myStudent As New Student
    ' Dim theStudentGroupRecord As StudentGroupRecord
    Dim OldStudentRec As StudentRecord


    Friend Sub prepareToUpdateStudent(studentMatric As String)
        MessageBox.Show("to update student with matric" & studentMatric)
        With Me
            .AddUpdateButton.Text = "Update"
        End With
        displayExistingStudentInfo(studentMatric)
    End Sub

    Private Sub displayExistingStudentInfo(studentMatric As String)
        Try
            OldStudentRec = myStudent.getStudentRecord(studentMatric)
            With Me
                .icNumberTextBox.Text = OldStudentRec.ic
                .matricTextBox.Text = OldStudentRec.matric
                .nameTextBox.Text = OldStudentRec.name
                displayLevel(OldStudentRec.gender)
                MessageBox.Show(OldStudentRec.dob.Date.ToString)
                'displayLevel(OldStudentGroupRec.groupLevel) 'to check suitable radio button
                '.dobDateTimePicker1.CustomFormat = "dd-MM-yyyy"
                .dobDateTimePicker1.Value = OldStudentRec.dob.Date
                .PhoneNumberTextBox.Text = OldStudentRec.phone
                .classComboBox.Text = OldStudentRec.classGroup
                .Address1TextBox.Text = OldStudentRec.address1
                .Address2TextBox.Text = OldStudentRec.address2
                .PostcodeTextBox.Text = OldStudentRec.postcode
            End With
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try

    End Sub
    Friend Sub prepareToAddNewStudent()
        clearStudentForm()
        With Me
            .AddUpdateButton.Text = "Add"
        End With
    End Sub
    Private Sub AddUpdateButton_Click(sender As Object, e As EventArgs) Handles AddUpdateButton.Click
        If AddUpdateButton.Text = "Add" Then
            addThisStudent() 'add new subject 
        Else 'update
            updateThisStudent(OldStudentRec)
        End If
    End Sub
    Private Sub addThisStudent()
        Dim theNewStudentRec As New StudentRecord
        Dim addOk As Boolean
        Dim messageString As String
        With theNewStudentRec
            .ic = icNumberTextBox.Text
            .matric = matricTextBox.Text
            .name = nameTextBox.Text
            .gender = getLevelFromRadioButton()
            .dob = dobDateTimePicker1.Value
            .phone = PhoneNumberTextBox.Text
            .classGroup = classComboBox.Text
            .address1 = Address1TextBox.Text
            .address2 = Address2TextBox.Text
            .postcode = PostcodeTextBox.Text
        End With

        addOk = myStudent.addStudent(theNewStudentRec)
        If addOk Then
            messageString = "New student with matric : " & theNewStudentRec.matric & " has been succesfully added"
            MessageBox.Show(messageString, "Add New Student ", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        End If
    End Sub
    Private Sub clearStudentForm()
        With Me
            .matricTextBox.Clear()
            .icNumberTextBox.Clear()
            .nameTextBox.Clear()

            .classComboBox.Text = ""
        End With
    End Sub

    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
        Me.Close()
    End Sub
    Private Sub updateThisStudent(oldStudentRec As StudentRecord)
        Dim theNewStudentRec As New StudentRecord
        Dim updateOk As Boolean
        Dim messageString As String
        theNewStudentRec.matric = matricTextBox.Text
        theNewStudentRec.ic = icNumberTextBox.Text
        theNewStudentRec.name = nameTextBox.Text
        theNewStudentRec.gender = getLevelFromRadioButton() 'levelTextBox.Text
        theNewStudentRec.dob = dobDateTimePicker1.Value
        theNewStudentRec.phone = PhoneNumberTextBox.Text
        theNewStudentRec.classGroup = classComboBox.Text
        theNewStudentRec.address1 = Address1TextBox.Text
        theNewStudentRec.address2 = Address2TextBox.Text
        theNewStudentRec.postcode = PostcodeTextBox.Text
        updateOk = myStudent.updateThisStudent(oldStudentRec, theNewStudentRec)
        If updateOk Then
            messageString = "Student with matric : " & theNewStudentRec.matric & " has been updated"
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
End Class