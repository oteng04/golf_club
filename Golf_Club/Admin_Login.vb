Public Class Admin_Login

    Public adminSelectAll As String
    Public adminDataTable As DataTable







    Private Sub Admin_Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AdminLoginTableDataSet.Admin_login' table. You can move, or remove it, as needed.

    End Sub

    Private Sub UsernameLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub UsernameTextBox_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub LoginButton_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub linkCreateadmin_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)

    End Sub

    Private Sub GroupBoxAdminLogin_Enter(sender As Object, e As EventArgs) Handles GroupBoxAdminLogin.Enter

    End Sub


    Private Sub linkToCreateAdmin_Click(sender As Object, e As EventArgs) Handles linkToCreateAdmin.Click


        Me.Hide()
        Dim authen = New AdminCode
        authen.Show()
    End Sub

    Private Sub LoginButton_Click_1(sender As Object, e As EventArgs) Handles LoginButton.Click
        If UsernameTextBox.Text.Length > 0 And PasswordTextBox.Text.Length > 0 Then

            adminSelectAll = "SELECT * FROM Admin_login WHERE Username = '" & UsernameTextBox.Text & "'  AND Password = '" & PasswordTextBox.Text & "'"
            adminDataTable = AdminCommandCreation(adminSelectAll)

            If adminDataTable.Rows.Count Then

                Me.Hide()


                Home.Show()


            Else
                MessageBox.Show("Incorrect username or password", "", MessageBoxButtons.OK)
                UsernameTextBox.Clear()
                PasswordTextBox.Clear()

            End If
        End If


    End Sub
    Protected Overrides Sub OnFormClosing(ByVal e As FormClosingEventArgs)
        MyBase.OnFormClosing(e)
        If Not e.Cancel AndAlso e.CloseReason = CloseReason.UserClosing Then
            e.Cancel = True

            Dim Msg As String
            Msg = MessageBox.Show("Are you sure you would like to exit?", "", MessageBoxButtons.YesNo)
            If Msg = DialogResult.Yes Then
                Application.Exit()
            End If
        End If
    End Sub

End Class