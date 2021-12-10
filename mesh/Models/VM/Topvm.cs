using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mesh.Models.VM
{
    public class Topvm
    {
        public Topvm()
        {
            Channel = new List<Channel>();
            Chats = new List<Chat>();
            User = new User();
        }

        public List<Channel> Channel;
        public List<Chat> Chats;
        public User User;
    }
}