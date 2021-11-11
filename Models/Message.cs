using System;

namespace LoginExample.Models
{
    public class Message
    {

        public String senderName { get; set; }

        public String receiverName { get; set; }

        public String chatMessages { get; set; }

        public override string ToString()
        {
            return senderName + ": " + chatMessages;
        }
    }
}