Imports System.IO
Imports ConsoleApp_vb.Interfaces
Imports Microsoft.Extensions.Logging

Namespace Classes

    Public Class WorkerService
        Implements IService

        Private ReadOnly logger As ILogger

        Public Sub New(logger As ILogger(Of WorkerService))
            Me.logger = logger
        End Sub

        Public Sub DoWork() Implements IService.DoWork

            logger.LogInformation("3 Doing work.")
            logger.LogWarning("4 Something warning")
            logger.LogCritical("5 Something critical")

        End Sub

        Public Sub IService_WriteToFile() Implements IService.WriteToFile
            Try
                File.ReadAllLines("SomeNonExistingFile.txt")
            Catch ex As Exception
                logger.LogError(ex.Message)
            End Try
        End Sub

    End Class
End Namespace