using ClientManagementAPIDB.Models;
using Microsoft.EntityFrameworkCore;

namespace ClientManagementAPIDB.Data
{
    public class ApplicationContext : DbContext, IApplicationContext
    {
        public DbSet<Client> Clients { get; set; }

        public ApplicationContext(DbContextOptions options) : base(options)
        {
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connetionString = "Server=localhost;Database=ClientManagementDB;User=SA;Password=Password123;TrustServerCertificate=True";
            optionsBuilder.UseSqlServer(connetionString);
        }
    }
}