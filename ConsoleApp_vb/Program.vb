
Imports Microsoft.Extensions.Configuration
Imports Microsoft.Extensions.DependencyInjection
Imports Microsoft.Extensions.Logging
Imports System.Console
Imports System.IO
Imports ConsoleApp_vb.Classes
Imports ConsoleApp_vb.Interfaces

Module Program
    Private _logger As ILogger(Of LoggerLocal)

    Sub Main(args As String())

        WriteLine()
        'ApplicationConfiguration.Instance.Logger.LogInformation("1 logger information")
        'ApplicationConfiguration.Instance.Logger.LogWarning("2 logger warning")
        ApplicationConfiguration.Instance.Karen()
        'Example()

        'ApplicationConfiguration.Instance.Service.DoWork()
        'ApplicationConfiguration.Instance.Service.WriteToFile()
        ReadLine()

    End Sub

    'Private Sub Example()
    '    Dim configuration As IConfigurationRoot = (New ConfigurationBuilder()).
    '            AddJsonFile("appsettings.json", False, True).
    '            Build()


    '    Dim serviceProvider As ServiceProvider = (New ServiceCollection()).
    '            AddSingleton(Of IService, WorkerService)().
    '            AddLogging(Sub(builder)
    '                           builder.AddConfiguration(configuration.GetSection("Logging"))
    '                           builder.AddConsole()
    '                       End Sub).BuildServiceProvider()


    '    _logger = serviceProvider.GetService(Of ILogger(Of Logger))()
    '    Dim service As IService = serviceProvider.GetService(Of IService)()

    '    _logger.LogInformation("1 logger information")
    '    _logger.LogWarning("2 logger warning")

    '    service.DoWork()

    '    WriteToFile()
    'End Sub

    Private Sub WriteToFile()
        Try
            File.ReadAllLines("SomeNonExistingFile.txt")
        Catch ex As Exception
            _logger.LogError(ex.Message)
        End Try
    End Sub

End Module


