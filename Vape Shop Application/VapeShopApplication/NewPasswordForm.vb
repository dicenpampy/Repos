Public Class NewPasswordForm
    Private Sub ButtonCancel_Click(sender As Object, e As EventArgs) Handles ButtonCancel.Click
        Application.Exit()
    End Sub

    Private Sub ExitApp_Click(sender As Object, e As EventArgs) Handles ExitApp.Click
        Application.Exit()
    End Sub

    Private Sub MinimizeForm_Click(sender As Object, e As EventArgs) Handles MinimizeForm.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub NewPasswordForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextUser.Text = u_acc
        u_acc = Nothing : code = Nothing
    End Sub

    Private Sub ButtonConfirm_Click(sender As Object, e As EventArgs) Handles ButtonConfirm.Click
        If TextPass.Text.Length < 8 Then
            PanelMessage.Visible = True
            LabelMessage.Text = "New password should contain at least 8 characters."
            TextPass.Focus()
        Else
            If TextPass.Text <> TextReType.Text Then
                PanelMessage.Visible = True
                LabelMessage.Text = "The passwords you have entered do not match."
                TextReType.Focus()
            Else
                PanelMessage.Visible = False
                ChangeUserPass(TextUser.Text, TextPass.Text)
                LoginForm.Show() : Close()
            End If
        End If
    End Sub
End Class