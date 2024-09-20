using ClientManagementAPIDB.Data;
using Microsoft.EntityFrameworkCore;

namespace ClientManagementAPIDB.Repository
{
    public class RepositoryBase<TEntity> : IRepositoryBase<TEntity> where TEntity : class
    {
        private readonly ApplicationDBContext _context;
        private DbSet<TEntity> DbSetEntity;

        public RepositoryBase(ApplicationDBContext context)
        {
            _context = context;
            DbSetEntity = _context.Set<TEntity>();
        } 

        public void Add(TEntity entity)
        {
            DbSetEntity.Add(entity);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            DbSetEntity.Remove(DbSetEntity.Find(id));
            _context.SaveChanges();
        }

        public IEnumerable<TEntity> GetAll()
        {
            return DbSetEntity.ToList();
        }

        public TEntity GetById(int id)
        {
            return DbSetEntity.Find(id);
        }

        public void Update(TEntity entity)
        {
            DbSetEntity.Update(entity);
            _context.SaveChanges();
        }
    }
}