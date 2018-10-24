using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VesoQuanli.Models
{
    public class soluongdky
    {
        [Key,DisplayName("ID Số lượng đăng ký")]
        public string Id { get; set; }
        [DisplayName("Số lượng đăng ký")]
        public long sldky { get; set; }
        [DisplayName("Ngày đăng ký")]
        public DateTime Ngay { get; set; }
        //reference
       // public string daili { get; set; }
        public virtual daili Daili { get; set; }
    }
}