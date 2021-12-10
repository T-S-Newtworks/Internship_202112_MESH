using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace mesh.Models
{
    public class Applly
    {
        [Key]
        public int? ID { get; set; }

        [DisplayName("利用者番号")]
        [MaxLength(30)]
        public  User User { get; set; }

        [DisplayName("登録情報")]
        public string Description { get; set; }
       
        [DisplayName("申請種別")]
        public int? Appllytype { get; set; }
    }
}