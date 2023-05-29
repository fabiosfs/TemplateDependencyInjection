using Microsoft.EntityFrameworkCore;
using TemplateDependencyInjection.Domain.Entities;

namespace TemplateDependencyInjection.Infrastructure.Contexts
{
    public class FirstDbContext : DbContext
    {
        public DbSet<ClientEntity> Client { get; set; }

        public FirstDbContext(DbContextOptions<FirstDbContext> options) : base(options)
        { 
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var entityClient = modelBuilder.Entity<ClientEntity>().ToTable("Client");
            entityClient.Property(column => column.Id)
                .UseIdentityColumn();
            entityClient.Property(column => column.Name)
                .HasMaxLength(255).IsRequired(true);
            entityClient.Property(column => column.BirthDate)
                .IsRequired(true);
        }
    }
}
