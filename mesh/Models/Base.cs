using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace mesh.Models
{
    public class Base
    {
        [Key]
        [DisplayName("拠点番号")]
        public int Id { get; set; }

        [DisplayName("拠点名")]
        public string Name { get; set; }


    }
}