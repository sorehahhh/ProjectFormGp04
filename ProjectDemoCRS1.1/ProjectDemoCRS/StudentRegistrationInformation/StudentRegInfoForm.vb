Public Class StudentRegInfoForm
    Dim mySubjectRegister As New SubjectRegisterRegInfo
    ' Dim theSubjectRegisterGroupRecord As SubjectRegisterGroupRecord
    Dim OldSubjectRegisterRec As SubjectRegisterRecord


    Friend Sub prepareToUpdateSubjectRegister(subjectregisterSubjectCode As String)
        MessageBox.Show("to update subjectregister with subjectCode" & subjectregisterSubjectCode)
        With Me
            .AddUpdateButton.Text = "Update"
        End With
        displayExistingSubjectRegisterInfo(subjectregisterSubjectCode)
    End Sub

    Private Sub displayExistingSubjectRegisterInfo(subjectregisterSubjectCode As String)
        Try
            OldSubjectRegisterRec = mySubjectRegister.getSubjectRegisterRecord(subjectregisterSubjectCode)
            With Me
                .nameTextBox.Text = OldSubjectRegisterRec.name
                .matricTextBox.Text = OldSubjectRegisterRec.matric
            End With
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try

    End Sub
    Friend Sub prepareToAddNewSubjectRegister()
        clearSubjectRegisterForm()
        With Me
            .AddUpdateButton.Text = "Add"
        End With
    End Sub
    Private Sub AddUpdateButton_Click(sender As Object, e As EventArgs) Handles AddUpdateButton.Click
        If AddUpdateButton.Text = "Add" Then
            addThisSubjectRegister() 'add new subject 
        Else 'update
            updateThisSubjectRegister(OldSubjectRegisterRec)
        End If
    End Sub
    Private Sub addThisSubjectRegister()
        Dim theNewSubjectRegisterRec As New SubjectRegisterRecord
        Dim addOk As Boolean
        Dim messageString As String
        With theNewSubjectRegisterRec
            .SubjectCodeTextBox.Text = OldSubjectRegisterRec.subjectCode
            .matricTextBox.Text = OldSubjectRegisterRec.matric
        End With

        addOk = mySubjectRegister.addSubjectRegister(theNewSubjectRegisterRec)
        If addOk Then
            messageString = "New subjectregister with subjectCode : " & theNewSubjectRegisterRec.matric & " has been succesfully added"
            MessageBox.Show(messageString, "Add New SubjectRegister ", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        End If
    End Sub
    Private Sub clearSubjectRegisterForm()
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
    Private Sub updateThisSubjectRegister(oldSubjectRegisterRec As SubjectRegisterRecord)
        Dim theNewSubjectRegisterRec As New SubjectRegisterRecord
        Dim updateOk As Boolean
        Dim messageString As String

        theNewSubjectRegisterRec.subjectCode = SubjectCodeTextBox.Text
        theNewSubjectRegisterRec.matric = matricTextBox.Text

        updateOk = mySubjectRegister.updateThisSubjectRegister(oldSubjectRegisterRec, theNewSubjectRegisterRec)
        If updateOk Then
            messageString = "SubjectRegister with subjectCode : " & theNewSubjectRegisterRec.matric & " has been updated"
            MessageBox.Show(messageString, "Update", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        End If
    End Sub

End Class