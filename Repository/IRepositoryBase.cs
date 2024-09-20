using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClientManagementAPIDB.Models;

namespace ClientManagementAPIDB.Repository
{
    public interface IRepositoryBase<TEntity> where TEntity : class
    {
        public void Add(TEntity entity);
        public IEnumerable<TEntity> GetAll();
        public void Update(TEntity entity);
        public void Delete(int id);
    }
}