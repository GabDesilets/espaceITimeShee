Public Class hoursManagement
    Private _hourFrom, _hourTo, _minFrom, _minTo As Integer

    Public Sub New()
        _hourFrom = 0
        _hourTo = 0
        _minFrom = 0
        _minTo = 0
    End Sub

    Public Property hourFrom() As Integer
        Get
            Return _hourFrom
        End Get
        Set(ByVal value As Integer)
            _hourFrom = value
        End Set
    End Property

    Public Property hourTo() As Integer
        Get
            Return _hourTo
        End Get
        Set(ByVal value As Integer)
            _hourTo = value
        End Set
    End Property


    Public Property minFrom() As Integer
        Get
            Return _minFrom
        End Get
        Set(ByVal value As Integer)
            _minFrom = value
        End Set
    End Property


    Public Property minTo() As Integer
        Get
            Return _minTo
        End Get
        Set(ByVal value As Integer)
            _minTo = value
        End Set
    End Property

    Public Function getWorkedHours(ByVal hours(,) As Integer) As Decimal
        Dim hourTot, minTot As Decimal

        If _minTo < _minFrom Then
            minTot = (60 - Math.Abs(_minTo - _minFrom)) / 100D
            hourTot = (_hourTo - _hourFrom) - 1
        Else
            minTot = (_minTo - _minFrom) / 100D
            hourTot = _hourTo - _hourFrom
        End If
        Return hourTot + minTot
    End Function

End Class
