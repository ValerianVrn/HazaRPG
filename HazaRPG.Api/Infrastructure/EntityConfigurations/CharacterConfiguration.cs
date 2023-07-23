using HazaRPG.Api.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HazaRPG.Api.Infrastructure.EntityConfigurations
{
    public class CharacterConfiguration : IEntityTypeConfiguration<Character>
    {
        public void Configure(EntityTypeBuilder<Character> builder)
        {
            builder.ToTable("Characters"); // Name of the table in the database

            // Primary key
            builder.HasKey(c => c.Id);

            // Properties
            builder.Property(c => c.Name).HasMaxLength(100).IsRequired();
            builder.Property(c => c.Health).IsRequired();
            builder.Property(c => c.Stamina).IsRequired();
            builder.Property(c => c.Attack).IsRequired();
            builder.Property(c => c.Defense).IsRequired();
            builder.Property(c => c.Dodge).IsRequired();
            builder.Property(c => c.Aggro).IsRequired();

            // Relationships
            builder.HasOne(c => c.AttackEquipment)
                .WithOne()
                .HasForeignKey<Character>(c => c.AttackEquipmentId);

            builder.HasOne(c => c.DefenseEquipment)
                .WithOne()
                .HasForeignKey<Character>(c => c.DefenseEquipmentId);

            builder.HasOne(c => c.ArtifactEquipment)
                .WithOne()
                .HasForeignKey<Character>(c => c.ArtifactEquipmentId);
        }
    }
}
