using HeroForge.Models;

namespace HeroForge.Helpers
{
    public static class DisplayHelper
    {
        public static void DisplayStats(Hero hero)
        {
            Console.WriteLine($"\n=== {hero.Name} the {hero.CharacterClass} ===");
            Console.WriteLine($"Max Hp: {hero.MaxHp}");
            Console.WriteLine($"Current Hp: {hero.CurrentHp}");
            Console.WriteLine($"Attack Power: {hero.AttackPower}");
            Console.WriteLine($"Defence: {hero.Defence}\n");
        }

        public static void DisplayStats(Enemy enemy)
        {
            Console.WriteLine($"\n=== {enemy.Name} the enemy ===");
            Console.WriteLine($"Max Hp: {enemy.MaxHp}");
            Console.WriteLine($"Current Hp: {enemy.CurrentHp}");
            Console.WriteLine($"Attack Power: {enemy.AttackPower}");
            Console.WriteLine($"Defence: {enemy.Defence}\n");
        }
    }
}
