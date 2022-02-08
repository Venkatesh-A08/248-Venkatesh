using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WepApiProduct.Models;

namespace WepApiProduct.Data
{
    public class WepApiProductContext : DbContext
    {
        public WepApiProductContext (DbContextOptions<WepApiProductContext> options)
            : base(options)
        {
        }

        public DbSet<WepApiProduct.Models.Product> Product { get; set; }
    }
}
