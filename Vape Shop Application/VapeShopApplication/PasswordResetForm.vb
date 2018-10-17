Imports System.ComponentModel

Public Class PasswordResetForm

    Private Sub MinimizeForm_Click(sender As Object, e As EventArgs) Handles MinimizeForm.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub ExitApp_Click(sender As Object, e As EventArgs) Handles ExitApp.Click
        Application.Exit()
    End Sub

    Private Sub ButtonBack_Click(sender As Object, e As EventArgs) Handles ButtonBack.Click
        LoginForm.Show() : Close()
    End Sub

    Private Sub ButtonCancel_Click(sender As Object, e As EventArgs) Handles ButtonCancel.Click
        Application.Exit()
    End Sub

    Private Sub ButtonNext_Click(sender As Object, e As EventArgs) Handles ButtonNext.Click
        If UsernameExists(TextUser.Text) = False Then
            PanelMessage.Visible = True
            LabelMessage.Text = "The username you have entered does not exist. Please enter try again."
            TextUser.Focus()
        Else
            PanelMessage.Visible = False
            PanelProgress.Visible = True
            BackgroundWorker1.RunWorkerAsync()
        End If
    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        TextUser.ReadOnly = True
        ButtonNext.Enabled = False
        ButtonBack.Enabled = False
        ButtonCancel.Enabled = False
        Dim email As String = GetEmailAddress(TextUser.Text)
        Dim subject As String = "Your IQOS account: Password reset verification"
        code = GenerateVerificationCode()
        Dim message As String = $"Dear {TextUser.Text},{vbLf}{vbLf}Here is the verification code you need to reset your account: {vbLf}{ApplicationModule.code}{vbLf}{vbLf}The verification code is required to complete the password reset process.{vbLf}{vbLf}The IQOS Team"

        SendToEmail(email, subject, message)
        LabelProgress.Text = "Verification code sent."
        ProgressBar1.Visible = False
        Threading.Thread.Sleep(3000)
    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        u_acc = TextUser.Text
        PasswordResetVerificationForm.Show() : Close()
    End Sub

    Private Sub PasswordResetForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CheckForIllegalCrossThreadCalls = False
    End Sub
End Class