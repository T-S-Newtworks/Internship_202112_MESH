using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mesh.Models.VM
{
    public class ChatVM { 
    
      public ChatVM()
        {
            Channel = new Channel();
            Chats = new List<Chat>();
        }

        public Channel Channel;
        public List<Chat> Chats;
    }
}