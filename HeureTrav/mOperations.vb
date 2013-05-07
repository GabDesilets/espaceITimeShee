﻿Imports MySql.Data.MySqlClient
Module mOperations
    Public db As MySqlDB = New MySqlDB("Data Source=localhost;Database=sitemeut_espace-i2;User ID=root;Password=toor;")
    Private Const catProgrammation = "PROGRAMMATION"
    Private Const catSupport = "SUPPORT"
    Public Sub saveTime(ByVal work_day As String, ByVal comment As String, ByVal categorie_id As String, ByVal hours As hoursManagement, ByVal uid As Integer, ByVal rowId As String)

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

    Public Function getProgrammationHours(Optional ByVal dtFrom As String = Nothing, Optional ByVal dtTo As String = Nothing) As Dictionary(Of Integer, Decimal)
        'We have to declare a local database connection because we already had one open and that create a conflict. other solution( i suggest you not ) is to close
        'the first one take his channel for this one then close this one a reopen the other one....
        Dim dbloc As MySqlDB = New MySqlDB("Data Source=localhost;Database=sitemeut_espace-i2;User ID=root;Password=toor;")
        Dim r As MySqlDataReader
        Dim query = "SELECT SUM( temps_travail.worked_hours ) AS prog_hours, temps_travail.etu_id " &
                    " FROM(temps_travail)" &
                    " JOIN work_categories wo ON wo.id = temps_travail.categorie_id" &
                    " AND UPPER( wo.name ) LIKE  @0 "

        If Not dtFrom = Nothing And Not dtTo = Nothing Then
            query &= " AND temps_travail.work_day BETWEEN @1 AND @2 GROUP BY temps_travail.etu_id"
        Else
            query &= " GROUP BY temps_travail.etu_id"
        End If

        r = dbloc.Query(query, catProgrammation, dtFrom, dtTo)

        Dim userProgHoursByCat = New Dictionary(Of Integer, Decimal)

        While r.Read()
            userProgHoursByCat.Add(CInt(r("etu_id")), CDec(r("prog_hours")))
        End While

        r.Close()
        dbloc.Dispose()
        Return userProgHoursByCat
    End Function


    Public Function geSupportHours(Optional ByVal dtFrom As String = Nothing, Optional ByVal dtTo As String = Nothing) As Dictionary(Of Integer, Decimal)
        'We have to declare a local database connection because we already had one open and that create a conflict. other solution( i suggest you not ) is to close
        'the first one take his channel for this one then close this one a reopen the other one....
        Dim dbLocSupp As MySqlDB = New MySqlDB("Data Source=localhost;Database=sitemeut_espace-i2;User ID=root;Password=toor;")
        Dim qr = dbLocSupp
        Dim r As MySqlDataReader
        Dim query = "SELECT SUM( temps_travail.worked_hours ) AS supp_hours, temps_travail.etu_id" &
                    " FROM(temps_travail)" &
                    " JOIN work_categories wo ON wo.id = temps_travail.categorie_id" &
                    " WHERE UPPER( wo.name ) LIKE  @0 "

        If Not dtFrom = Nothing And Not dtTo = Nothing Then
            query &= " AND temps_travail.work_day BETWEEN @1 AND @2 GROUP BY temps_travail.etu_id"
            r = qr.Query(query, catSupport, dtFrom, dtTo)
        Else
            query &= " GROUP BY temps_travail.etu_id"
            r = qr.Query(query, catSupport)
        End If


        Dim userSuppHoursByCat = New Dictionary(Of Integer, Decimal)

        While r.Read()
            userSuppHoursByCat.Add(CInt(r("etu_id")), CDec(r("supp_hours")))
        End While

        r.Close()
        dbLocSupp.Dispose()
        Return userSuppHoursByCat

    End Function

    Public Function getTicketNumbers(Optional ByVal dtFrom As String = Nothing, Optional ByVal dtTo As String = Nothing) As Dictionary(Of Integer, Decimal)
        Dim dbLocTick As MySqlDB = New MySqlDB("Data Source=localhost;Database=sitemeut_espace-i2;User ID=root;Password=toor;")
        Dim qr = dbLocTick
        Dim r As MySqlDataReader
        Dim query = "SELECT count(*) AS nb_tickets, questions.staff_id as etu_id" &
        " FROM(questions) "


        If Not dtFrom = Nothing And Not dtTo = Nothing Then
            query &= " WHERE questions.question_modified BETWEEN @0 AND @1 group by questions.staff_id"
            r = qr.Query(query, dtFrom, dtTo)
        Else
            query &= " group by questions.staff_id "
            r = qr.Query(query)
        End If

        Dim userTickets = New Dictionary(Of Integer, Decimal)

        While r.Read()
            userTickets.Add(CInt(r("etu_id")), CDec(r("nb_tickets")))
        End While

        r.Close()
        dbLocTick.Dispose()
        Return userTickets
    End Function
End Module
