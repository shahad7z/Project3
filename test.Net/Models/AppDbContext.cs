using System;
using Microsoft.EntityFrameworkCore;

namespace test.Net.Models
{
    public class AppDbContext : DbContext
    {
      

        public AppDbContext(DbContextOptions<AppDbContext> options)
            :base(options)
        {
        }

        public DbSet<product> products { get; set; }

        public DbSet<customer> customers { get; set; }

        public DbSet<order> orders { get; set; }

       
    }

   
}
