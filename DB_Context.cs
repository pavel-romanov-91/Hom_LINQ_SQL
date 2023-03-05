using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hom_LINQ_SQL
{
    public class DB_Context : DbContext
    {

        public DB_Context() : base("DBConnectionString")
        {

        }

        public DbSet<countries> countries { get; set; }
        public DbSet<cities> cities { get; set; }
        public DbSet<capitals> capitals { get; set; }
    }
}
