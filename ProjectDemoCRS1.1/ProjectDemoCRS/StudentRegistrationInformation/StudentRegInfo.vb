Imports System.Data.OleDb
Friend Structure SubjectCodeRegInfo
    Dim matric, subjectCode As String
End Structure
Public Class SubjectCodeRegInfo

    Private con As New OleDb.OleDbConnection
    Friend Function getSubjectRegisterRecord(matric) As SubjectRegisterRecord
        Dim dr As OleDbDataReader
        Dim subjectregisterRec As New SubjectRegisterRecord
        Try
            Dim sql As String
            con.ConnectionString = My.Resources.databaseConnectionPath & Application.StartupPath & My.Resources.databaseName
            con.Open()
            sql = "select * FROM subjectresgister WHERE (subjectCode = '" & subjectCode & "')"

            MessageBox.Show(sql)
            Debug.WriteLine(sql)
            Dim cmd As New OleDbCommand(sql, con)
            dr = cmd.ExecuteReader()
            If dr.HasRows Then
                dr.Read()
                subjectregisterRec.matric = dr("matricNumber").ToString
                con.Close()
                Return subjectregisterRec
            End If
        Catch
            MessageBox.Show("Error accessing subjectregister record for subject with subject code :" & subjectCode)
            con.Close()
            Return subjectregisterRec
        End Try
        Return subjectregisterRec
    End Function
    Friend Function addSubjectRegister(newSubjectCodeRec As SubjectRegisterRecord) As Boolean
        Try
            Dim sql As String
            ''Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\registrationdb.accdb")
            con.ConnectionString = My.Resources.databaseConnectionPath & Application.StartupPath & My.Resources.databaseName
            con.Open()
            If con.State = ConnectionState.Open Then
                MsgBox("MS Database Connected!")
            Else
                MsgBox("error connecting to database")
                Exit Function
            End If
            sql = "insert into subjectregister(subjectCode,matricNumber)"
            sql = sql & " values('" & newSubjectCodeRec.subjectCode & "','" & newSubjectCodeRec.matric & "')"
            'insert into subject(matricNumber,icNumber,name,dateOfBirth,groupId) values('M1002','','Ahmad','1/9/2021 4:29:14 PM','P1_MERAH')
            MessageBox.Show(sql)
            Debug.WriteLine(sql)
            Dim cmd As New OleDbCommand(sql, con)
            cmd.ExecuteNonQuery()
            con.Close()
            Return True
        Catch ex As Exception

            MessageBox.Show("Error adding new subject register record. Message:" & ex.ToString)
            con.Close()
            Return False
        End Try
        Return True

    End Function
    Friend Function updateThisSubjectRegister(oldSubjectCodeRec As SubjectCodeRecord, newSubejctCodeRec As SubjectCodeRecord) As Boolean
        Try
            Dim sql As String
            con.ConnectionString = My.Resources.databaseConnectionPath & Application.StartupPath & My.Resources.databaseName
            con.Open()

            sql = "update subjectregister set subjectCode ='" & newSubjectCodeRec.subjectCode & "'"
            sql = sql & " matricNumber ='" & newSubjectCodeRec.matric & "'"
            sql = sql & " where subjectCode ='" & oldSubjectCodeRec.subjectCode & "'"
            MessageBox.Show(sql)
            Dim cmd As New OleDbCommand(sql, con)
            cmd.ExecuteNonQuery()
            con.Close()
            Return True

        Catch ex As Exception
            MessageBox.Show("Error updating group record. Message:" & ex.ToString)
            Return False
        End Try


    End Function
    Friend Function deleteSubjectCodeRecord(matric As String) As Boolean
        Try
            Dim sql As String
            con.ConnectionString = My.Resources.databaseConnectionPath & Application.StartupPath & My.Resources.databaseName
            con.Open()
            sql = "DELETE FROM subjectregister WHERE (subjectCode = '" & subjectCode & "')"
            MessageBox.Show(sql)
            Dim cmd As New OleDbCommand(sql, con)
            cmd.ExecuteNonQuery()
            con.Close()
            Return True
        Catch e As Exception
            MessageBox.Show(e.ToString) 'data integrity error
            Return False
        End Try

    End Function
End Class
