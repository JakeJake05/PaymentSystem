Public Class PaymentWindow
    Private Sub PaymentWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Sub confirm_button_Click(sender As Object, e As EventArgs) Handles confirm_button.Click

        Dim pymnt_confirmation As New PaymentConfirmation()
        pymnt_confirmation.Show()
        Me.Close()

    End Sub

    Private Sub cancel_pay_button_Click(sender As Object, e As EventArgs) Handles cancel_pay_button.Click
        Dim logged As New LoggedUserWindow
        logged.Show()
        Me.Close()

    End Sub
End Class