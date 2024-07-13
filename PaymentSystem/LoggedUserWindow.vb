Public Class LoggedUserWindow
    Private Sub LoggedUserWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub LU_exit_button_Click(sender As Object, e As EventArgs) Handles LU_exit_button.Click

        Dim confirmExit As New LoggedExitConfirmation()
        Dim result As DialogResult = confirmExit.ShowDialog()
        ' Check the result of the exit confirmation dialog
        If result = DialogResult.OK Then
            ' If the user confirmed the exit, allow the form to close
            Dim login As New LoginWindow()
            login.Show()
            Me.Close()

        Else
            ' If the user canceled the exit, cancel the form closing
            confirmExit.Close()
        End If

    End Sub

    Private Sub LU_pay_button_Click(sender As Object, e As EventArgs) Handles LU_pay_button.Click
        Dim payment As New PaymentWindow()
        payment.Show()
        Me.Close()
    End Sub
End Class