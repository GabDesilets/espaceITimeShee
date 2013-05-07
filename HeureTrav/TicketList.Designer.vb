<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TicketList
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
        Dim Container As System.Windows.Forms.TableLayoutPanel
        Dim FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TicketList))
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.btn_mod = New System.Windows.Forms.Button()
        Me.btn_add = New System.Windows.Forms.Button()
        Me.btn_return = New System.Windows.Forms.Button()
        Me.cboSColumn = New System.Windows.Forms.ComboBox()
        Me.txtSQuery = New System.Windows.Forms.TextBox()
        Me.dgList = New System.Windows.Forms.DataGridView()
        Me.colState = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCategory = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colUser = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colStaff = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colQuestion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colResponse = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bSAct = New System.Windows.Forms.Button()
        Container = New System.Windows.Forms.TableLayoutPanel()
        FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Container.SuspendLayout()
        FlowLayoutPanel1.SuspendLayout()
        CType(Me.dgList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Container
        '
        Container.ColumnCount = 3
        Container.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150.0!))
        Container.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Container.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75.0!))
        Container.Controls.Add(FlowLayoutPanel1, 1, 2)
        Container.Controls.Add(Me.cboSColumn, 0, 0)
        Container.Controls.Add(Me.txtSQuery, 1, 0)
        Container.Controls.Add(Me.dgList, 0, 1)
        Container.Controls.Add(Me.bSAct, 2, 0)
        Container.Dock = System.Windows.Forms.DockStyle.Fill
        Container.Location = New System.Drawing.Point(0, 0)
        Container.Name = "Container"
        Container.RowCount = 3
        Container.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Container.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Container.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Container.Size = New System.Drawing.Size(892, 673)
        Container.TabIndex = 0
        '
        'FlowLayoutPanel1
        '
        Container.SetColumnSpan(FlowLayoutPanel1, 2)
        FlowLayoutPanel1.Controls.Add(Me.btn_delete)
        FlowLayoutPanel1.Controls.Add(Me.btn_mod)
        FlowLayoutPanel1.Controls.Add(Me.btn_add)
        FlowLayoutPanel1.Controls.Add(Me.btn_return)
        FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        FlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft
        FlowLayoutPanel1.Location = New System.Drawing.Point(153, 641)
        FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        FlowLayoutPanel1.Size = New System.Drawing.Size(736, 29)
        FlowLayoutPanel1.TabIndex = 0
        '
        'btn_delete
        '
        Me.btn_delete.Location = New System.Drawing.Point(658, 3)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(75, 23)
        Me.btn_delete.TabIndex = 6
        Me.btn_delete.Text = "Supprimer"
        Me.btn_delete.UseVisualStyleBackColor = True
        '
        'btn_mod
        '
        Me.btn_mod.Location = New System.Drawing.Point(577, 3)
        Me.btn_mod.Name = "btn_mod"
        Me.btn_mod.Size = New System.Drawing.Size(75, 23)
        Me.btn_mod.TabIndex = 5
        Me.btn_mod.Text = "Modifier"
        Me.btn_mod.UseVisualStyleBackColor = True
        '
        'btn_add
        '
        Me.btn_add.Location = New System.Drawing.Point(496, 3)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(75, 23)
        Me.btn_add.TabIndex = 4
        Me.btn_add.Text = "Ajouter"
        Me.btn_add.UseVisualStyleBackColor = True
        '
        'btn_return
        '
        Me.btn_return.Image = CType(resources.GetObject("btn_return.Image"), System.Drawing.Image)
        Me.btn_return.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_return.Location = New System.Drawing.Point(402, 3)
        Me.btn_return.Name = "btn_return"
        Me.btn_return.Size = New System.Drawing.Size(88, 23)
        Me.btn_return.TabIndex = 7
        Me.btn_return.Text = "Retour"
        Me.btn_return.UseVisualStyleBackColor = True
        '
        'cboSColumn
        '
        Me.cboSColumn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cboSColumn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSColumn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSColumn.FormattingEnabled = True
        Me.cboSColumn.Items.AddRange(New Object() {"État", "Catégorie", "Étudiant", "Aidant", "Question", "Réponse"})
        Me.cboSColumn.Location = New System.Drawing.Point(3, 3)
        Me.cboSColumn.Name = "cboSColumn"
        Me.cboSColumn.Size = New System.Drawing.Size(144, 24)
        Me.cboSColumn.TabIndex = 1
        '
        'txtSQuery
        '
        Me.txtSQuery.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtSQuery.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtSQuery.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtSQuery.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSQuery.Location = New System.Drawing.Point(153, 3)
        Me.txtSQuery.Name = "txtSQuery"
        Me.txtSQuery.Size = New System.Drawing.Size(661, 24)
        Me.txtSQuery.TabIndex = 2
        '
        'dgList
        '
        Me.dgList.AllowUserToAddRows = False
        Me.dgList.AllowUserToDeleteRows = False
        Me.dgList.AllowUserToOrderColumns = True
        Me.dgList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colState, Me.colCategory, Me.colUser, Me.colStaff, Me.colQuestion, Me.colResponse})
        Container.SetColumnSpan(Me.dgList, 3)
        Me.dgList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgList.Location = New System.Drawing.Point(3, 33)
        Me.dgList.Name = "dgList"
        Me.dgList.ReadOnly = True
        Me.dgList.RowHeadersVisible = False
        Me.dgList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgList.Size = New System.Drawing.Size(886, 602)
        Me.dgList.TabIndex = 4
        '
        'colState
        '
        Me.colState.HeaderText = "État"
        Me.colState.Name = "colState"
        Me.colState.ReadOnly = True
        '
        'colCategory
        '
        Me.colCategory.HeaderText = "Catégorie"
        Me.colCategory.Name = "colCategory"
        Me.colCategory.ReadOnly = True
        '
        'colUser
        '
        Me.colUser.HeaderText = "Étudiant"
        Me.colUser.Name = "colUser"
        Me.colUser.ReadOnly = True
        Me.colUser.Width = 150
        '
        'colStaff
        '
        Me.colStaff.FillWeight = 150.0!
        Me.colStaff.HeaderText = "Aidant"
        Me.colStaff.Name = "colStaff"
        Me.colStaff.ReadOnly = True
        '
        'colQuestion
        '
        Me.colQuestion.HeaderText = "Question"
        Me.colQuestion.Name = "colQuestion"
        Me.colQuestion.ReadOnly = True
        Me.colQuestion.Width = 200
        '
        'colResponse
        '
        Me.colResponse.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colResponse.HeaderText = "Réponse"
        Me.colResponse.Name = "colResponse"
        Me.colResponse.ReadOnly = True
        '
        'bSAct
        '
        Me.bSAct.Location = New System.Drawing.Point(820, 3)
        Me.bSAct.Name = "bSAct"
        Me.bSAct.Size = New System.Drawing.Size(69, 23)
        Me.bSAct.TabIndex = 3
        Me.bSAct.Text = "Chercher"
        Me.bSAct.UseVisualStyleBackColor = True
        '
        'TicketList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(892, 673)
        Me.Controls.Add(Container)
        Me.Name = "TicketList"
        Me.ShowIcon = False
        Me.Text = "Liste des questions"
        Container.ResumeLayout(False)
        Container.PerformLayout()
        FlowLayoutPanel1.ResumeLayout(False)
        CType(Me.dgList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cboSColumn As System.Windows.Forms.ComboBox
    Friend WithEvents txtSQuery As System.Windows.Forms.TextBox
    Friend WithEvents dgList As System.Windows.Forms.DataGridView
    Friend WithEvents btn_delete As System.Windows.Forms.Button
    Friend WithEvents btn_mod As System.Windows.Forms.Button
    Friend WithEvents btn_add As System.Windows.Forms.Button
    Friend WithEvents btn_return As System.Windows.Forms.Button
    Friend WithEvents bSAct As System.Windows.Forms.Button
    Friend WithEvents colState As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colCategory As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colUser As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colStaff As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colQuestion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colResponse As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
