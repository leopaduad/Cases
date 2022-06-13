using CaseCustomerData.Context;
using CaseCustomerDomain.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace CaseCustomerData.Repository
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class
    {
        protected readonly CustomerContext _context;
        protected readonly DbSet<TEntity> _DbSet;

        public BaseRepository(CustomerContext context)
        {
            _context = context;
            _DbSet = _context.Set<TEntity>();
        }
        public void Add(TEntity obj) => _DbSet.Add(obj);

        public IQueryable<TEntity> GetAll() => _DbSet;

        public TEntity GetById(Guid id) => _DbSet.Find(id);

        public TEntity GetById(int id) => _DbSet.Find(id);

        public void Remove(Guid id) => _DbSet.Remove(_DbSet.Find(id));

        public void Remove(int id) => _DbSet.Remove(_DbSet.Find(id));

        public int SaveChanges() => _context.SaveChanges();

        public void Update(TEntity obj) => _DbSet.Update(obj);

        public void Dispose()
        {
            _context.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
