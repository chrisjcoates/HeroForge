using HeroForge.Models;

namespace HeroForge.Services
{
    public static class EnemyFactory
    {
        public static Enemy GenerateEnemy()
        {
            string[] enemyName = ["Goblin", "Troll", "Skeleton", "Dark Knight"];
            
            var random = new Random();
            
            var enemyIndex = random.Next(enemyName.Length);
            
            var maxHp = random.Next(10, 100);
            var attackPower = random.Next(5, 10);
            var defence = random.Next(5, 10);

            var newEnemy = new Enemy
            {
                Name = enemyName[enemyIndex], 
                MaxHp = maxHp, 
                CurrentHp = maxHp,
                AttackPower = attackPower, 
                Defence = defence
            };

            return newEnemy;
        }
    }
}
