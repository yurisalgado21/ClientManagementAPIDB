using ClientManagementAPIDB.Data;
using ClientManagementAPIDB.Models;

namespace ClientManagementAPIDB.Repository
{
    public class ClientRepository : RepositoryBase<Client>, IClientRepository
    {
        public ClientRepository(ApplicationDBContext context) : base(context)
        {
        }
    }
}