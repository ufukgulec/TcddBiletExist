using TcddBiletExist.Models;

namespace TcddBiletExist.Providers
{
    public class LogProvider
    {
        private static LogProvider? logHelper;

        public static LogProvider Default => logHelper ??= new LogProvider();

        public event EventHandler<string>? OnLogAdded;

        public void AddLog(Log log)
        {
            OnLogAdded?.Invoke(this, $"[{log.Time:dd.MM.yyyy HH:mm:ss:fff}] - [{log.Type}] - {log.Message}");
        }
    }
}
