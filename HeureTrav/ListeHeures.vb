Imports MySql.Data.MySqlClient
Public Class ListeHeures
    Public cn As MySqlConnection = New MySqlConnection("Data Source=localhost;Database=sitemeut_espace-i2;User ID=root;Password=toor;")
    Private Sub ListeHeures_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cn.Open()
        Dim Query As String
        Query = "SELECT tt.work_day,CONCAT_WS(':',from_hour,from_min) as worked_from,CONCAT_WS(':',to_hour,to_min) as worked_to, worked_hours ,tt.comment,tt.etu_id "
        Query += " FROM temps_travail tt"
        Query += " JOIN etudiant e on e.id=tt.etu_id"



        Dim mysqlQuery As New MySqlCommand(Query, cn)
        Dim reader As MySqlDataReader = mysqlQuery.ExecuteReader
   
        Dim arr(5) As String
        Dim itm As ListViewItem

        Do While reader.Read
            arr(0) = Format(CDate(reader.GetValue(0).ToString), "yyyy-MM-dd")
            arr(1) = reader.GetValue(1)
            arr(2) = reader.GetValue(2)
            arr(3) = reader.GetValue(3)
            arr(4) = reader.GetValue(4)
            itm = New ListViewItem(arr)
            'hidden value , purpose : store the uid will be usefull later for update
            itm.Tag = reader.GetValue(4)

            lvStudent.Items.Add(itm)
        Loop

        reader.Close()
        mysqlQuery.Dispose()
        cn.Close()

    End Sub

    Private Sub lvStudent_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvStudent.DoubleClick
        Dim li As ListViewItem
        li = lvStudent.FocusedItem

        ' va chercher la valeur storer a ma colonne X Debug.WriteLine(li.SubItems(work_date.Index).Text)
        Debug.WriteLine(li.Tag)
    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Dispose()
        Me.Close()
        FrmHeure.Show()
    End Sub
End Class