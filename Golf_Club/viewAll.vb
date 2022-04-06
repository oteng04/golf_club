Public Class viewAll
    Public memSelectAll As String
    Public memDataTable As DataTable
    Public memSelect As String





    Protected Overrides Sub OnFormClosing(ByVal e As FormClosingEventArgs)
        MyBase.OnFormClosing(e)
        If Not e.Cancel AndAlso e.CloseReason = CloseReason.UserClosing Then
            e.Cancel = True

            Me.Hide()
            Dim home = New Home
            home.Show()

        End If
    End Sub

    Private Sub AllData_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)
        Dim picLoc As String = My.Computer.FileSystem.SpecialDirectories.AllUsersApplicationData & "\photos\" & AllData.SelectedRows(0).Cells(0).Value.ToString
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.ImageLocation = picLoc
        Firstname.Text = AllData.SelectedRows(0).Cells(2).Value.ToString
    End Sub

    Public Sub viewAll_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        memSelectAll = "SELECT Surname,Firstname ,Othername ,Gender As 'Sex' ,Date_Of_Birth As 'DOB' ,Occupation ,Marital_Status As 'Status',
                Telephone_Number As 'TEL' ,Residential_Address As 'R_Address' ,Email_Address As 'Email' ,Bill ,Payment,Balance ,Picture
                  FROM  Members"
        MembersCommandCreation(memSelectAll)
        AllData.DataSource = MembersCommandCreation(memSelectAll)





    End Sub
    Private Sub AllData_RowEnter(sender As Object, e As DataGridViewCellEventArgs) Handles AllData.RowEnter
        Try
            Dim picLoc As String = My.Computer.FileSystem.SpecialDirectories.AllUsersApplicationData & "\photos\" & AllData.SelectedRows(0).Cells(13).Value.ToString
            PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
            PictureBox1.ImageLocation = picLoc
            Firstname.Text = AllData.SelectedRows(0).Cells(1).Value.ToString

        Catch ex As Exception
        End Try
    End Sub


    Private Sub AllData_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub AllData_CellContentClick_2(sender As Object, e As DataGridViewCellEventArgs) Handles AllData.CellContentClick

    End Sub

    Private Sub AllData_MouseClick(sender As Object, e As MouseEventArgs) Handles AllData.MouseClick
        Try
            Dim picLoc As String = My.Computer.FileSystem.SpecialDirectories.AllUsersApplicationData & "\photos\" & AllData.SelectedRows(0).Cells(13).Value.ToString
            PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
            PictureBox1.ImageLocation = picLoc
            Firstname.Text = AllData.SelectedRows(0).Cells(1).Value.ToString

        Catch ex As Exception
        End Try
    End Sub

    Private Sub Firstname_Click(sender As Object, e As EventArgs) Handles Firstname.Click

    End Sub
End Class