using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TcddBiletExist.Services.Abstract
{
    public interface IHttpClientProviderService
    {
        Task<T?> GetRequestAsync<T>(string requestUrl);

        Task<T?> PostRequestAsync<T>(string requestUrl, object parameters);
    }
}
