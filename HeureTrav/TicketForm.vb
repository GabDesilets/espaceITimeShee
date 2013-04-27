﻿Imports MySql.Data.MySqlClient

Public Class TicketForm
	Public Shared db AS MySqlDB

	Public ID As Integer
	Public States, Categories, Staff, Users As Dictionary(Of Integer, String)

	Public Sub New(Optional id As Integer = 0)
		InitializeComponent()

		Me.ID = id

		Staff = New Dictionary(Of Integer, String)
		Users = New Dictionary(Of Integer, String)
		States = New Dictionary(Of Integer, String)
		Categories = New Dictionary(Of Integer, String)

		Fill()

		Dim set_bind = Sub (target As ComboBox, source As Dictionary(Of Integer, String))
			target.DataSource = New BindingSource(source, Nothing)
			target.DisplayMember = "Value"
			target.ValueMember = "Key"
		End Sub

		set_bind(cboStaff, Staff)
		set_bind(cboUser, Users)
		set_bind(cboCategory, Categories)
		set_bind(cboState, States)
	End Sub

	Public Sub Fill()
		Dim fill_dict = Sub (dict As Dictionary(Of Integer, String), query As String, callback As Action(Of MySqlDataReader))
			dict.Clear()
			Using r = db.Query(query)
				While r.Read()
					callback(r)
				End While
			End Using
		End Sub


		fill_dict(States, "SELECT id, name FROM question_states", Sub (r As MySqlDataReader)
			States.Add(CInt(r("id")), CStr(r("name")))
		End Sub)

		fill_dict(Categories, "SELECT id, name FROM work_categories", Sub (r As MySqlDataReader)
			Categories.Add(CInt(r("id")), CStr(r("name")))
		End Sub)

		fill_dict(Users, "SELECT id, nom, prenom FROM etudiant WHERE admin = 0", Sub (r As MySqlDataReader)
			Users.Add(CInt(r("id")), CStr(r("nom")) & ", " & CStr(r("prenom")))
		End Sub)

		fill_dict(Staff, "SELECT id, nom, prenom FROM etudiant WHERE admin > 0", Sub (r As MySqlDataReader)
			Staff.Add(CInt(r("id")), CStr(r("nom")) & ", " & CStr(r("prenom")))
		End Sub)

		Using r = db.Query(
					"SELECT etu_id, staff_id, state, categorie_id, " &
					"response, response_modified, question, " &
					"question_modified " &
					"FROM questions " &
					"WHERE id = @0",
				ID
				)
		
			If r.HasRows Then
				r.Read()

				cboState.SelectedValue = CInt(r("state"))
				cboCategory.SelectedValue = CInt(r("categorie_id"))
				cboUser.SelectedValue = CInt(r("etu_id"))
				cboStaff.SelectedValue = CInt(r("staff_id"))
				txtQuestion.Text = CStr(r("question"))
				txtResponse.Text = CStr(r("response"))
				lblQLastDisplay.Text = If(r("question_modified") Is DBNull.Value, Date.Now, CDate(r("question_modified"))).ToString("yyyy-MM-dd HH:mm")
				lblRLastDisplay.Text = If(r("response_modified") Is DBNull.Value, Date.Now, CDate(r("response_modified"))).ToString("yyyy-MM-dd HH:mm")
			Else
				cboState.SelectedValue = States.First()
				cboCategory.SelectedValue = Categories.First()
				cboUser.SelectedValue = Users.First()
				cboStaff.SelectedValue = Staff.First()
				txtQuestion.Text = Nothing
				txtResponse.Text = Nothing
				lblQLastDisplay.Text = Date.Now.ToString("yyyy-MM-dd HH:mm")
				lblRLastDisplay.Text = Date.Now.ToString("yyyy-MM-dd HH:mm")
			End If
		End Using
	End Sub

	Public Sub ReturnBtn() Handles btn_return.Click
		DialogResult = Windows.Forms.DialogResult.Cancel
		Close()
	End Sub

	Public Sub AcceptBtn() Handles btn_save.Click
		DialogResult = Windows.Forms.DialogResult.OK
		Close()
	End Sub
End Class