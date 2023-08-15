namespace HazaRPG.Api.Models
{
    public class Dice
    {
        public static readonly Dice AttackDice1 = new(1, DiceType.Attack, 0, 1, 1, 1, 2, 2);
        
        public static readonly Dice AttackDice2 = new(2, DiceType.Attack,1, 1, 2, 2, 2, 3);
        
        public static readonly Dice AttackDice3 = new(3, DiceType.Attack,1, 2, 2, 3, 3, 4);
        
        public static readonly Dice DefenseDice1 = new(4, DiceType.Defense, 0, 1, 1, 1, 2, 2);
        
        public static readonly Dice DefenseDice2 = new(5, DiceType.Defense,1, 1, 2, 2, 2, 3);
        
        public static readonly Dice DefenseDice3 = new(6, DiceType.Defense,1, 2, 2, 3, 3, 4);

        public static readonly Dice DodgeDice = new(7, DiceType.Dodge, false, false, false, true, true, true);
        
        public int Id { get; set; }

        //public int[] IntFaces { get; private set; } = new int[6];
        
        //public bool[] BoolFaces { get; private set; } = new bool[6];

        public object[] Faces { get; private set; } = new object[6];

        public DiceType DiceType { get; private set; }
        
        private Dice(int id, DiceType diceType, object[] faces)
        {
            Id = id;
            DiceType = diceType;
            Faces = faces;
        }

        private Dice(int id, DiceType diceType, int face1, int face2, int face3, int face4, int face5, int face6)
        {
            Id = id;
            DiceType = diceType;
            Faces[0] = face1;
            Faces[1] = face2;
            Faces[2] = face3;
            Faces[3] = face4;
            Faces[4] = face5;
            Faces[5] = face6;
        }

        private Dice(int id, DiceType diceType, bool face1, bool face2, bool face3, bool face4, bool face5, bool face6)
        {
            Id = id;
            DiceType = diceType;
            Faces[0] = face1;
            Faces[1] = face2;
            Faces[2] = face3;
            Faces[3] = face4;
            Faces[4] = face5;
            Faces[5] = face6;
        }

        //private Dice(int id, DiceType diceType, bool[] boolFaces)
        //{
        //    Id = id;
        //    DiceType = diceType;
        //    BoolFaces = boolFaces;
        //}

        //private Dice(int id, DiceType diceType, int face1, int face2, int face3, int face4, int face5, int face6)
        //{
        //    Id = id;
        //    DiceType = diceType;
        //    IntFaces[0] = face1;
        //    IntFaces[1] = face2;
        //    IntFaces[2] = face3;
        //    IntFaces[3] = face4;
        //    IntFaces[4] = face5;
        //    IntFaces[5] = face6;
        //}

        //private Dice(int id, DiceType diceType, bool face1, bool face2, bool face3, bool face4, bool face5, bool face6)
        //{
        //    Id = id;
        //    DiceType = diceType;
        //    BoolFaces[0] = face1;
        //    BoolFaces[1] = face2;
        //    BoolFaces[2] = face3;
        //    BoolFaces[3] = face4;
        //    BoolFaces[4] = face5;
        //    BoolFaces[5] = face6;
        //}

        //public T Roll()
        //{
        //    Random random = new Random();
        //    int randomFace = random.Next(6);
        //    return DiceType == DiceType.Dodge ? BoolFaces[randomFace] : IntFaces[randomFace];
        //}
    }
}
