namespace HeroForge.Models
{
    public class Hero
    {
        public string? Name { get; set; }
        public string? CharacterClass { get; set; }
        public int MaxHp { get; set; }
        public int CurrentHp { get; set; }
        public int AttackPower { get; set; }
        public int Defence { get; set; }
        
        public Hero(string name, string characterClass)
        {
            var random = new Random();

            Name = name;
            CharacterClass = characterClass;
            MaxHp = random.Next(10, 80);
            CurrentHp = MaxHp;
            AttackPower = random.Next(10, 20);
            Defence = random.Next(10, 20);
        }
    }
}

