namespace HazaRPG.Api.Models
{
    public class EquipmentAction
    {
        public int Id { get; set; }

        public int Stamina { get; set; }

        public List<Dice> Dices { get; set; }
    }
}
