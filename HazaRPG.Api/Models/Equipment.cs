namespace HazaRPG.Api.Models
{
        public abstract class Equipment
        {
            public int Id { get; set; }

            public string Name { get; set; }
            
            public List<EquipmentAction> EquipmentActions { get; set; }
        }
}
