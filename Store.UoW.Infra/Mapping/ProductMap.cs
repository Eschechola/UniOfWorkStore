using Store.UoW.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Store.UoW.Infra.Mapping
{
    public class ProductMap : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("Products", "dbo");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .UseIdentityColumn()
                .HasColumnType("BIGINT");

            builder.Property(x => x.Name)
                .HasMaxLength(90)
                .HasColumnType("VARCHAR(90)")
                .HasColumnName("name");

            builder.Property(x => x.Price)
                .HasColumnType("DECIMAL")
                .HasColumnName("price");

            builder.Property(x => x.Stock)
                .HasColumnType("INT")
                .HasColumnName("stock");
        }
    }
}
