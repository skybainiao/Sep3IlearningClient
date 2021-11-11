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
    }
}