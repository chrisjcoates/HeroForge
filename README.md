# ⚔️ HeroForge

*A text-based RPG character creator and battle simulator built in C#. Create your hero and face a randomly generated enemy.*

## About

HeroForge is a console application where you name your hero, pick a class, and get thrown straight into battle against a mystery opponent. Stats are randomised, outcomes are uncertain, and glory (or shame) awaits.

## Features

- Create a named hero and choose from three classes: Warrior, Mage, or Rogue
- Randomised hero and enemy stats keep every run feeling different
- Turn-based combat with damage calculations and live HP tracking
- Four enemy types: Goblin, Troll, Skeleton, and Dark Knight
- Replay prompt so you can keep going until you get that win
- Clean console output with stats displayed after every turn

## How to Run

Make sure you have the .NET SDK installed, then:
```bash
git clone https://github.com/chrisjcoates/HeroForge
cd HeroForge
dotnet run
```

## Project Structure

- `Models/Hero.cs` — Hero class with name, class, and stats
- `Models/Enemy.cs` — Enemy class with randomized stats
- `Services/BattleService.cs` — Turn-based combat logic
- `Services/EnemyFactory.cs` — Random enemy generator
- `Helpers/DisplayHelper.cs` — Console stat display (overloaded methods)
- `Program.cs` — Entry point, character creation flow, and replay loop

## Built With

C# / .NET — no third-party dependencies, just the standard library.
