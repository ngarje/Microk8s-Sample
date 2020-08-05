using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace MicroK8s.Api.Database.Context
{
    public sealed class EfContextFactory : IDesignTimeDbContextFactory<EfContext>
    {
        public EfContext CreateDbContext(string[] args)
        {
            var connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=MicroK8sApi;Integrated Security=True;";
            return new EfContext(new DbContextOptionsBuilder<EfContext>().UseSqlServer(connectionString).Options);
        }
    }
}
