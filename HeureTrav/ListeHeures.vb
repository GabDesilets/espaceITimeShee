Imports MySql.Data.MySqlClient
Public Class ListeHeures
    Public cn As MySqlConnection = New MySqlConnection("Data Source=localhost;Database=sitemeut_espace-i2;User ID=root;Password=toor;")
    Private Sub ListeHeures_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cn.Open()
        Dim Query As String
        Query = "SELECT tt.work_day ,CONCAT_WS(' ',e.prenom,e.nom) as nom, sum(worked_hours) as worked_hours,tt.etu_id "
        Query += " FROM temps_travail tt"
        Query += " JOIN etudiant e on e.id=tt.etu_id"
        Query += " group by tt.work_day"


        Dim mysqlQuery As New MySqlCommand(Query, cn)
        Dim reader As MySqlDataReader = mysqlQuery.ExecuteReader
   
        Dim arr(3) As String
        Dim itm As ListViewItem

        Do While reader.Read
            arr(0) = reader.GetValue(1)
            arr(1) = Format(CDate(reader.GetValue(0).ToString), "yyyy-MM-dd")
            arr(2) = reader.GetValue(2)
            itm = New ListViewItem(arr)
            'hidden value , purpose : store the uid will be usefull later for update
            itm.Tag = reader.GetValue(3)

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
End Class