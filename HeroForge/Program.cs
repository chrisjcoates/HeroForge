
using HeroForge.Helpers;
using HeroForge.Models;
using HeroForge.Services;

var appRunning = true;

Console.WriteLine("=== Welcome to HeroForge! ===\n");
Console.WriteLine("Create a hero and test their strength against a random enemy!\n");
do
{   
    Console.Write("Enter a name for your character: ");
    var playerName = Console.ReadLine();

    string[] classes = ["Warrior", "Mage", "Rogue"];
    
    Console.WriteLine("\nClasses:\n");
    for (var i = 0; i < classes.Length; i++)
    {
        Console.WriteLine($"{i + 1}. {classes[i]}");
    }
    bool validInt;
    int classChoice;
    do
    {
        Console.Write($"\nChoose a class from the below list (1-{classes.Length}): ");
        var playerClassChoice = Console.ReadLine();
        if (int.TryParse(playerClassChoice, out classChoice) &&
            classChoice >= 1 &&
            classChoice <= classes.Length)
        {
            validInt = true;
        }
        else
        {
            Console.WriteLine("Invalid input, try again.");
            validInt = false;
        }
        
    } while (!validInt);
    
    var random = new Random();
    var newHero = new Hero
    {
        Name = playerName, CharacterClass = classes[classChoice -1], MaxHp = random.Next(10, 80), AttackPower = random.Next(10, 20), Defence = random.Next(10, 20),
    };
    newHero.CurrentHp = newHero.MaxHp;

    Console.Clear();
    
    Console.WriteLine($"{newHero.Name} the {newHero.CharacterClass} has been created.");
    DisplayHelper.DisplayStats(newHero);
    
    var newEnemy = EnemyFactory.GenerateEnemy();
    Console.WriteLine($"A {newEnemy.Name} has been created.");
    DisplayHelper.DisplayStats(newEnemy);

    Console.WriteLine("Click any key to continue...");
    Console.ReadKey();
    Console.Clear();
    
    BattleService.StartBattle(newHero, newEnemy);
    
    bool validResponse;
    do
    {
        Console.Write("Would you like to play again? y/n: ");
        var playAgain = Console.ReadLine();
        switch (playAgain?.ToLower())
        {
            case "y":
                validResponse = false;
                break;
            case "n":
                Console.WriteLine("\nExiting HeroForge...");
                validResponse = false;
                appRunning = false;
                break;
            default:
                validResponse = true;
                Console.WriteLine($"{playAgain} is not a valid choice.");
                break;
        }
    } while (validResponse);
    
} while (appRunning);
