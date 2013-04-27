<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TicketForm
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
		Dim lblRLast As System.Windows.Forms.Label
		Dim lblQLast As System.Windows.Forms.Label
		Dim lblType As System.Windows.Forms.Label
		Dim lblStaff As System.Windows.Forms.Label
		Dim lblUser As System.Windows.Forms.Label
		Dim lblState As System.Windows.Forms.Label
		Dim lblQuestion As System.Windows.Forms.Label
		Dim lblResponse As System.Windows.Forms.Label
		Dim FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TicketForm))
		Me.lblRLastDisplay = New System.Windows.Forms.Label()
		Me.lblQLastDisplay = New System.Windows.Forms.Label()
		Me.cboCategory = New System.Windows.Forms.ComboBox()
		Me.txtQuestion = New System.Windows.Forms.TextBox()
		Me.txtResponse = New System.Windows.Forms.TextBox()
		Me.cboState = New System.Windows.Forms.ComboBox()
		Me.btn_save = New System.Windows.Forms.Button()
		Me.btn_return = New System.Windows.Forms.Button()
		Me.cboStaff = New System.Windows.Forms.ComboBox()
		Me.cboUser = New System.Windows.Forms.ComboBox()
		Container = New System.Windows.Forms.TableLayoutPanel()
		lblRLast = New System.Windows.Forms.Label()
		lblQLast = New System.Windows.Forms.Label()
		lblType = New System.Windows.Forms.Label()
		lblStaff = New System.Windows.Forms.Label()
		lblUser = New System.Windows.Forms.Label()
		lblState = New System.Windows.Forms.Label()
		lblQuestion = New System.Windows.Forms.Label()
		lblResponse = New System.Windows.Forms.Label()
		FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
		Container.SuspendLayout
		FlowLayoutPanel1.SuspendLayout
		Me.SuspendLayout
		'
		'Container
		'
		Container.ColumnCount = 5
		Container.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150!))
		Container.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 175!))
		Container.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150!))
		Container.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 175!))
		Container.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
		Container.Controls.Add(Me.cboUser, 1, 0)
		Container.Controls.Add(Me.cboStaff, 3, 0)
		Container.Controls.Add(Me.lblRLastDisplay, 2, 4)
		Container.Controls.Add(Me.lblQLastDisplay, 2, 2)
		Container.Controls.Add(lblRLast, 1, 4)
		Container.Controls.Add(lblQLast, 1, 2)
		Container.Controls.Add(lblType, 2, 1)
		Container.Controls.Add(Me.cboCategory, 3, 1)
		Container.Controls.Add(lblStaff, 2, 0)
		Container.Controls.Add(lblUser, 0, 0)
		Container.Controls.Add(lblState, 0, 1)
		Container.Controls.Add(Me.txtQuestion, 0, 3)
		Container.Controls.Add(lblQuestion, 0, 2)
		Container.Controls.Add(Me.txtResponse, 0, 5)
		Container.Controls.Add(lblResponse, 0, 4)
		Container.Controls.Add(Me.cboState, 1, 1)
		Container.Controls.Add(FlowLayoutPanel1, 4, 6)
		Container.Dock = System.Windows.Forms.DockStyle.Fill
		Container.Location = New System.Drawing.Point(0, 0)
		Container.Name = "Container"
		Container.RowCount = 7
		Container.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30!))
		Container.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30!))
		Container.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30!))
		Container.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50!))
		Container.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30!))
		Container.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50!))
		Container.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35!))
		Container.Size = New System.Drawing.Size(892, 673)
		Container.TabIndex = 0
		'
		'lblRLastDisplay
		'
		Me.lblRLastDisplay.AutoSize = true
		Me.lblRLastDisplay.Dock = System.Windows.Forms.DockStyle.Fill
		Me.lblRLastDisplay.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.lblRLastDisplay.Location = New System.Drawing.Point(328, 349)
		Me.lblRLastDisplay.Name = "lblRLastDisplay"
		Me.lblRLastDisplay.Size = New System.Drawing.Size(144, 30)
		Me.lblRLastDisplay.TabIndex = 18
		Me.lblRLastDisplay.Text = "01/01/2001 00:00"
		Me.lblRLastDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lblQLastDisplay
		'
		Me.lblQLastDisplay.AutoSize = true
		Me.lblQLastDisplay.Dock = System.Windows.Forms.DockStyle.Fill
		Me.lblQLastDisplay.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.lblQLastDisplay.Location = New System.Drawing.Point(328, 60)
		Me.lblQLastDisplay.Name = "lblQLastDisplay"
		Me.lblQLastDisplay.Size = New System.Drawing.Size(144, 30)
		Me.lblQLastDisplay.TabIndex = 17
		Me.lblQLastDisplay.Text = "01/01/2001 00:00"
		Me.lblQLastDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lblRLast
		'
		lblRLast.AutoSize = true
		lblRLast.Dock = System.Windows.Forms.DockStyle.Fill
		lblRLast.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		lblRLast.Location = New System.Drawing.Point(153, 349)
		lblRLast.Name = "lblRLast"
		lblRLast.Size = New System.Drawing.Size(169, 30)
		lblRLast.TabIndex = 16
		lblRLast.Text = "dernière modification:"
		lblRLast.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'lblQLast
		'
		lblQLast.AutoSize = true
		lblQLast.Dock = System.Windows.Forms.DockStyle.Fill
		lblQLast.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		lblQLast.Location = New System.Drawing.Point(153, 60)
		lblQLast.Name = "lblQLast"
		lblQLast.Size = New System.Drawing.Size(169, 30)
		lblQLast.TabIndex = 15
		lblQLast.Text = "dernière modification:"
		lblQLast.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'lblType
		'
		lblType.AutoSize = true
		lblType.Dock = System.Windows.Forms.DockStyle.Fill
		lblType.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		lblType.Location = New System.Drawing.Point(328, 30)
		lblType.Name = "lblType"
		lblType.Size = New System.Drawing.Size(144, 30)
		lblType.TabIndex = 11
		lblType.Text = "Type:"
		lblType.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'cboCategory
		'
		Me.cboCategory.Dock = System.Windows.Forms.DockStyle.Fill
		Me.cboCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cboCategory.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.cboCategory.FormattingEnabled = true
		Me.cboCategory.Location = New System.Drawing.Point(478, 33)
		Me.cboCategory.Name = "cboCategory"
		Me.cboCategory.Size = New System.Drawing.Size(169, 24)
		Me.cboCategory.TabIndex = 10
		'
		'lblStaff
		'
		lblStaff.AutoSize = true
		lblStaff.Dock = System.Windows.Forms.DockStyle.Fill
		lblStaff.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		lblStaff.Location = New System.Drawing.Point(328, 0)
		lblStaff.Name = "lblStaff"
		lblStaff.Size = New System.Drawing.Size(144, 30)
		lblStaff.TabIndex = 8
		lblStaff.Text = "Aidant:"
		lblStaff.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'lblUser
		'
		lblUser.AutoSize = true
		lblUser.Dock = System.Windows.Forms.DockStyle.Fill
		lblUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		lblUser.Location = New System.Drawing.Point(3, 0)
		lblUser.Name = "lblUser"
		lblUser.Size = New System.Drawing.Size(144, 30)
		lblUser.TabIndex = 7
		lblUser.Text = "Aidé:"
		lblUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'lblState
		'
		lblState.AutoSize = true
		lblState.Dock = System.Windows.Forms.DockStyle.Fill
		lblState.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		lblState.Location = New System.Drawing.Point(3, 30)
		lblState.Name = "lblState"
		lblState.Size = New System.Drawing.Size(144, 30)
		lblState.TabIndex = 5
		lblState.Text = "État:"
		lblState.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'txtQuestion
		'
		Container.SetColumnSpan(Me.txtQuestion, 5)
		Me.txtQuestion.Dock = System.Windows.Forms.DockStyle.Fill
		Me.txtQuestion.Location = New System.Drawing.Point(3, 93)
		Me.txtQuestion.Multiline = true
		Me.txtQuestion.Name = "txtQuestion"
		Me.txtQuestion.Size = New System.Drawing.Size(886, 253)
		Me.txtQuestion.TabIndex = 3
		'
		'lblQuestion
		'
		lblQuestion.AutoSize = true
		lblQuestion.Dock = System.Windows.Forms.DockStyle.Fill
		lblQuestion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		lblQuestion.Location = New System.Drawing.Point(3, 60)
		lblQuestion.Name = "lblQuestion"
		lblQuestion.Size = New System.Drawing.Size(144, 30)
		lblQuestion.TabIndex = 2
		lblQuestion.Text = "Question:"
		lblQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'txtResponse
		'
		Container.SetColumnSpan(Me.txtResponse, 5)
		Me.txtResponse.Dock = System.Windows.Forms.DockStyle.Fill
		Me.txtResponse.Location = New System.Drawing.Point(3, 382)
		Me.txtResponse.Multiline = true
		Me.txtResponse.Name = "txtResponse"
		Me.txtResponse.Size = New System.Drawing.Size(886, 253)
		Me.txtResponse.TabIndex = 0
		'
		'lblResponse
		'
		lblResponse.AutoSize = true
		lblResponse.Dock = System.Windows.Forms.DockStyle.Fill
		lblResponse.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		lblResponse.Location = New System.Drawing.Point(3, 349)
		lblResponse.Name = "lblResponse"
		lblResponse.Size = New System.Drawing.Size(144, 30)
		lblResponse.TabIndex = 1
		lblResponse.Text = "Réponse:"
		lblResponse.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'cboState
		'
		Me.cboState.Dock = System.Windows.Forms.DockStyle.Fill
		Me.cboState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cboState.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.cboState.FormattingEnabled = true
		Me.cboState.Location = New System.Drawing.Point(153, 33)
		Me.cboState.Name = "cboState"
		Me.cboState.Size = New System.Drawing.Size(169, 24)
		Me.cboState.TabIndex = 4
		'
		'FlowLayoutPanel1
		'
		FlowLayoutPanel1.Controls.Add(Me.btn_save)
		FlowLayoutPanel1.Controls.Add(Me.btn_return)
		FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
		FlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft
		FlowLayoutPanel1.Location = New System.Drawing.Point(653, 641)
		FlowLayoutPanel1.Name = "FlowLayoutPanel1"
		FlowLayoutPanel1.Size = New System.Drawing.Size(236, 29)
		FlowLayoutPanel1.TabIndex = 14
		'
		'btn_save
		'
		Me.btn_save.Image = CType(resources.GetObject("btn_save.Image"),System.Drawing.Image)
		Me.btn_save.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
		Me.btn_save.Location = New System.Drawing.Point(140, 3)
		Me.btn_save.Name = "btn_save"
		Me.btn_save.Size = New System.Drawing.Size(93, 25)
		Me.btn_save.TabIndex = 12
		Me.btn_save.Text = "Accepter"
		Me.btn_save.UseVisualStyleBackColor = true
		'
		'btn_return
		'
		Me.btn_return.DialogResult = System.Windows.Forms.DialogResult.Cancel
		Me.btn_return.Image = CType(resources.GetObject("btn_return.Image"),System.Drawing.Image)
		Me.btn_return.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
		Me.btn_return.Location = New System.Drawing.Point(41, 3)
		Me.btn_return.Name = "btn_return"
		Me.btn_return.Size = New System.Drawing.Size(93, 24)
		Me.btn_return.TabIndex = 13
		Me.btn_return.Text = "Retour"
		Me.btn_return.UseVisualStyleBackColor = true
		'
		'cboStaff
		'
		Me.cboStaff.Dock = System.Windows.Forms.DockStyle.Fill
		Me.cboStaff.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.cboStaff.FormattingEnabled = true
		Me.cboStaff.Location = New System.Drawing.Point(478, 3)
		Me.cboStaff.Name = "cboStaff"
		Me.cboStaff.Size = New System.Drawing.Size(169, 24)
		Me.cboStaff.TabIndex = 19
		'
		'cboUser
		'
		Me.cboUser.Dock = System.Windows.Forms.DockStyle.Fill
		Me.cboUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.cboUser.FormattingEnabled = true
		Me.cboUser.Location = New System.Drawing.Point(153, 3)
		Me.cboUser.Name = "cboUser"
		Me.cboUser.Size = New System.Drawing.Size(169, 24)
		Me.cboUser.TabIndex = 20
		'
		'TicketForm
		'
		Me.AcceptButton = Me.btn_save
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.CancelButton = Me.btn_return
		Me.ClientSize = New System.Drawing.Size(892, 673)
		Me.Controls.Add(Container)
		Me.Name = "TicketForm"
		Me.ShowIcon = false
		Me.Text = "Question"
		Container.ResumeLayout(false)
		Container.PerformLayout
		FlowLayoutPanel1.ResumeLayout(false)
		Me.ResumeLayout(false)

End Sub
    Friend WithEvents txtResponse As System.Windows.Forms.TextBox
    Friend WithEvents txtQuestion As System.Windows.Forms.TextBox
    Friend WithEvents cboCategory As System.Windows.Forms.ComboBox
    Friend WithEvents cboState As System.Windows.Forms.ComboBox
    Friend WithEvents btn_save As System.Windows.Forms.Button
    Friend WithEvents btn_return As System.Windows.Forms.Button
    Friend WithEvents lblRLastDisplay As System.Windows.Forms.Label
    Friend WithEvents lblQLastDisplay As System.Windows.Forms.Label
    Friend WithEvents cboStaff As System.Windows.Forms.ComboBox
    Friend WithEvents cboUser As System.Windows.Forms.ComboBox
End Class
