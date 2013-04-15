Public Class hoursManagement
    Public hourFrom, hourTo, minFrom, minTo As Integer

    Public Sub New(Optional _hourFrom As Integer = 0, Optional _hourTo As Integer = 0, Optional _minFrom As Integer = 0, Optional _minTo As Integer = 0)
        hourFrom = _hourFrom
        hourTo = _hourTo
        minFrom = _minFrom
        minTo = _minTo
    End Sub

    Public ReadOnly Property workedHours As Decimal
        Get
            Dim minTot, hourTot As Decimal

            If minTo < minFrom Then
                minTot = (60 - Math.Abs(minTo - minFrom)) / 100D
                hourTot = (hourTo - hourFrom) - 1
            Else
                minTot = (minTo - minFrom) / 100D
                hourTot = hourTo - hourFrom
            End If

            Return hourTot + minTot
        End Get
    End Property

End Class
