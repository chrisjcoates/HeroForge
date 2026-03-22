
using HeroForge.Helpers;
using HeroForge.Models;
using HeroForge.Services;

var appRunning = true;

Console.WriteLine("=== Welcome to HeroForge! ===");
Console.WriteLine("Create a hero and test their strength against a random enemy!");
do
{   
    Console.Write("Enter a name for your character: ");
    var playerName = Console.ReadLine();

    string[] classes = ["Warrior", "Mage", "Rouge"];
    
    Console.WriteLine("Classes:");
    for (var i = 0; i < classes.Length; i++)
    {
        Console.WriteLine($"{i + 1}. {classes[i]}");
    }
    Console.Write($"Choose a class from the below list (1-{classes.Length}: )");
    var playerClass = Convert.ToInt32(Console.ReadLine());
    
    var random = new Random();
    var newHero = new Hero
    {
        Name = playerName, CharacterClass = classes[playerClass], MaxHp = random.Next(10, 100), AttackPower = random.Next(10, 20), Defence = random.Next(10, 20),
    };
    newHero.CurrentHp = newHero.MaxHp;
    
    DisplayHelper.DisplayStats(newHero);

    var newEnemy = EnemyFactory.GenerateEnemy();
    
    BattleService.StartBattle(newHero, newEnemy);

    Console.Write("Would you like to play again? y/n: ");
    var validResponse = false;
    do
    {
        var playAgain = Console.ReadLine();
        switch (playAgain)
        {
            case "y":
                validResponse = true;
                break;
            case "n":
                validResponse = true;
                appRunning = false;
                break;
            default:
                validResponse = false;
                Console.WriteLine($"{playAgain} is not a valid choice.");
                break;
        }
    } while (!validResponse);


} while (appRunning);