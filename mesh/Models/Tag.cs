using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace mesh.Models
{
    public class Tag
    {
        [Key]
        [DisplayName("タグ番号")]
        public int? ID { get; set; }

        [DisplayName("タグ名")]
        [MaxLength(20, ErrorMessage ="{0}は{1}文字以内で入力してください")]
        public string Name { get; set; }

    }
}