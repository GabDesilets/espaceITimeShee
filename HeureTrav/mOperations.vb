Imports MySql.Data.MySqlClient
Module mOperations
    Public db As MySqlDB = New MySqlDB("Data Source=localhost;Database=sitemeut_espace-i2;User ID=root;Password=toor;")

    Public Sub saveTime(work_day As String, comment As String, categorie_id As String, hours As hoursManagement)
        db.Command(
            "INSERT INTO temps_travail (etu_id, work_day,worked_hours, from_hour,to_hour,from_min,to_min,comment,categorie_id) " &
            "VALUES(@0, @1, @2, @3, @4, @5, @6, @7, @8)",
            3,
            work_day,
            hours.workedHours,
            hours.hourFrom,
            hours.minFrom,
            hours.hourTo,
            hours.minTo,
            comment,
            categorie_id
            )
    End Sub

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
