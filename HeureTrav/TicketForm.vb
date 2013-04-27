Imports MySql.Data.MySqlClient

Public Class TicketForm
	Public Shared db AS MySqlDB

	Public ID As Integer
	Public States, Categories, Staff, Users As Dictionary(Of Integer, String)

	Public Sub New(Optional id As Integer = 0)
		InitializeComponent()

		ID = id

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

		Using db_questions = db.Query(
					"SELECT etu_id, state, categorie_id, " &
					"	response, response_modified, question, " &
					"	question_modified " &
					"FROM questions " &
					"WHERE questions.id = @0",
				ID
				)
		
			If db_questions.HasRows Then
				db_questions.Read()

				cboState.SelectedValue = CInt(db_questions("state"))
				cboCategory.SelectedValue = CInt(db_questions("categorie_id"))
				cboStaff.SelectedValue = CInt(db_questions("etu_id"))
				txtQuestion.Text = CStr(db_questions("question"))
				txtResponse.Text = CStr(db_questions("response"))
				lblQLastDisplay.Text = CDate(db_questions("question_modified")).ToString("yyyy-MM-dd HH:mm")
				lblRLastDisplay.Text = CDate(db_questions("response_modified")).ToString("yyyy-MM-dd HH:mm")
			Else
				cboState.SelectedValue = States.First()
				cboCategory.SelectedValue = Categories.First()
				cboStaff.SelectedValue = Staff.First()
				txtQuestion.Text = Nothing
				txtResponse.Text = Nothing
				lblQLastDisplay.Text = Date.Now.ToString("yyyy-MM-dd HH:mm")
				lblRLastDisplay.Text = Date.Now.ToString("yyyy-MM-dd HH:mm")
			End If

		End Using
	End Sub

	Public Sub Save()
		If ID = 0
			db.Command(
					"INSERT INTO questions (etu_id, state, categorie_id, response, question) " &
					"VALUES (@0, @1, @2, @3, @4, @5)",
				cboStaff.SelectedValue,
				cboState.SelectedValue,
				cboCategory.SelectedValue,
				txtResponse.Text,
				txtQuestion.Text
				)
		Else
			db.Command(
					"UPDATE questions SET etu_id = @1, state = @2, " &
					" categorie_id = @3, response = @4, question = @6 " &
					"WHERE id = @0",
				ID,
				cboStaff.SelectedValue,
				cboState.SelectedValue,
				cboCategory.SelectedValue,
				txtResponse.Text,
				txtQuestion.Text
				)
		End If
	End Sub
End Class