using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPIModule1.Module;

namespace WebAPIModule1.Data
{
    public class ProductsDbContext : DbContext
    {
        public ProductsDbContext(DbContextOptions<ProductsDbContext>option) : base(option)
        {

        }

        public DbSet<Product> Products { get; set; }
    }
}
