using System;
using System.Collections.Generic;
using D_D_project.Unit;
using UnitBase = D_D_project.Unit.Unit;

namespace D_D_project;

public class GameEngine
{
    public event Action<string>? OnMessageLog;
    private void Log(string msg) => OnMessageLog?.Invoke(msg);

    private enum PlayerAction
    {
        Attack = 1,
        UsePotion = 2,
        Run = 3,
        UseItem = 4
    }

    private int potions = 1;
    private const int PotionHeal = 20;
    private const int RunChance = 60;

    
    public void StartGame(UnitBase hero)
    {
        var rooms = new List<Room>
        {
            new Room("Room 1: Corridor", () => new Goblin()),
            new Room("Room 2: Cave", () => new Orc()),
            new Room("Room 3: Boss room", () => new Boss())
        };

        Log(" Game started!");
        LogHeroInfo(hero);
        Log("");

        int roomNumber = 1;

        foreach (var room in rooms)
        {
            if (!hero.IsAlive) return;

            Log($" You enter {room.Name}");
            Log("");

            UnitBase monster = room.SpawnMonster();
            Log($" You meet {monster.Name}");
            Log("");

            bool finishedBattle = Battle(hero, monster);

            if (!finishedBattle)
            {
                Log($" You escaped from {room.Name}");
                Log(" Game ended.");
                return;
            }

            if (!hero.IsAlive)
            {
                Log($" You died in {room.Name}");
                Log(" Game over.");
                return;
            }

            Log($" Room {roomNumber} cleared!");
            Log(" Moving to the next room...");
            Log("");
            roomNumber++;
        }

        Log(" You defeated the Boss!");
        Log(" Game completed!");
    }

    
    public bool Battle(UnitBase hero, UnitBase monster)
    {
        Log($" Battle started: {hero.Name} vs {monster.Name}");
        Log("");

        while (hero.IsAlive && monster.IsAlive)
        {
            LogHeroInfo(hero);
            Log($"{monster.Name} | HP: {monster.Health} | ATK: {monster.AttackPower}");
            Log("");

            PlayerAction action = AskPlayerAction();
            bool heroSpentTurn = true;

            switch (action)
            {
                case PlayerAction.Attack:
                    HeroAttack(hero, monster);
                    break;

                case PlayerAction.UsePotion:
                    heroSpentTurn = UsePotion(hero);
                    break;

                case PlayerAction.Run:
                    if (TryRun())
                    {
                        Log(" Escape successful!");
                        Log("");
                        return false;
                    }
                    Log(" Escape failed!");
                    break;

                case PlayerAction.UseItem:
                    ShowInventory(hero);
                    heroSpentTurn = false;
                    break;
            }

            if (!monster.IsAlive || !hero.IsAlive) break;

            if (heroSpentTurn)
                MonsterAttack(hero, monster);
            else
                Log(" Turn not spent.");

            Log("");
        }

        Log(monster.IsAlive
            ? $" {hero.Name} lost the battle..."
            : $" {hero.Name} won the battle!");

        Log("");
        return true;
    }

    
    private void HeroAttack(UnitBase hero, UnitBase monster)
    {
        int before = monster.Health;
        hero.Attack(monster);
        int dmg = before - monster.Health;
        Log($" {hero.Name} hits {monster.Name} for {dmg}. {monster.Name} HP={monster.Health}");
    }

    private void MonsterAttack(UnitBase hero, UnitBase monster)
    {
        int before = hero.Health;
        monster.Attack(hero);
        int dmg = before - hero.Health;
        Log($" {monster.Name} hits {hero.Name} for {dmg}. {hero.Name} HP={hero.Health}");
    }

    
    private bool UsePotion(UnitBase hero)
    {
        if (potions <= 0)
        {
            Log(" No potions left!");
            return false;
        }

        potions--;
        int before = hero.Health;
        hero.Heal(PotionHeal);
        Log($" Potion used. Healed {hero.Health - before}. Potions left: {potions}");
        return true;
    }

    private bool TryRun()
    {
        int roll = Random.Shared.Next(1, 101);
        return roll <= RunChance;
    }

  
    private PlayerAction AskPlayerAction()
    {
        while (true)
        {
            Log("Choose action:");
            Log("1) Attack");
            Log($"2) Use potion (x{potions})");
            Log("3) Run");
            Log("4) Use item (show inventory)");
            Console.Write("> ");

            string? input = Console.ReadLine();

            if (int.TryParse(input, out int n) && n >= 1 && n <= 4)
                return (PlayerAction)n;

            Log(" Wrong input.");
        }
    }

    private void LogHeroInfo(UnitBase hero)
    {
        Log($" {hero.Name} | HP: {hero.Health} | ATK: {hero.AttackPower}");
        ShowInventory(hero);
    }

    private void ShowInventory(UnitBase hero)
    {
        Log(" Inventory:");

        if (hero.Inventory.Count == 0)
        {
            Log(" (empty)");
            return;
        }

        for (int i = 0; i < hero.Inventory.Count; i++)
        {
            var item = hero.Inventory[i];
            Log($" {i + 1}) {item.Name} - {item.Description}");
        }
    }
}
