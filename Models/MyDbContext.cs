
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_SYNC3.Models
{
    public class MyDbContext : DbContext
    {
        // public MyDbContext()
        //: base(@"Server=.\SQLEXPRESS;Database=CMS;User Id=sa;Password=Magical9070;Trusted_Connection=True;")
        // : base(@"Server=localhost;Database=RentHouseDb;User Id=sa;Password=sH+a$GTT;Encrypt=True;TrustServerCertificate=True;")  { }

        // 建構子指定 App.config 連線字串名稱
#if DEBUG
 
        public MyDbContext() : base("name=CMS_Dev") { }
       
 
#else
 
        public MyDbContext() : base("name=CMS") { }
 
#endif

        public DbSet<memb> memb { get; set; }
        public DbSet<custom> custom { get; set; }
        public DbSet<comm> Comms { get; set; }
        public DbSet<maintain> maintain { get; set; }

        /// <summary>
        /// 沒有PK的小程式解決方式
        /// </summary>
        /// <param name="modelBuilder"></param>

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<custom>().HasKey(c => new { c.m_date, c.name });
            modelBuilder.Entity<comm>().HasKey(c => new { c.m_date, c.address });
            modelBuilder.Entity<maintain>().HasKey(m => new { m.m_date});

            base.OnModelCreating(modelBuilder);
        }
    }
}
