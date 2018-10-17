Public Class CreateUserAccountDetailsForm

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
        CreateUserAccountForm.Show() : Hide()
    End Sub

    Private Sub ButtonNext_Click(sender As Object, e As EventArgs) Handles ButtonNext.Click
        If TextFirstName.Text = "" Then
            PanelMessage.Visible = True
            LabelMessage.Text = "Please enter your first name."
            TextFirstName.Focus()
        Else
            If TextLastName.Text = "" Then
                PanelMessage.Visible = True
                LabelMessage.Text = "Please enter your last name."
                TextLastName.Focus()
            Else
                If EmailCheck(TextEmail.Text) = False Then
                    PanelMessage.Visible = True
                    LabelMessage.Text = "Please enter a valid email address."
                    TextEmail.Focus()
                Else
                    If TextAddress.Text = "" Then
                        PanelMessage.Visible = True
                        LabelMessage.Text = "Please enter your address."
                        TextAddress.Focus()
                    Else
                        If TextContact.Text.Length < 11 Then
                            PanelMessage.Visible = True
                            LabelMessage.Text = "Please enter a valid contact number."
                            TextContact.Focus()
                        Else
                            PanelMessage.Visible = False
                            Dim username As String = CreateUserAccountForm.TextUser.Text
                            Dim password As String = CreateUserAccountForm.TextPass.Text
                            Dim position As String = "Administrator"
                            Dim firstname As String = TextFirstName.Text
                            Dim lastname As String = TextLastName.Text
                            Dim email As String = TextEmail.Text
                            Dim address As String = TextAddress.Text
                            Dim contact As String = TextContact.Text

                            CreateNewUserAccount(username, password, position, firstname, lastname, email, address, contact)
                            LoginForm.Show() : CreateUserAccountForm.Close() : Close()
                        End If
                    End If
                End If
            End If
        End If
    End Sub
End Class