<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CodeInsertion
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
        Dim CodeLabel As System.Windows.Forms.Label
        Me.InsertCode = New System.Windows.Forms.GroupBox()
        Me.OkButton = New System.Windows.Forms.Button()
        Me.CodeTextBox = New System.Windows.Forms.TextBox()
        CodeLabel = New System.Windows.Forms.Label()
        Me.InsertCode.SuspendLayout()
        Me.SuspendLayout()
        '
        'InsertCode
        '
        Me.InsertCode.Controls.Add(Me.OkButton)
        Me.InsertCode.Controls.Add(Me.CodeTextBox)
        Me.InsertCode.Controls.Add(CodeLabel)
        Me.InsertCode.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InsertCode.ForeColor = System.Drawing.Color.White
        Me.InsertCode.Location = New System.Drawing.Point(12, 5)
        Me.InsertCode.Name = "InsertCode"
        Me.InsertCode.Size = New System.Drawing.Size(371, 120)
        Me.InsertCode.TabIndex = 0
        Me.InsertCode.TabStop = False
        Me.InsertCode.Text = "Insert Code"
        '
        'OkButton
        '
        Me.OkButton.BackColor = System.Drawing.Color.Violet
        Me.OkButton.Font = New System.Drawing.Font("Cooper Black", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OkButton.ForeColor = System.Drawing.Color.Black
        Me.OkButton.Location = New System.Drawing.Point(155, 76)
        Me.OkButton.Name = "OkButton"
        Me.OkButton.Size = New System.Drawing.Size(75, 23)
        Me.OkButton.TabIndex = 20
        Me.OkButton.Text = "Save"
        Me.OkButton.UseVisualStyleBackColor = False
        '
        'CodeLabel
        '
        CodeLabel.AutoSize = True
        CodeLabel.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CodeLabel.Location = New System.Drawing.Point(43, 35)
        CodeLabel.Name = "CodeLabel"
        CodeLabel.Size = New System.Drawing.Size(50, 19)
        CodeLabel.TabIndex = 18
        CodeLabel.Text = "code:"
        '
        'CodeTextBox
        '
        Me.CodeTextBox.Location = New System.Drawing.Point(99, 32)
        Me.CodeTextBox.Name = "CodeTextBox"
        Me.CodeTextBox.Size = New System.Drawing.Size(197, 26)
        Me.CodeTextBox.TabIndex = 19
        '
        'CodeInsertion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(395, 132)
        Me.Controls.Add(Me.InsertCode)
        Me.ForeColor = System.Drawing.Color.White
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "CodeInsertion"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " "
        Me.InsertCode.ResumeLayout(False)
        Me.InsertCode.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents InsertCode As GroupBox
    Friend WithEvents OkButton As Button
    Friend WithEvents CodeTextBox As TextBox
End Class
