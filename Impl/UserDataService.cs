using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using LoginExample.Models;

namespace LoginExample.Data.Impl
{
    public class UserDataService : UserData
    {
        
        public async Task<String> get()
        {
            using HttpClient httpClient = new HttpClient();
            Task<String> str = httpClient.GetStringAsync("http://localhost:8080/greeting");
            String result = await str;
            return result;
        }


        public async Task<IList<User>> getAllUsers()
        {
            using HttpClient client = new HttpClient();
            Task<string> stringAsync = client.GetStringAsync("http://localhost:8080/getUser");
            string message = await stringAsync;
            IList<User> result = JsonSerializer.Deserialize<List<User>>(message, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            });
            return result;
        }


        public async Task post(User user)
        {
            using HttpClient client = new HttpClient();
            String stringasjson = JsonSerializer.Serialize(user, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            });
            HttpContent content = new StringContent(stringasjson, Encoding.UTF8, "application/json");
            await client.PostAsync("http://localhost:8080/user",content);
            
        }
        
        
        public async Task<IList<User>> getAllFriends(String username)
        {
            using HttpClient client = new HttpClient();
            Task<string> stringAsync = client.GetStringAsync($"http://localhost:8080/getFriends?username={username}");
            string message = await stringAsync;
            IList<User> result = JsonSerializer.Deserialize<List<User>>(message, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            });
            return result;
        }
        
        
        



    }
}