﻿using System;
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


        public async Task addFriend(string username,string friendName)
        {
            using HttpClient client = new HttpClient();
            
            HttpContent content = new StringContent(username, Encoding.UTF8, "application/json");
            
            await client.PostAsync($"http://localhost:8080/addFriend?friendName={friendName}", content);
        }


        public async Task sendRequest(Request request)
        {
            using HttpClient client = new HttpClient();
            String stringasjson = JsonSerializer.Serialize(request, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            });
            HttpContent content = new StringContent(stringasjson, Encoding.UTF8, "application/json");
            await client.PostAsync("http://localhost:8080/sendRequest",content);
            Console.WriteLine(request.sender);
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


        public async Task deleteRequest(string sender,string receiver)
        {
            using HttpClient client = new HttpClient();
           
            HttpContent content = new StringContent(sender, Encoding.UTF8, "application/json");
            
            await client.PostAsync($"http://localhost:8080/deleteRequest?receiver={receiver}",content);
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


        public async Task<IList<Moment>> getMoments()
        {
            using HttpClient client = new HttpClient();
            Task<string> stringAsync = client.GetStringAsync($"http://localhost:8080/getMoments");
            string message = await stringAsync;
            IList<Moment> result = JsonSerializer.Deserialize<List<Moment>>(message, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            });
            return result;
        }


        public async Task addMoment(Moment moment)
        {
            using HttpClient client = new HttpClient();
            String stringasjson = JsonSerializer.Serialize(moment, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            });
            HttpContent content = new StringContent(stringasjson, Encoding.UTF8, "application/json");
            await client.PostAsync("http://localhost:8080/addMoment",content);
        }


        public async Task like(string username)
        {
            using HttpClient client = new HttpClient();
          
            HttpContent content = new StringContent(username, Encoding.UTF8, "application/json");
            
            await client.PostAsync("http://localhost:8080/like",content);
        }
        
        
        public async Task dislike(string username)
        {
            using HttpClient client = new HttpClient();
          
            HttpContent content = new StringContent(username, Encoding.UTF8, "application/json");
            
            await client.PostAsync("http://localhost:8080/dislike",content);
        }
        
        
        public async Task<IList<Comment>> getComments(string username,string publisher,string time)
        {
            using HttpClient client = new HttpClient();
            Task<string> stringAsync = client.GetStringAsync($"http://localhost:8080/getComments?username={username}&publisher={publisher}&time={time}");
            string message = await stringAsync;
            IList<Comment> result = JsonSerializer.Deserialize<List<Comment>>(message, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            });
            return result;
        }


        public async Task addComment(Comment comment)
        {
            using HttpClient client = new HttpClient();
            String stringasjson = JsonSerializer.Serialize(comment, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            });
            HttpContent content = new StringContent(stringasjson, Encoding.UTF8, "application/json");
            await client.PostAsync("http://localhost:8080/addComment",content);
        }


    }
}