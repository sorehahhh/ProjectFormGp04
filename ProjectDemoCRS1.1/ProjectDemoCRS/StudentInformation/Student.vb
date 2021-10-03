﻿Imports System.Data.OleDb
Friend Structure StudentRecord
    Dim matric, ic, name, email, phone, classGroup, gender, address1, address2, postcode As String
    Dim dob As Date
End Structure
Public Class StudentRegInfo

    Private con As New OleDb.OleDbConnection
    Friend Function getStudentRecord(matric) As StudentRecord
        Dim dr As OleDbDataReader
        Dim studentRec As New StudentRecord
        Try
            Dim sql As String
            con.ConnectionString = My.Resources.databaseConnectionPath & Application.StartupPath & My.Resources.databaseName
            con.Open()
            sql = "select * FROM student WHERE (matricNumber = '" & matric & "')"

            MessageBox.Show(sql)
            Debug.WriteLine(sql)
            Dim cmd As New OleDbCommand(sql, con)
            dr = cmd.ExecuteReader()
            If dr.HasRows Then
                dr.Read()
                studentRec.ic = dr("icNumber").ToString
                studentRec.matric = dr("matricNumber").ToString
                studentRec.name = dr("name").ToString
                studentRec.gender = dr("gender").ToString
                studentRec.classGroup = dr("groupId").ToString
                studentRec.dob = dr("dateOfBirth")
                studentRec.phone = dr("phoneNumber").ToString
                studentRec.address1 = dr("address1").ToString
                studentRec.address2 = dr("address2").ToString
                studentRec.postcode = dr("postcode").ToString
                con.Close()
                Return studentRec
            End If
        Catch
            MessageBox.Show("Error accessing student record for subject with matric :" & matric)
            con.Close()
            Return studentRec
        End Try
        Return studentRec
    End Function
    Friend Function addStudent(newStudentRec As StudentRecord) As Boolean
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
            sql = "insert into student(matricNumber,icNumber,name,gender,dateOfBirth,phoneNumber,groupId,address1,address2,postcode)"
            sql = sql & " values('" & newStudentRec.matric & "','" & newStudentRec.ic & "','" & newStudentRec.name & "','" & newStudentRec.gender & "','" & newStudentRec.dob & "','" & newStudentRec.phone & "','" & newStudentRec.classGroup & "','" & newStudentRec.address1 & "','" & newStudentRec.address2 & "','" & newStudentRec.postcode & "')"
            'insert into subject(matricNumber,icNumber,name,dateOfBirth,groupId) values('M1002','','Ahmad','1/9/2021 4:29:14 PM','P1_MERAH')
            MessageBox.Show(sql)
            Debug.WriteLine(sql)
            Dim cmd As New OleDbCommand(sql, con)
            cmd.ExecuteNonQuery()
            con.Close()
            Return True
        Catch ex As Exception

            MessageBox.Show("Error adding new student record. Message:" & ex.ToString)
            con.Close()
            Return False
        End Try
        Return True

    End Function
    Friend Function updateThisStudent(oldStudentRec As StudentRecord, newStudentRec As StudentRecord) As Boolean
        Try
            Dim sql As String
            con.ConnectionString = My.Resources.databaseConnectionPath & Application.StartupPath & My.Resources.databaseName
            con.Open()

            sql = "update student set matricNumber ='" & newStudentRec.matric & "',"
            sql = sql & " icNumber ='" & newStudentRec.ic & "',"
            sql = sql & " name ='" & newStudentRec.name & "',"
            sql = sql & " gender ='" & newStudentRec.gender & "',"
            sql = sql & " dateOfBirth ='" & newStudentRec.dob & "',"
            sql = sql & " phoneNumber ='" & newStudentRec.phone & "',"
            sql = sql & " groupId ='" & newStudentRec.classGroup & "',"
            sql = sql & " address1 ='" & newStudentRec.address1 & "',"
            sql = sql & " address2='" & newStudentRec.address2 & "',"
            sql = sql & " postcode ='" & newStudentRec.postcode & "'"
            sql = sql & " where matricNumber ='" & oldStudentRec.matric & "'"
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
    Friend Function deleteStudentRecord(matric As String) As Boolean
        Try
            Dim sql As String
            con.ConnectionString = My.Resources.databaseConnectionPath & Application.StartupPath & My.Resources.databaseName
            con.Open()
            sql = "DELETE FROM student WHERE (matricNumber = '" & matric & "')"
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
