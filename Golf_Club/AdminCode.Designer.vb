<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminCode
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
        Me.GroupAuthen = New System.Windows.Forms.GroupBox()
        Me.OkButton = New System.Windows.Forms.Button()
        Me.CodeTextBox = New System.Windows.Forms.TextBox()
        CodeLabel = New System.Windows.Forms.Label()
        Me.GroupAuthen.SuspendLayout()
        Me.SuspendLayout()
        '
        'CodeLabel
        '
        CodeLabel.AutoSize = True
        CodeLabel.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CodeLabel.Location = New System.Drawing.Point(38, 37)
        CodeLabel.Name = "CodeLabel"
        CodeLabel.Size = New System.Drawing.Size(50, 19)
        CodeLabel.TabIndex = 2
        CodeLabel.Text = "code:"
        '
        'GroupAuthen
        '
        Me.GroupAuthen.BackColor = System.Drawing.Color.Transparent
        Me.GroupAuthen.Controls.Add(Me.OkButton)
        Me.GroupAuthen.Controls.Add(CodeLabel)
        Me.GroupAuthen.Controls.Add(Me.CodeTextBox)
        Me.GroupAuthen.Font = New System.Drawing.Font("Cooper Black", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupAuthen.ForeColor = System.Drawing.Color.White
        Me.GroupAuthen.Location = New System.Drawing.Point(12, 12)
        Me.GroupAuthen.Name = "GroupAuthen"
        Me.GroupAuthen.Size = New System.Drawing.Size(333, 109)
        Me.GroupAuthen.TabIndex = 1
        Me.GroupAuthen.TabStop = False
        Me.GroupAuthen.Text = "Authentification code"
        '
        'OkButton
        '
        Me.OkButton.BackColor = System.Drawing.Color.Cyan
        Me.OkButton.Font = New System.Drawing.Font("Cooper Black", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OkButton.ForeColor = System.Drawing.Color.Black
        Me.OkButton.Location = New System.Drawing.Point(140, 69)
        Me.OkButton.Name = "OkButton"
        Me.OkButton.Size = New System.Drawing.Size(75, 23)
        Me.OkButton.TabIndex = 17
        Me.OkButton.Text = "OK"
        Me.OkButton.UseVisualStyleBackColor = False
        '
        'CodeTextBox
        '
        Me.CodeTextBox.Location = New System.Drawing.Point(94, 37)
        Me.CodeTextBox.Name = "CodeTextBox"
        Me.CodeTextBox.Size = New System.Drawing.Size(179, 22)
        Me.CodeTextBox.TabIndex = 3
        '
        'AdminCode
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(354, 127)
        Me.Controls.Add(Me.GroupAuthen)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AdminCode"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.GroupAuthen.ResumeLayout(False)
        Me.GroupAuthen.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupAuthen As GroupBox
    Friend WithEvents OkButton As Button
    Friend WithEvents CodeTextBox As TextBox
End Class
