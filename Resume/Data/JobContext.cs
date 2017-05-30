using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Resume.Models
{
    public class JobContext : DbContext
    {
        public JobContext (DbContextOptions<JobContext> options)
            : base(options)
        {
        }

        public DbSet<Resume.Models.Job> Job { get; set; }
    }
}
