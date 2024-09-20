using ClientManagementAPIDB.Models;
using Microsoft.EntityFrameworkCore;

namespace ClientManagementAPIDB.Data
{
    public class ApplicationDBContext : DbContext, IApplicationDBContext
    {
        public DbSet<Client> Clients { get; set; }

        public ApplicationDBContext(DbContextOptions options) : base(options)
        {
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connetionString = "Server=localhost;Database=ClientManagementDB;User=SA;Password=Password123;TrustServerCertificate=True";
            optionsBuilder.UseSqlServer(connetionString);
        }
    }
}