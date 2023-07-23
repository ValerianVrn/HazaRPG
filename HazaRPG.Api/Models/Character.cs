namespace HazaRPG.Api.Models
{
    public class Character
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Health { get; set; }

        public int Stamina { get; set; }

        public int Attack { get; set; }

        public int Defense { get; set; }

        public int Dodge { get; set; }

        public int Aggro { get; set; }
        
        public int AttackEquipmentId { get; set; }

        public AttackEquipment AttackEquipment { get; set; }
        
        public int DefenseEquipmentId { get; set; }

        public DefenseEquipment DefenseEquipment { get; set; }
        
        public int ArtifactEquipmentId { get; set; }

        public ArtifactEquipment ArtifactEquipment { get; set; }
    }
}
