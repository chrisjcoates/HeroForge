namespace HeroForge.Models
{
    public class Hero
    {
        public string? Name { get; set; }
        public string? CharacterClass { get; set; }
        public int MaxHp { get; set; }
        public int CurrentHp { get; set; }
        public int AttackPower  { get; set; }
        public int Defence { get; set; }
    }
}
