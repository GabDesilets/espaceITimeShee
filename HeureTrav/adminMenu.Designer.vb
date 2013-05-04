<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class adminMenu
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
        Me.bTicketsList = New System.Windows.Forms.Button()
        Me.bHoursList = New System.Windows.Forms.Button()
        Me.panBtnExit = New System.Windows.Forms.Panel()
        Me.SuspendLayout()
        '
        'bTicketsList
        '
        Me.bTicketsList.Image = Global.FrmHeureTrav.My.Resources.Resources.to_do_list_cheked_all
        Me.bTicketsList.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.bTicketsList.Location = New System.Drawing.Point(23, 88)
        Me.bTicketsList.Name = "bTicketsList"
        Me.bTicketsList.Size = New System.Drawing.Size(210, 39)
        Me.bTicketsList.TabIndex = 1
        Me.bTicketsList.Text = "Liste des tickets"
        Me.bTicketsList.UseVisualStyleBackColor = True
        '
        'bHoursList
        '
        Me.bHoursList.Image = Global.FrmHeureTrav.My.Resources.Resources.application_view_list
        Me.bHoursList.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bHoursList.Location = New System.Drawing.Point(23, 32)
        Me.bHoursList.Name = "bHoursList"
        Me.bHoursList.Size = New System.Drawing.Size(210, 38)
        Me.bHoursList.TabIndex = 0
        Me.bHoursList.Text = "Liste des heures de travail"
        Me.bHoursList.UseVisualStyleBackColor = True
        '
        'panBtnExit
        '
        Me.panBtnExit.Location = New System.Drawing.Point(157, 195)
        Me.panBtnExit.Name = "panBtnExit"
        Me.panBtnExit.Size = New System.Drawing.Size(115, 55)
        Me.panBtnExit.TabIndex = 2
        '
        'adminMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.panBtnExit)
        Me.Controls.Add(Me.bTicketsList)
        Me.Controls.Add(Me.bHoursList)
        Me.Name = "adminMenu"
        Me.Text = "adminMenu"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents bHoursList As System.Windows.Forms.Button
    Friend WithEvents bTicketsList As System.Windows.Forms.Button
    Friend WithEvents panBtnExit As System.Windows.Forms.Panel
End Class
