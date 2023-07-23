using HazaRPG.Api.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HazaRPG.Api.Infrastructure.EntityConfigurations
{
    public class DefenseEquipmentConfiguration : IEntityTypeConfiguration<DefenseEquipment>
    {
        public void Configure(EntityTypeBuilder<DefenseEquipment> builder)
        {

        }
    }
}
