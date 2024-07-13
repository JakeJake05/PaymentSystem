Public Class RegistarionWindow
    Private Sub RegistarionWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub re_exit_button_Click(sender As Object, e As EventArgs) Handles re_exit_button.Click

        Dim newLoginWin As New LoginWindow()
        newLoginWin.Show()
        Me.Hide()

    End Sub

End Class
