class House : City {
public List<Worker> residents = new();
public string Color { get; set; }
    public House(string Country, string Name, string Color) : base(Country, Name)
    {
        this.Color = Color;
    }

    public void WriteAllResidents()
    {
        Console.WriteLine("This house has the following residents:");
        foreach(Worker resident in residents)
        {
            Console.WriteLine(" - " + resident);
        }
    }
}