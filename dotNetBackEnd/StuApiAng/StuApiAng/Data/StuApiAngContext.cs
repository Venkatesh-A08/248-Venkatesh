using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using StuApiAng.Models;

namespace StuApiAng.Data
{
    public class StuApiAngContext : DbContext
    {
        public StuApiAngContext (DbContextOptions<StuApiAngContext> options)
            : base(options)
        {
        }

        public DbSet<StuApiAng.Models.StudentDetails> StudentDetails { get; set; }
    }
}
