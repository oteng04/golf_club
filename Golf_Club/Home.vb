Public Class Home
    Dim memSelectAll As String
    Private Sub Home_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Select()
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

    Private Sub addMember_Click(sender As Object, e As EventArgs) Handles addMember.Click
        Dim membersForm = New Membersform
        Me.Hide()
        membersForm.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Dim viewall = New viewAll
        viewall.Show()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Hide()
        Dim dues = New Dues
        dues.Show()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        Dim update1 = New Update
        update1.Show()
    End Sub

    Private Sub SearchBtn_Click(sender As Object, e As EventArgs) Handles SearchBtn.Click
        If ComboBox1.SelectedIndex = 0 Then
            memSelectAll = "SELECT Surname,Firstname ,Othername ,Gender As 'Sex' ,Date_Of_Birth As 'DOB' ,Occupation ,Marital_Status As 'Status',
                Telephone_Number As 'TEL' ,Residential_Address As 'R_Address' ,Email_Address As 'Email' ,Bill ,Payment,Balance ,Picture
                  FROM  Members WHERE Surname = '" & TextBox1.Text & "'"
            MembersCommandCreation(memSelectAll)
            AllData1.DataSource = MembersCommandCreation(memSelectAll)
            GroupBox2.Visible = True
            AllData1.Visible = True
            PictureBox1.Visible = True
            GroupBox3.Visible = True
            Firstname.Visible = True
            Button5.Visible = True
            PictureBox1.Image = Nothing
            Firstname.Text = Nothing

        ElseIf ComboBox1.SelectedIndex = 1 Then
            memSelectAll = "SELECT Surname,Firstname ,Othername ,Gender As 'Sex' ,Date_Of_Birth As 'DOB' ,Occupation ,Marital_Status As 'Status',
                Telephone_Number As 'TEL' ,Residential_Address As 'R_Address' ,Email_Address As 'Email' ,Bill ,Payment,Balance ,Picture
                  FROM  Members WHERE Firstname = '" & TextBox1.Text & "'"
            MembersCommandCreation(memSelectAll)
            AllData1.DataSource = MembersCommandCreation(memSelectAll)
            GroupBox2.Visible = True
            AllData1.Visible = True
            PictureBox1.Visible = True
            GroupBox3.Visible = True
            Firstname.Visible = True
            Button5.Visible = True


        ElseIf ComboBox1.SelectedIndex = 2 Then
            memSelectAll = "SELECT Surname,Firstname ,Othername ,Gender As 'Sex' ,Date_Of_Birth As 'DOB' ,Occupation ,Marital_Status As 'Status',
                Telephone_Number As 'TEL' ,Residential_Address As 'R_Address' ,Email_Address As 'Email' ,Bill ,Payment,Balance ,Picture
                  FROM  Members WHERE Gender = '" & TextBox1.Text & "'"
            MembersCommandCreation(memSelectAll)
            AllData1.DataSource = MembersCommandCreation(memSelectAll)
            GroupBox2.Visible = True
            AllData1.Visible = True
            PictureBox1.Visible = True
            GroupBox3.Visible = True
            Firstname.Visible = True
            Button5.Visible = True


        ElseIf ComboBox1.SelectedIndex = 3 Then
            memSelectAll = "SELECT Surname,Firstname ,Othername ,Gender As 'Sex' ,Date_Of_Birth As 'DOB' ,Occupation ,Marital_Status As 'Status',
                Telephone_Number As 'TEL' ,Residential_Address As 'R_Address' ,Email_Address As 'Email' ,Bill ,Payment,Balance ,Picture
                  FROM  Members WHERE Marital_Status = '" & TextBox1.Text & "'"
            MembersCommandCreation(memSelectAll)
            AllData1.DataSource = MembersCommandCreation(memSelectAll)
            GroupBox2.Visible = True
            AllData1.Visible = True
            PictureBox1.Visible = True
            GroupBox3.Visible = True
            Firstname.Visible = True
            Button5.Visible = True


        Else ComboBox1.SelectedIndex = 4
            memSelectAll = "SELECT Surname,Firstname ,Othername ,Gender As 'Sex' ,Date_Of_Birth As 'DOB' ,Occupation ,Marital_Status As 'Status',
                Telephone_Number As 'TEL' ,Residential_Address As 'R_Address' ,Email_Address As 'Email' ,Bill ,Payment,Balance ,Picture
                  FROM  Members WHERE Member_ID = '" & TextBox1.Text & "'"
            MembersCommandCreation(memSelectAll)
            AllData1.DataSource = MembersCommandCreation(memSelectAll)
            GroupBox2.Visible = True
            AllData1.Visible = True
            PictureBox1.Visible = True
            GroupBox3.Visible = True
            Firstname.Visible = True
            Button5.Visible = True


        End If
        TextBox1.Clear()

    End Sub

    Private Sub AllData1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles AllData1.RowEnter
        Try
            Dim picLoc As String = My.Computer.FileSystem.SpecialDirectories.AllUsersApplicationData & "\photos\" & AllData1.SelectedRows(0).Cells(13).Value.ToString
            PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
            PictureBox1.ImageLocation = picLoc
            Firstname.Text = AllData1.SelectedRows(0).Cells(1).Value.ToString



        Catch ex As Exception
        End Try
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedIndex = 0 Then

        End If
    End Sub

    Private Sub AllData1_MouseClick(sender As Object, e As MouseEventArgs) Handles AllData1.MouseClick
        Try
            Dim picLoc As String = My.Computer.FileSystem.SpecialDirectories.AllUsersApplicationData & "\photos\" & AllData1.SelectedRows(0).Cells(13).Value.ToString
            PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
            PictureBox1.ImageLocation = picLoc
            Firstname.Text = AllData1.SelectedRows(0).Cells(1).Value.ToString

        Catch ex As Exception
        End Try
    End Sub

    Private Sub view2_Click(sender As Object, e As EventArgs)
        Me.Hide()
        Dim viewall = New viewAll
        viewall.Show()
    End Sub

    Private Sub add2_Click(sender As Object, e As EventArgs)
        Dim membersForm = New Membersform
        Me.Hide()
        membersForm.Show()
    End Sub

    Private Sub update2_Click(sender As Object, e As EventArgs)
        Me.Hide()
        Dim update1 = New Update
        update1.Show()
    End Sub

    Private Sub bill2_Click(sender As Object, e As EventArgs)
        Me.Hide()
        Dim dues = New Dues
        dues.Show()
    End Sub

    Private Sub hide_it_Click(sender As Object, e As EventArgs)
        GroupBox2.Visible = False
        AllData1.Visible = False
        PictureBox1.Visible = False
        GroupBox3.Visible = False
        Firstname.Visible = False

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Dim _update = New Update
        _update.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        GroupBox2.Hide()
        GroupBox3.Hide()
        Button5.Hide()
        Firstname.Hide()

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Hide()
        Dim insertCode = New CodeInsertion
        insertCode.Show()
    End Sub

    Private Sub AllData1_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles AllData1.CellContentClick

    End Sub
End Class