using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Diagnostics;

namespace WebApplication1.Models
{
    public class ProductContext : DbContext
    {
        public ProductContext() : base("DefaultConnection")
        {
            Debug.WriteLine("DAAAAAAAAAAAAAAAAAAAAAAAAAAA");

        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<CartItem> ShoppingCartItems { get; set; }
    }
}
