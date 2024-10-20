using System.ComponentModel;

namespace AwesomeLogger
{
    public class Logger
    {

        private readonly ILoggerConfig _config;
            public Logger(ILoggerConfig config = null)
        {
            _config = config ?? new LoggerConfig();

        }
        private void Log(string message,string level, ConsoleColor color) {
            string formattedMessage = $"[{DateTime.Now}] [{level}] {message}";
            if (_config.EnableConsoleLogging)
            {
                Console.ForegroundColor = color;
                Console.WriteLine(message);
                Console.ResetColor();
            }
            if (_config.EnableFileLogging)
            {
                File.AppendAllText(_config.LogFilePath, formattedMessage + Environment.NewLine);
            }
        }

        public void Info(string message) => Log(message, "INFO", _config.InfoColor);
        public void Warning(string message) => Log(message, "Warning", _config.WarningColor);
        public void Error(string message) => Log(message, "ERROR", _config.ErrorColor);
        public void Debug(string message) => Log(message, "DEBUG", _config.DebugColor);

    }
}