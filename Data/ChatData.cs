using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using LoginExample.Models;

namespace LoginExample.Data
{
    public interface ChatData
    {
        Task sendMessage(String sender, String receiver, String message);

        Task<IList<Message>> getMessages(String sender, String receiver);

        Task<IList<Message>> getAllMessages(String receiver);
    }
}