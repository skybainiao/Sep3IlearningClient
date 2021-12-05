using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using LoginExample.Models;

namespace LoginExample.Data.Impl
{
    public class LecturerDataService : LecturerData
    {
        public async Task<IList<LecturerAccount>> getLecturer()
        {
            using HttpClient client = new HttpClient();
            Task<string> stringAsync = client.GetStringAsync($"http://localhost:8080/getLecturer");
            string message = await stringAsync;
            IList<LecturerAccount> result = JsonSerializer.Deserialize<List<LecturerAccount>>(message, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            });
            return result;
        }
    }
}