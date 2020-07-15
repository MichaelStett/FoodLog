using FoodLog.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FoodLog.Infrastructure.Configuration
{
    class ItemConfiguration : IEntityTypeConfiguration<Item>
    {
        public void Configure(EntityTypeBuilder<Item> builder)
        {
            builder.HasKey(i => i.Id);

            builder.Property(i => i.Id)
                   .IsRequired()
                   .ValueGeneratedOnAdd();

            builder.Property(i => i.Name)
                   .IsRequired();

            builder.Property(i => i.Date)
                   .HasColumnType("date")
                   .IsRequired();

            builder.Property(i => i.Grams)
                   .IsRequired();

            builder.Property(i => i.CategoryType)
                   .IsRequired();

        }
    }
}
