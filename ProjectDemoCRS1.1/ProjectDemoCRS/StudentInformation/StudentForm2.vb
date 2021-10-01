Public Class StudentForm2
    Private Sub StudentBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles StudentBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.StudentBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.IhsanTuitionCenterDbDataSet)
        MessageBox.Show("Updated")


    End Sub

    Private Sub StudentForm2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'IhsanTuitionCenterDbDataSet.student' table. You can move, or remove it, as needed.
        Me.StudentTableAdapter.Fill(Me.IhsanTuitionCenterDbDataSet.student)

    End Sub
End Class