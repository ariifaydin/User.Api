using Microsoft.EntityFrameworkCore;
using User.Api.Constants;
using User.Api.Entites;

namespace User.Api.Contexts
{
    public class UserDbContext: DbContext
    {
        public UserDbContext(DbContextOptions<UserDbContext> options) : base(options)
        {

        }

        public UserDbContext()
        {
                
        }

        public virtual DbSet<UserEntity> UserEntities { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(DatabaseConstant.MSSQL_CONNECTION_STRING);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("arf");

            modelBuilder.Entity<UserEntity>(entity =>
            {
                entity.ToTable("users");

                entity.Property(i => i.Id).HasColumnName("id").HasColumnType("UNIQUEIDENTIFIER").IsRequired();
                entity.Property(i => i.Username).HasColumnName("username").HasColumnType("nvarchar").HasMaxLength(256).IsRequired();
                entity.Property(i => i.Password).HasColumnName("password").HasColumnType("nvarchar").HasMaxLength(256).IsRequired();
                entity.Property(i => i.Email).HasColumnName("email").HasColumnType("nvarchar").HasMaxLength(256).IsRequired();
            });

            base.OnModelCreating(modelBuilder);
        }
    }
}
