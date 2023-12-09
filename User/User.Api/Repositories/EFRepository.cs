using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using User.Api.Contexts;
using User.Api.Entites;

namespace User.Api.Repositories
{
    public class EFRepository<T, TContext> : IEFRepository<T>
               where T : class
            where TContext : DbContext, new()
    {
        private readonly DbContext _context;
        private readonly DbSet<T> _dbSet;

        public EFRepository(DbContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }

        public T GetById(int id)
        {
            return _dbSet.Find(id);
        }

        public IEnumerable<T> GetAll()
        {
            return _dbSet.ToList();
        }

        public void Add(T entity)
        {
            _dbSet.Add(entity);
        }

        public void Update(T entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
        }

        public void Delete(T entity)
        {
            _dbSet.Remove(entity);
        }


    }
}

