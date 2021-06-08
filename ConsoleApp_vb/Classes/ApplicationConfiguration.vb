Imports ConsoleApp_vb.Interfaces
Imports Microsoft.Extensions.Configuration
Imports Microsoft.Extensions.DependencyInjection
Imports Microsoft.Extensions.Logging

Namespace Classes
    Public NotInheritable Class ApplicationConfiguration

        Private Shared ReadOnly Lazy As New Lazy(Of ApplicationConfiguration)(Function() New ApplicationConfiguration())

        ''' <summary>
        ''' Access point to methods and properties
        ''' </summary>
        Public Shared ReadOnly Property Instance() As ApplicationConfiguration
            Get
                Return Lazy.Value
            End Get
        End Property

        Private Sub New()

            configuration = (New ConfigurationBuilder()).
                AddJsonFile("appsettings.json", False, True).
                Build()

            serviceProvider = New ServiceCollection().
                AddSingleton(Of IService, WorkerService)().
                AddLogging(Sub(builder)
                               builder.AddConfiguration(configuration.GetSection("Logging"))
                               builder.AddConsole()
                           End Sub).BuildServiceProvider()

            Logger = serviceProvider.GetService(Of ILogger(Of LoggerLocal))()

        End Sub

        Private ReadOnly configuration As IConfigurationRoot
        Private ReadOnly serviceProvider As ServiceProvider

        Public ReadOnly Property Service() As IService
            Get
                Return serviceProvider.GetService(Of IService)()
            End Get
        End Property

        Public ReadOnly Property Logger As ILogger(Of LoggerLocal)
        Public Sub Karen()
            _Logger.LogInformation("Before")
            Try
                Using _Logger.BeginScope("Some name")
                    Using _Logger.BeginScope(42)
                        Using _Logger.BeginScope("Formatted {WithValue}", 12345)
                            Using _Logger.BeginScope(New Dictionary(Of String, Object) From {{"ViaDictionary", 100}})
                                ' An unexpected problem!
                                Throw New Exception("Oops, something went wrong!")
                                _Logger.LogInformation("Hello from the Index!")
                                _Logger.LogDebug("Hello is done")
                            End Using
                        End Using
                    End Using
                End Using

                _Logger.LogInformation("After")


            Catch ex As Exception
                _Logger.LogError(ex, "An unexpected exception occurred")

            End Try


        End Sub
    End Class
End Namespace