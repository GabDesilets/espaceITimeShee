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
        q.Parameters.AddRange(p)

        Return q.ExecuteReader()
    End Function

    Public Function Command(qs As String, ParamArray p() As Object) As Integer
        Dim q = New MySqlCommand(qs, conn)
        q.Parameters.AddRange(p)

        Return q.ExecuteNonQuery()
    End Function

    Public Sub Dispose() Implements IDisposable.Dispose
        conn.Close()
    End Sub
End Class
