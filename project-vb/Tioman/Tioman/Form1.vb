Public Class Form1
    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs)
        OpenFileDialog1.ShowDialog()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Staff_InfoDataSet.StaffInfo' table. You can move, or remove it, as needed.
        Me.StaffInfoTableAdapter.Fill(Me.Staff_InfoDataSet.StaffInfo)
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Me.StaffInfoBindingSource.AddNew()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Me.StaffInfoBindingSource.EndEdit()
        Me.TableAdapterManager1.UpdateAll(Me.Staff_InfoDataSet)
        MessageBox.Show("Data Saved")
        My.Settings.Username = UsernameTextBox.Text
        My.Settings.Password = PasswordTextBox.Text
        My.Settings.Save()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Me.StaffInfoBindingSource.RemoveCurrent()
        Me.TableAdapterManager1.UpdateAll(Me.Staff_InfoDataSet)
        MessageBox.Show("Data has been remove")
    End Sub
End Class