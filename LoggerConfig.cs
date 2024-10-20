namespace AwesomeLogger
{
    public class LoggerConfig : ILoggerConfig

    {
        public string LogFilePath { get; set; } = "logs.txt";
        public bool EnableConsoleLogging { get; set; } = true;
        public bool EnableFileLogging { get; set; } = true;
        public ConsoleColor InfoColor { get; set; } = ConsoleColor.White;
        public ConsoleColor WarningColor { get; set; } = ConsoleColor.Yellow;
        public ConsoleColor ErrorColor { get; set; }= ConsoleColor.Red;
        public ConsoleColor DebugColor { get; set; } = ConsoleColor.Blue;
    }
}