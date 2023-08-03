using Infrastructure.Repository;

namespace Infrastructure.EFCore.Repository
{
    public class EFRepository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Delete(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TEntity> GetAll()
        {
            throw new NotImplementedException();
        }

        public TEntity GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public int Insert(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public void Update(TEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
