Imports Microsoft.Extensions.Logging

Public Class MyService
    Implements IMyService

    Private ReadOnly logger As ILogger

    Public Sub New(logger As ILogger(Of MyService))
        Me.logger = logger
    End Sub

    Public Sub DoWork() Implements IMyService.DoWork

        logger.LogInformation("3 Doing work.")
        logger.LogWarning("4 Something warning")
        logger.LogCritical("5 Something critical")

    End Sub
End Class
