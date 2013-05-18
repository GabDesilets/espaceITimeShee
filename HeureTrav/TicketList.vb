Public Class TicketList
    Public Shared db As MySqlDB
    Public userId As Integer
    'Constructeur de la class ticketList
    Public Sub New(ByVal uid As Integer)
        InitializeComponent()
        AddHandler FormClosed, Sub() amenu.Show()
        userId = uid
        cboSColumn.SelectedIndex = 0
        FillAutocomplete(0)
        Fill()
    End Sub

    'Methode qui remplie le datagridview dgList pour afficher les tickets
	Public Sub Fill()
        Dim query = "SELECT question_states.name, work_categories.name, " &
          "CONCAT(e.nom, ', ', e.prenom), CONCAT(s.nom, ', ', s.prenom), " &
          "questions.question, questions.response, questions.id " &
          "FROM questions " &
          "JOIN question_states ON question_states.id = questions.state " &
          "JOIN work_categories ON work_categories.id = questions.categorie_id " &
          "JOIN etudiant e ON e.id = questions.etu_id " &
          "JOIN etudiant s ON s.id = questions.staff_id " &
          "WHERE 1=1"

        If mOperations.getAdminLevelByUid(userId) <= 1 Then
            query &= " AND questions.staff_id = " & userId
        End If

        If Not txtSQuery.Text = "" And Not cboSColumn.SelectedItem Is Nothing Then
            'Array de string qui fais le lien entre la selection dans le combo box et la position des where (0..n)
            query &= " AND " & (New String() {
             "question_states.name",
             "work_categories.name",
             "CONCAT(e.nom, ', ', e.prenom)",
             "CONCAT(s.nom, ', ', s.prenom)",
             "questions.question",
             "questions.response"
            })(cboSColumn.SelectedIndex) & " LIKE CONCAT('%', @1, '%')"
        End If

        'Ajout les lignes au datagridview
        dgList.Rows.Clear()
        Using r = db.Query(query, txtSQuery.Text)
            While r.Read()
                dgList.Rows(dgList.Rows.Add(
                 r.GetValue(0),
                 r.GetValue(1),
                 r.GetValue(2),
                 r.GetValue(3),
                 r.GetValue(4),
                 r.GetValue(5)
                )).Tag = r.GetValue(6)
            End While
        End Using
    End Sub

    'Remplie un Array de string dans l'auto-completion du textbox de recherche
	Public Sub FillAutocomplete(ix As Integer)
		Dim query = (New String() {
			"SELECT name FROM question_states",
			"SELECT name FROM work_categories",
			"SELECT CONCAT(nom, ', ', prenom) FROM etudiant WHERE admin = 0",
			"SELECT CONCAT(nom, ', ', prenom) FROM etudiant WHERE admin > 0",
			"SELECT question FROM questions",
			"SELECT response FROM questions"
		})(ix)

		txtSQuery.AutoCompleteCustomSource.Clear()
		Using r = db.Query(query)
			While r.Read()
				txtSQuery.AutoCompleteCustomSource.Add(r.GetString(0))
			End While
		End Using
	End Sub

	Public Sub Add()
        Dim dialog = New TicketForm(userId)
		If Not dialog.ShowDialog() = DialogResult.OK Then
			Return
		End If
        If dialog.timeEntryMin.Text = "" Then
            dialog.timeEntryMin.Text = CStr(0)
        End If

        db.Command(
          "INSERT INTO questions (etu_id, staff_id, state, categorie_id, response, " &
          "question, response_modified, question_modified,time_entry_min,program_number) " &
          "VALUES (@0, @1, @2, @3, @4, @5, @6, @7, @8, @9)",
         dialog.cboUser.SelectedValue,
         dialog.cboStaff.SelectedValue,
         dialog.cboState.SelectedValue,
         dialog.cboCategory.SelectedValue,
         dialog.txtResponse.Text,
         dialog.txtQuestion.Text,
         Date.Now,
         Date.Now,
         CInt(dialog.timeEntryMin.Text),
         dialog.tbProgramNumber.Text
         )

        Fill()
    End Sub

	Public Sub Delete(id As Integer)
		db.Command("DELETE FROM questions WHERE id = @0", ID)

		Fill()
	End Sub

	Public Sub Modify(id As Integer)
		Dim dialog = New TicketForm(id)
		If Not dialog.ShowDialog() = DialogResult.OK Then
			Return
		End If
		
        db.Command(
         "UPDATE questions SET " &
            "time_entry_min = @8, " &
          "response_modified = CASE " &
           "WHEN response = @5 THEN response_modified " &
           "ELSE @7 " &
          "END, " &
          "question_modified = CASE " &
           "WHEN question = @6 THEN question_modified " &
           "ELSE @7 " &
          "END, " &
          "etu_id = @1, staff_id = @2, state = @3, " &
          "categorie_id = @4, response = @5, " &
          "question = @6 " &
         "WHERE id = @0",
         dialog.ID,
         dialog.cboUser.SelectedValue,
         dialog.cboStaff.SelectedValue,
         dialog.cboState.SelectedValue,
         dialog.cboCategory.SelectedValue,
         dialog.txtResponse.Text,
         dialog.txtQuestion.Text,
         Date.Now,
         CInt(dialog.timeEntryMin.Text)
         )

		Fill()
	End Sub

	Public Sub SearchKey(s As Object, e As KeyEventArgs) Handles txtSQuery.KeyUp
		If e.KeyCode = 13
			SearchBtn()
		End If
	End Sub

	Public Sub SearchBtn() Handles bSAct.Click
		Fill()
	End Sub

	Public Sub SearchColChange() Handles cboSColumn.SelectedValueChanged
		FillAutocomplete(cboSColumn.SelectedIndex)
	End Sub

	Public Sub AddBtn() Handles btn_add.Click
		Add()
	End Sub

	Public Sub DelBtn() Handles btn_delete.Click
        If Not dgList.SelectedRows.Count = 0 Then

            If MsgBox("Vous etes sur le point de supprimer " & dgList.SelectedRows.Count & " elements", CType(MsgBoxStyle.Critical + MsgBoxStyle.YesNo, MsgBoxStyle), "WARNING") = MsgBoxResult.Yes Then
                For Each item As DataGridViewRow In dgList.SelectedRows
                    Delete(CInt(item.Tag))
                Next
            End If

        End If
	End Sub

	Public Sub ModBtn() Handles btn_mod.Click
		If Not dgList.SelectedRows.Count = 0 Then
			Modify(CInt(dgList.SelectedRows(0).Tag))
		End If
	End Sub

    Private Sub btn_return_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_return.Click
        Me.Hide()
        amenu.Show()
    End Sub


    Private Sub TicketList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = "Liste des interventions "
        If mOperations.getAdminLevelByUid(userId) <= 1 Then
            cboSColumn.Hide()
            bSAct.Hide()
            txtSQuery.Hide()
        End If
    End Sub
End Class