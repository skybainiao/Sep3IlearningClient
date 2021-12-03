using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using LoginExample.Models;

namespace LoginExample.Data.Impl
{
    public class GroupDataService : GroupData
    {
        
        public async Task<IList<Group>> getAllCourses()
        {
            using HttpClient client = new HttpClient();
            Task<string> stringAsync = client.GetStringAsync($"http://localhost:8080/getGroups");
            string message = await stringAsync;
            IList<Group> result = JsonSerializer.Deserialize<List<Group>>(message, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            });
            return result;
        }
        
        
    }
}