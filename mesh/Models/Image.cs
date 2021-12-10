using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace mesh.Models
{
    public class Image
    {
        [Key]
        public int? ID { get; set; }

        [DisplayName("画像パス")]
        public string path { get; set; }

        [DisplayName("投稿日時")]
        public DateTime? dateTime { get; set; }

    }
}