using HazaRPG.Api.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HazaRPG.Api.Infrastructure.EntityConfigurations
{
    public class EquipmentConfiguration : IEntityTypeConfiguration<Equipment>
    {
        public void Configure(EntityTypeBuilder<Equipment> builder)
        {
            builder.ToTable("Equipments"); // Name of the table in the database

            // Primary key
            builder.HasKey(e => e.Id);

            // Properties
            builder.Property(e => e.Name).HasMaxLength(100).IsRequired();

            // Relationships
            builder.HasMany(e => e.EquipmentActions)
                .WithOne()
                .HasForeignKey("EquipmentId");
        }
    }
}
