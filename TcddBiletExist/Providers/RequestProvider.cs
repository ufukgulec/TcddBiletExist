using Newtonsoft.Json;
using System.Text;
using TcddBiletExist.Models;
using TcddBiletExist.Services.Concrete;

namespace TcddBiletExist.Providers
{
    public class RequestProvider
    {
        public async Task<string> PostRequestAsync(string request, object parameters)
        {
            LogProviderService logService = new LogProviderService();
            try
            {
                Log newLog = await logService.CreateAsync($"PostRequestAsync : {request}", Models.LogType.Information);
                LogProvider.Default.AddLog(newLog);

                var json = JsonConvert.SerializeObject(parameters);

                var data = new StringContent(json, Encoding.UTF8, "application/json");

                using var client = new HttpClient();

                client.DefaultRequestHeaders.Add("Authorization", "Basic " + EncodedText());

                HttpResponseMessage response = await client.PostAsync(AppSettings.Default.BaseUrl + request, data);

                return response.Content.ReadAsStringAsync().Result;
            }
            catch (Exception)
            {
                Log newLog = await logService.CreateAsync($"PostRequestAsync : {request}", Models.LogType.Error);
                LogProvider.Default.AddLog(newLog);
                throw;
            }
        }
        public async Task<string> GetRequestAsync(string request)
        {
            using var client = new HttpClient();

            client.DefaultRequestHeaders.Add("Authorization", "Basic " + EncodedText());

            HttpResponseMessage response = await client.GetAsync(AppSettings.Default.BaseUrl + request);

            return response.Content.ReadAsStringAsync().Result;

        }

        private string EncodedText()
        {
            return AppSettings.Default.BasicAuth;
        }
    }
}
