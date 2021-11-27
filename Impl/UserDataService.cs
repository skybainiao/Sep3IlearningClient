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


        public async Task sendMessage(String sender, String receiver, String message)
        {
            using HttpClient client = new HttpClient();
            
            HttpContent content = new StringContent(sender, Encoding.UTF8, "application/json");
            
            await client.PostAsync($"http://localhost:8080/send?receiver={receiver}&text={message}", content);
        }


        public async Task<IList<Message>> getMessages(String sender, String receiver)
        {
            using HttpClient client = new HttpClient();
            Task<string> stringAsync = client.GetStringAsync($"http://localhost:8080/Messages?sender={sender}&receiver={receiver}");
            string message = await stringAsync;
            IList<Message> result = JsonSerializer.Deserialize<List<Message>>(message, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            });
            return result;
        }


        public async Task<IList<Message>> getallMessages(String receiver)
        {
            using HttpClient client = new HttpClient();
            Task<string> stringAsync = client.GetStringAsync($"http://localhost:8080/getAllMessages?receiver={receiver}");
            string message = await stringAsync;
            IList<Message> result = JsonSerializer.Deserialize<List<Message>>(message, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            });
            return result;
        }


        public async Task sendRequest(String sender,String receiver,String comment)
        {
            using HttpClient client = new HttpClient();
            
            HttpContent content = new StringContent(sender, Encoding.UTF8, "application/json");
            
            await client.PostAsync($"http://localhost:8080/sendRequest?receiver={receiver}&comment={comment}", content);
        }


        public async Task<IList<Request>> getRequest(String username)
        {
            using HttpClient client = new HttpClient();
            Task<string> stringAsync = client.GetStringAsync($"http://localhost:8080/getRequest?username={username}");
            string message = await stringAsync;
            IList<Request> result = JsonSerializer.Deserialize<List<Request>>(message, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            });
            return result;
            
        }


        public async Task addProfile(Profile profile)
        {
            using HttpClient client = new HttpClient();
            String stringasjson = JsonSerializer.Serialize(profile, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            });
            HttpContent content = new StringContent(stringasjson, Encoding.UTF8, "application/json");
            await client.PostAsync("http://localhost:8080/addProfile",content);
        }


        public async Task<IList<Profile>> getProfile()
        {
            using HttpClient client = new HttpClient();
            Task<string> stringAsync = client.GetStringAsync($"http://localhost:8080/getProfile");
            string message = await stringAsync;
            IList<Profile> result = JsonSerializer.Deserialize<List<Profile>>(message, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            });
            return result;
        }


        public async Task deleteProfile(String username)
        {
            using HttpClient client = new HttpClient();
           
            HttpContent content = new StringContent(username, Encoding.UTF8, "application/json");
            
            await client.PostAsync("http://localhost:8080/deleteProfile",content);
        }
        

    }
}