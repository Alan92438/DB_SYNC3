
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
        public MyDbContext()
            : base(@"Server=.\SQLEXPRESS;Database=CMS;User Id=sa;Password=Magical9070;Trusted_Connection=True;")
        { }
        public DbSet<custom> custom { get; set; }
        public DbSet<comm> Comms { get; set; }
        public DbSet<maintain> maintain { get; set; }
    }
}
