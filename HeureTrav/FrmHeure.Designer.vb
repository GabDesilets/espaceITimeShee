<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmHeure
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmHeure))
        Me.lbl_hour = New System.Windows.Forms.Label()
        Me.grBWorkHour = New System.Windows.Forms.GroupBox()
        Me.cbCategories = New System.Windows.Forms.ComboBox()
        Me.lbl_cat = New System.Windows.Forms.Label()
        Me.worked_min_to = New System.Windows.Forms.TextBox()
        Me.worked_min_from = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.worked_hour_to = New System.Windows.Forms.TextBox()
        Me.worked_hour_from = New System.Windows.Forms.TextBox()
        Me.lbl_date = New System.Windows.Forms.Label()
        Me.dtp_date = New System.Windows.Forms.DateTimePicker()
        Me.lbl_project = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tb_comment = New System.Windows.Forms.TextBox()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.errProv = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.btn_return = New System.Windows.Forms.Button()
        Me.lbl_add_success = New System.Windows.Forms.Label()
        Me.lbl_edit_success = New System.Windows.Forms.Label()
        Me.grBWorkHour.SuspendLayout()
        CType(Me.errProv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_hour
        '
        Me.lbl_hour.AutoSize = True
        Me.lbl_hour.Location = New System.Drawing.Point(9, 141)
        Me.lbl_hour.Name = "lbl_hour"
        Me.lbl_hour.Size = New System.Drawing.Size(47, 13)
        Me.lbl_hour.TabIndex = 0
        Me.lbl_hour.Text = "Heures :"
        '
        'grBWorkHour
        '
        Me.grBWorkHour.Controls.Add(Me.cbCategories)
        Me.grBWorkHour.Controls.Add(Me.lbl_cat)
        Me.grBWorkHour.Controls.Add(Me.worked_min_to)
        Me.grBWorkHour.Controls.Add(Me.worked_min_from)
        Me.grBWorkHour.Controls.Add(Me.Label3)
        Me.grBWorkHour.Controls.Add(Me.Label1)
        Me.grBWorkHour.Controls.Add(Me.worked_hour_to)
        Me.grBWorkHour.Controls.Add(Me.worked_hour_from)
        Me.grBWorkHour.Controls.Add(Me.lbl_date)
        Me.grBWorkHour.Controls.Add(Me.dtp_date)
        Me.grBWorkHour.Controls.Add(Me.lbl_project)
        Me.grBWorkHour.Controls.Add(Me.Label2)
        Me.grBWorkHour.Controls.Add(Me.tb_comment)
        Me.grBWorkHour.Controls.Add(Me.lbl_hour)
        Me.grBWorkHour.Location = New System.Drawing.Point(39, 90)
        Me.grBWorkHour.Name = "grBWorkHour"
        Me.grBWorkHour.Size = New System.Drawing.Size(540, 393)
        Me.grBWorkHour.TabIndex = 2
        Me.grBWorkHour.TabStop = False
        Me.grBWorkHour.Text = "GroupBox1"
        '
        'cbCategories
        '
        Me.cbCategories.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbCategories.FormattingEnabled = True
        Me.cbCategories.Location = New System.Drawing.Point(92, 167)
        Me.cbCategories.Name = "cbCategories"
        Me.cbCategories.Size = New System.Drawing.Size(121, 21)
        Me.cbCategories.Sorted = True
        Me.cbCategories.TabIndex = 13
        '
        'lbl_cat
        '
        Me.lbl_cat.AutoSize = True
        Me.lbl_cat.Location = New System.Drawing.Point(10, 170)
        Me.lbl_cat.Name = "lbl_cat"
        Me.lbl_cat.Size = New System.Drawing.Size(51, 13)
        Me.lbl_cat.TabIndex = 12
        Me.lbl_cat.Text = " Activité :"
        '
        'worked_min_to
        '
        Me.worked_min_to.Location = New System.Drawing.Point(221, 138)
        Me.worked_min_to.MaxLength = 2
        Me.worked_min_to.Name = "worked_min_to"
        Me.worked_min_to.Size = New System.Drawing.Size(25, 20)
        Me.worked_min_to.TabIndex = 3
        '
        'worked_min_from
        '
        Me.worked_min_from.Location = New System.Drawing.Point(125, 138)
        Me.worked_min_from.MaxLength = 2
        Me.worked_min_from.Name = "worked_min_from"
        Me.worked_min_from.Size = New System.Drawing.Size(25, 20)
        Me.worked_min_from.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(163, 141)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(14, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "A"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(65, 141)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(21, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "De"
        '
        'worked_hour_to
        '
        Me.worked_hour_to.Location = New System.Drawing.Point(190, 138)
        Me.worked_hour_to.MaxLength = 2
        Me.worked_hour_to.Name = "worked_hour_to"
        Me.worked_hour_to.Size = New System.Drawing.Size(25, 20)
        Me.worked_hour_to.TabIndex = 2
        '
        'worked_hour_from
        '
        Me.worked_hour_from.Location = New System.Drawing.Point(92, 138)
        Me.worked_hour_from.MaxLength = 2
        Me.worked_hour_from.Name = "worked_hour_from"
        Me.worked_hour_from.Size = New System.Drawing.Size(25, 20)
        Me.worked_hour_from.TabIndex = 0
        '
        'lbl_date
        '
        Me.lbl_date.AutoSize = True
        Me.lbl_date.Location = New System.Drawing.Point(9, 99)
        Me.lbl_date.Name = "lbl_date"
        Me.lbl_date.Size = New System.Drawing.Size(36, 13)
        Me.lbl_date.TabIndex = 6
        Me.lbl_date.Text = "Date :"
        '
        'dtp_date
        '
        Me.dtp_date.CustomFormat = "yyyy-MM-dd"
        Me.dtp_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_date.Location = New System.Drawing.Point(92, 93)
        Me.dtp_date.Name = "dtp_date"
        Me.dtp_date.Size = New System.Drawing.Size(101, 20)
        Me.dtp_date.TabIndex = 5
        Me.dtp_date.Value = New Date(2013, 3, 4, 0, 0, 0, 0)
        '
        'lbl_project
        '
        Me.lbl_project.AutoSize = True
        Me.lbl_project.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_project.Location = New System.Drawing.Point(9, 35)
        Me.lbl_project.Name = "lbl_project"
        Me.lbl_project.Size = New System.Drawing.Size(231, 22)
        Me.lbl_project.TabIndex = 4
        Me.lbl_project.Text = "Espace-i Support technique"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 203)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Commentaire :"
        '
        'tb_comment
        '
        Me.tb_comment.Location = New System.Drawing.Point(92, 203)
        Me.tb_comment.Multiline = True
        Me.tb_comment.Name = "tb_comment"
        Me.tb_comment.Size = New System.Drawing.Size(280, 167)
        Me.tb_comment.TabIndex = 4
        '
        'btn_save
        '
        Me.btn_save.Image = CType(resources.GetObject("btn_save.Image"), System.Drawing.Image)
        Me.btn_save.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_save.Location = New System.Drawing.Point(138, 489)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(93, 28)
        Me.btn_save.TabIndex = 3
        Me.btn_save.Text = "Accepter"
        Me.btn_save.UseVisualStyleBackColor = True
        '
        'errProv
        '
        Me.errProv.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.errProv.ContainerControl = Me
        '
        'btn_return
        '
        Me.btn_return.Image = CType(resources.GetObject("btn_return.Image"), System.Drawing.Image)
        Me.btn_return.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_return.Location = New System.Drawing.Point(39, 489)
        Me.btn_return.Name = "btn_return"
        Me.btn_return.Size = New System.Drawing.Size(93, 28)
        Me.btn_return.TabIndex = 4
        Me.btn_return.Text = "Retour"
        Me.btn_return.UseVisualStyleBackColor = True
        '
        'lbl_add_success
        '
        Me.lbl_add_success.AutoSize = True
        Me.lbl_add_success.BackColor = System.Drawing.Color.PaleGreen
        Me.lbl_add_success.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_add_success.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_add_success.ForeColor = System.Drawing.Color.Black
        Me.lbl_add_success.Location = New System.Drawing.Point(36, 32)
        Me.lbl_add_success.Name = "lbl_add_success"
        Me.lbl_add_success.Size = New System.Drawing.Size(272, 28)
        Me.lbl_add_success.TabIndex = 5
        Me.lbl_add_success.Text = "Ajout execute avec succes"
        '
        'lbl_edit_success
        '
        Me.lbl_edit_success.AutoSize = True
        Me.lbl_edit_success.BackColor = System.Drawing.Color.PaleGreen
        Me.lbl_edit_success.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_edit_success.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_edit_success.ForeColor = System.Drawing.Color.Black
        Me.lbl_edit_success.Location = New System.Drawing.Point(36, 32)
        Me.lbl_edit_success.Name = "lbl_edit_success"
        Me.lbl_edit_success.Size = New System.Drawing.Size(289, 28)
        Me.lbl_edit_success.TabIndex = 6
        Me.lbl_edit_success.Text = "Edition execute avec succes"
        '
        'FrmHeure
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(687, 564)
        Me.Controls.Add(Me.lbl_edit_success)
        Me.Controls.Add(Me.lbl_add_success)
        Me.Controls.Add(Me.btn_return)
        Me.Controls.Add(Me.btn_save)
        Me.Controls.Add(Me.grBWorkHour)
        Me.Name = "FrmHeure"
        Me.Text = "FrmHeure"
        Me.grBWorkHour.ResumeLayout(False)
        Me.grBWorkHour.PerformLayout()
        CType(Me.errProv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_hour As System.Windows.Forms.Label
    Friend WithEvents grBWorkHour As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tb_comment As System.Windows.Forms.TextBox
    Friend WithEvents btn_save As System.Windows.Forms.Button
    Friend WithEvents lbl_project As System.Windows.Forms.Label
    Friend WithEvents lbl_date As System.Windows.Forms.Label
    Friend WithEvents dtp_date As System.Windows.Forms.DateTimePicker
    Friend WithEvents errProv As System.Windows.Forms.ErrorProvider
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents worked_hour_to As System.Windows.Forms.TextBox
    Friend WithEvents worked_hour_from As System.Windows.Forms.TextBox
    Friend WithEvents worked_min_to As System.Windows.Forms.TextBox
    Friend WithEvents worked_min_from As System.Windows.Forms.TextBox
    Friend WithEvents lbl_cat As System.Windows.Forms.Label
    Friend WithEvents cbCategories As System.Windows.Forms.ComboBox
    Friend WithEvents btn_return As System.Windows.Forms.Button
    Friend WithEvents lbl_add_success As System.Windows.Forms.Label
    Friend WithEvents lbl_edit_success As System.Windows.Forms.Label
End Class
