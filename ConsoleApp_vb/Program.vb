
Imports Microsoft.Extensions.Configuration
Imports Microsoft.Extensions.DependencyInjection
Imports Microsoft.Extensions.Logging


Module Program
    Sub Main(args As String())

        System.Console.WriteLine("Hello World! from console")

        Dim configuration = (New ConfigurationBuilder()).
                AddJsonFile("appsettings.json", False, True).
                Build()


        Dim serviceProvider = (New ServiceCollection()).
                AddSingleton(Of IFooService, FooService)().
                AddLogging(Sub(builder)
                               builder.AddConfiguration(configuration.GetSection("Logging"))
                               builder.AddConsole()
                           End Sub).BuildServiceProvider()


        Dim logger As ILogger(Of SomeClass) = serviceProvider.GetService(Of ILogger(Of SomeClass))()
        Dim fooService As IFooService = serviceProvider.GetService(Of IFooService)()

        logger.LogInformation("1111logger information")
        logger.LogWarning("2222logger warning")

        fooService.DoWork()


        System.Console.ReadLine()

    End Sub

End Module


