using FoodLog.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FoodLog.Infrastructure.Configuration
{
    class NutrientConfiguration : IEntityTypeConfiguration<Nutrient>
    {
        public void Configure(EntityTypeBuilder<Nutrient> builder)
        {
            builder.HasKey(i => new { i.Id, i.ItemId});

            builder.Property(i => i.Id)
                   .IsRequired()
                   .ValueGeneratedOnAdd();

            builder.Property(i => i.ItemId)
                   .IsRequired();

            builder.Property(i => i.NutrientType)
                   .IsRequired();

        }
    }
}
