Public Class workTimeRow
    Public rowId, userId As Integer
    Public Sub New(Optional ByVal _rowId As Integer = Nothing, Optional ByVal _userId As Integer = Nothing)
        rowId = _rowId
        userId = _userId
    End Sub
End Class
