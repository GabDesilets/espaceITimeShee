Imports MySql.Data.MySqlClient
Module mOperations
    Public db As MySqlDB = New MySqlDB("Data Source=localhost;Database=sitemeut_espace-i2;User ID=root;Password=toor;")

    Public Sub saveTime(ByVal work_day As String, ByVal comment As String, ByVal categorie_id As String, ByVal hours As hoursManagement)
        If checkIfWorkedToday(3, work_day) Then
            db.Command("UPDATE temps_travail set worked_hours = @0,comment = @1, categorie_id = @2,from_hour = @3 ,to_hour = @4,from_min = @5, to_min = @6 where work_day = @7 and etu_id = @8",
                       hours.workedHours,
                       comment,
                       categorie_id,
                       hours.hourFrom,
                       hours.hourTo,
                       hours.minFrom,
                       hours.minTo,
                       work_day,
                       3
                       )

        Else
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
        End If
       
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

    Private Function checkIfWorkedToday(ByVal studentId As Integer, ByVal workDate As String) As Boolean
        Dim r = db.Query("SELECT id from temps_travail where etu_id = @0 and work_day = CAST(@1 as date)", studentId, workDate)
        Try
            Return r.HasRows

        Finally
            r.Close()

        End Try

    End Function

    Public Sub deleteStudentTime(ByVal workTimeRow As WorkTimeRow)
        db.Command(
            "DELETE FROM temps_travail WHERE etu_id = @0 and id = @1",
            workTimeRow.userId,
            workTimeRow.rowId
            )
    End Sub

End Module
