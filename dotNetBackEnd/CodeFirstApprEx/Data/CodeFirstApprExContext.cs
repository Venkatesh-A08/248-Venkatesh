using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CodeFirstApprEx.Models;

namespace CodeFirstApprEx.Data
{
    public class CodeFirstApprExContext : DbContext
    {
        public CodeFirstApprExContext (DbContextOptions<CodeFirstApprExContext> options)
            : base(options)
        {
        }

        public DbSet<CodeFirstApprEx.Models.Department> Department { get; set; }
    }
}
