class City 
{
public string Country { get; private set; }
public string Name { get; private set; }

    public City(string Country, string Name)
    {
        this.Country = Country;
        this.Name = Name;
    }
}