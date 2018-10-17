Imports Encryptor
Imports InventoryLibrary

Public Class LoginForm
    Private Sub ButtonCancel_Click(sender As Object, e As EventArgs) Handles ButtonCancel.Click
        Application.Exit()
    End Sub

    Private Sub ExitApp_Click(sender As Object, e As EventArgs) Handles ExitApp.Click
        Application.Exit()
    End Sub

    Private Sub MinimizeForm_Click(sender As Object, e As EventArgs) Handles MinimizeForm.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub ButtonLogin_Click(sender As Object, e As EventArgs) Handles ButtonLogin.Click
        If PermitUserLogin(TextUser.Text, TextPass.Text) = True Then MainForm.Show() : Close() Else PanelMessage.Visible = True : TextPass.Clear() : TextPass.Focus()
    End Sub

    Private Sub ButtonCreateAcc_Click(sender As Object, e As EventArgs) Handles ButtonCreateAcc.Click
        CreateUserAccountForm.Show() : Close()
    End Sub

    Private Sub ButtonHelp_Click(sender As Object, e As EventArgs) Handles ButtonHelp.Click
        PasswordResetForm.Show() : Close()
    End Sub

End Class