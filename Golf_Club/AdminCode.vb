Public Class AdminCode
    Public authenSelectAll As String
    Public authenDelete As String
    Public authenDataTable As DataTable
    Private Sub AdminCode_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AuthenticateTableDataSet.Authentication_codes' table. You can move, or remove it, as needed.

    End Sub
    Private Sub delete()
        authenDelete = "DELETE FROM Authentification_codes WHERE  code = '" & CodeTextBox.Text & "'"


        authenDataTable = AuthentificationCommandCreation(authenDelete)

    End Sub

    Private Sub CreateButton_Click(sender As Object, e As EventArgs) Handles OkButton.Click

        authenSelectAll = "SELECT * FROM Authentification_codes WHERE  code = '" & CodeTextBox.Text & "'"


        authenDataTable = AuthentificationCommandCreation(authenSelectAll)

        If authenDataTable.Rows.Count Then
            delete()
            Me.Hide()
            Dim createAdmin = New CreateAdmin
            createAdmin.Show()


        Else
            MessageBox.Show("INVALID CODE", "ERROR", MessageBoxButtons.OK)
            CodeTextBox.Clear()
            CodeTextBox.Select()

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

    Private Sub GroupAuthen_Enter(sender As Object, e As EventArgs) Handles GroupAuthen.Enter

    End Sub
End Class