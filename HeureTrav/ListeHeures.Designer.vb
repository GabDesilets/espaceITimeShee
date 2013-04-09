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
        Me.nom = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.work_date = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.worked_hours = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.user_id = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SuspendLayout()
        '
        'lvStudent
        '
        Me.lvStudent.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor
        Me.lvStudent.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.lvStudent.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.nom, Me.work_date, Me.worked_hours, Me.user_id})
        Me.lvStudent.FullRowSelect = True
        Me.lvStudent.GridLines = True
        Me.lvStudent.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lvStudent.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lvStudent.Location = New System.Drawing.Point(165, 197)
        Me.lvStudent.Name = "lvStudent"
        Me.lvStudent.Size = New System.Drawing.Size(398, 178)
        Me.lvStudent.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.lvStudent.TabIndex = 0
        Me.lvStudent.UseCompatibleStateImageBehavior = False
        Me.lvStudent.View = System.Windows.Forms.View.Details
        '
        'nom
        '
        Me.nom.Text = "Nom"
        Me.nom.Width = 130
        '
        'work_date
        '
        Me.work_date.Text = "Date"
        Me.work_date.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.work_date.Width = 150
        '
        'worked_hours
        '
        Me.worked_hours.Text = "Cumul des heures"
        Me.worked_hours.Width = 113
        '
        'user_id
        '
        Me.user_id.Text = ""
        Me.user_id.Width = 0
        '
        'ListeHeures
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(575, 387)
        Me.Controls.Add(Me.lvStudent)
        Me.Name = "ListeHeures"
        Me.Text = "ListeHeures"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents nom As System.Windows.Forms.ColumnHeader
    Friend WithEvents work_date As System.Windows.Forms.ColumnHeader
    Friend WithEvents worked_hours As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvStudent As System.Windows.Forms.ListView
    Friend WithEvents user_id As System.Windows.Forms.ColumnHeader
End Class
