namespace Infrastructure.Repository
{
    public interface IRepository<TEntity> where TEntity : class
    {
        TEntity GetByID(int id);

        IEnumerable<TEntity> GetAll();

        int Insert(TEntity entity);

        void Delete(int id);

        void Delete(TEntity entity);

        void Update(TEntity entity);
    }

}
