Public Class Membersform
    Public memInsert As String
    Public memDataTable As DataTable
    Dim Profile_picName As String



    Private Sub Membersform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MembersTableDataSet.Members' table. You can move, or remove it, as needed.

    End Sub
    Private Sub Create()
        memInsert = "INSERT INTO Members
               (Surname,Firstname,Othername,Gender,Date_Of_Birth ,Telephone_Number,Email_Address,Residential_Address,Occupation,Marital_Status,Picture)
                VALUES('" & SurnameTextBox.Text & "','" & FirstnameTextBox.Text & "','" & OthernameTextBox.Text & "','" & GenderTextBox.Text & "','" & Date_Of_BirthDateTimePicker.Value & "','" & TelephoneTextBox.Text & "','" & Address_TextBox.Text & "','" & Residential_AddressTextBox.Text & "','" & OccupationTextBox.Text & "','" & StatusTextBox.Text & "','" & Profile_picName & "')"
        MembersCommandCreation(memInsert)


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Create()
            Dim view = New viewAll
            Dim Msg As String
            Msg = MessageBox.Show("Do you wish to create another profile?", "", MessageBoxButtons.YesNo)
            If Msg = DialogResult.Yes Then

                FirstnameTextBox.Clear()
                OthernameTextBox.Clear()
                SurnameTextBox.Clear()
                GenderTextBox.Clear()
                Date_Of_BirthDateTimePicker.CustomFormat = " "
                Date_Of_BirthDateTimePicker.Format = DateTimePickerFormat.Custom
                OccupationTextBox.Clear()
                StatusTextBox.Clear()
                TelephoneTextBox.Clear()
                Residential_AddressTextBox.Clear()
                Address_TextBox.Clear()
                Profile_picturePictureBox.Image = Nothing



            Else
                Me.Hide()
                Dim home = New Home
                home.Show()
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

    Private Sub Button2_Click(sender As Object, e As EventArgs)

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
                    Profile_picturePictureBox.Load(.FileName)
                    My.Computer.FileSystem.CopyFile(.FileName, My.Computer.FileSystem.SpecialDirectories.AllUsersApplicationData & "\photos\" & .SafeFileName.ToString, True)
                    Profile_picName = .SafeFileName

                Catch ex As Exception
                    '  MsgBox(ex.Message)
                End Try
            End If

        End With
    End Sub

    Private Sub Profile_Enter(sender As Object, e As EventArgs) Handles Profile.Enter

    End Sub

    Private Sub StatusTextBox_TextChanged(sender As Object, e As EventArgs) Handles StatusTextBox.TextChanged

    End Sub

    Private Sub OpenFileDialog2_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs)

    End Sub

    Private Sub Profile_picturePictureBox_Click(sender As Object, e As EventArgs) Handles Profile_picturePictureBox.Click
        With OpenFileDialog1

            .Title = "select a jpeg image"
            .Filter = "All files|*.PNG"
            .InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyPictures
            .FileName = ""
            .Multiselect = False
            .ShowDialog()

            If .FileName = "" Then
                Exit Sub

            Else
                Try
                    Profile_picturePictureBox.Load(.FileName)
                    My.Computer.FileSystem.CopyFile(.FileName, My.Computer.FileSystem.SpecialDirectories.AllUsersApplicationData & "\photos\" & .SafeFileName.ToString, True)
                    Profile_picName = .SafeFileName

                Catch ex As Exception
                    '  MsgBox(ex.Message)
                End Try
            End If

        End With
    End Sub

    Private Sub GroupBox4_Enter(sender As Object, e As EventArgs) Handles GroupBox4.Enter

    End Sub
End Class