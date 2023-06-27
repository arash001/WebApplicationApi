using Microsoft.EntityFrameworkCore;
using System;

namespace WebApplicationApi.Model
{
    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options)
         : base(options)
        {
        }
        public DbSet<Fixture> Fixtures { get; set; }
        public DbSet<PutDataRequest> PutDataRequests { get; set; }
        public DbSet<Fixtures> FixturesLits { get; set; }
}
    }
