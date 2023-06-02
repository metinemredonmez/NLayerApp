using System.Reflection;
using Microsoft.EntityFrameworkCore;
using NLayer.Core;

namespace NLayer.Repository;

public class AppDbContext:DbContext
{

    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
      
    }

    public DbSet<Category> Cate { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<ProductFeatured> ProductFeatureds { get; set; }

    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        base.OnModelCreating(modelBuilder);
    }
}