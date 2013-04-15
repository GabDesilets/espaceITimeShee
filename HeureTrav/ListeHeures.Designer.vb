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
        Me.lvStudent = New System.Windows.Forms.ListView()
        Me.work_date = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.worked_from = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.worked_to = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.worked_hours = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.comment = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btn_add = New System.Windows.Forms.Button()
        Me.btn_mod = New System.Windows.Forms.Button()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.lbl_title = New System.Windows.Forms.Label()
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
        Me.lvStudent.Location = New System.Drawing.Point(108, 91)
        Me.lvStudent.Name = "lvStudent"
        Me.lvStudent.Size = New System.Drawing.Size(646, 234)
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
        'btn_add
        '
        Me.btn_add.Location = New System.Drawing.Point(108, 331)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(75, 23)
        Me.btn_add.TabIndex = 1
        Me.btn_add.Text = "Ajouter"
        Me.btn_add.UseVisualStyleBackColor = True
        '
        'btn_mod
        '
        Me.btn_mod.Location = New System.Drawing.Point(189, 331)
        Me.btn_mod.Name = "btn_mod"
        Me.btn_mod.Size = New System.Drawing.Size(75, 23)
        Me.btn_mod.TabIndex = 2
        Me.btn_mod.Text = "Modifier"
        Me.btn_mod.UseVisualStyleBackColor = True
        '
        'btn_delete
        '
        Me.btn_delete.Location = New System.Drawing.Point(270, 331)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(75, 23)
        Me.btn_delete.TabIndex = 3
        Me.btn_delete.Text = "Supprimer"
        Me.btn_delete.UseVisualStyleBackColor = True
        '
        'lbl_title
        '
        Me.lbl_title.AutoSize = True
        Me.lbl_title.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_title.Location = New System.Drawing.Point(239, 38)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(312, 29)
        Me.lbl_title.TabIndex = 4
        Me.lbl_title.Text = "Set big ass title for this table"
        '
        'ListeHeures
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(912, 435)
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
End Class
