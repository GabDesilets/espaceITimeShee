Imports MySql.Data.MySqlClient
Module mOperations
    Public cn As MySqlConnection = New MySqlConnection("Data Source=localhost;Database=sitemeut_espace-i2;User ID=root;Password=toor;")

    Public Sub saveTime(ByVal data As Dictionary(Of String, String), ByVal hours(,) As Integer)

        Dim Query As String
        Dim i As Integer
        Dim workedHours As Decimal

        workedHours = getWorkedHours(hours)
        Query = "INSERT INTO temps_travail (etu_id, work_day,worked_hours, from_hour,to_hour,from_min,to_min,comment,categorie_id) "
        Query += "VALUES(" & 3 & ",'" & data.Item("work_day") & "'," & workedHours & "," & hours(0, 0) & "," & hours(1, 0) & "," & hours(0, 1) & "," & hours(1, 1) & ",'" & data.Item("comment") & "'," & data.Item("categorie_id") & ")"

        cn.Open()


        Dim cmd As MySqlCommand = New MySqlCommand(Query, cn)
        i = cmd.ExecuteNonQuery()

        cn.Close()
    End Sub

    Private Function getWorkedHours(ByVal hours(,) As Integer)
        Dim hourTot As Integer
        Dim minTot As Decimal

        If hours(1, 1) < hours(0, 1) Then
            minTot = (60 - Math.Abs(hours(1, 1) - hours(0, 1))) / 100
            hourTot = (hours(1, 0) - hours(0, 0)) - 1
        Else
            minTot = (hours(1, 1) - hours(0, 1)) / 100
            hourTot = hours(1, 0) - hours(0, 0)
        End If
        Return hourTot + minTot
    End Function

    Public Function getCategories()

        cn.Open()
        Dim Query As String
        Query = "Select id,name from work_categories"
        Dim mysqlQuery As New MySqlCommand(Query, cn)
        Dim reader As MySqlDataReader = mysqlQuery.ExecuteReader

        Dim categories As New Dictionary(Of Integer, String)

        While reader.Read()
            categories.Add(reader("id"), reader("name"))
        End While
        cn.Close()
        Return categories

    End Function


End Module
