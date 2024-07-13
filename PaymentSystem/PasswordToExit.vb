Public Class PasswordToExit


    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click

        Dim enterPassword As String = passwordtxtExit.Text.Trim()
        If enterPassword = PasswordModule.Password Then
            ' If correct, close the dialog form
            Me.DialogResult = System.Windows.Forms.DialogResult.OK
            Application.Exit()
        Else
            ' If incorrect, display a message
            MessageBox.Show("Incorrect password. Please try again.", "Invalid Password", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

End Class
