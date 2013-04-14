Imports MySql.Data.MySqlClient
Public Class ListeHeures
    Public cn As MySqlConnection = New MySqlConnection("Data Source=localhost;Database=sitemeut_espace-i2;User ID=root;Password=toor;")
    Private Sub ListeHeures_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cn.Open()
        Dim Query As String
        Query = "SELECT tt.work_day,CONCAT_WS(':',from_hour,from_min) as worked_from,CONCAT_WS(':',to_hour,to_min) as worked_to, worked_hours ,tt.comment,tt.etu_id "
        Query += " FROM temps_travail tt"
        Query += " JOIN etudiant e on e.id=tt.etu_id"

        Dim reader As MySqlDataReader = (New MySqlCommand(Query, cn)).ExecuteReader

        Dim itm As ListViewItem

        Do While reader.Read
            itm = New ListViewItem(New String() {
                Format(CDate(reader.GetValue(0).ToString), "yyyy-MM-dd"),
                CStr(reader.GetValue(1)),
                CStr(reader.GetValue(2)),
                CStr(reader.GetValue(3)),
                CStr(reader.GetValue(4))
            })
            'hidden value , purpose : store the uid will be usefull later for update
            itm.Tag = reader.GetValue(5)

            lvStudent.Items.Add(itm)
        Loop

        reader.Close()
        cn.Close()

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

    Private Sub btn_delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_delete.Click
        Dim student As ListViewItem
        For Each student In lvStudent.Items
            If student.Selected = True Then
                MsgBox(student.Tag)
            End If
        Next
    End Sub
End Class