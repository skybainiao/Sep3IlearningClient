using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using LoginExample.Models;

namespace LoginExample.Data
{
    public interface UserData
    {
        Task<String> get();

        Task post(User user);

        Task<IList<User>> getAllUsers();

        Task<IList<User>> getAllFriends(String username);

        Task sendMessage(String sender, String receiver, String message);

        Task<IList<Message>> getMessages(String sender, String receiver);

        Task<IList<Message>> getAllMessages(String receiver);

        Task sendRequest(Request request);
        
        Task addProfile(Profile profile);

        Task<IList<Profile>> getProfile();

        Task deleteProfile(String username);

        Task<IList<Request>> getRequest(String username);

        Task deleteRequest(string sender, string receiver);

        Task addFriend(string username, string friendName);
    }
}