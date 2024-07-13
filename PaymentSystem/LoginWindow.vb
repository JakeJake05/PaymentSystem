Public Class LoginWindow
    Private Sub LoginWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        systemTimer1.Interval = 1000
        time1.Interval = 1000
        systemTimer1.Start()

    End Sub

    Private Sub systemTimer_Tick(sender As Object, e As EventArgs) Handles systemTimer1.Tick

        date_display.Text = Date.Now.ToString("MM-dd-yyyy")
        time_display.Text = Date.Now.ToString("hh:mm:ss tt")

    End Sub

    Private Sub enter_button_log_Click(sender As Object, e As EventArgs) Handles enter_button_log.Click

        Dim SendId_string As String = "202011586"
        log_id_box.Text = SendId_string

    End Sub

    Private Sub log_id_box_TextChanged(sender As Object, e As EventArgs) Handles log_id_box.TextChanged
        ' Define the required ID or pattern
        Dim id_string As String = "202011586" ' Example ID

        ' Check if the typed ID matches 
        If log_id_box.Text.Trim() = id_string Then
            Dim LoggedIn As New LoggedUserWindow()
            LoggedIn.Show()
            Me.Hide()
        Else
            log_id_box.Clear()
            error_disp.Text = "ID Not Found"
            time1.Start()
        End If
    End Sub

    Private Sub time1_Tick(sender As Object, e As EventArgs) Handles time1.Tick

        error_disp.Text = "Scan or Enter your ID Number"
        time1.Stop()

    End Sub

    Private Sub LoginWindow_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        ' Check if Alt + F4 is pressed
        If e.Alt AndAlso e.KeyCode = Keys.F4 Then
            ' Close all forms
            For Each frm As Form In Application.OpenForms
                frm.Close()
                Application.Exit()
            Next
        End If
    End Sub

    Private Sub register_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles register.LinkClicked
        Dim register As New RegistarionWindow()
        register.Show()
        Me.Hide()
    End Sub
End Class