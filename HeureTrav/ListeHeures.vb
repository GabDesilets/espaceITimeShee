﻿Imports MySql.Data.MySqlClient
Public Class ListeHeures
    Public Shared db As MySqlDB

    Public uid As Integer, userName As String, other As FrmHeure

    Public Sub New(u As Integer)
        InitializeComponent()
        uid = u
        userName = getUserNameById(uid)
    End Sub

    Private Sub ListeHeures_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim dateOfFirstDay As DateTime = getfirstOfWeek(DateTime.Now)
        Dim dateOflastDay As DateTime = getlastOfWeek(DateTime.Now)

        lbl_title.Text = "Liste des heures de : " & userName
        dateFrom.Value = dateOfFirstDay
        dateTo.Value = dateOflastDay
        Dim dtFrom As String = Format(dateOfFirstDay, "yyyy-MM-dd")
        Dim dtTo As String = Format(dateOflastDay, "yyyy-MM-dd")
        fillByWorkedDayBetweenDates(dtFrom, dtTo)
    End Sub

    Private Sub lvStudent_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvStudent.DoubleClick
        Dim li = lvStudent.FocusedItem.Tag

        ' va chercher la valeur storer a ma colonne X Debug.WriteLine(li.SubItems(work_date.Index).Text)
        Debug.WriteLine(li)
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
    End Sub

    Private Sub btn_delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_delete.Click
        If lvStudent.SelectedIndices.Count <= 0 Then
            Return
        End If
        Dim listTag = lvStudent.FocusedItem.Tag

        deleteStudentTime(CType(listTag, workTimeRow))
        lvStudent.Items.Remove(lvStudent.SelectedItems(0))
    End Sub
    Public Sub loadForm()
        Dim r = db.Query(
                   "SELECT tt.work_day,from_hour,from_min,to_hour,to_min, worked_hours ,tt.comment,tt.etu_id, tt.id" &
                   " FROM temps_travail tt" &
                   " JOIN etudiant e on e.id=tt.etu_id" &
                   " WHERE e.id = @0",
                   uid
               )

        lvStudent.Items.Clear()
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

        r.Close()
    End Sub
    Private Sub ListeHeures_Closed() Handles Me.FormClosed
        other.Close()
    End Sub

    Public Sub fillByWorkedDayBetweenDates(ByVal dateFrom As String, ByVal dateTo As String)

        Dim r = db.Query(
                   "SELECT tt.work_day,from_hour,from_min,to_hour,to_min, worked_hours ,tt.comment,tt.etu_id, tt.id" &
                   " FROM temps_travail tt" &
                   " JOIN etudiant e on e.id=tt.etu_id" &
                   " WHERE e.id = @0" &
                   " AND tt.work_day BETWEEN @1 AND @2 ",
                   uid,
                   dateFrom,
                   dateTo
               )

        lvStudent.Items.Clear()
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

        r.Close()
    End Sub

    Private Sub dateFrom_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dateFrom.ValueChanged, dateTo.ValueChanged
        Dim dfrom, dto As String
        dfrom = Format(dateFrom.Value, "yyyy-MM-dd")
        dto = Format(dateTo.Value, "yyyy-MM-dd")

        fillByWorkedDayBetweenDates(dfrom, dto)
    End Sub

    
End Class