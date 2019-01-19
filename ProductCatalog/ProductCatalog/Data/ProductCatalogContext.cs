using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ProductCatalog.Models
{
    public class ProductCatalogContext : DbContext
    {
        public ProductCatalogContext (DbContextOptions<ProductCatalogContext> options)
            : base(options)
        { 
        }

        public DbSet<ProductCatalog.Models.Product> Product { get; set; }

    }
}
