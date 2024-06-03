using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace samet_market_app.Models
{
    public class AppDbContext : DbContext
    {
        public DbSet<Inventory> Inventory { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<Sale> Sale { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=samet-pc\\MSSQLSERVER01;Database=odevfinal;Encrypt=false;Trusted_Connection=True;");
            


        }

    }

}
