Namespace LogFile
    Public Class ClsLog
        Private dName As String
        Private fName As String

        Property dirName() As String
            Get
                Return dName
            End Get
            Set(ByVal Value As String)
                dName = Value
            End Set
        End Property

        Property fileName() As String
            Get
                Return fName
            End Get
            Set(ByVal Value As String)
                fName = Value
            End Set
        End Property

'ecrit les log
        Public Sub writeLog(ByVal text As String)
            If System.IO.File.Exists(dName & fName) = False Then
                createDir(dName)
                createFile(dName & fName)
            End If
            Dim objWriter As New System.IO.StreamWriter(dName & fName, True)
            objWriter.Write(text & vbCrLf)
            objWriter.Close()
        End Sub
        Private Sub createDir(ByVal dirName As String)
            If (Not System.IO.Directory.Exists(dirName)) Then
                System.IO.Directory.CreateDirectory(dirName)
            End If
        End Sub

        Private Sub createFile(ByVal filePath As String)
            If Not System.IO.File.Exists(filePath) Then
                System.IO.File.Create(filePath).Dispose()
            End If
        End Sub
    End Class
End Namespace

