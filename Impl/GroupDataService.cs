using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using LoginExample.Models;

namespace LoginExample.Data.Impl
{
    public class GroupDataService : GroupData
    {
        
        public async Task<IList<Group>> getAllGroups()
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
        
        
        public async Task<IList<string>> getAllGroupName()
        {
            using HttpClient client = new HttpClient();
            Task<string> stringAsync = client.GetStringAsync($"http://localhost:8080/getGroupName");
            string message = await stringAsync;
            IList<string> result = JsonSerializer.Deserialize<List<string>>(message, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            });
            return result;
        }
        
        
        public async Task<IList<string>> getAllGroupMember(string username)
        {
            using HttpClient client = new HttpClient();
            Task<string> stringAsync = client.GetStringAsync($"http://localhost:8080/getGroupMember?username={username}");
            string message = await stringAsync;
            IList<string> result = JsonSerializer.Deserialize<List<string>>(message, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            });
            return result;
        }
        
        
        public async Task addGroup(Group group)
        {
            using HttpClient client = new HttpClient();
            String stringasjson = JsonSerializer.Serialize(group, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            });
            HttpContent content = new StringContent(stringasjson, Encoding.UTF8, "application/json");
            await client.PostAsync("http://localhost:8080/addGroup",content);
        }
        
        
    }
}