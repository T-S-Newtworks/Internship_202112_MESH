using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace mesh.Models
{
    public class Like
    {
        [Key]
        [DisplayName("いいね番号")]
        public int Id { get; set; }

        [DisplayName("利用者番号")]
        public User User { get; set; }

        [DisplayName("画像番号")]
        public Image Image { get; set; }
    }
}