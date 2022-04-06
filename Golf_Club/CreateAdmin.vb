Public Class CreateAdmin
    Dim adminInsert As String
    Dim adminSelectAll As String
    Dim adminDataTable As DataTable
    Dim admin_Login = New Admin_Login

    Private Sub Admin_loginBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Admin_loginBindingNavigatorSaveItem.Click

    End Sub

    Private Sub CreateAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AdminLoginTableDataSet.Admin_login' table. You can move, or remove it, as needed.

    End Sub

    Private Sub UsernameLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub CreateButton_Click(sender As Object, e As EventArgs)

    End Sub



    Private Sub linkToAdminLogin_Click(sender As Object, e As EventArgs) Handles linkToAdminLogin.Click
        Me.Hide()
        admin_Login.Show()
        admin_Login.Focus()
    End Sub

    Private Sub CreateButton_Click_1(sender As Object, e As EventArgs) Handles CreateButton.Click
        If UsernameTextBox.Text = Nothing Or PasswordTextBox.Text = Nothing Or TextBoxConfirmPassword.Text = Nothing Then
            MessageBox.Show("Kindly fill in all the spaces provided")
            If UsernameTextBox.Text = Nothing And PasswordTextBox.Text = Nothing Or TextBoxConfirmPassword.Text = Nothing Then
                UsernameTextBox.Select()
            ElseIf PasswordTextBox.Text = Nothing And TextBoxConfirmPassword.Text = Nothing Then
                PasswordTextBox.Select()
            Else
                TextBoxConfirmPassword.Select()
            End If
        ElseIf PasswordTextBox.Text = TextBoxConfirmPassword.Text Then
            Try
                adminSelectAll = "select * From Admin_login Where Username = '" & UsernameTextBox.Text & "' And Password = '" & PasswordTextBox.Text & "'"
                AdminCommandCreation(adminSelectAll)


                adminDataTable = AdminCommandCreation(adminSelectAll)

                If adminDataTable.Rows.Count Then

                    MessageBox.Show("username or password already exist", "error", MessageBoxButtons.OK)


                Else
                    Create()
                    MessageBox.Show("Successfully Created", "", MessageBoxButtons.OK)
                End If
                Me.Hide()
                Dim admin = New Admin_Login
                admin.Show()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        Else
            MessageBox.Show("Try again...Passwords don't match", "Information", MessageBoxButtons.OK)
            PasswordTextBox.Clear()
            TextBoxConfirmPassword.Clear()
        End If
    End Sub

    Protected Overrides Sub OnFormClosing(ByVal e As FormClosingEventArgs)
        MyBase.OnFormClosing(e)
        If Not e.Cancel AndAlso e.CloseReason = CloseReason.UserClosing Then
            e.Cancel = True
            Dim admin_login = New Admin_Login
            admin_login.Show()
            Me.Hide()
        End If
    End Sub
    Private Sub Create()

        adminInsert = "INSERT INTO Admin_login(Username,Password)
               VALUES ('" & UsernameTextBox.Text & "','" & PasswordTextBox.Text & "')"

        AdminCommandCreation(adminInsert)


    End Sub

    Private Sub GroupBoxCreateAdmin_Enter(sender As Object, e As EventArgs) Handles GroupBoxCreateAdmin.Enter

    End Sub
End Class