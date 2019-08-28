using ApoliceSegfy.Api.Data.Configuration;
using ApoliceSegfy.Api.Data.Model;
using Microsoft.EntityFrameworkCore;

namespace ApoliceSegfy.Api.Data
{
    public class PolicyDbContext : DbContext
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new PolicyConfiguration());
        }
        public PolicyDbContext(DbContextOptions<PolicyDbContext> options) : base(options){}

        public DbSet<Policy> Policy { get; set; }

    }
}