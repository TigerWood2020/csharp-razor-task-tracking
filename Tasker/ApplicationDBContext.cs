using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tasker
{
    public class ApplicationDBContext : DbContext
    {
        public DbSet<Task> Tasks { get; set; }

        public ApplicationDBContext(DbContextOptions options) : base(options)
        {

        }
    }
}
