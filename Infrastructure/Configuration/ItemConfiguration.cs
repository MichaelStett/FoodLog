using FoodLog.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FoodLog.Infrastructure.Configuration
{
    class ItemConfiguration : IEntityTypeConfiguration<Item>
    {
        public void Configure(EntityTypeBuilder<Item> builder)
        {
            builder.ToTable("Items");
            builder.HasKey(i => i.Id);

            builder.Property(i => i.Id)
                   .IsRequired()
                   .ValueGeneratedOnAdd();

            builder.Property(i => i.Name)
                   .IsRequired();

            builder.Property(i => i.Date)
                   .IsRequired();

            builder.Property(i => i.Grams)
                   .IsRequired();

            builder.Property(i => i.CategoryType)
                   .IsRequired();

            builder.Property(i => i.Nutrients)
                   .IsRequired();
        }
    }
}
