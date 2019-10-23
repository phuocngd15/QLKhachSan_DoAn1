using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MVC_Demo.Models
{
    public class MVC_DemoContext : DbContext
    {
        public MVC_DemoContext()
        {
        }

        public MVC_DemoContext (DbContextOptions<MVC_DemoContext> options)
            : base(options)
        {
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<MVC_Demo.Models.Movie> Movie { get; set; }
    }
}
