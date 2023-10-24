class Painter : Worker {

    public Painter(City Hometown, string Profession) : base(Hometown, Profession)
    {}

    public override void Work()
    {
        Console.WriteLine("fwoosh");
    }
}