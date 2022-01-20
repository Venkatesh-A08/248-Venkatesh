using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using StuInfoPro.Models;

namespace StuInfoPro.Data
{
    public class StuInfoProContext : DbContext
    {
        public StuInfoProContext (DbContextOptions<StuInfoProContext> options)
            : base(options)
        {
        }

        public DbSet<StuInfoPro.Models.Student> Student { get; set; }
    }
}
