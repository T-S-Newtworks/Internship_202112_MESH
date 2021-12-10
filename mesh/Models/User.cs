using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace mesh.Models
{
    public class User
    {
        [Key]
        [DisplayName("利用者番号")]
        public int ID { get; set; }

        [DisplayName("パスワード")]
        public string Passward { get; set; }

        [MaxLength(256)]
        [DisplayName("氏名")]
        public string Name { get; set; }

        [DisplayName("アイコン")]
        public byte [] Icon { get; set; }

        [DisplayName("拠点番号")]
        public virtual Base Base{ get; set; }
        
        [DisplayName("権限番号")]
        public virtual Authority Authority{ get; set; }

        public virtual ICollection<Applly> Applly { get; set; }
        public virtual ICollection<Chat> Chat { get; set; }
        public virtual ICollection<Like> Like { get; set; } 
    }
}