Imports MySql.Data.MySqlClient
Module mOperations
    Public db As MySqlDB = New MySqlDB("Data Source=localhost;Database=sitemeut_espace-i2;User ID=root;Password=toor;")

    Public Sub saveTime(ByVal data As Dictionary(Of String, String), ByVal hours(,) As Integer)
        Dim workedHours = getWorkedHours(hours)

        db.Command(
            "INSERT INTO temps_travail (etu_id, work_day,worked_hours, from_hour,to_hour,from_min,to_min,comment,categorie_id) " &
            "VALUES(@0, @1, @2, @3, @4, @5, @6, @7, @8)",
            3,
            data.Item("work_day"),
            getWorkedHours(hours),
            hours(0, 0),
            hours(1, 0),
            hours(0, 1),
            hours(1, 1),
            data.Item("comment"),
            data.Item("categorie_id")
            )
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
        Dim categories As New Dictionary(Of Integer, String)
        Dim reader = db.Query("Select id,name from work_categories")

        While reader.Read()
            categories.Add(CInt(reader("id")), CStr(reader("name")))
        End While

        reader.Close()
        Return categories
    End Function

    Public Sub deleteStudentTime(ByVal studentId As Integer)
        db.Command(
            "DELETE FROM temps_travail WHERE etu_id = @0", studentId
            )
    End Sub

End Module
