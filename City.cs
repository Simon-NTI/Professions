class City 
{
    public string Country { get; private set; }
    public string Name { get; private set; }

    public City(string country, string name)
    {
        Country = country;
        Name = name;
    }
}