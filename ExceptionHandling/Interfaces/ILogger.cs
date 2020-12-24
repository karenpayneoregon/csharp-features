namespace ExceptionHandling.Interfaces
{
    public interface ILogger
    {
        string FileName { get; set; }
        void LogWarning(string message) => Log(LogLevel.Warning, message);
        void LogError(string message) => Log(LogLevel.Error, message);
        void LogGeneral(string message) => Log(LogLevel.General, message);
        void Log(LogLevel level, string message);
    }
}
