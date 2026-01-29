using D_D_project.Unit;
using D_D_project.Items.Weapons;
using D_D_project.Items.Potions;

namespace D_D_project;

class Program

{
    static void Main()
    {
        var engine = new GameEngine();
        engine.OnMessageLog += Console.WriteLine;

        Unit.Unit hero = new Knight("Reagen");

        hero.Inventory.Add(new Sword());
        hero.Inventory.Add(new HealingPotion());
        hero.Inventory.Add(new GreaterHealingPotion());

        Console.WriteLine("The Hero and His Inventory");
        Console.WriteLine($"{hero.Name} | HP: {hero.Health} | ATK: {hero.AttackPower}");
        engine.ShowInventory(hero);
        Console.WriteLine();

        engine.StartGame(hero);

        Console.ReadLine();
    }
}