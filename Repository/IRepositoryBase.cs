namespace ClientManagementAPIDB.Repository
{
    public interface IRepositoryBase<TEntity> where TEntity : class
    {
        public void Add(TEntity entity);
        public IEnumerable<TEntity> GetAll();
        public TEntity GetById(int id);
        public void Update(TEntity entity);
        public void Delete(int id);
    }
}