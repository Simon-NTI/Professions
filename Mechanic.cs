class Mechanic : Worker
{
    public Mechanic(City Hometown, string Profession) : base(Hometown, Profession)
    {}

    public override void Work()
    {
        Console.WriteLine("cling clang");
    }
}