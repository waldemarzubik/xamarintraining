using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using xamarintraining.Interfaces;

namespace xamarintraining.Services
{
    public class DataService : IDataService
    {
        public async Task<IEnumerable<User>> GetDataAsync(string searchCriteria)
        {
            var url = "https://api.github.com/users";

            if (!string.IsNullOrEmpty(searchCriteria))
            {
                url += $"/{searchCriteria}";
            }
            var client = new HttpClient(new ModernHttpClient.NativeMessageHandler());
            var result = await client.GetStringAsync(url);

            return JsonConvert.DeserializeObject<IEnumerable<User>>(result);
        }
    }
}
