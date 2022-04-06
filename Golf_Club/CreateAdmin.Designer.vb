<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreateAdmin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim LabelConfirmPassword As System.Windows.Forms.Label
        Dim UsernameLabel As System.Windows.Forms.Label
        Dim PasswordLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CreateAdmin))
        Me.Admin_loginBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.Admin_loginBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.GroupBoxCreateAdmin = New System.Windows.Forms.GroupBox()
        Me.linkToAdminLogin = New System.Windows.Forms.Label()
        Me.CreateButton = New System.Windows.Forms.Button()
        Me.TextBoxConfirmPassword = New System.Windows.Forms.TextBox()
        Me.UsernameTextBox = New System.Windows.Forms.TextBox()
        Me.PasswordTextBox = New System.Windows.Forms.TextBox()
        LabelConfirmPassword = New System.Windows.Forms.Label()
        UsernameLabel = New System.Windows.Forms.Label()
        PasswordLabel = New System.Windows.Forms.Label()
        CType(Me.Admin_loginBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Admin_loginBindingNavigator.SuspendLayout()
        Me.GroupBoxCreateAdmin.SuspendLayout()
        Me.SuspendLayout()
        '
        'LabelConfirmPassword
        '
        LabelConfirmPassword.AutoSize = True
        LabelConfirmPassword.Font = New System.Drawing.Font("Cooper Black", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        LabelConfirmPassword.Location = New System.Drawing.Point(22, 150)
        LabelConfirmPassword.Name = "LabelConfirmPassword"
        LabelConfirmPassword.Size = New System.Drawing.Size(136, 15)
        LabelConfirmPassword.TabIndex = 14
        LabelConfirmPassword.Text = "Confirm Password:"
        '
        'UsernameLabel
        '
        UsernameLabel.AutoSize = True
        UsernameLabel.Font = New System.Drawing.Font("Cooper Black", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        UsernameLabel.Location = New System.Drawing.Point(38, 63)
        UsernameLabel.Name = "UsernameLabel"
        UsernameLabel.Size = New System.Drawing.Size(108, 15)
        UsernameLabel.TabIndex = 10
        UsernameLabel.Text = "Add Username:"
        '
        'PasswordLabel
        '
        PasswordLabel.AutoSize = True
        PasswordLabel.Font = New System.Drawing.Font("Cooper Black", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PasswordLabel.Location = New System.Drawing.Point(25, 104)
        PasswordLabel.Name = "PasswordLabel"
        PasswordLabel.Size = New System.Drawing.Size(121, 15)
        PasswordLabel.TabIndex = 12
        PasswordLabel.Text = "Create Password:"
        '
        'Admin_loginBindingNavigator
        '
        Me.Admin_loginBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Admin_loginBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Admin_loginBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Admin_loginBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Admin_loginBindingNavigatorSaveItem})
        Me.Admin_loginBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Admin_loginBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Admin_loginBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Admin_loginBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Admin_loginBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Admin_loginBindingNavigator.Name = "Admin_loginBindingNavigator"
        Me.Admin_loginBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Admin_loginBindingNavigator.Size = New System.Drawing.Size(389, 25)
        Me.Admin_loginBindingNavigator.TabIndex = 0
        Me.Admin_loginBindingNavigator.Text = "BindingNavigator1"
        Me.Admin_loginBindingNavigator.Visible = False
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
        'Admin_loginBindingNavigatorSaveItem
        '
        Me.Admin_loginBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Admin_loginBindingNavigatorSaveItem.Image = CType(resources.GetObject("Admin_loginBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Admin_loginBindingNavigatorSaveItem.Name = "Admin_loginBindingNavigatorSaveItem"
        Me.Admin_loginBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.Admin_loginBindingNavigatorSaveItem.Text = "Save Data"
        '
        'GroupBoxCreateAdmin
        '
        Me.GroupBoxCreateAdmin.Controls.Add(Me.linkToAdminLogin)
        Me.GroupBoxCreateAdmin.Controls.Add(Me.CreateButton)
        Me.GroupBoxCreateAdmin.Controls.Add(LabelConfirmPassword)
        Me.GroupBoxCreateAdmin.Controls.Add(Me.TextBoxConfirmPassword)
        Me.GroupBoxCreateAdmin.Controls.Add(UsernameLabel)
        Me.GroupBoxCreateAdmin.Controls.Add(Me.UsernameTextBox)
        Me.GroupBoxCreateAdmin.Controls.Add(PasswordLabel)
        Me.GroupBoxCreateAdmin.Controls.Add(Me.PasswordTextBox)
        Me.GroupBoxCreateAdmin.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxCreateAdmin.ForeColor = System.Drawing.Color.White
        Me.GroupBoxCreateAdmin.Location = New System.Drawing.Point(12, 12)
        Me.GroupBoxCreateAdmin.Name = "GroupBoxCreateAdmin"
        Me.GroupBoxCreateAdmin.Size = New System.Drawing.Size(365, 278)
        Me.GroupBoxCreateAdmin.TabIndex = 1
        Me.GroupBoxCreateAdmin.TabStop = False
        Me.GroupBoxCreateAdmin.Text = "Create new Admin"
        '
        'linkToAdminLogin
        '
        Me.linkToAdminLogin.AutoSize = True
        Me.linkToAdminLogin.Font = New System.Drawing.Font("Times New Roman", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.linkToAdminLogin.ForeColor = System.Drawing.Color.Lime
        Me.linkToAdminLogin.Location = New System.Drawing.Point(118, 245)
        Me.linkToAdminLogin.Name = "linkToAdminLogin"
        Me.linkToAdminLogin.Size = New System.Drawing.Size(109, 15)
        Me.linkToAdminLogin.TabIndex = 17
        Me.linkToAdminLogin.Text = "Already an admin?"
        '
        'CreateButton
        '
        Me.CreateButton.BackColor = System.Drawing.Color.Yellow
        Me.CreateButton.Font = New System.Drawing.Font("Cooper Black", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CreateButton.ForeColor = System.Drawing.Color.Black
        Me.CreateButton.Location = New System.Drawing.Point(137, 196)
        Me.CreateButton.Name = "CreateButton"
        Me.CreateButton.Size = New System.Drawing.Size(75, 23)
        Me.CreateButton.TabIndex = 16
        Me.CreateButton.Text = "Create"
        Me.CreateButton.UseVisualStyleBackColor = False
        '
        'TextBoxConfirmPassword
        '
        Me.TextBoxConfirmPassword.Font = New System.Drawing.Font("Cooper Black", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxConfirmPassword.Location = New System.Drawing.Point(164, 147)
        Me.TextBoxConfirmPassword.Name = "TextBoxConfirmPassword"
        Me.TextBoxConfirmPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBoxConfirmPassword.Size = New System.Drawing.Size(179, 22)
        Me.TextBoxConfirmPassword.TabIndex = 15
        '
        'UsernameTextBox
        '
        Me.UsernameTextBox.Font = New System.Drawing.Font("Cooper Black", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UsernameTextBox.Location = New System.Drawing.Point(164, 60)
        Me.UsernameTextBox.Name = "UsernameTextBox"
        Me.UsernameTextBox.Size = New System.Drawing.Size(179, 22)
        Me.UsernameTextBox.TabIndex = 11
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.Font = New System.Drawing.Font("Cooper Black", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PasswordTextBox.Location = New System.Drawing.Point(164, 101)
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PasswordTextBox.Size = New System.Drawing.Size(179, 22)
        Me.PasswordTextBox.TabIndex = 13
        '
        'CreateAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(389, 302)
        Me.Controls.Add(Me.GroupBoxCreateAdmin)
        Me.Controls.Add(Me.Admin_loginBindingNavigator)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "CreateAdmin"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.Admin_loginBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Admin_loginBindingNavigator.ResumeLayout(False)
        Me.Admin_loginBindingNavigator.PerformLayout()
        Me.GroupBoxCreateAdmin.ResumeLayout(False)
        Me.GroupBoxCreateAdmin.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub


    Friend WithEvents Admin_loginBindingSource As BindingSource

    Friend WithEvents Admin_loginBindingNavigator As BindingNavigator
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
    Friend WithEvents Admin_loginBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents GroupBoxCreateAdmin As GroupBox
    Friend WithEvents CreateButton As Button
    Friend WithEvents TextBoxConfirmPassword As TextBox
    Friend WithEvents UsernameTextBox As TextBox
    Friend WithEvents PasswordTextBox As TextBox
    Friend WithEvents linkToAdminLogin As Label
End Class
