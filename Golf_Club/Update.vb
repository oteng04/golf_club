Public Class Update
    Public memSelectAll As String
    Public memDelete As String
    Public memUpdate As String
    Public memSelectOne As String
    Private Sub Update_Load(sender As Object, e As EventArgs)

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

    Private Sub SplitContainer1_Panel2_Paint(sender As Object, e As PaintEventArgs) Handles SplitContainer1.Panel2.Paint

    End Sub

    Private Sub Update_Load_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub Update_Load_2(sender As Object, e As EventArgs)

    End Sub

    Private Sub Update_Load_3(sender As Object, e As EventArgs) Handles MyBase.Load
        memSelectAll = "SELECT  Member_ID,Surname,Firstname ,Othername ,Gender As 'Sex' ,Date_Of_Birth As 'DOB' ,Occupation ,Marital_Status As 'Status',
                Telephone_Number As 'TEL' ,Residential_Address As 'R_Address' ,Email_Address As 'Email' ,Bill ,Payment ,Balance,Picture
                  FROM  Members"
        MembersCommandCreation(memSelectAll)
        AllDataUpdate.DataSource = MembersCommandCreation(memSelectAll)
        Date_Of_BirthDateTimePicker.CustomFormat = " "
        Date_Of_BirthDateTimePicker.Format = DateTimePickerFormat.Custom

    End Sub
    Private Sub Refreshing()
        memSelectAll = "SELECT Picture,Surname,Firstname ,Othername ,Gender As 'Sex' ,Date_Of_Birth As 'DOB' ,Occupation ,Marital_Status As 'Status',
                Telephone_Number As 'TEL' ,Residential_Address As 'R_Address' ,Email_Address As 'Email' ,Bill ,Payment ,Balance, Member_ID
                  FROM  Members"
        MembersCommandCreation(memSelectAll)
        AllDataUpdate.DataSource = MembersCommandCreation(memSelectAll)
    End Sub
    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
    Private Sub AllDataUpdate_RowEnter(sender As Object, e As DataGridViewCellEventArgs) Handles AllDataUpdate.RowEnter
        Try
            Dim picLoc As String = My.Computer.FileSystem.SpecialDirectories.AllUsersApplicationData & "\photos\" & AllDataUpdate.SelectedRows(0).Cells(14).Value.ToString
            PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage

            PictureBox1.ImageLocation = picLoc

            FirstnameTextBox.Text = AllDataUpdate.SelectedRows(0).Cells(2).Value.ToString
            OthernameTextBox.Text = AllDataUpdate.SelectedRows(0).Cells(3).Value.ToString
            SurnameTextBox.Text = AllDataUpdate.SelectedRows(0).Cells(1).Value.ToString
            GenderTextBox.Text = AllDataUpdate.SelectedRows(0).Cells(4).Value.ToString
            Date_Of_BirthDateTimePicker.Value = AllDataUpdate.SelectedRows(0).Cells(5).Value
            OccupationTextBox.Text = AllDataUpdate.SelectedRows(0).Cells(6).Value.ToString
            StatusTextBox.Text = AllDataUpdate.SelectedRows(0).Cells(7).Value.ToString
            TelephoneTextBox.Text = AllDataUpdate.SelectedRows(0).Cells(8).Value.ToString
            Residential_AddressTextBox.Text = AllDataUpdate.SelectedRows(0).Cells(9).Value.ToString
            Address_TextBox.Text = AllDataUpdate.SelectedRows(0).Cells(10).Value.ToString
            ID.Text = AllDataUpdate.SelectedRows(0).Cells(0).Value.ToString

        Catch ex As Exception
        End Try
    End Sub
    Dim Profile_picName As String

    Private Sub AllData_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles AllDataUpdate.CellContentClick
    End Sub

    Private Sub save_Click(sender As Object, e As EventArgs) Handles save.Click
        If Profile_picName = Nothing Then
            Profile_picName = AllDataUpdate.SelectedRows(0).Cells(14).Value.ToString
            memUpdate = "UPDATE Members SET Surname = '" & SurnameTextBox.Text & "', Firstname = '" & FirstnameTextBox.Text & "', 
                     Othername = '" & OthernameTextBox.Text & "', Gender =  '" & GenderTextBox.Text & "' ,Date_Of_Birth = '" & Date_Of_BirthDateTimePicker.Value & "' ,Occupation = '" & OccupationTextBox.Text & "' ,Marital_Status = '" & StatusTextBox.Text & "',
                     Telephone_Number   =  '" & TelephoneTextBox.Text & "' ,Residential_Address   =  '" & Residential_AddressTextBox.Text & "',Email_Address   =  '" & Address_TextBox.Text & "', Picture = '" & Profile_picName & "'
                    WHERE Member_ID = '" & ID.Text & "'"

            MembersCommandCreation(memUpdate)
            AllDataUpdate.DataSource = MembersCommandCreation(memSelectAll)

            FirstnameTextBox.Clear()
            OthernameTextBox.Clear()
            SurnameTextBox.Clear()
            GenderTextBox.Clear()
            PictureBox1.Image = Nothing
            Date_Of_BirthDateTimePicker.CustomFormat = " "
            Date_Of_BirthDateTimePicker.Format = DateTimePickerFormat.Custom
            OccupationTextBox.Clear()
            StatusTextBox.Clear()
            TelephoneTextBox.Clear()
            Residential_AddressTextBox.Clear()
            Address_TextBox.Clear()
            Profile_picName = Nothing
            MessageBox.Show("Successfully Updated")
        Else
            memUpdate = "UPDATE Members SET Surname = '" & SurnameTextBox.Text & "', Firstname = '" & FirstnameTextBox.Text & "', 
                     Othername = '" & OthernameTextBox.Text & "', Gender =  '" & GenderTextBox.Text & "' ,Date_Of_Birth = '" & Date_Of_BirthDateTimePicker.Value & "' ,Occupation = '" & OccupationTextBox.Text & "' ,Marital_Status = '" & StatusTextBox.Text & "',
                     Telephone_Number   =  '" & TelephoneTextBox.Text & "' ,Residential_Address   =  '" & Residential_AddressTextBox.Text & "',Email_Address   =  '" & Address_TextBox.Text & "', Picture = '" & Profile_picName & "'
                    WHERE Member_ID = '" & ID.Text & "'"

            MembersCommandCreation(memUpdate)
            AllDataUpdate.DataSource = MembersCommandCreation(memSelectAll)

            FirstnameTextBox.Clear()
            OthernameTextBox.Clear()
            SurnameTextBox.Clear()
            GenderTextBox.Clear()
            PictureBox1.Image = Nothing
            Date_Of_BirthDateTimePicker.CustomFormat = " "
            Date_Of_BirthDateTimePicker.Format = DateTimePickerFormat.Custom
            OccupationTextBox.Clear()
            StatusTextBox.Clear()
            TelephoneTextBox.Clear()
            Residential_AddressTextBox.Clear()
            Address_TextBox.Clear()
            ID.Text = Nothing
            MessageBox.Show("Successfully Updated")

        End If

    End Sub

    Private Sub Delete_Click(sender As Object, e As EventArgs) Handles Delete.Click
        Dim Msg As String
        Msg = MessageBox.Show("Delete the data of '" & FirstnameTextBox.Text.ToUpper & "' ?", "", MessageBoxButtons.YesNo)
        If Msg = DialogResult.Yes Then

            memDelete = "delete Members 
                              WHERE  Member_ID = '" & ID.Text & "' 
                       "
            MembersCommandCreation(memDelete)
            AllDataUpdate.DataSource = MembersCommandCreation(memSelectAll)



            FirstnameTextBox.Clear()
            OthernameTextBox.Clear()
            SurnameTextBox.Clear()
            GenderTextBox.Clear()
            PictureBox1.Image = Nothing
            Date_Of_BirthDateTimePicker.CustomFormat = " "
            Date_Of_BirthDateTimePicker.Format = DateTimePickerFormat.Custom
            OccupationTextBox.Clear()
            StatusTextBox.Clear()
            TelephoneTextBox.Clear()
            Residential_AddressTextBox.Clear()
            Address_TextBox.Clear()
            Profile_picName = Nothing
            MessageBox.Show("Successfully Deleted")

        End If


    End Sub

    Private Sub ButtonSearch_Click(sender As Object, e As EventArgs) Handles ButtonSearch.Click
        If TextBoxID.Text = Nothing Or TextBoxName.Text = Nothing Then
            MessageBox.Show("Kindly fill in details")
        Else
            memSelectAll = "SELECT Member_ID,Surname,Firstname ,Othername ,Gender As 'Sex' ,Date_Of_Birth As 'DOB' ,Occupation ,Marital_Status As 'Status',
                Telephone_Number As 'TEL' ,Residential_Address As 'R_Address' ,Email_Address As 'Email' ,Bill ,Payment ,Balance,Picture 
                  FROM  Members WHERE Firstname = '" & TextBoxName.Text & "' AND Member_ID = '" & TextBoxID.Text & "'"
            MembersCommandCreation(memSelectAll)
            AllDataUpdate.DataSource = MembersCommandCreation(memSelectAll)
            TextBoxID.Clear()
            TextBoxName.Clear()

        End If
    End Sub

    Private Sub ButtonAll_Click(sender As Object, e As EventArgs) Handles ButtonAll.Click
        memSelectAll = "SELECT Member_ID Surname,Firstname ,Othername ,Gender As 'Sex' ,Date_Of_Birth As 'DOB' ,Occupation ,Marital_Status As 'Status',
                Telephone_Number As 'TEL' ,Residential_Address As 'R_Address' ,Email_Address As 'Email' ,Bill ,Payment ,Balance,Picture
                  FROM  Members  "
        MembersCommandCreation(memSelectAll)
        AllDataUpdate.DataSource = MembersCommandCreation(memSelectAll)
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        If FirstnameTextBox.Text = Nothing Then
        Else
            With OpenFileDialog1

                .Title = "select a jpeg image"
                .Filter = "All files|*.JPG"
                .InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyPictures
                .FileName = ""
                .Multiselect = False
                .ShowDialog()

                If .FileName = "" Then
                    Exit Sub

                Else
                    Try
                        PictureBox1.Load(.FileName)
                        My.Computer.FileSystem.CopyFile(.FileName, My.Computer.FileSystem.SpecialDirectories.AllUsersApplicationData & "\photos\" & .SafeFileName.ToString, True)
                        Profile_picName = .SafeFileName

                    Catch ex As Exception
                        '  MsgBox(ex.Message)
                    End Try
                End If

            End With
        End If
    End Sub

    Private Sub SplitContainer1_Panel1_Paint(sender As Object, e As PaintEventArgs) Handles SplitContainer1.Panel1.Paint

    End Sub

    Private Sub AllDataUpdate_MouseClick(sender As Object, e As MouseEventArgs) Handles AllDataUpdate.MouseClick
        Try
            Dim picLoc As String = My.Computer.FileSystem.SpecialDirectories.AllUsersApplicationData & "\photos\" & AllDataUpdate.SelectedRows(0).Cells(14).Value.ToString
            PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage

            PictureBox1.ImageLocation = picLoc

            FirstnameTextBox.Text = AllDataUpdate.SelectedRows(0).Cells(2).Value.ToString
            OthernameTextBox.Text = AllDataUpdate.SelectedRows(0).Cells(3).Value.ToString
            SurnameTextBox.Text = AllDataUpdate.SelectedRows(0).Cells(1).Value.ToString
            GenderTextBox.Text = AllDataUpdate.SelectedRows(0).Cells(4).Value.ToString
            Date_Of_BirthDateTimePicker.Value = AllDataUpdate.SelectedRows(0).Cells(5).Value
            OccupationTextBox.Text = AllDataUpdate.SelectedRows(0).Cells(6).Value.ToString
            StatusTextBox.Text = AllDataUpdate.SelectedRows(0).Cells(7).Value.ToString
            TelephoneTextBox.Text = AllDataUpdate.SelectedRows(0).Cells(8).Value.ToString
            Residential_AddressTextBox.Text = AllDataUpdate.SelectedRows(0).Cells(9).Value.ToString
            Address_TextBox.Text = AllDataUpdate.SelectedRows(0).Cells(10).Value.ToString
            ID.Text = AllDataUpdate.SelectedRows(0).Cells(0).Value.ToString

        Catch ex As Exception
        End Try
    End Sub

    Private Sub Firstname_Click(sender As Object, e As EventArgs) Handles Firstname.Click

    End Sub
End Class