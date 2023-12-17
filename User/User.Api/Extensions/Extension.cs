using Microsoft.EntityFrameworkCore;
using User.Api.Constants;
using User.Api.Contexts;
using User.Api.Entites;
using User.Api.Mappings;
using User.Api.Repositories;
using User.Api.Services;
using User.Api.UnitOfWorks.Abstract;
using User.Api.UnitOfWorks.Concrete;

namespace User.Api.Extensions
{
    public class Extension
    {
        public static void AddDependencyInjection(IServiceCollection services)
        {
            services.AddAutoMapper(typeof(UserProfile));

            services.AddDbContext<UserDbContext>();

            services.AddScoped<IUnitOfWork, EFUnitOfWork<UserDbContext>>();

            services.AddScoped(typeof(IEFRepository<UserEntity>), typeof(EFRepository<UserEntity>));

            services.AddScoped(typeof(IUserService), typeof(UserService));

        }
    }
}
