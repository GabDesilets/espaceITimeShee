Imports MySql.Data.MySqlClient
Public Class ListeHeures
    Public Shared db As MySqlDB
    Private Const STUDENT As Integer = 1
    Private Const SUPER_USER As Integer = 2
    Public dateOfFirstDay As DateTime = getFirstOfWeek(DateTime.Now)
    Public dateOflastDay As DateTime = getLastOfWeek(DateTime.Now)
    Public uid, adminLvl As Integer, userName As String, other As FrmHeure

    Public Sub New(u As Integer)
        InitializeComponent()
        uid = u
        adminLvl = mOperations.getAdminLevelByUid(uid)
        userName = mOperations.getUserNameById(uid)
        checkAdminAccess(adminLvl)

        dateFrom.Value = dateOfFirstDay
        dateTo.Value = dateOflastDay
        Dim dtFrom As String = Format(dateOfFirstDay, "yyyy-MM-dd")
        Dim dtTo As String = Format(dateOflastDay, "yyyy-MM-dd")

        If adminLvl > STUDENT Then
            lvStudent.Columns.Add("Nom", 90, HorizontalAlignment.Left).DisplayIndex = 0
            lvStudent.Columns.Add("Prenom", 90, HorizontalAlignment.Left).DisplayIndex = 1
            lvStudent.Size = New Size(810, 282)
        End If
        other = New FrmHeure(uid, Me)
    
    End Sub

    Private Sub ListeHeures_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lbl_title.Text = "Liste des heures de : " & userName
        dateFrom.Value = dateOfFirstDay
        dateTo.Value = dateOflastDay
        Dim dtFrom As String = Format(dateOfFirstDay, "yyyy-MM-dd")
        Dim dtTo As String = Format(dateOflastDay, "yyyy-MM-dd")
        fillByWorkedDayBetweenDates(dtFrom, dtTo)
        FillAutocomplete()

        panBtnExit.Controls.Add(exitButton.createExitBtn(Me))
    End Sub

    Private Sub btn_add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_add.Click
        Me.Hide()
        other.Show()
    End Sub


    Private Sub btn_mod_Click(sender As Object, e As EventArgs) Handles btn_mod.Click
        If lvStudent.SelectedIndices.Count <= 0 Then
            Return
        End If

        Me.Hide()
        other.Show()

        Dim row = lvStudent.SelectedItems(0)
        Dim listTag = lvStudent.FocusedItem.Tag
        Dim time_from, time_to As String()

        other.dtp_date.Value = CDate(row.SubItems(0).Text)
        other.cbCategories.SelectedValue = getCategorieIdByRowId(CType(listTag, workTimeRow))
        time_from = row.SubItems(1).Text.Split(":"c)
        other.worked_hour_from.Text = time_from(0)
        other.worked_min_from.Text = time_from(1)

        time_to = row.SubItems(2).Text.Split(":"c)
        other.worked_hour_to.Text = time_to(0)
        other.worked_min_to.Text = time_to(1)

        other.tb_comment.Text = row.SubItems(4).Text

        other.lbl_hidden_row_id.Text = CType(listTag, workTimeRow).rowId.ToString
    End Sub

    Private Sub btn_delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_delete.Click
        If lvStudent.SelectedIndices.Count <= 0 Then
            Return
        End If

        If MsgBox("Vous etes sur le point de supprimer " & lvStudent.SelectedIndices.Count & " elements", CType(MsgBoxStyle.Critical + MsgBoxStyle.YesNo, MsgBoxStyle), "WARNING") = MsgBoxResult.Yes Then
            For Each item As ListViewItem In lvStudent.SelectedItems
                If item.Selected Then
                    Dim listTag = item.Tag
                    mOperations.deleteStudentTime(CType(listTag, workTimeRow))
                    lvStudent.Items.Remove(item)
                End If
            Next
        End If

        

    End Sub

    Private Sub ListeHeures_Closed() Handles Me.FormClosed
        other.Close()
        amenu.Show()
    End Sub

    Public Sub fillByWorkedDayBetweenDates(ByVal dateFrom As String, ByVal dateTo As String)

        Dim query = "SELECT tt.work_day,from_hour,from_min,to_hour,to_min, worked_hours ,tt.comment,tt.etu_id, tt.id,e.prenom,e.nom " &
                   " FROM temps_travail tt" &
                   " JOIN etudiant e on e.id=tt.etu_id" &
                   " WHERE tt.work_day BETWEEN @0 AND @1 "


        Dim r As MySqlDataReader
        lvStudent.Items.Clear()

        If adminLvl > STUDENT Then
            If Not txtSQuery.Text = "" Then
                query &= " AND e.nom LIKE CONCAT('%', @2, '%') OR e.prenom LIKE CONCAT('%', @2, '%') OR CONCAT(e.nom,' ', e.prenom) LIKE CONCAT('%', @2, '%') OR CONCAT(e.prenom, ' ', e.nom) LIKE CONCAT('%', @2, '%') "
                r = db.Query(query,
                 dateFrom,
                 dateTo,
                 txtSQuery.Text
             )
            Else
                r = db.Query(query,
                                 dateFrom,
                                 dateTo
                             )
            End If
           
            'Therefore he's an admin
            fillAsAdmin(r)
        Else

            query &= " AND e.id = @2"
            If Not txtSQuery.Text = "" Then
                query &= " AND e.nom LIKE CONCAT('%', @2, '%') OR e.prenom LIKE CONCAT('%', @2, '%') OR CONCAT(e.nom,' ', e.prenom) LIKE CONCAT('%', @2, '%') OR CONCAT(e.prenom, ' ', e.nom) LIKE CONCAT('%', @2, '%') "
                r = db.Query(query,
                      dateFrom,
                      dateTo,
                      uid,
                      txtSQuery.Text
                      )
            Else
                r = db.Query(query,
                  dateFrom,
                  dateTo,
                  uid
                  )
            End If
          
            'therefore he's a student
            fillAsStudent(r)

        End If

        r.Close()
    End Sub

    Private Sub fillAsAdmin(ByVal r As MySqlDataReader)
        Dim i As ListViewItem

        Dim rowArr As New Dictionary(Of String, Integer)
        Do While r.Read()
            i = New ListViewItem(New String() {
                Format(CDate(r.GetValue(0).ToString), "yyyy-MM-dd"),
                String.Format("{0:00}:{1:00}", CInt(r.GetValue(1)), CInt(r.GetValue(2))),
                String.Format("{0:00}:{1:00}", CInt(r.GetValue(3)), CInt(r.GetValue(4))),
                CStr(r.GetValue(5)),
                CStr(r.GetValue(6)),
                CStr(r("nom")),
                CStr(r("prenom"))
            })

            'hidden value , purpose : store the uid will be usefull later for update pos 0 is UID and 1 row id

            i.Tag = New workTimeRow(CInt(r.GetValue(8)), CInt(r.GetValue(7)))

            lvStudent.Items.Add(i)
        Loop
    End Sub
    Private Sub fillAsStudent(ByVal r As MySqlDataReader)
        Dim i As ListViewItem

        Dim rowArr As New Dictionary(Of String, Integer)
        Do While r.Read()
            i = New ListViewItem(New String() {
                Format(CDate(r.GetValue(0).ToString), "yyyy-MM-dd"),
                String.Format("{0:00}:{1:00}", CInt(r.GetValue(1)), CInt(r.GetValue(2))),
                String.Format("{0:00}:{1:00}", CInt(r.GetValue(3)), CInt(r.GetValue(4))),
                CStr(r.GetValue(5)),
                CStr(r.GetValue(6))
            })

            'hidden value , purpose : store the uid will be usefull later for update pos 0 is UID and 1 row id

            i.Tag = New workTimeRow(CInt(r.GetValue(8)), CInt(r.GetValue(7)))

            lvStudent.Items.Add(i)
        Loop
    End Sub

    Private Sub dateFrom_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dateFrom.ValueChanged, dateTo.ValueChanged
        Dim dfrom, dto As String
        dfrom = Format(dateFrom.Value, "yyyy-MM-dd")
        dto = Format(dateTo.Value, "yyyy-MM-dd")

        fillByWorkedDayBetweenDates(dfrom, dto)
    End Sub

    Public Sub FillAutocomplete()
        txtSQuery.AutoCompleteCustomSource.Clear()
        Using r = db.Query("SELECT CONCAT_WS(' ',prenom,nom) as name FROM etudiant")
            While r.Read()
                txtSQuery.AutoCompleteCustomSource.Add(r.GetString(0))
            End While
        End Using
    End Sub

    Private Sub checkAdminAccess(ByVal adminLvl As Integer)
        If adminLvl < STUDENT Then
            txtSQuery.Hide()
            bSAct.Hide()
        End If
    End Sub

    Public Sub SearchKey(ByVal s As Object, ByVal e As KeyEventArgs) Handles txtSQuery.KeyUp
        If e.KeyCode = 13 Then
            SearchBtn()
        End If
    End Sub

    Public Sub SearchBtn() Handles bSAct.Click
        Dim dfrom, dto As String
        dfrom = Format(dateFrom.Value, "yyyy-MM-dd")
        dto = Format(dateTo.Value, "yyyy-MM-dd")

        fillByWorkedDayBetweenDates(dfrom, dto)
    End Sub

End Class