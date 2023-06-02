using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayer.Core;

namespace NLayer.Repository.Seeds;

public class ProduıctFeaturedSeed :IEntityTypeConfiguration<ProductFeatured>
{

    public void Configure(EntityTypeBuilder<ProductFeatured> builder)
    {
        builder.HasData(new ProductFeatured()
        {
            Id = 1,
            Color = "kırmızı",
            Height = 100,
            Width = 200,
            ProductId = 1
        },
            new ProductFeatured()
            {
                Id = 2,
                Color = "Mavi",
                Height = 100,
                Width = 200,
                ProductId = 2
            }
            );


    }
}