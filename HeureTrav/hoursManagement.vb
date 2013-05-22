'Classe qui gere les heures travailler et calcule le nombre total
'Puisque la classe contient seulement un Constructeur et une methode readOnly
'Dans un futur elle pourrait etre supprimer et remplacer par une simple fonction dans un module
Public Class hoursManagement
    Public hourFrom, hourTo, minFrom, minTo As Integer

    Public Sub New(Optional ByVal _hourFrom As Integer = 0, Optional ByVal _hourTo As Integer = 0, Optional ByVal _minFrom As Integer = 0, Optional ByVal _minTo As Integer = 0)
        hourFrom = _hourFrom
        hourTo = _hourTo
        minFrom = _minFrom
        minTo = _minTo
    End Sub

    'Formule pour calculer le temps travailler entre les 2 periode
    ' Ex : 12:10 a 13:00
    ' 60 - Abs(00-10) = 50
    ' 13-12-1 car on a pas travailler 1h
    ' sinon normal ex:
    ' 12:00 a 14:30
    ' 
    Public ReadOnly Property workedHours As Decimal
        Get
            Dim _to, from As Decimal
            _to = minTo + hourTo * 60
            from = minFrom + hourFrom * 60

            Return Math.Abs(_to - from) / 60D
            
        End Get
    End Property

End Class
