using Newtonsoft.Json;
using TcddBiletExist.Providers;
using TcddBiletExist.Services.Abstract;

namespace TcddBiletExist.Services.Concrete
{
    public class HttpClientProviderService : IHttpClientProviderService
    {

        private RequestProvider _requestProvider;
        private LogProvider _logProvider;

        public HttpClientProviderService(RequestProvider requestProvider, LogProvider logProvider)
        {
            _requestProvider = requestProvider;
            _logProvider = logProvider;
        }

        public async Task<T?> GetRequestAsync<T>(string requestUrl)
        {
            try
            {
                var result = await _requestProvider.GetRequestAsync(requestUrl);

                var resultObject = JsonConvert.DeserializeObject<T>(result);

                return resultObject;
            }
            catch (Exception exc)
            {
                _logProvider.AddLog(new Models.Log()
                {
                    Message = exc.Message,
                    Type = Models.LogType.Warning
                });

                throw;
            }
        }

        public async Task<T?> PostRequestAsync<T>(string requestUrl, object parameters)
        {
            try
            {
                var result = await _requestProvider.PostRequestAsync(requestUrl, parameters);

                var resultObject = JsonConvert.DeserializeObject<T>(result);

                return resultObject;
            }
            catch (Exception exc)
            {
                _logProvider.AddLog(new Models.Log()
                {
                    Message = exc.Message,
                    Type = Models.LogType.Warning
                });

                throw;
            }
        }

    }
}
