namespace User.Api.UnitOfWorks.Abstract
{
    public interface IUnitOfWork
    {
        int SaveChanges();
    }
}
