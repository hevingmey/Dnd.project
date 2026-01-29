using D_D_project.Unit;

namespace D_D_project;

class Program

{
    static void Main()
    {
        var engine = new GameEngine();
        engine.OnMessageLog += Console.WriteLine;

       Hero hero = new Knight("Reagen");
       
        engine.StartGame(hero);

        Console.ReadLine();
    }
}