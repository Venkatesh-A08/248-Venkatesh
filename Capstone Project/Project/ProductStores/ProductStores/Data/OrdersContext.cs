using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProductStores.Models;

namespace ProductStores.Data
{
    public class OrdersContext : DbContext
    {
        public OrdersContext (DbContextOptions<OrdersContext> options)
            : base(options)
        {
        }

        public DbSet<ProductStores.Models.Order> Order { get; set; }

        public DbSet<ProductStores.Models.OrderDetail> OrderDetail { get; set; }

        public DbSet<ProductStores.Models.Product> Product { get; set; }

        public DbSet<ProductStores.Models.User> User { get; set; }
    }
}
