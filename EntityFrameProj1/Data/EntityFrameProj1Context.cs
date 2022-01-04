using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EntityFrameProj1.Models;

namespace EntityFrameProj1.Data
{
    public class EntityFrameProj1Context : DbContext
    {
        public EntityFrameProj1Context (DbContextOptions<EntityFrameProj1Context> options)
            : base(options)
        {
        }

        public DbSet<EntityFrameProj1.Models.Students> Students { get; set; }
    }
}
