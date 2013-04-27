Imports MySql.Data.MySqlClient
Module mOperations
    Public db As MySqlDB = New MySqlDB("Data Source=localhost;Database=sitemeut_espace-i2;User ID=root;Password=toor;")
    Public Const fromAdd As Integer = 1
    Public Const fromEdit As Integer = 2

    Public Function saveTime(ByVal work_day As String, ByVal comment As String, ByVal categorie_id As String, ByVal hours As hoursManagement, ByVal uid As Integer, ByVal rowId As String) As Integer
        Dim saveFrom As Integer
        If rowId <> "" Or checkIfWorkedToday(uid, work_day, hours) Then

            db.Command(
                "UPDATE temps_travail set worked_hours = @0,comment = @1, categorie_id = @2,from_hour = @3 ,to_hour = @4,from_min = @5, to_min = @6 where work_day = @7 and etu_id = @8" &
                " AND id = @9",
                   hours.workedHours,
                   comment,
                   categorie_id,
                   hours.hourFrom,
                   hours.hourTo,
                   hours.minFrom,
                   hours.minTo,
                   work_day,
                   uid,
                   rowId
                       )
            saveFrom = fromEdit

        Else

            db.Command(
                "INSERT INTO temps_travail (etu_id, work_day,worked_hours, from_hour,to_hour,from_min,to_min,comment,categorie_id) " &
                "VALUES(@0, @1, @2, @3, @4, @5, @6, @7, @8)",
                uid,
                work_day,
                hours.workedHours,
                hours.hourFrom,
                hours.hourTo,
                hours.minFrom,
                hours.minTo,
                comment,
                categorie_id
            )

            saveFrom = fromAdd

        End If
        Return saveFrom
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

    Private Function checkIfWorkedToday(ByVal studentId As Integer, ByVal workDate As String, ByVal hours As hoursManagement) As Boolean
        Dim r = db.Query("SELECT id from temps_travail where etu_id = @0 and work_day = CAST(@1 as date) " &
                         "AND from_hour = @2 AND to_hour = @3 AND from_min =  @4 and to_min = @5",
                         studentId,
                         workDate,
                         hours.hourFrom,
                         hours.hourTo,
                         hours.minFrom,
                         hours.minTo
                         )
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

    Public Function getCategorieIdByRowId(ByVal workTimeRow As workTimeRow) As Integer
        Dim r = db.Query("SELECT categorie_id from temps_travail where id = @0  LIMIT 1 ", workTimeRow.rowId)
        r.Read()
        Dim cat_id As Integer = CInt(r("categorie_id"))

        r.Close()
        Return cat_id
    End Function

    Public Function getUserNameById(ByVal studentId As Integer) As String
        Dim r = db.Query("SELECT CONCAT_WS(' ',prenom,nom) as name from etudiant where id = @0  LIMIT 1 ", studentId)
        r.Read()
        Dim uName As String = CStr(r("name"))

        r.Close()
        Return uName
    End Function

    Public Function getAdminLevelByUid(ByVal uid As Integer) As Integer
        Dim r = db.Query("SELECT admin from etudiant where id = @0  LIMIT 1 ", uid)
        r.Read()
        Dim uAdminLevel As Integer = CInt(r("admin"))

        r.Close()
        Return uAdminLevel
    End Function

    Public Function getFirstOfWeek(ByRef Dt As DateTime) As DateTime
        Return Dt.AddDays(-Dt.DayOfWeek)
    End Function

    Public Function getLastOfWeek(ByRef Dt As DateTime) As DateTime
        Return Dt.AddDays(-Dt.DayOfWeek + 6)
    End Function

End Module
