Imports MySql.Data.MySqlClient
Public Class ListeHeures
    Public db As MySqlDB = New MySqlDB("Data Source=localhost;Database=sitemeut_espace-i2;User ID=root;Password=toor;")

    Private Sub ListeHeures_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim r = db.Query(
            "SELECT tt.work_day,CONCAT_WS(':',from_hour,from_min) as worked_from,CONCAT_WS(':',to_hour,to_min) as worked_to, worked_hours ,tt.comment,tt.etu_id" &
            " FROM temps_travail tt" &
            " JOIN etudiant e on e.id=tt.etu_id"
        )
        Dim i As ListViewItem

        Do While r.Read
            i = New ListViewItem(New String() {
                Format(CDate(r.GetValue(0).ToString), "yyyy-MM-dd"),
                CStr(r.GetValue(1)),
                CStr(r.GetValue(2)),
                CStr(r.GetValue(3)),
                CStr(r.GetValue(4))
            })
            'hidden value , purpose : store the uid will be usefull later for update
            i.Tag = r.GetValue(5)

            lvStudent.Items.Add(i)
        Loop

        r.Close()
    End Sub

    Private Sub lvStudent_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvStudent.DoubleClick
        Dim li = lvStudent.FocusedItem

        ' va chercher la valeur storer a ma colonne X Debug.WriteLine(li.SubItems(work_date.Index).Text)
        Debug.WriteLine(li.Tag)
    End Sub


    Private Sub btn_add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_add.Click
        Me.Hide()
        FrmHeure.Show()
    End Sub


    Private Sub btn_mod_Click(sender As Object, e As EventArgs) Handles btn_mod.Click
        If lvStudent.SelectedIndices.Count <= 0 Then
            Return
        End If

        Me.Hide()
        FrmHeure.Show()

        Dim row = lvStudent.SelectedItems(0)
        Dim time_from, time_to As String()

        FrmHeure.dtp_date.Value = CDate(row.SubItems(0).Text)

        time_from = row.SubItems(1).Text.Split(":"c)
        FrmHeure.worked_hour_from.Text = time_from(0)
        FrmHeure.worked_min_from.Text = time_from(1)

        time_to = row.SubItems(2).Text.Split(":"c)
        FrmHeure.worked_hour_to.Text = time_to(0)
        FrmHeure.worked_min_to.Text = time_to(1)

        FrmHeure.tb_comment.Text = row.SubItems(4).Text
    End Sub

    Private Sub btn_delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_delete.Click
        ' TODO id de la row much?
        db.Command("DELETE FROM temps_travail WHERE etu_id = @0", lvStudent.SelectedItems(0).Tag)
        lvStudent.Items.Remove(lvStudent.SelectedItems(0))
    End Sub

    Private Sub ListeHeures_Closed() Handles Me.FormClosed
        FrmHeure.Close()
    End Sub
End Class