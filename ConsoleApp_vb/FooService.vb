Imports Microsoft.Extensions.Logging

Public Class FooService
    Implements IFooService

    Private ReadOnly logger As ILogger

    Public Sub New(ByVal logger As ILogger(Of FooService))
        Me.logger = logger
    End Sub

    Public Sub DoWork() Implements IFooService.DoWork
        logger.LogInformation("3333Doing work.")
        logger.LogWarning("4444Something warning")
        logger.LogCritical("5555Something critical")
    End Sub
End Class
