using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace mesh.Models
{
    public class Channel
    {
        [Key]
        [DisplayName("チャンネル番号")]
        public int Id { get; set; }

        [MaxLength(200)]
        [DisplayName("チャンネル名")]
        public string Name { get; set;}
    }
}