﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
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
        Me.worked_to.DisplayIndex = 2
        Me.worked_to.Text = "A"
        '
        'worked_hours
        '
        Me.worked_hours.DisplayIndex = 3
        Me.worked_hours.Text = "Cumul des heures"
        Me.worked_hours.Width = 161
        '
        'comment
        '
        Me.comment.DisplayIndex = 4
        Me.comment.Text = "Commentaires"
        Me.comment.Width = 237
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(108, 331)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Ajouter"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(189, 331)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Modifier"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'ListeHeures
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(912, 435)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lvStudent)
        Me.Name = "ListeHeures"
        Me.Text = "ListeHeures"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents work_date As System.Windows.Forms.ColumnHeader
    Friend WithEvents worked_hours As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvStudent As System.Windows.Forms.ListView
    Friend WithEvents comment As System.Windows.Forms.ColumnHeader
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents worked_from As System.Windows.Forms.ColumnHeader
    Friend WithEvents worked_to As System.Windows.Forms.ColumnHeader
End Class
