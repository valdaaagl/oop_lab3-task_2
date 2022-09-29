class Neighbor : Person
{
    public string? neighbour = "";
    public string? Neighbour
    {
        get { return neighbour; }
        set { neighbour = value; }
    }
     public void Print()
    {
        Console.WriteLine($"Neighbor's name: {Name} {Surname}, apartment: {Neighbour}");
    }
}