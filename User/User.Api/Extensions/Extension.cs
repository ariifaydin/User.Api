using User.Api.Contexts;
using User.Api.UnitOfWorks.Abstract;
using User.Api.UnitOfWorks.Concrete;

namespace User.Api.Extensions
{
    public class Extension
    {
        public static void AddDependencyInjection(IServiceCollection services)
        {
            services.AddDbContext<UserDbContext>();
            services.AddScoped<IUnitOfWork, EFUnitOfWork<UserDbContext>>();
            // services.AddScoped<IEFRepository<UserDbContext>, EFRepository<UrlShorteningEntity, ShorteningDbContext>>();

        }
    }
}
