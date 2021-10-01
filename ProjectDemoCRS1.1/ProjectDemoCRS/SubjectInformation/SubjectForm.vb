Public Class SubjectForm
    Dim mySubject As New Subject
    ' Dim theSubjectGroupRecord As SubjectGroupRecord
    Dim OldSubjectRec As SubjectRecord

    Friend Sub prepareToUpdateSubject(subjectCode As String)
        MessageBox.Show("to update student with subject Code" & subjectCode)
        With Me
            .AddUpdateButton.Text = "Update"
        End With
        displayExistingSubjectInfo(subjectCode)
    End Sub

    Private Sub displayExistingSubjectInfo(subjectCode As String)
        Try
            OldSubjectRec = mySubject.getSubjectRecord(subjectCode)
            With Me
                .nameTextBox.Text = OldSubjectRec.name
                MessageBox.Show(OldSubjectRec.credit.ToString)
                'displayLevel(OldSubjectGroupRec.groupLevel) 'to check suitable radio button
                '.dobDateTimePicker1.CustomFormat = "dd-MM-yyyy"
                .creditTextBox.Text = OldSubjectRec.credit
                .subjectCodeTextBox.Text = OldSubjectRec.subjectCode
            End With
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Friend Sub prepareToAddNewSubject()
        clearSubjectForm()
        With Me
            .AddUpdateButton.Text = "Add"
        End With
    End Sub
    Private Sub AddUpdateButton_Click(sender As Object, e As EventArgs) Handles AddUpdateButton.Click
        If AddUpdateButton.Text = "Add" Then
            addThisSubject() 'add new subject
        Else 'update
            updateThisSubject(OldSubjectRec)
        End If
    End Sub
    Private Sub addThisSubject()
        Dim theNewSubjectRec As New SubjectRecord
        Dim addOk As Boolean
        Dim messageString As String
        With theNewSubjectRec
            .subjectCode = subjectCodeTextBox.Text
            .name = nameTextBox.Text
            .credit = creditTextBox.Text
        End With
        addOk = mySubject.addSubject(theNewSubjectRec)
        If addOk Then
            messageString = "New subject with subject code : " & theNewSubjectRec.subjectCode & " has been added"
            MessageBox.Show(messageString, "Add New Subject ", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        End If
    End Sub
    Private Sub clearSubjectForm()
        With Me
            .subjectCodeTextBox.Clear()
            .nameTextBox.Clear()
            '.classComboBox.Text = ""
        End With
    End Sub

    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
        Me.Close()
    End Sub
    Private Sub updateThisSubject(oldSubjectRec As SubjectRecord)
        Dim theNewSubjectRec As New SubjectRecord
        Dim updateOk As Boolean
        Dim messageString As String
        theNewSubjectRec.subjectCode = subjectCodeTextBox.Text
        theNewSubjectRec.name = nameTextBox.Text
        theNewSubjectRec.credit = creditTextBox.Text
        updateOk = mySubject.updateThisSubject(oldSubjectRec, theNewSubjectRec)
        If updateOk Then
            messageString = "Subject with subjectCode : " & theNewSubjectRec.subjectCode & " has been updated"
            MessageBox.Show(messageString, "Update", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        End If
    End Sub

End Class