namespace User.Api.UnitOfWorks.Abstract
{
    public interface IUnitOfWork
    {
        Task<int> SaveChangesAsync();
    }
}
