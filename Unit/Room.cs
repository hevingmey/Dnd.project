using D_D_project.Unit;
namespace D_D_project.Unit;

public class Room
{
    public string Name { get; }
    public Func<Unit> SpawnMonster { get; }

    public Room(string name, Func<Unit> spawnMonster)
    {
        Name = name;
        SpawnMonster = spawnMonster;
    }
}