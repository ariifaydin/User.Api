using System.Linq.Expressions;

namespace User.Api.Repositories
{
    public interface IEFRepository<T>
    {
        IQueryable<T> Get(Expression<Func<T, bool>> filter = null);
        T GetById(Guid id);
        IEnumerable<T> GetAll();
        T Add(T entity);
        T Update(T entity);
        void Delete(Guid id);
    }
}
