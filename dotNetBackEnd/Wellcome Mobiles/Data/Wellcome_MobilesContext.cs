using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Wellcome_Mobiles.Models;

namespace Wellcome_Mobiles.Data
{
    public class Wellcome_MobilesContext : DbContext
    {
        public Wellcome_MobilesContext (DbContextOptions<Wellcome_MobilesContext> options)
            : base(options)
        {
        }

        public DbSet<Wellcome_Mobiles.Models.EmployeeDetail> EmployeeDetail { get; set; }
    }
}
