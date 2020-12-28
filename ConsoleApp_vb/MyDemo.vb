Imports Microsoft.Extensions.Logging
Public Class MyDemo
    Private ReadOnly _logger As ILogger(Of MyDemo)

    Private Sub New(logger As ILogger(Of MyDemo))
        _logger = logger
    End Sub

    Public Sub LogCritical(message As String)
        _logger.Log(LogLevel.Critical, message)
    End Sub
    Public Sub LogInfo(message As String)
        _logger.LogInformation(message)
    End Sub
End Class
