Imports Microsoft.Extensions.Logging

Namespace Classes
    Public Class LoggerLocal
        Private ReadOnly _logger As ILogger(Of LoggerLocal)

        Private Sub New(logger As ILogger(Of LoggerLocal))
            _logger = logger
        End Sub
        Public Sub Payne()
            
        End Sub
    End Class
End Namespace