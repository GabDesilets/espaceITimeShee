'Classe de base de donne MySql pour simplifier la gestion des requetes
Imports MySql.Data.MySqlClient

Public Class MySqlDB
    Implements IDisposable

    Dim conn As MySqlConnection

    Public Sub New(cs As String)
        conn = New MySqlConnection(cs)
        conn.Open()
    End Sub

    Public Function Query(qs As String, ParamArray p() As Object) As MySqlDataReader
        Dim q = New MySqlCommand(qs, conn)
        For i As Integer = 0 To p.Count - 1
            q.Parameters.AddWithValue(i.ToString(), p(i))
        Next

        Return q.ExecuteReader()
    End Function

    Public Function Command(qs As String, ParamArray p() As Object) As Integer
        Dim q = New MySqlCommand(qs, conn)
        For i As Integer = 0 To p.Count - 1
            q.Parameters.AddWithValue(i.ToString(), p(i))
        Next

        Return q.ExecuteNonQuery()
    End Function

    Public Sub Dispose() Implements IDisposable.Dispose
        conn.Close()
    End Sub
End Class
