<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Membersform
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
        Me.components = New System.ComponentModel.Container()
        Dim GenderLabel As System.Windows.Forms.Label
        Dim TelephoneLabel As System.Windows.Forms.Label
        Dim Address_Label As System.Windows.Forms.Label
        Dim OccupationLabel As System.Windows.Forms.Label
        Dim StatusLabel As System.Windows.Forms.Label
        Dim Residential_AddressLabel As System.Windows.Forms.Label
        Dim Date_Of_BirthLabel As System.Windows.Forms.Label
        Dim OthernameLabel As System.Windows.Forms.Label
        Dim SurnameLabel As System.Windows.Forms.Label
        Dim FirstnameLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Membersform))
        Me.MembersBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.MembersBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Profile = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Profile_picturePictureBox = New System.Windows.Forms.PictureBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Date_Of_BirthDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Address_TextBox = New System.Windows.Forms.TextBox()
        Me.GenderTextBox = New System.Windows.Forms.TextBox()
        Me.TelephoneTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.OccupationTextBox = New System.Windows.Forms.TextBox()
        Me.StatusTextBox = New System.Windows.Forms.TextBox()
        Me.Residential_AddressTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.FirstnameTextBox = New System.Windows.Forms.TextBox()
        Me.OthernameTextBox = New System.Windows.Forms.TextBox()
        Me.SurnameTextBox = New System.Windows.Forms.TextBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        GenderLabel = New System.Windows.Forms.Label()
        TelephoneLabel = New System.Windows.Forms.Label()
        Address_Label = New System.Windows.Forms.Label()
        OccupationLabel = New System.Windows.Forms.Label()
        StatusLabel = New System.Windows.Forms.Label()
        Residential_AddressLabel = New System.Windows.Forms.Label()
        Date_Of_BirthLabel = New System.Windows.Forms.Label()
        OthernameLabel = New System.Windows.Forms.Label()
        SurnameLabel = New System.Windows.Forms.Label()
        FirstnameLabel = New System.Windows.Forms.Label()
        CType(Me.MembersBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MembersBindingNavigator.SuspendLayout()
        Me.Profile.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.Profile_picturePictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GenderLabel
        '
        GenderLabel.AutoSize = True
        GenderLabel.Location = New System.Drawing.Point(6, 54)
        GenderLabel.Name = "GenderLabel"
        GenderLabel.Size = New System.Drawing.Size(73, 19)
        GenderLabel.TabIndex = 31
        GenderLabel.Text = "Gender:"
        '
        'TelephoneLabel
        '
        TelephoneLabel.AutoSize = True
        TelephoneLabel.Location = New System.Drawing.Point(9, 113)
        TelephoneLabel.Name = "TelephoneLabel"
        TelephoneLabel.Size = New System.Drawing.Size(98, 19)
        TelephoneLabel.TabIndex = 35
        TelephoneLabel.Text = "Telephone:"
        '
        'Address_Label
        '
        Address_Label.AutoSize = True
        Address_Label.Location = New System.Drawing.Point(9, 145)
        Address_Label.Name = "Address_Label"
        Address_Label.Size = New System.Drawing.Size(135, 19)
        Address_Label.TabIndex = 37
        Address_Label.Text = "Email Address :"
        '
        'OccupationLabel
        '
        OccupationLabel.AutoSize = True
        OccupationLabel.Location = New System.Drawing.Point(6, 61)
        OccupationLabel.Name = "OccupationLabel"
        OccupationLabel.Size = New System.Drawing.Size(107, 19)
        OccupationLabel.TabIndex = 41
        OccupationLabel.Text = "Occupation:"
        '
        'StatusLabel
        '
        StatusLabel.AutoSize = True
        StatusLabel.Location = New System.Drawing.Point(6, 93)
        StatusLabel.Name = "StatusLabel"
        StatusLabel.Size = New System.Drawing.Size(126, 19)
        StatusLabel.TabIndex = 43
        StatusLabel.Text = "MaritalStatus:"
        '
        'Residential_AddressLabel
        '
        Residential_AddressLabel.AutoSize = True
        Residential_AddressLabel.Location = New System.Drawing.Point(6, 26)
        Residential_AddressLabel.Name = "Residential_AddressLabel"
        Residential_AddressLabel.Size = New System.Drawing.Size(175, 19)
        Residential_AddressLabel.TabIndex = 39
        Residential_AddressLabel.Text = "Residential Address:"
        '
        'Date_Of_BirthLabel
        '
        Date_Of_BirthLabel.AutoSize = True
        Date_Of_BirthLabel.Location = New System.Drawing.Point(6, 81)
        Date_Of_BirthLabel.Name = "Date_Of_BirthLabel"
        Date_Of_BirthLabel.Size = New System.Drawing.Size(122, 19)
        Date_Of_BirthLabel.TabIndex = 33
        Date_Of_BirthLabel.Text = "Date Of Birth:"
        '
        'OthernameLabel
        '
        OthernameLabel.AutoSize = True
        OthernameLabel.Location = New System.Drawing.Point(6, 100)
        OthernameLabel.Name = "OthernameLabel"
        OthernameLabel.Size = New System.Drawing.Size(104, 19)
        OthernameLabel.TabIndex = 29
        OthernameLabel.Text = "Othername:"
        '
        'SurnameLabel
        '
        SurnameLabel.AutoSize = True
        SurnameLabel.Location = New System.Drawing.Point(6, 61)
        SurnameLabel.Name = "SurnameLabel"
        SurnameLabel.Size = New System.Drawing.Size(87, 19)
        SurnameLabel.TabIndex = 27
        SurnameLabel.Text = "Surname:"
        '
        'FirstnameLabel
        '
        FirstnameLabel.AutoSize = True
        FirstnameLabel.Location = New System.Drawing.Point(6, 35)
        FirstnameLabel.Name = "FirstnameLabel"
        FirstnameLabel.Size = New System.Drawing.Size(98, 19)
        FirstnameLabel.TabIndex = 25
        FirstnameLabel.Text = "Firstname:"
        '
        'MembersBindingNavigator
        '
        Me.MembersBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.MembersBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.MembersBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.MembersBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.MembersBindingNavigatorSaveItem})
        Me.MembersBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.MembersBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.MembersBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.MembersBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.MembersBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.MembersBindingNavigator.Name = "MembersBindingNavigator"
        Me.MembersBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.MembersBindingNavigator.Size = New System.Drawing.Size(816, 25)
        Me.MembersBindingNavigator.TabIndex = 0
        Me.MembersBindingNavigator.Text = "BindingNavigator1"
        Me.MembersBindingNavigator.Visible = False
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'MembersBindingNavigatorSaveItem
        '
        Me.MembersBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.MembersBindingNavigatorSaveItem.Image = CType(resources.GetObject("MembersBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.MembersBindingNavigatorSaveItem.Name = "MembersBindingNavigatorSaveItem"
        Me.MembersBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.MembersBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Profile
        '
        Me.Profile.Controls.Add(Me.Button1)
        Me.Profile.Controls.Add(Me.GroupBox5)
        Me.Profile.Controls.Add(Me.GroupBox4)
        Me.Profile.Controls.Add(Me.GroupBox3)
        Me.Profile.Controls.Add(Me.GroupBox2)
        Me.Profile.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Profile.ForeColor = System.Drawing.Color.White
        Me.Profile.Location = New System.Drawing.Point(28, 12)
        Me.Profile.Name = "Profile"
        Me.Profile.Size = New System.Drawing.Size(776, 450)
        Me.Profile.TabIndex = 25
        Me.Profile.TabStop = False
        Me.Profile.Text = "Profile"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Lime
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(306, 414)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(140, 30)
        Me.Button1.TabIndex = 50
        Me.Button1.Text = "save"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Profile_picturePictureBox)
        Me.GroupBox5.ForeColor = System.Drawing.Color.White
        Me.GroupBox5.Location = New System.Drawing.Point(424, 175)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(269, 217)
        Me.GroupBox5.TabIndex = 49
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Image"
        '
        'Profile_picturePictureBox
        '
        Me.Profile_picturePictureBox.Location = New System.Drawing.Point(21, 24)
        Me.Profile_picturePictureBox.Name = "Profile_picturePictureBox"
        Me.Profile_picturePictureBox.Size = New System.Drawing.Size(225, 169)
        Me.Profile_picturePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Profile_picturePictureBox.TabIndex = 46
        Me.Profile_picturePictureBox.TabStop = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Date_Of_BirthDateTimePicker)
        Me.GroupBox4.Controls.Add(Me.Address_TextBox)
        Me.GroupBox4.Controls.Add(GenderLabel)
        Me.GroupBox4.Controls.Add(Address_Label)
        Me.GroupBox4.Controls.Add(Me.GenderTextBox)
        Me.GroupBox4.Controls.Add(Me.TelephoneTextBox)
        Me.GroupBox4.Controls.Add(Date_Of_BirthLabel)
        Me.GroupBox4.Controls.Add(TelephoneLabel)
        Me.GroupBox4.Location = New System.Drawing.Point(17, 175)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(358, 217)
        Me.GroupBox4.TabIndex = 48
        Me.GroupBox4.TabStop = False
        '
        'Date_Of_BirthDateTimePicker
        '
        Me.Date_Of_BirthDateTimePicker.Location = New System.Drawing.Point(142, 79)
        Me.Date_Of_BirthDateTimePicker.Name = "Date_Of_BirthDateTimePicker"
        Me.Date_Of_BirthDateTimePicker.Size = New System.Drawing.Size(200, 26)
        Me.Date_Of_BirthDateTimePicker.TabIndex = 34
        '
        'Address_TextBox
        '
        Me.Address_TextBox.Location = New System.Drawing.Point(142, 142)
        Me.Address_TextBox.Name = "Address_TextBox"
        Me.Address_TextBox.Size = New System.Drawing.Size(200, 26)
        Me.Address_TextBox.TabIndex = 38
        '
        'GenderTextBox
        '
        Me.GenderTextBox.Location = New System.Drawing.Point(142, 47)
        Me.GenderTextBox.Name = "GenderTextBox"
        Me.GenderTextBox.Size = New System.Drawing.Size(200, 26)
        Me.GenderTextBox.TabIndex = 32
        '
        'TelephoneTextBox
        '
        Me.TelephoneTextBox.Location = New System.Drawing.Point(142, 110)
        Me.TelephoneTextBox.Name = "TelephoneTextBox"
        Me.TelephoneTextBox.Size = New System.Drawing.Size(200, 26)
        Me.TelephoneTextBox.TabIndex = 36
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.OccupationTextBox)
        Me.GroupBox3.Controls.Add(Me.StatusTextBox)
        Me.GroupBox3.Controls.Add(StatusLabel)
        Me.GroupBox3.Controls.Add(OccupationLabel)
        Me.GroupBox3.Controls.Add(Me.Residential_AddressTextBox)
        Me.GroupBox3.Controls.Add(Residential_AddressLabel)
        Me.GroupBox3.Location = New System.Drawing.Point(354, 29)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(402, 140)
        Me.GroupBox3.TabIndex = 47
        Me.GroupBox3.TabStop = False
        '
        'OccupationTextBox
        '
        Me.OccupationTextBox.Location = New System.Drawing.Point(187, 54)
        Me.OccupationTextBox.Name = "OccupationTextBox"
        Me.OccupationTextBox.Size = New System.Drawing.Size(200, 26)
        Me.OccupationTextBox.TabIndex = 42
        '
        'StatusTextBox
        '
        Me.StatusTextBox.Location = New System.Drawing.Point(187, 97)
        Me.StatusTextBox.Name = "StatusTextBox"
        Me.StatusTextBox.Size = New System.Drawing.Size(200, 26)
        Me.StatusTextBox.TabIndex = 44
        '
        'Residential_AddressTextBox
        '
        Me.Residential_AddressTextBox.Location = New System.Drawing.Point(187, 19)
        Me.Residential_AddressTextBox.Name = "Residential_AddressTextBox"
        Me.Residential_AddressTextBox.Size = New System.Drawing.Size(200, 26)
        Me.Residential_AddressTextBox.TabIndex = 40
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(FirstnameLabel)
        Me.GroupBox2.Controls.Add(Me.FirstnameTextBox)
        Me.GroupBox2.Controls.Add(Me.OthernameTextBox)
        Me.GroupBox2.Controls.Add(SurnameLabel)
        Me.GroupBox2.Controls.Add(OthernameLabel)
        Me.GroupBox2.Controls.Add(Me.SurnameTextBox)
        Me.GroupBox2.Location = New System.Drawing.Point(17, 29)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(325, 140)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        '
        'FirstnameTextBox
        '
        Me.FirstnameTextBox.Location = New System.Drawing.Point(119, 25)
        Me.FirstnameTextBox.Name = "FirstnameTextBox"
        Me.FirstnameTextBox.Size = New System.Drawing.Size(200, 26)
        Me.FirstnameTextBox.TabIndex = 26
        '
        'OthernameTextBox
        '
        Me.OthernameTextBox.Location = New System.Drawing.Point(119, 95)
        Me.OthernameTextBox.Name = "OthernameTextBox"
        Me.OthernameTextBox.Size = New System.Drawing.Size(200, 26)
        Me.OthernameTextBox.TabIndex = 30
        '
        'SurnameTextBox
        '
        Me.SurnameTextBox.Location = New System.Drawing.Point(119, 61)
        Me.SurnameTextBox.Name = "SurnameTextBox"
        Me.SurnameTextBox.Size = New System.Drawing.Size(200, 26)
        Me.SurnameTextBox.TabIndex = 28
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Membersform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(816, 474)
        Me.Controls.Add(Me.Profile)
        Me.Controls.Add(Me.MembersBindingNavigator)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Membersform"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " "
        CType(Me.MembersBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MembersBindingNavigator.ResumeLayout(False)
        Me.MembersBindingNavigator.PerformLayout()
        Me.Profile.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        CType(Me.Profile_picturePictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub


    Friend WithEvents MembersBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents MembersBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents Profile As GroupBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents Profile_picturePictureBox As PictureBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Date_Of_BirthDateTimePicker As DateTimePicker
    Friend WithEvents Address_TextBox As TextBox
    Friend WithEvents GenderTextBox As TextBox
    Friend WithEvents TelephoneTextBox As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents OccupationTextBox As TextBox
    Friend WithEvents StatusTextBox As TextBox
    Friend WithEvents Residential_AddressTextBox As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents FirstnameTextBox As TextBox
    Friend WithEvents OthernameTextBox As TextBox
    Friend WithEvents SurnameTextBox As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
