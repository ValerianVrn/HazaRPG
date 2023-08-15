using HazaRPG.Api.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HazaRPG.Api.Infrastructure.EntityConfigurations
{
    public class EquipmentActionConfiguration : IEntityTypeConfiguration<EquipmentAction>
    {
        public void Configure(EntityTypeBuilder<EquipmentAction> builder)
        {
            builder.HasKey(ea => ea.Id);

            builder.Property(ea => ea.Stamina)
                .IsRequired();

            // Configure Dices relationship if needed
            builder.HasMany(ea => ea.Dices)
                .WithOne()
                .HasForeignKey("EquipmentActionId");
        }
    }
}
