Imports Microsoft.Extensions.Logging
Public Class SomeClass
    Private ReadOnly _logger As ILogger(Of SomeClass)

    Private Sub New(ByVal logger As ILogger(Of SomeClass))
        _logger = logger
    End Sub

    Private Sub LogCritical(message As String)
        _logger.Log(LogLevel.Critical, message)
        _logger.LogInformation("")
    End Sub
    Public Sub LogInfo(message As String)
        _logger.LogInformation(message)
    End Sub
End Class
