class Student : Person
{
    public string? course = "";
    public string? Course
    {
        get { return course; }
        set { course = value; }
    }
     public void Print()
    {
        Console.WriteLine($"Student's name: {Name} {Surname}, age: {Age}, course: {Course}");
    }
}