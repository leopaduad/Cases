
namespace CaseCustomerDomain.Interfaces
{
    public interface IBaseRepository<TEntity> : IDisposable where TEntity : class
    {
        void Add(TEntity obj);
        TEntity GetById(Guid id);
        TEntity GetById(int id);
        IQueryable<TEntity> GetAll();
        void Update(TEntity obj);
        void Remove(Guid id);
        void Remove(int id);
        int SaveChanges();
    }
}
