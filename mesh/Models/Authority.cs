using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace mesh.Models
{
    public class Authority
    {
        [Key]
        [DisplayName("権限コード")]
        public int Id { get; set; }

        [DisplayName("権限名")]
        public string Name { get; set; }
    }
}