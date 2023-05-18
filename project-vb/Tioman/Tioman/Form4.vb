Public Class Receipt
    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        Me.Hide()
        Form2.Show()
        Form3.Hide()
        Form3.txtName.Text = ""
        Form3.txtIC.Text = ""
        Form3.txtContact.Text = ""
        Form3.txtEmail.Text = ""
        Form3.txtAdd.Text = ""
        Form3.cboAdult.SelectedIndex = 0
        Form3.cboChild.SelectedIndex = 0
        Form3.cboSenior.SelectedIndex = 0
        Form3.bookDate.Value = Now
    End Sub
End Class