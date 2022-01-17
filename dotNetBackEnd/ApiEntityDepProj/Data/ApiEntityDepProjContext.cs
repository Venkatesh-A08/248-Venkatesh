using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ApiEntityDepProj.Models;

namespace ApiEntityDepProj.Data
{
    public class ApiEntityDepProjContext : DbContext
    {
        public ApiEntityDepProjContext (DbContextOptions<ApiEntityDepProjContext> options)
            : base(options)
        {
        }

        public DbSet<ApiEntityDepProj.Models.Department> Department { get; set; }
    }
}
