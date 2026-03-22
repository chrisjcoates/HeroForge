using HeroForge.Models;
using HeroForge.Helpers;

namespace HeroForge.Services
{
    public static class BattleService
    {
        private static void HeroAttacks(Hero hero, Enemy enemy)
        {
            var damage = hero.AttackPower - enemy.Defence;
            if (damage < 1) damage = 1;
            
            enemy.CurrentHp -= damage;
            
            Console.WriteLine($"{hero.Name} attacks {enemy.Name} dealing {damage} damage.\n");
            DisplayHelper.DisplayStats(hero);
            DisplayHelper.DisplayStats(enemy);
        }

        private static void EnemyAttacks(Hero hero, Enemy enemy)
        {
            var damage = enemy.AttackPower - hero.Defence;
            if (damage < 1) damage = 1;
            
            hero.CurrentHp -= damage;
            
            Console.WriteLine($"{enemy.Name} attacks {hero.Name} dealing {damage} damage.\n");
            DisplayHelper.DisplayStats(enemy);
            DisplayHelper.DisplayStats(hero);
        }

        public static void StartBattle(Hero hero, Enemy enemy)
        {
            Console.WriteLine($"=== BATTLE COMMENCING! ===");
            Console.WriteLine($"{hero.Name} vs {enemy.Name}");

            do
            {
                HeroAttacks(hero, enemy);

                if (enemy.CurrentHp <= 0) break;
                
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
                
                Console.Clear();
                
                EnemyAttacks(hero, enemy);
                
                if (hero.CurrentHp <= 0) break;
                
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
                
                Console.Clear();

            } while (hero.CurrentHp > 0 && enemy.CurrentHp > 0);

            if (hero.CurrentHp > 0)
            {
                Console.WriteLine("=== The hero is victorious ===");
                Console.WriteLine($"{hero.Name} defeated {enemy.Name}! Another tale for the hall of heroes!");
            }
            else
            {
                Console.WriteLine("=== The hero is defeated! ===");
                Console.WriteLine($"{hero.Name} has been defeated by {enemy.Name}, shame...");
            }
        }
    }
}
