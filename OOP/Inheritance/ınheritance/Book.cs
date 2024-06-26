namespace ınheritance;

public class Book
{
    public string Name {get; set;}

    public Book(string name)
    {
        Name = name;
    }
    public void Read()
    {
        Console.WriteLine($"{Name} is reading.");
    }

}
public class Human : Book
{
    public Human(string name) : base(name)
    {

    }
    public void Turn_Page()
    {
        Console.WriteLine($"{Name} is turnin the page.");
    }
}
