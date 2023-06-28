using Flunt.Notifications;
using IWantApp.Domain.Products;
using Microsoft.EntityFrameworkCore;

namespace IWantApp.Infra.Data;

public class AplicationDbContext : DbContext
{
    public DbSet<Product> Products { get; set; }
    public DbSet<Category> Categories { get; set; }

    public AplicationDbContext(DbContextOptions<AplicationDbContext> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.Ignore<Notification>();
        builder.Entity<Product>().Property(p => p.Name).IsRequired();
        builder.Entity<Product>().Property(p => p.Description).HasMaxLength(255);

        builder.Entity<Category>().Property(c => c.Name).IsRequired();

    }

    // Convencao que permite generalizar um parametro
    // Toda string tera um tamanho maximo de 100 caracteres
    protected override void ConfigureConventions(ModelConfigurationBuilder configuration)
    {
        configuration.Properties<string>().HaveMaxLength(100);
    }
}
