using Entities.Concrate;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrate.EntityFramework
{
    public class ReCapContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=ReCap;Trusted_Connection=true");
        }
        //yukarıda veritabanımın ne olduğunu söyledim ama hangi nesnem hangi nesneye karşılık gelecek bunuda dbset ile

        public DbSet<Car> Cars { get; set; }

        public DbSet<Brand> Brands { get; set; }

        public DbSet<Color> Colors { get; set; }
    }
}
