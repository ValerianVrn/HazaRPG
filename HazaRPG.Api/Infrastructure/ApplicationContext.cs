using HazaRPG.Api.Infrastructure.EntityConfigurations;
using HazaRPG.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace HazaRPG.Api.Infrastructure
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Dice> Dices { get; set; }

        public DbSet<Character> Characters { get; set; }

        public DbSet<Equipment> Equipments { get; set; }

        public DbSet<AttackEquipment> AttackEquipments { get; set; }

        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CharacterConfiguration());
            modelBuilder.ApplyConfiguration(new DiceConfiguration());
            modelBuilder.ApplyConfiguration(new EquipmentConfiguration());
            modelBuilder.ApplyConfiguration(new ArtifactEquipmentConfiguration());
            modelBuilder.ApplyConfiguration(new AttackEquipmentConfiguration());
            modelBuilder.ApplyConfiguration(new DefenseEquipmentConfiguration());
        }
    }
}
