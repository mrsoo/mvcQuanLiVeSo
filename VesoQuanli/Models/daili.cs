using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VesoQuanli.Models
{
    public class daili
    {
        
        [Key]
        public string Id { get; set; }
        [DisplayName("Tên đại lí")]
        public string TenDaili { get; set; }
        [DisplayName("Địa chỉ")]
        public string diachi { get; set; }
        //reference 
        public virtual ICollection<soluongdky> Soluongdkis { get; set; }
        public virtual ICollection<vesodaili> Vesodailis { get; set; }
    }
}