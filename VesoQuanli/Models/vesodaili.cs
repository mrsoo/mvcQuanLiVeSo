using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace VesoQuanli.Models
{
    public class vesodaili
    {
        [Key, Column(Order = 1)]
        public string Idloaiveso { get; set; }
        [Key, Column(Order = 2)]
       [DisplayName("Số lượng giao")]
        public long soluong { get; set; }
        [DisplayName("Số lượng bán được")]
        public long? slbandc { get; set; }
        [DisplayName("Ngày")]
        public long Date { get; set; }
        //==reference
        public string Iddaili { get; set; }
        public virtual daili Daili { get; set; }
        public string idveso { get; set; }
        public virtual loaiveso Loaiveso { get; set; }

    }
}