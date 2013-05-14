Imports MySql.Data.MySqlClient
Module LogHook
    'Methode qui ecrit les journal d'activitees
    Public Sub writeLog(ByVal text As String)
        'Nom du directory
        Dim dName = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) & "\Journal d'activite"
        'Nom du fichier
        Dim fName = "\" & Format(DateTime.Today, "yyyy-MM-dd") & "-Journal d'activitie.txt"

        If (Not System.IO.Directory.Exists(dName)) Then
            System.IO.Directory.CreateDirectory(dName)
        End If

        If Not System.IO.File.Exists(dName & fName) Then
            System.IO.File.Create(dName & fName).Dispose()
        End If

        Dim objWriter As New System.IO.StreamWriter(dName & fName, True)
        objWriter.Write(text & vbCrLf)
        objWriter.Close()
    End Sub

    Public Sub add(ByVal etu_id As Integer, ByVal action As String, Optional ByVal description As String = "")
        db.Command(
            "INSERT INTO log (etu_id, changed_at, act, description) " &
            "VALUES(@0, now(), @1, @2)",
            etu_id,
            action,
            description)
    End Sub

    Public Function getLog() As MySqlDataReader
        Return db.Query("SELECT CONCAT_WS(',',UCASE(e.nom),UCASE(e.prenom)) as name, DATE_FORMAT( l.changed_at,  '%Y-%m-%d %H:%i:%s' )as changed_at , l.act, l.description" &
                        " FROM log l" &
                        " JOIN etudiant e ON e.id = l.etu_id ")
    End Function

End Module
