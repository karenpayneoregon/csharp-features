Imports Microsoft.Extensions.DependencyInjection
Imports Microsoft.Extensions.Logging
Imports Microsoft.Extensions.Logging.Console

''' <summary>
''' Incomplete code sample
''' </summary>
Module Program
    Sub Main(args As String())

        Dim serviceCollection As New ServiceCollection()
        ConfigureServices(serviceCollection)

        Dim serviceProvider = serviceCollection.BuildServiceProvider()

        Dim someClass = serviceProvider.GetService(Of SomeClass)()

        someClass.LogInfo("Hello")
        someClass.LogCritical("World")


        System.Console.ReadLine()

    End Sub
    Private Sub ConfigureServices(services As IServiceCollection)

        services.AddLogging(Function(configure) configure.AddConsole()).AddTransient(Of SomeClass)()

    End Sub

End Module


