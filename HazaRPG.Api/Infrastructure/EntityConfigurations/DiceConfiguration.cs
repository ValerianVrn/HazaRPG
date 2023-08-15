using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using HazaRPG.Api.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Newtonsoft.Json;

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
            builder.Property(d => d.Faces).HasColumnName("Faces").HasConversion(
                v => JsonConvert.SerializeObject(v),
                v => JsonConvert.DeserializeObject<object[]>(v));

            //builder.Property(d => d.BoolFaces).HasColumnName("BoolFaces");
        }
    }
}
