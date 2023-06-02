using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayer.Core;

namespace NLayer.Repository.Configuration;

public class ProductFeatureConfiguration:IEntityTypeConfiguration<ProductFeatured>
{
    public void Configure(EntityTypeBuilder<ProductFeatured> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id).UseIdentityColumn();
        builder.HasOne(x => x.Product).WithOne(x => x.ProductFeatured).HasForeignKey<ProductFeatured>(x => x.ProductId);
        
    }
}