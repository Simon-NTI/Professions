abstract class Worker {
public City Hometown { get; set; }
public string Name { get; set; }

    public string[] possesions;
    
    public Worker(City Hometown, string Name)
    {
        this.Hometown = Hometown;
        this.Name = Name;
    }

    public void GoToWork()
    {
        Console.WriteLine($"{Name} went to {Hometown.Name} to begin work");
    }
    public abstract void Work();
    
}