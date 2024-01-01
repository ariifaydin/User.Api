using System.Linq.Expressions;

namespace User.Api.Repositories
{
    public interface IEFRepository<T>
    {
        T GetById(Guid id);
        IEnumerable<T> GetAll();
        T Add(T entity);
        T Update(T entity);
        void Delete(T entity);
    }
}
