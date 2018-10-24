using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VesoQuanli.Models
{
    public class Init:System.Data.Entity.DropCreateDatabaseIfModelChanges<VesoContext>
    {
        protected override void Seed(VesoContext context)
        {
            base.Seed(context);
            var loaiveso = new List<loaiveso>()
            {
               new loaiveso(){ Id="1", dai="Long An" }, 
               new loaiveso(){ Id="2", dai="Bình Dương" }, 
               new loaiveso(){ Id="3", dai="Bến tre" }, 
               new loaiveso(){ Id="4", dai="TP Hồ Chí Minh" } 
            };
            loaiveso.ForEach(p => context.Loaivesos.Add(p));
            context.SaveChanges();
        }
    }
}