using ClientManagementAPIDB.Models;
using Microsoft.EntityFrameworkCore;

namespace ClientManagementAPIDB.Data
{
    public interface IApplicationContext
    {
        public DbSet<Client> Clients { get; set; }
        public int SaveChanges();
    }
}