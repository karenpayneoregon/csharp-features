Imports Microsoft.Extensions.Logging
Public Class SomeClass
    Private ReadOnly _logger As ILogger(Of SomeClass)

    Private Sub New(logger As ILogger(Of SomeClass))
        _logger = logger
    End Sub

    Public Sub LogCritical(message As String)
        _logger.Log(LogLevel.Critical, message)
    End Sub
    Public Sub LogInfo(message As String)
        _logger.LogInformation(message)
    End Sub
End Class
