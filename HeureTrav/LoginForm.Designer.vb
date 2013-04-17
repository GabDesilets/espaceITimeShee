<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginForm
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
		Dim LUser As System.Windows.Forms.Label
		Dim LPass As System.Windows.Forms.Label
		Me.TPass = New System.Windows.Forms.MaskedTextBox()
		Me.TUser = New System.Windows.Forms.TextBox()
		Me.BLogin = New System.Windows.Forms.Button()
		Me.LError = New System.Windows.Forms.Label()
		LUser = New System.Windows.Forms.Label()
		LPass = New System.Windows.Forms.Label()
		Me.SuspendLayout()
		'
		'LUser
		'
		LUser.AutoSize = True
		LUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		LUser.Location = New System.Drawing.Point(12, 15)
		LUser.Name = "LUser"
		LUser.Size = New System.Drawing.Size(53, 16)
		LUser.TabIndex = 0
		LUser.Text = "Usager"
		'
		'LPass
		'
		LPass.AutoSize = True
		LPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		LPass.Location = New System.Drawing.Point(12, 56)
		LPass.Name = "LPass"
		LPass.Size = New System.Drawing.Size(90, 16)
		LPass.TabIndex = 1
		LPass.Text = "Mot de passe"
		'
		'TPass
		'
		Me.TPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.TPass.Location = New System.Drawing.Point(118, 50)
		Me.TPass.Name = "TPass"
		Me.TPass.Size = New System.Drawing.Size(177, 22)
		Me.TPass.TabIndex = 1
		Me.TPass.UseSystemPasswordChar = True
		'
		'TUser
		'
		Me.TUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.TUser.Location = New System.Drawing.Point(118, 12)
		Me.TUser.Name = "TUser"
		Me.TUser.Size = New System.Drawing.Size(177, 22)
		Me.TUser.TabIndex = 0
		'
		'BLogin
		'
		Me.BLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.BLogin.Location = New System.Drawing.Point(188, 95)
		Me.BLogin.Name = "BLogin"
		Me.BLogin.Size = New System.Drawing.Size(107, 31)
		Me.BLogin.TabIndex = 2
		Me.BLogin.Text = "Connexion"
		Me.BLogin.UseVisualStyleBackColor = True
		'
		'LError
		'
		Me.LError.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.LError.ForeColor = System.Drawing.Color.Red
		Me.LError.Location = New System.Drawing.Point(12, 95)
		Me.LError.Name = "LError"
		Me.LError.Size = New System.Drawing.Size(170, 31)
		Me.LError.TabIndex = 3
		Me.LError.Text = "Combinaison usager / mot de passe incorrecte"
		'
		'LoginForm
		'
		Me.AcceptButton = Me.BLogin
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(307, 138)
		Me.Controls.Add(Me.LError)
		Me.Controls.Add(Me.BLogin)
		Me.Controls.Add(Me.TUser)
		Me.Controls.Add(Me.TPass)
		Me.Controls.Add(LPass)
		Me.Controls.Add(LUser)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.Name = "LoginForm"
		Me.ShowIcon = False
		Me.Text = "Login"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents TPass As System.Windows.Forms.MaskedTextBox
	Friend WithEvents TUser As System.Windows.Forms.TextBox
	Friend WithEvents BLogin As System.Windows.Forms.Button
	Friend WithEvents LError As System.Windows.Forms.Label
End Class
