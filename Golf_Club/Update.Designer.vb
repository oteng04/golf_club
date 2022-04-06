<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Update
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim FirstnameLabel As System.Windows.Forms.Label
        Dim SurnameLabel As System.Windows.Forms.Label
        Dim OthernameLabel As System.Windows.Forms.Label
        Dim GenderLabel As System.Windows.Forms.Label
        Dim Address_Label As System.Windows.Forms.Label
        Dim Date_Of_BirthLabel As System.Windows.Forms.Label
        Dim TelephoneLabel As System.Windows.Forms.Label
        Dim StatusLabel As System.Windows.Forms.Label
        Dim OccupationLabel As System.Windows.Forms.Label
        Dim Residential_AddressLabel As System.Windows.Forms.Label
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ID = New System.Windows.Forms.Label()
        Me.save = New System.Windows.Forms.Button()
        Me.OccupationTextBox = New System.Windows.Forms.TextBox()
        Me.Delete = New System.Windows.Forms.Button()
        Me.StatusTextBox = New System.Windows.Forms.TextBox()
        Me.Residential_AddressTextBox = New System.Windows.Forms.TextBox()
        Me.Date_Of_BirthDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Address_TextBox = New System.Windows.Forms.TextBox()
        Me.GenderTextBox = New System.Windows.Forms.TextBox()
        Me.TelephoneTextBox = New System.Windows.Forms.TextBox()
        Me.FirstnameTextBox = New System.Windows.Forms.TextBox()
        Me.OthernameTextBox = New System.Windows.Forms.TextBox()
        Me.SurnameTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ButtonAll = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.ButtonSearch = New System.Windows.Forms.Button()
        Me.Firstname = New System.Windows.Forms.Label()
        Me.LabelId = New System.Windows.Forms.Label()
        Me.TextBoxName = New System.Windows.Forms.TextBox()
        Me.TextBoxID = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.AllDataUpdate = New System.Windows.Forms.DataGridView()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        FirstnameLabel = New System.Windows.Forms.Label()
        SurnameLabel = New System.Windows.Forms.Label()
        OthernameLabel = New System.Windows.Forms.Label()
        GenderLabel = New System.Windows.Forms.Label()
        Address_Label = New System.Windows.Forms.Label()
        Date_Of_BirthLabel = New System.Windows.Forms.Label()
        TelephoneLabel = New System.Windows.Forms.Label()
        StatusLabel = New System.Windows.Forms.Label()
        OccupationLabel = New System.Windows.Forms.Label()
        Residential_AddressLabel = New System.Windows.Forms.Label()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.AllDataUpdate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FirstnameLabel
        '
        FirstnameLabel.AutoSize = True
        FirstnameLabel.Location = New System.Drawing.Point(103, 323)
        FirstnameLabel.Name = "FirstnameLabel"
        FirstnameLabel.Size = New System.Drawing.Size(98, 19)
        FirstnameLabel.TabIndex = 31
        FirstnameLabel.Text = "Firstname:"
        '
        'SurnameLabel
        '
        SurnameLabel.AutoSize = True
        SurnameLabel.Location = New System.Drawing.Point(113, 291)
        SurnameLabel.Name = "SurnameLabel"
        SurnameLabel.Size = New System.Drawing.Size(87, 19)
        SurnameLabel.TabIndex = 33
        SurnameLabel.Text = "Surname:"
        '
        'OthernameLabel
        '
        OthernameLabel.AutoSize = True
        OthernameLabel.Location = New System.Drawing.Point(103, 352)
        OthernameLabel.Name = "OthernameLabel"
        OthernameLabel.Size = New System.Drawing.Size(104, 19)
        OthernameLabel.TabIndex = 35
        OthernameLabel.Text = "Othername:"
        '
        'GenderLabel
        '
        GenderLabel.AutoSize = True
        GenderLabel.Location = New System.Drawing.Point(92, 384)
        GenderLabel.Name = "GenderLabel"
        GenderLabel.Size = New System.Drawing.Size(73, 19)
        GenderLabel.TabIndex = 39
        GenderLabel.Text = "Gender:"
        '
        'Address_Label
        '
        Address_Label.AutoSize = True
        Address_Label.Location = New System.Drawing.Point(72, 480)
        Address_Label.Name = "Address_Label"
        Address_Label.Size = New System.Drawing.Size(135, 19)
        Address_Label.TabIndex = 45
        Address_Label.Text = "Email Address :"
        '
        'Date_Of_BirthLabel
        '
        Date_Of_BirthLabel.AutoSize = True
        Date_Of_BirthLabel.Location = New System.Drawing.Point(80, 415)
        Date_Of_BirthLabel.Name = "Date_Of_BirthLabel"
        Date_Of_BirthLabel.Size = New System.Drawing.Size(122, 19)
        Date_Of_BirthLabel.TabIndex = 41
        Date_Of_BirthLabel.Text = "Date Of Birth:"
        '
        'TelephoneLabel
        '
        TelephoneLabel.AutoSize = True
        TelephoneLabel.Location = New System.Drawing.Point(92, 448)
        TelephoneLabel.Name = "TelephoneLabel"
        TelephoneLabel.Size = New System.Drawing.Size(98, 19)
        TelephoneLabel.TabIndex = 43
        TelephoneLabel.Text = "Telephone:"
        '
        'StatusLabel
        '
        StatusLabel.AutoSize = True
        StatusLabel.Location = New System.Drawing.Point(76, 576)
        StatusLabel.Name = "StatusLabel"
        StatusLabel.Size = New System.Drawing.Size(126, 19)
        StatusLabel.TabIndex = 51
        StatusLabel.Text = "MaritalStatus:"
        '
        'OccupationLabel
        '
        OccupationLabel.AutoSize = True
        OccupationLabel.Location = New System.Drawing.Point(94, 540)
        OccupationLabel.Name = "OccupationLabel"
        OccupationLabel.Size = New System.Drawing.Size(107, 19)
        OccupationLabel.TabIndex = 49
        OccupationLabel.Text = "Occupation:"
        '
        'Residential_AddressLabel
        '
        Residential_AddressLabel.AutoSize = True
        Residential_AddressLabel.Location = New System.Drawing.Point(35, 512)
        Residential_AddressLabel.Name = "Residential_AddressLabel"
        Residential_AddressLabel.Size = New System.Drawing.Size(175, 19)
        Residential_AddressLabel.TabIndex = 47
        Residential_AddressLabel.Text = "Residential Address:"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.GroupBox1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.BackColor = System.Drawing.Color.Black
        Me.SplitContainer1.Panel2.Controls.Add(Me.ButtonAll)
        Me.SplitContainer1.Panel2.Controls.Add(Me.GroupBox4)
        Me.SplitContainer1.Panel2.Controls.Add(Me.GroupBox3)
        Me.SplitContainer1.Size = New System.Drawing.Size(1370, 749)
        Me.SplitContainer1.SplitterDistance = 534
        Me.SplitContainer1.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ID)
        Me.GroupBox1.Controls.Add(Me.save)
        Me.GroupBox1.Controls.Add(Me.OccupationTextBox)
        Me.GroupBox1.Controls.Add(Me.Delete)
        Me.GroupBox1.Controls.Add(Me.StatusTextBox)
        Me.GroupBox1.Controls.Add(StatusLabel)
        Me.GroupBox1.Controls.Add(OccupationLabel)
        Me.GroupBox1.Controls.Add(Me.Residential_AddressTextBox)
        Me.GroupBox1.Controls.Add(Residential_AddressLabel)
        Me.GroupBox1.Controls.Add(Me.Date_Of_BirthDateTimePicker)
        Me.GroupBox1.Controls.Add(Me.Address_TextBox)
        Me.GroupBox1.Controls.Add(GenderLabel)
        Me.GroupBox1.Controls.Add(Address_Label)
        Me.GroupBox1.Controls.Add(Me.GenderTextBox)
        Me.GroupBox1.Controls.Add(Me.TelephoneTextBox)
        Me.GroupBox1.Controls.Add(Date_Of_BirthLabel)
        Me.GroupBox1.Controls.Add(TelephoneLabel)
        Me.GroupBox1.Controls.Add(FirstnameLabel)
        Me.GroupBox1.Controls.Add(Me.FirstnameTextBox)
        Me.GroupBox1.Controls.Add(Me.OthernameTextBox)
        Me.GroupBox1.Controls.Add(SurnameLabel)
        Me.GroupBox1.Controls.Add(OthernameLabel)
        Me.GroupBox1.Controls.Add(Me.SurnameTextBox)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(498, 676)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Update Profile"
        '
        'ID
        '
        Me.ID.AutoSize = True
        Me.ID.Location = New System.Drawing.Point(410, 630)
        Me.ID.Name = "ID"
        Me.ID.Size = New System.Drawing.Size(29, 19)
        Me.ID.TabIndex = 55
        Me.ID.Text = "ID"
        Me.ID.Visible = False
        '
        'save
        '
        Me.save.BackColor = System.Drawing.Color.Lime
        Me.save.ForeColor = System.Drawing.Color.Black
        Me.save.Location = New System.Drawing.Point(253, 620)
        Me.save.Name = "save"
        Me.save.Size = New System.Drawing.Size(140, 39)
        Me.save.TabIndex = 53
        Me.save.Text = "Update"
        Me.save.UseVisualStyleBackColor = False
        '
        'OccupationTextBox
        '
        Me.OccupationTextBox.Location = New System.Drawing.Point(216, 537)
        Me.OccupationTextBox.Name = "OccupationTextBox"
        Me.OccupationTextBox.Size = New System.Drawing.Size(200, 26)
        Me.OccupationTextBox.TabIndex = 50
        '
        'Delete
        '
        Me.Delete.BackColor = System.Drawing.Color.Lime
        Me.Delete.ForeColor = System.Drawing.Color.Black
        Me.Delete.Location = New System.Drawing.Point(70, 620)
        Me.Delete.Name = "Delete"
        Me.Delete.Size = New System.Drawing.Size(140, 39)
        Me.Delete.TabIndex = 54
        Me.Delete.Text = "Delete"
        Me.Delete.UseVisualStyleBackColor = False
        '
        'StatusTextBox
        '
        Me.StatusTextBox.Location = New System.Drawing.Point(216, 569)
        Me.StatusTextBox.Name = "StatusTextBox"
        Me.StatusTextBox.Size = New System.Drawing.Size(200, 26)
        Me.StatusTextBox.TabIndex = 52
        '
        'Residential_AddressTextBox
        '
        Me.Residential_AddressTextBox.Location = New System.Drawing.Point(216, 505)
        Me.Residential_AddressTextBox.Name = "Residential_AddressTextBox"
        Me.Residential_AddressTextBox.Size = New System.Drawing.Size(200, 26)
        Me.Residential_AddressTextBox.TabIndex = 48
        '
        'Date_Of_BirthDateTimePicker
        '
        Me.Date_Of_BirthDateTimePicker.Location = New System.Drawing.Point(216, 409)
        Me.Date_Of_BirthDateTimePicker.Name = "Date_Of_BirthDateTimePicker"
        Me.Date_Of_BirthDateTimePicker.Size = New System.Drawing.Size(200, 26)
        Me.Date_Of_BirthDateTimePicker.TabIndex = 42
        '
        'Address_TextBox
        '
        Me.Address_TextBox.Location = New System.Drawing.Point(216, 473)
        Me.Address_TextBox.Name = "Address_TextBox"
        Me.Address_TextBox.Size = New System.Drawing.Size(200, 26)
        Me.Address_TextBox.TabIndex = 46
        '
        'GenderTextBox
        '
        Me.GenderTextBox.Location = New System.Drawing.Point(216, 377)
        Me.GenderTextBox.Name = "GenderTextBox"
        Me.GenderTextBox.Size = New System.Drawing.Size(200, 26)
        Me.GenderTextBox.TabIndex = 40
        '
        'TelephoneTextBox
        '
        Me.TelephoneTextBox.Location = New System.Drawing.Point(216, 441)
        Me.TelephoneTextBox.Name = "TelephoneTextBox"
        Me.TelephoneTextBox.Size = New System.Drawing.Size(200, 26)
        Me.TelephoneTextBox.TabIndex = 44
        '
        'FirstnameTextBox
        '
        Me.FirstnameTextBox.Location = New System.Drawing.Point(216, 316)
        Me.FirstnameTextBox.Name = "FirstnameTextBox"
        Me.FirstnameTextBox.Size = New System.Drawing.Size(200, 26)
        Me.FirstnameTextBox.TabIndex = 32
        '
        'OthernameTextBox
        '
        Me.OthernameTextBox.Location = New System.Drawing.Point(216, 345)
        Me.OthernameTextBox.Name = "OthernameTextBox"
        Me.OthernameTextBox.Size = New System.Drawing.Size(200, 26)
        Me.OthernameTextBox.TabIndex = 36
        '
        'SurnameTextBox
        '
        Me.SurnameTextBox.Location = New System.Drawing.Point(216, 284)
        Me.SurnameTextBox.Name = "SurnameTextBox"
        Me.SurnameTextBox.Size = New System.Drawing.Size(200, 26)
        Me.SurnameTextBox.TabIndex = 34
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.PictureBox1)
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(117, 19)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(255, 210)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Tag = "Picture"
        Me.GroupBox2.Text = "Picture"
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(17, 25)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(220, 165)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'ButtonAll
        '
        Me.ButtonAll.BackColor = System.Drawing.Color.Lime
        Me.ButtonAll.Font = New System.Drawing.Font("Cooper Black", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonAll.ForeColor = System.Drawing.Color.Black
        Me.ButtonAll.Location = New System.Drawing.Point(29, 517)
        Me.ButtonAll.Name = "ButtonAll"
        Me.ButtonAll.Size = New System.Drawing.Size(74, 52)
        Me.ButtonAll.TabIndex = 54
        Me.ButtonAll.Text = "All Members"
        Me.ButtonAll.UseVisualStyleBackColor = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.ButtonSearch)
        Me.GroupBox4.Controls.Add(Me.Firstname)
        Me.GroupBox4.Controls.Add(Me.LabelId)
        Me.GroupBox4.Controls.Add(Me.TextBoxName)
        Me.GroupBox4.Controls.Add(Me.TextBoxID)
        Me.GroupBox4.Font = New System.Drawing.Font("Cooper Black", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.Color.White
        Me.GroupBox4.Location = New System.Drawing.Point(266, 524)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(333, 137)
        Me.GroupBox4.TabIndex = 1
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Search"
        '
        'ButtonSearch
        '
        Me.ButtonSearch.BackgroundImage = Global.Golf_Club.My.Resources.Resources.Google_custom_search_logo
        Me.ButtonSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ButtonSearch.Location = New System.Drawing.Point(273, 60)
        Me.ButtonSearch.Name = "ButtonSearch"
        Me.ButtonSearch.Size = New System.Drawing.Size(40, 23)
        Me.ButtonSearch.TabIndex = 4
        Me.ButtonSearch.UseVisualStyleBackColor = True
        '
        'Firstname
        '
        Me.Firstname.AutoSize = True
        Me.Firstname.Location = New System.Drawing.Point(11, 80)
        Me.Firstname.Name = "Firstname"
        Me.Firstname.Size = New System.Drawing.Size(77, 15)
        Me.Firstname.TabIndex = 3
        Me.Firstname.Text = "Firstname"
        '
        'LabelId
        '
        Me.LabelId.AutoSize = True
        Me.LabelId.Location = New System.Drawing.Point(54, 46)
        Me.LabelId.Name = "LabelId"
        Me.LabelId.Size = New System.Drawing.Size(22, 15)
        Me.LabelId.TabIndex = 2
        Me.LabelId.Text = "ID"
        '
        'TextBoxName
        '
        Me.TextBoxName.Location = New System.Drawing.Point(104, 77)
        Me.TextBoxName.Name = "TextBoxName"
        Me.TextBoxName.Size = New System.Drawing.Size(152, 22)
        Me.TextBoxName.TabIndex = 1
        '
        'TextBoxID
        '
        Me.TextBoxID.Location = New System.Drawing.Point(104, 43)
        Me.TextBoxID.Name = "TextBoxID"
        Me.TextBoxID.Size = New System.Drawing.Size(152, 22)
        Me.TextBoxID.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.AllDataUpdate)
        Me.GroupBox3.Font = New System.Drawing.Font("Cooper Black", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.Black
        Me.GroupBox3.Location = New System.Drawing.Point(29, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(791, 499)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        '
        'AllDataUpdate
        '
        Me.AllDataUpdate.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.AllDataUpdate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.AllDataUpdate.Location = New System.Drawing.Point(28, 25)
        Me.AllDataUpdate.Name = "AllDataUpdate"
        Me.AllDataUpdate.Size = New System.Drawing.Size(737, 450)
        Me.AllDataUpdate.TabIndex = 5
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Update
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(1370, 749)
        Me.Controls.Add(Me.SplitContainer1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Update"
        Me.ShowIcon = False
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.AllDataUpdate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents AllDataUpdate As DataGridView
    Friend WithEvents FirstnameTextBox As TextBox
    Friend WithEvents OthernameTextBox As TextBox
    Friend WithEvents SurnameTextBox As TextBox
    Friend WithEvents Date_Of_BirthDateTimePicker As DateTimePicker
    Friend WithEvents Address_TextBox As TextBox
    Friend WithEvents GenderTextBox As TextBox
    Friend WithEvents TelephoneTextBox As TextBox
    Friend WithEvents OccupationTextBox As TextBox
    Friend WithEvents StatusTextBox As TextBox
    Friend WithEvents Residential_AddressTextBox As TextBox
    Friend WithEvents save As Button
    Friend WithEvents Delete As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ID As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents ButtonSearch As Button
    Friend WithEvents Firstname As Label
    Friend WithEvents LabelId As Label
    Friend WithEvents TextBoxName As TextBox
    Friend WithEvents TextBoxID As TextBox
    Friend WithEvents ButtonAll As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
