class Person
{
    public string name = "";
    public string Name
    {
        get { return name; }
        set { name = value; }
    }
    public string surname = "";
    public string Surname
    {
        get { return surname; }
        set { surname = value; }
    }
    public int? age = 0;
    public int? Age
    {
        get { return age; }
        set { age = value; }
    }
    public void Print()
    {
        Console.WriteLine($"Name: {Name} {Surname}, {Age}");
    }
}