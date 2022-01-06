using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ApiEntityFrameProj1.Models;

namespace ApiEntityFrameProj1.Data
{
    public class ApiEntityFrameProj1Context : DbContext
    {
        public ApiEntityFrameProj1Context (DbContextOptions<ApiEntityFrameProj1Context> options)
            : base(options)
        {
        }

        public DbSet<ApiEntityFrameProj1.Models.Employee> Employee { get; set; }
    }
}
