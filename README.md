# AwesomeLogger
A simple, customizable .NET logging library with colorized console output and file logging support.

## Installation
Clone the repository and include the `AwesomeLogger` project in your solution or use the DLL directly.

## Usage

```csharp
var config = new LoggerConfig
{
    LogFilePath = "mylogs.txt",
    EnableConsoleLogging = true,
    EnableFileLogging = true,
    InfoColor = ConsoleColor.Green
};

var logger = new Logger(config);
logger.Info("This is an info message.");
logger.Warning("This is a warning.");
logger.Error("This is an error!");
logger.Debug("This is a debug message.");
