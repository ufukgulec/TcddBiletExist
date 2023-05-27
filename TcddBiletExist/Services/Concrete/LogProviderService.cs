using TcddBiletExist.Models;
using TcddBiletExist.Services.Abstract;

namespace TcddBiletExist.Services.Concrete
{
    public class LogProviderService : ILogProviderService
    {
        public Task<Log> CreateAsync(string logMessage, LogType logType)
        {
            Log log = new Log()
            {
                Message = logMessage,
                Type = logType
            };
            return Task.FromResult(log);

        }
    }
}
