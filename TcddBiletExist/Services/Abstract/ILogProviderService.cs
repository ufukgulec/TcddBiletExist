using TcddBiletExist.Models;

namespace TcddBiletExist.Services.Abstract
{
    public interface ILogProviderService
    {
        Task<Log> CreateAsync(string logMessage, LogType logType);
    }
}
