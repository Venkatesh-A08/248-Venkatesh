using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EmployeeEntityProj.Models;

namespace EmployeeEntityProj.Data
{
    public class EmployeeEntityProjContext : DbContext
    {
        public EmployeeEntityProjContext (DbContextOptions<EmployeeEntityProjContext> options)
            : base(options)
        {
        }

        public DbSet<EmployeeEntityProj.Models.Employee> Employee { get; set; }
    }
}
