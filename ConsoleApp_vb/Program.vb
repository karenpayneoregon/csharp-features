
Imports Microsoft.Extensions.Configuration
Imports Microsoft.Extensions.DependencyInjection
Imports Microsoft.Extensions.Logging
Imports System.Console

Module Program
    Sub Main(args As String())

        WriteLine("Hello World! from console")
        WriteLine()

        Dim configuration = (New ConfigurationBuilder()).
                AddJsonFile("appsettings.json", False, True).
                Build()


        Dim serviceProvider = (New ServiceCollection()).
                AddSingleton(Of IMyService, MyService)().
                AddLogging(Sub(builder)
                               builder.AddConfiguration(configuration.GetSection("Logging"))
                               builder.AddConsole()
                           End Sub).BuildServiceProvider()


        Dim logger As ILogger(Of MyDemo) = serviceProvider.GetService(Of ILogger(Of MyDemo))()
        Dim service As IMyService = serviceProvider.GetService(Of IMyService)()

        logger.LogInformation("1 logger information")
        logger.LogWarning("2 logger warning")

        service.DoWork()

        ReadLine()

    End Sub

End Module


