using HazaRPG.Api.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HazaRPG.Api.Infrastructure.EntityConfigurations
{
    public class DiceConfiguration : IEntityTypeConfiguration<Dice>
    {
        public void Configure(EntityTypeBuilder<Dice> builder)
        {
            builder.ToTable("Dices");

            // Primary key
            builder.HasKey(d => d.Id);

            // Properties
            builder.Property(d => d.DiceType).HasColumnName("DiceType");
            builder.Property(d => d.IntFaces).HasColumnName("IntFaces");
            builder.Property(d => d.BoolFaces).HasColumnName("BoolFaces");

            // Relationships
            builder.HasMany(e => e.EquipmentActions)
                .WithOne()
                .HasForeignKey(ea => ea.Id);
        }

    }
}
