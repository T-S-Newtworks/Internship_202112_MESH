using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace mesh.Models
{
    public class meshContext : DbContext
    {
        public System.Data.Entity.DbSet<mesh.Models.User> Users { get; set; }

        public System.Data.Entity.DbSet<mesh.Models.Chat> Chats { get; set; }

        public System.Data.Entity.DbSet<mesh.Models.Channel> Channels { get; set; }

        public System.Data.Entity.DbSet<mesh.Models.Like> Likes { get; set; }

        public System.Data.Entity.DbSet<mesh.Models.Authority> Authorities { get; set; }

        public System.Data.Entity.DbSet<mesh.Models.Applly> Appllies { get; set; }

        public System.Data.Entity.DbSet<mesh.Models.Base> Bases { get; set; }

        public System.Data.Entity.DbSet<mesh.Models.Image> Images { get; set; }

        public System.Data.Entity.DbSet<mesh.Models.Tag> Tags { get; set; }
    }
}