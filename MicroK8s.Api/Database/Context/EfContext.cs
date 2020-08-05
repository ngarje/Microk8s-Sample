using MicroK8s.Api.Database.Domain;
using Microsoft.EntityFrameworkCore;

namespace MicroK8s.Api.Database.Context
{
    public class EfContext : DbContext
    {
        public EfContext()
        {

        }
        public EfContext(DbContextOptions options) : base(options) { }

        public DbSet<CountryEntity> CountryTable { get; set; }
        public DbSet<RegionEntity> RegionTable { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(typeof(EfContext).Assembly);
        }
    }
}
