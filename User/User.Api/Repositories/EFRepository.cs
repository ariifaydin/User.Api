using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using User.Api.Contexts;
using User.Api.Entites;

namespace User.Api.Repositories
{
    public class EFRepository<TEntity> : IEFRepository<TEntity>
               where TEntity : BaseEntity
    {
        private readonly UserDbContext _context;
        private readonly DbSet<TEntity> _dbSet;

        public EFRepository(UserDbContext context)
        {
            _context = context;
            _dbSet = _context.Set<TEntity>();
        }

        public IQueryable<TEntity> Get(Expression<Func<TEntity, bool>> filter = null)
        {
            if (filter == null) return _dbSet.AsQueryable();

            return _dbSet.Where(filter);
        }

        public TEntity GetById(Guid id)
        {
            return _dbSet.Find(id);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _dbSet.ToList();
        }

        public TEntity Add(TEntity entity)
        {
            _dbSet.Add(entity);

            return entity;
        }

        public TEntity Update(TEntity entity)
        {
            _context.Entry(entity).State = EntityState.Modified;

            return entity;
        }

        public void Delete(Guid id)
        {
            _dbSet.Remove(_dbSet.Find(id));
        }
    }
}

