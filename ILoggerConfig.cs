namespace AwesomeLogger
{
    public interface ILoggerConfig
    {
        string LogFilePath { get; set; }
        bool EnableConsoleLogging { get; set; }
        bool EnableFileLogging { get; set; }

        ConsoleColor InfoColor { get; set; }
        ConsoleColor WarningColor { get; set; }
        ConsoleColor ErrorColor { get; set; }
        ConsoleColor DebugColor { get; set; }

    }
}