Imports MySql.Data.MySqlClient
Module mOperations
    Public cn As MySqlConnection = New MySqlConnection("Data Source=localhost;Database=sitemeut_espace-i2;User ID=root;Password=toor;")

    Public Sub saveTime(ByVal data As Dictionary(Of String, String), ByVal hours(,) As Integer)
        Dim workedHours = getWorkedHours(hours)

        cn.Open()

        ' v syntax error without this thing. dont f*cking ask
        Dim vbneedsthis = (New MySqlCommand("INSERT INTO temps_travail (etu_id, work_day,worked_hours, from_hour,to_hour,from_min,to_min,comment,categorie_id) ", cn)).ExecuteNonQuery()

        cn.Close()
    End Sub

    Private Function getWorkedHours(ByVal hours(,) As Integer) As Decimal
        Dim hourTot, minTot As Decimal

        If hours(1, 1) < hours(0, 1) Then
            minTot = (60 - Math.Abs(hours(1, 1) - hours(0, 1))) / 100D
            hourTot = (hours(1, 0) - hours(0, 0)) - 1
        Else
            minTot = (hours(1, 1) - hours(0, 1)) / 100D
            hourTot = hours(1, 0) - hours(0, 0)
        End If
        Return hourTot + minTot
    End Function

    Public Function getCategories() As Dictionary(Of Integer, String)
        cn.Open()

        Dim categories As New Dictionary(Of Integer, String)
        Dim reader As MySqlDataReader = (New MySqlCommand("Select id,name from work_categories", cn)).ExecuteReader()

        While reader.Read()
            categories.Add(CInt(reader("id")), CStr(reader("name")))
        End While

        cn.Close()

        Return categories
    End Function


End Module
