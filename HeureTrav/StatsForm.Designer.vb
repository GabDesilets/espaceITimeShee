<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StatsForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StatsForm))
        Me.lvStatsStudent = New System.Windows.Forms.ListView()
        Me.students = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.progHours = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.supHours = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.totalHours = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.nbTickets = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.timeByTicketsMoy = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.txtSQuery = New System.Windows.Forms.TextBox()
        Me.bSAct = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbl_from = New System.Windows.Forms.Label()
        Me.dateTo = New System.Windows.Forms.DateTimePicker()
        Me.dateFrom = New System.Windows.Forms.DateTimePicker()
        Me.btn_return = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lvStatsStudent
        '
        Me.lvStatsStudent.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.students, Me.progHours, Me.supHours, Me.totalHours, Me.nbTickets, Me.timeByTicketsMoy})
        Me.lvStatsStudent.Location = New System.Drawing.Point(145, 141)
        Me.lvStatsStudent.Name = "lvStatsStudent"
        Me.lvStatsStudent.Size = New System.Drawing.Size(729, 199)
        Me.lvStatsStudent.TabIndex = 0
        Me.lvStatsStudent.UseCompatibleStateImageBehavior = False
        Me.lvStatsStudent.View = System.Windows.Forms.View.Details
        '
        'students
        '
        Me.students.Text = "Etudiants"
        Me.students.Width = 105
        '
        'progHours
        '
        Me.progHours.Text = "Programmation(Heures)"
        Me.progHours.Width = 133
        '
        'supHours
        '
        Me.supHours.Text = "Support(Heures)"
        Me.supHours.Width = 98
        '
        'totalHours
        '
        Me.totalHours.Text = "Total(Heures)"
        Me.totalHours.Width = 78
        '
        'nbTickets
        '
        Me.nbTickets.Text = "Nbr interventions"
        Me.nbTickets.Width = 102
        '
        'timeByTicketsMoy
        '
        Me.timeByTicketsMoy.Text = "Temps moyen Intervention (min)"
        Me.timeByTicketsMoy.Width = 193
        '
        'txtSQuery
        '
        Me.txtSQuery.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtSQuery.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtSQuery.BackColor = System.Drawing.SystemColors.Window
        Me.txtSQuery.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSQuery.Location = New System.Drawing.Point(445, 115)
        Me.txtSQuery.Name = "txtSQuery"
        Me.txtSQuery.Size = New System.Drawing.Size(139, 20)
        Me.txtSQuery.TabIndex = 16
        '
        'bSAct
        '
        Me.bSAct.Location = New System.Drawing.Point(590, 113)
        Me.bSAct.Name = "bSAct"
        Me.bSAct.Size = New System.Drawing.Size(69, 23)
        Me.bSAct.TabIndex = 15
        Me.bSAct.Text = "Chercher"
        Me.bSAct.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(301, 121)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(26, 13)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Au :"
        '
        'lbl_from
        '
        Me.lbl_from.AutoSize = True
        Me.lbl_from.Location = New System.Drawing.Point(147, 121)
        Me.lbl_from.Name = "lbl_from"
        Me.lbl_from.Size = New System.Drawing.Size(27, 13)
        Me.lbl_from.TabIndex = 19
        Me.lbl_from.Text = "Du :"
        '
        'dateTo
        '
        Me.dateTo.CustomFormat = "yyyy-MM-dd"
        Me.dateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dateTo.Location = New System.Drawing.Point(333, 115)
        Me.dateTo.Name = "dateTo"
        Me.dateTo.Size = New System.Drawing.Size(106, 20)
        Me.dateTo.TabIndex = 18
        '
        'dateFrom
        '
        Me.dateFrom.CustomFormat = "yyyy-MM-dd"
        Me.dateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dateFrom.Location = New System.Drawing.Point(180, 115)
        Me.dateFrom.Name = "dateFrom"
        Me.dateFrom.Size = New System.Drawing.Size(106, 20)
        Me.dateFrom.TabIndex = 17
        '
        'btn_return
        '
        Me.btn_return.Image = CType(resources.GetObject("btn_return.Image"), System.Drawing.Image)
        Me.btn_return.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_return.Location = New System.Drawing.Point(145, 346)
        Me.btn_return.Name = "btn_return"
        Me.btn_return.Size = New System.Drawing.Size(88, 23)
        Me.btn_return.TabIndex = 21
        Me.btn_return.Text = "Retour"
        Me.btn_return.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(326, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(166, 37)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Statistique"
        '
        'StatsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1127, 572)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_return)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lbl_from)
        Me.Controls.Add(Me.dateTo)
        Me.Controls.Add(Me.dateFrom)
        Me.Controls.Add(Me.txtSQuery)
        Me.Controls.Add(Me.bSAct)
        Me.Controls.Add(Me.lvStatsStudent)
        Me.Name = "StatsForm"
        Me.Text = "StatsForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lvStatsStudent As System.Windows.Forms.ListView
    Friend WithEvents students As System.Windows.Forms.ColumnHeader
    Friend WithEvents progHours As System.Windows.Forms.ColumnHeader
    Friend WithEvents supHours As System.Windows.Forms.ColumnHeader
    Friend WithEvents totalHours As System.Windows.Forms.ColumnHeader
    Friend WithEvents txtSQuery As System.Windows.Forms.TextBox
    Friend WithEvents bSAct As System.Windows.Forms.Button
    Friend WithEvents nbTickets As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lbl_from As System.Windows.Forms.Label
    Friend WithEvents dateTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents dateFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents timeByTicketsMoy As System.Windows.Forms.ColumnHeader
    Friend WithEvents btn_return As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
