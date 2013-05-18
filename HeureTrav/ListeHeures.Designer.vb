<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListeHeures
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ListeHeures))
        Me.lvStudent = New System.Windows.Forms.ListView()
        Me.work_date = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.worked_from = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.worked_to = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.worked_hours = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.comment = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lbl_title = New System.Windows.Forms.Label()
        Me.dateFrom = New System.Windows.Forms.DateTimePicker()
        Me.dateTo = New System.Windows.Forms.DateTimePicker()
        Me.lbl_from = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.panBtnExit = New System.Windows.Forms.Panel()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.btn_mod = New System.Windows.Forms.Button()
        Me.btn_add = New System.Windows.Forms.Button()
        Me.bSAct = New System.Windows.Forms.Button()
        Me.txtSQuery = New System.Windows.Forms.TextBox()
        Me.btn_return = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lvStudent
        '
        Me.lvStudent.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor
        Me.lvStudent.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.lvStudent.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.work_date, Me.worked_from, Me.worked_to, Me.worked_hours, Me.comment})
        Me.lvStudent.FullRowSelect = True
        Me.lvStudent.GridLines = True
        Me.lvStudent.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lvStudent.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lvStudent.Location = New System.Drawing.Point(64, 106)
        Me.lvStudent.Name = "lvStudent"
        Me.lvStudent.Size = New System.Drawing.Size(647, 282)
        Me.lvStudent.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.lvStudent.TabIndex = 0
        Me.lvStudent.UseCompatibleStateImageBehavior = False
        Me.lvStudent.View = System.Windows.Forms.View.Details
        '
        'work_date
        '
        Me.work_date.Text = "Date"
        Me.work_date.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.work_date.Width = 106
        '
        'worked_from
        '
        Me.worked_from.Text = "De"
        '
        'worked_to
        '
        Me.worked_to.Text = "A"
        '
        'worked_hours
        '
        Me.worked_hours.Text = "Cumul des heures"
        Me.worked_hours.Width = 161
        '
        'comment
        '
        Me.comment.Text = "Commentaires"
        Me.comment.Width = 237
        '
        'lbl_title
        '
        Me.lbl_title.AutoSize = True
        Me.lbl_title.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_title.Location = New System.Drawing.Point(208, 24)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(87, 29)
        Me.lbl_title.TabIndex = 4
        Me.lbl_title.Text = "list title"
        '
        'dateFrom
        '
        Me.dateFrom.CustomFormat = "yyyy-MM-dd"
        Me.dateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dateFrom.Location = New System.Drawing.Point(106, 74)
        Me.dateFrom.Name = "dateFrom"
        Me.dateFrom.Size = New System.Drawing.Size(106, 20)
        Me.dateFrom.TabIndex = 5
        '
        'dateTo
        '
        Me.dateTo.CustomFormat = "yyyy-MM-dd"
        Me.dateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dateTo.Location = New System.Drawing.Point(259, 74)
        Me.dateTo.Name = "dateTo"
        Me.dateTo.Size = New System.Drawing.Size(106, 20)
        Me.dateTo.TabIndex = 6
        '
        'lbl_from
        '
        Me.lbl_from.AutoSize = True
        Me.lbl_from.Location = New System.Drawing.Point(73, 80)
        Me.lbl_from.Name = "lbl_from"
        Me.lbl_from.Size = New System.Drawing.Size(27, 13)
        Me.lbl_from.TabIndex = 7
        Me.lbl_from.Text = "Du :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(227, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(26, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Au :"
        '
        'panBtnExit
        '
        Me.panBtnExit.Location = New System.Drawing.Point(1176, 554)
        Me.panBtnExit.Name = "panBtnExit"
        Me.panBtnExit.Size = New System.Drawing.Size(131, 47)
        Me.panBtnExit.TabIndex = 10
        '
        'btn_delete
        '
        Me.btn_delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btn_delete.Image = Global.FrmHeureTrav.My.Resources.Resources.pencil_delete
        Me.btn_delete.ImageAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btn_delete.Location = New System.Drawing.Point(345, 394)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(88, 23)
        Me.btn_delete.TabIndex = 3
        Me.btn_delete.Text = "Supprimer"
        Me.btn_delete.UseVisualStyleBackColor = True
        '
        'btn_mod
        '
        Me.btn_mod.Image = Global.FrmHeureTrav.My.Resources.Resources.pencil
        Me.btn_mod.ImageAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btn_mod.Location = New System.Drawing.Point(252, 394)
        Me.btn_mod.Name = "btn_mod"
        Me.btn_mod.Size = New System.Drawing.Size(87, 23)
        Me.btn_mod.TabIndex = 2
        Me.btn_mod.Text = "Modifier"
        Me.btn_mod.UseVisualStyleBackColor = True
        '
        'btn_add
        '
        Me.btn_add.Image = Global.FrmHeureTrav.My.Resources.Resources.pencil_add
        Me.btn_add.ImageAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btn_add.Location = New System.Drawing.Point(158, 394)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(88, 23)
        Me.btn_add.TabIndex = 1
        Me.btn_add.Text = "Ajouter"
        Me.btn_add.UseVisualStyleBackColor = True
        '
        'bSAct
        '
        Me.bSAct.Location = New System.Drawing.Point(642, 71)
        Me.bSAct.Name = "bSAct"
        Me.bSAct.Size = New System.Drawing.Size(69, 23)
        Me.bSAct.TabIndex = 13
        Me.bSAct.Text = "Chercher"
        Me.bSAct.UseVisualStyleBackColor = True
        '
        'txtSQuery
        '
        Me.txtSQuery.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtSQuery.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtSQuery.BackColor = System.Drawing.SystemColors.Window
        Me.txtSQuery.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSQuery.Location = New System.Drawing.Point(497, 73)
        Me.txtSQuery.Name = "txtSQuery"
        Me.txtSQuery.Size = New System.Drawing.Size(139, 20)
        Me.txtSQuery.TabIndex = 14
        '
        'btn_return
        '
        Me.btn_return.Image = CType(resources.GetObject("btn_return.Image"), System.Drawing.Image)
        Me.btn_return.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_return.Location = New System.Drawing.Point(64, 394)
        Me.btn_return.Name = "btn_return"
        Me.btn_return.Size = New System.Drawing.Size(88, 23)
        Me.btn_return.TabIndex = 15
        Me.btn_return.Text = "Retour"
        Me.btn_return.UseVisualStyleBackColor = True
        '
        'ListeHeures
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1319, 613)
        Me.Controls.Add(Me.btn_return)
        Me.Controls.Add(Me.txtSQuery)
        Me.Controls.Add(Me.bSAct)
        Me.Controls.Add(Me.panBtnExit)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lbl_from)
        Me.Controls.Add(Me.dateTo)
        Me.Controls.Add(Me.dateFrom)
        Me.Controls.Add(Me.lbl_title)
        Me.Controls.Add(Me.btn_delete)
        Me.Controls.Add(Me.btn_mod)
        Me.Controls.Add(Me.btn_add)
        Me.Controls.Add(Me.lvStudent)
        Me.Name = "ListeHeures"
        Me.Text = "ListeHeures"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents work_date As System.Windows.Forms.ColumnHeader
    Friend WithEvents worked_hours As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvStudent As System.Windows.Forms.ListView
    Friend WithEvents comment As System.Windows.Forms.ColumnHeader
    Friend WithEvents btn_add As System.Windows.Forms.Button
    Friend WithEvents btn_mod As System.Windows.Forms.Button
    Friend WithEvents worked_from As System.Windows.Forms.ColumnHeader
    Friend WithEvents worked_to As System.Windows.Forms.ColumnHeader
    Friend WithEvents btn_delete As System.Windows.Forms.Button
    Friend WithEvents lbl_title As System.Windows.Forms.Label
    Friend WithEvents dateFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents dateTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbl_from As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents panBtnExit As System.Windows.Forms.Panel
    Friend WithEvents bSAct As System.Windows.Forms.Button
    Friend WithEvents txtSQuery As System.Windows.Forms.TextBox
    Friend WithEvents btn_return As System.Windows.Forms.Button
End Class
