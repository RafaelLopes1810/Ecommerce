using Microsoft.EntityFrameworkCore;
using Ecommerce.Backend.Domain.Entities;

namespace Ecommerce.Backend.Infrastructure.Persistence
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // Mapeamento da entidade Produto
        public DbSet<Produto> Produtos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configuração opcional com Fluent API
            modelBuilder.Entity<Produto>(entity =>
            {
                entity.HasKey(p => p.Id);
                entity.Property(p => p.Nome).IsRequired().HasMaxLength(100);
                entity.Property(p => p.Descricao).HasMaxLength(500);
                entity.Property(p => p.Preco).HasColumnType("decimal(18,2)");
            });
        }
    }
}
