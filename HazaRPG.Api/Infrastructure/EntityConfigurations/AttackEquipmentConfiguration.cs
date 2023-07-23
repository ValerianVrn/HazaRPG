using HazaRPG.Api.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HazaRPG.Api.Infrastructure.EntityConfigurations
{
    public class AttackEquipmentConfiguration : IEntityTypeConfiguration<AttackEquipment>
    {
        public void Configure(EntityTypeBuilder<AttackEquipment> builder)
        {

        }
    }
}
