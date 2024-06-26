namespace ınheritance;

public class Animal1
{
    public string Name {get; set;}

    public virtual void Speak()
    {
        Console.WriteLine($"{Name} makes a sound.");
    }
}
public class Dog1 : Animal1
{
    public override void Speak()
    {
     Console.WriteLine($"{Name} barks");   
    }
}
public class Cat : Animal1
{
    public new void Speak()
    {
        Console.WriteLine($"{Name} meows");
    }
}
