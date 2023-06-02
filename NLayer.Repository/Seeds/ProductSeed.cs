using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayer.Core;

namespace NLayer.Repository.Seeds;

public class ProductSeed :IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        builder.HasData(new Product { Id = 1,CategoryId = 1, Name = "KALEM1",  Price =100,Stock = 20,CreatedDate = DateTime.Now});
        builder.HasData(new Product { Id = 2,CategoryId = 3,Name = "KALEM2",  Price =200,Stock = 30,CreatedDate = DateTime.Now });
        builder.HasData(new Product { Id = 3,CategoryId = 2, Name = "KALEM3", Price =300,Stock = 40,CreatedDate = DateTime.Now });
        builder.HasData(new Product { Id = 4,CategoryId = 1, Name = "KALEM4", Price =400,Stock = 50,CreatedDate = DateTime.Now });
        builder.HasData(new Product { Id = 5,CategoryId = 2, Name = "KALEM5", Price =500,Stock = 60,CreatedDate = DateTime.Now });
        builder.HasData(new Product { Id = 6,CategoryId = 3, Name = "KALEM6", Price =600,Stock = 70,CreatedDate = DateTime.Now });

    }
}