Public Class Log_in
    Private Sub loginBtn_Click(sender As Object, e As EventArgs) Handles loginBtn.Click
        Dim a As Integer = 0

        If txtUsername.Text = My.Settings.Username Then
            a += 1
        End If
        If txtPassword.Text = My.Settings.Password Then
            a += 1
        End If

        If a = 2 Then
            MessageBox.Show("Login successful!")
            Form5.Show()
            Form2.Hide()
            Me.Hide()
        ElseIf a < 2 Then
            MessageBox.Show("Your username/password is incorrect!")
        End If

    End Sub
End Class