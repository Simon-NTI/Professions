namespace Professions;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        
        City city1 = new("Sweden", "Stockholm");
        City city2 = new("USA", "New York");
        Painter painter1 = new(city1, "Jörgen");
        Mechanic mechanic1 = new(city2, "Josef");
        Mechanic mechanic2 = new(city1, "Emil");

        painter1.GoToWork();
        painter1.Work();

        mechanic1.GoToWork();
        mechanic2.GoToWork();

        mechanic2.Work();

        mechanic1.possessions.Add("Wrench");
        mechanic1.WriteAllPossessions();

        mechanic2.possessions.AddRange(new List<string>
        {
            "Wrench",
            "Napkin",
            "Newspaper"

        });
        mechanic2.WriteAllPossessions();

        House house1 = new("Venezuela", "Caracas", "Red");

        house1.residents.Add(painter1);
        house1.residents.Add(mechanic2);

        house1.WriteAllResidents();
    }
}
