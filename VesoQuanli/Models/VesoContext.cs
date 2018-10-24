using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace VesoQuanli.Models
{
    public class VesoContext : DbContext
    {
        public VesoContext() : base("Db_Veso")
        {
        }
        public DbSet<daili> Dailis { get; set; }
        public DbSet<loaiveso> Loaivesos { get; set; }
        public DbSet<soluongdky> Soluongdkys { get; set; }
        public DbSet<vesodaili> Vesodailis { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            Database.SetInitializer<VesoContext>(new Init());
        }
        
    }
}