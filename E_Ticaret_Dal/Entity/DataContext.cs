using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Ticaret_Dal.Entity
{
    public class DataContext:DbContext
    {
        public DataContext():base("MSSQL")
        {
            Database.SetInitializer(new DataInitializer());
        }

        
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
