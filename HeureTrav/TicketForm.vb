Public Class TicketForm
	Public Shared db AS MySqlDB

	Public ID As Integer
	Public States, Categories, Staff As Dictionary(Of Integer, String)

	Public Sub New(Optional id As Integer = 0)
		InitializeComponent()

		ID = id

		cboState.DataSource = States
		cboState.DisplayMember = "Value"
		cboState.ValueMember = "Key"

		cboCategory.DataSource = Categories
		cboCategory.DisplayMember = "Value"
		cboCategory.ValueMember = "Key"

		cboStaff.DataSource = Staff
		cboStaff.DisplayMember = "Value"
		cboStaff.ValueMember = "Key"

		Fill()
	End Sub

	Public Sub Fill()
		Dim db_states = db.Query("SELECT id, name FROM question_states")
		States.Clear()
		While db_states.Read()
			States.Add(
				CInt(db_states("id")),
				CStr(db_states("name"))
				)
		End While
		db_states.Close()

		Dim db_categories = db.Query("SELECT id, name FROM work_categories")
		Categories.Clear()
		While db_categories.Read()
			Categories.Add(
				CInt(db_categories("id")),
				CStr(db_categories("name"))
				)
		End While
		db_categories.Close()

		Dim db_staff = db.Query("SELECT id, nom, prenom FROM etudiant")
		Staff.Clear()
		While db_staff.Read()
			Staff.Add(
				CInt(db_staff("id")),
				CStr(db_staff("nom")) & ", " & CStr(db_staff("prenom"))
				)
		End While
		db_staff.Close()

		Dim db_questions = db.Query(
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

		db_questions.Close()
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

	Public Sub Clean()
	End Sub
End Class