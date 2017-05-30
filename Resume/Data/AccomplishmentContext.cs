using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Resume.Models
{
    public class AccomplishmentContext : DbContext
    {
        public AccomplishmentContext (DbContextOptions<AccomplishmentContext> options)
            : base(options)
        {
        }

        public DbSet<Resume.Models.Accomplishment> Accomplishment { get; set; }
    }
}
