Public Class CodeInsertion
    Dim codeInsert As String
    Private Sub Create()
        codeInsert = "INSERT INTO Authentification_codes(code)
                VALUES('" & CodeTextBox.Text & "')"
        AuthentificationCommandCreation(codeInsert)


    End Sub
    Private Sub OkButton_Click(sender As Object, e As EventArgs) Handles OkButton.Click
        Try
            If CodeTextBox.Text = Nothing Then
            Else
                Create()
                Dim Msg As String
                Msg = MessageBox.Show("Do you wish to add another code?", "", MessageBoxButtons.YesNo)
                If Msg = DialogResult.Yes Then
                    CodeTextBox.Clear()
                    CodeTextBox.Select()
                Else
                    Me.Hide()
                    Dim home = New Home
                    home.Show()
                    CodeTextBox.Clear()
                End If

            End If


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
    Protected Overrides Sub OnFormClosing(ByVal e As FormClosingEventArgs)
        MyBase.OnFormClosing(e)
        If Not e.Cancel AndAlso e.CloseReason = CloseReason.UserClosing Then
            e.Cancel = True

            Me.Hide()
            Dim home = New Home
            home.Show()

        End If
    End Sub

    Private Sub InsertCode_Enter(sender As Object, e As EventArgs) Handles InsertCode.Enter

    End Sub
End Class