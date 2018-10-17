Imports InventoryLibrary

Public Class CreateUserAccountForm
    Private Sub MinimizeForm_Click(sender As Object, e As EventArgs) Handles MinimizeForm.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub ExitApp_Click(sender As Object, e As EventArgs) Handles ExitApp.Click
        Application.Exit()
    End Sub

    Private Sub ButtonCancel_Click(sender As Object, e As EventArgs) Handles ButtonCancel.Click
        Application.Exit()
    End Sub

    Private Sub ButtonBack_Click(sender As Object, e As EventArgs) Handles ButtonBack.Click
        LoginForm.Show() : Close()
    End Sub

    Private Sub ButtonNext_Click(sender As Object, e As EventArgs) Handles ButtonNext.Click
        If TextUser.Text = "" Then
            PanelMessage.Visible = True
            LabelMessage.Text = "You must provide a username for your account."
            TextUser.Focus()
        Else
            If UserAccount.UsernameExists(TextUser.Text) = True Then
                PanelMessage.Visible = True
                LabelMessage.Text = "The username you have entered has already been used. Please try another one."
                TextUser.Focus()
            Else
                If TextPass.Text.Length < 8 Then
                    PanelMessage.Visible = True
                    LabelMessage.Text = "Password should contain at least 8 characters."
                    TextPass.Focus()
                Else
                    If TextPass.Text <> TextReType.Text Then
                        PanelMessage.Visible = True
                        LabelMessage.Text = "The passwords you have entered do not match."
                        TextReType.Focus()
                    Else
                        CreateUserAccountDetailsForm.Show() : Hide() : PanelMessage.Visible = False
                    End If
                End If
            End If
        End If
    End Sub
End Class