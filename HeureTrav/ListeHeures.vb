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
            i.Tag = r.GetValue(4)

            lvStudent.Items.Add(i)
        Loop

        r.Close()
    End Sub

    Private Sub lvStudent_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvStudent.DoubleClick
        Dim li = lvStudent.FocusedItem

        ' va chercher la valeur storer a ma colonne X Debug.WriteLine(li.SubItems(work_date.Index).Text)
        Debug.WriteLine(li.Tag)
    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
        FrmHeure.Show()
    End Sub
End Class