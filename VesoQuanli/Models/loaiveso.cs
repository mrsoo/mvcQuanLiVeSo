using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VesoQuanli.Models
{
    public class loaiveso
    {
        
        [Key]
        public string Id { get; set; }
        [DisplayName("Đài")]
        public string dai { get; set; }
        //reference
        public virtual ICollection<vesodaili> Vesodailis { get; set; }
    }
}