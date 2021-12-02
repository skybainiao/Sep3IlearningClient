using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using LoginExample.Models;

namespace LoginExample.Data.Impl
{
    public class ChatDataService : ChatData
    {
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


        public async Task<IList<Message>> getAllMessages(String receiver)
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
        
        
        public async Task<IList<Message>> getAMS()
        {
            using HttpClient client = new HttpClient();
            Task<string> stringAsync = client.GetStringAsync($"http://localhost:8080/getAMS");
            string message = await stringAsync;
            IList<Message> result = JsonSerializer.Deserialize<List<Message>>(message, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            });
            return result;
        }
        
    }
}