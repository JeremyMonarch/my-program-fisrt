using Lesson28.EF.DataAccess.Entities;
using Lesson28.EF.DataAccess.Mappings;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DbContext = Microsoft.EntityFrameworkCore.DbContext;

namespace Lesson28.EF.DataAccess
{
    public class ShopDataContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CategotyMapiing());
            modelBuilder.ApplyConfiguration(new ProductMapping());
            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //Server=.;Database=ShopDB;Trusted_Connection=True;
            optionsBuilder.UseSqlServer(@"Server=localhost;Database=ShopDB;Trusted_Connection=True");
        }
    }
}
