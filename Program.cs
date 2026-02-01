using D_D_project.Unit;
using D_D_project.Items.Weapons;
using D_D_project.Items.Potions;
using D_D_project.Music;

namespace D_D_project;

class Program

{
    static void Main()
    {        Soundtrack.Start("mus.wav");


        var engine = new GameEngine();
        engine.OnMessageLog += Console.WriteLine;

        Console.WriteLine("Deongeons and Dragons");
        Console.WriteLine("choose a hero");
        Console.WriteLine("1.Knight");
        Console.WriteLine("2.Mage");

        int choice = Convert.ToInt32(Console.ReadLine());

        Unit.Unit hero; 

        switch (choice)
        {
            case 1:

                hero = new Knight("Reagen");
                break;

            case 2:
                hero = new Mage("Tomas");
                break;

            default:
                Console.WriteLine("Wrong choice");
                return; 
        }

        
        hero.Inventory.Add(new Sword());
        hero.Inventory.Add(new HealingPotion());
        hero.Inventory.Add(new GreaterHealingPotion());

        Console.WriteLine("The Hero and His Inventory");
        Console.WriteLine($"{hero.Name} | HP: {hero.Health} | ATK: {hero.AttackPower}");
        engine.ShowInventory(hero);
        Console.WriteLine();

        engine.StartGame(hero);

        D_D_project.Music.Soundtrack.Stop();

        Console.ReadLine();
    }
}