using FoodLog.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FoodLog.Infrastructure.Configuration
{
    class NutrientConfiguration : IEntityTypeConfiguration<Nutrient>
    {
        public void Configure(EntityTypeBuilder<Nutrient> builder)
        {
            builder.ToTable("Nutrients");
            builder.HasKey(i => i.Id);

            builder.Property(i => i.Id)
                   .IsRequired()
                   .ValueGeneratedOnAdd();

            builder.Property(i => i.ItemId)
                   .IsRequired();
            builder.HasIndex(i => i.ItemId)
                   .IsUnique();

            builder.Property(i => i.NutrientType)
                   .IsRequired();

            builder.HasOne(i => i.Item)
                .WithMany(i => i.Nutrients)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
