Imports System
Imports Microsoft.Extensions.DependencyInjection
Imports Microsoft.Extensions.Logging

Module Program
    Sub Main(args As String())
        Dim serviceCollection As New ServiceCollection()
        ConfigureServices(serviceCollection)

        Dim serviceProvider = serviceCollection.BuildServiceProvider()

    End Sub
    Private Sub ConfigureServices(ByVal services As IServiceCollection)
        services.AddLogging(Function(configure) configure.AddConsole()).AddTransient(Of SomeClass)()

    End Sub

End Module


