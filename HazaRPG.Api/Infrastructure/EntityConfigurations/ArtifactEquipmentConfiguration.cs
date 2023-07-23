using HazaRPG.Api.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HazaRPG.Api.Infrastructure.EntityConfigurations
{
    public class ArtifactEquipmentConfiguration : IEntityTypeConfiguration<ArtifactEquipment>
    {
        public void Configure(EntityTypeBuilder<ArtifactEquipment> builder)
        {

        }
    }
}
