
namespace ELTSequencer
{
    // FileLogger: Logs command execution results to a file
    public static class FileLogger
    {
        private static readonly string LogFilePath = "command_log.txt";

        public static void Log(string message)
        {
            File.AppendAllText(LogFilePath, $"{DateTime.Now:yyyy-MM-dd HH:mm:ss} - {message}{Environment.NewLine}");
        }
    }
}