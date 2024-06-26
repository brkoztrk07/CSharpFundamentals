namespace polymorphismExeercise;

public class Mechanic
{
    public virtual void Tools(){
        Console.WriteLine("Get tools from workshop.");
    }
}
public class Intern : Mechanic
{
    public override void Tools()
    {
        Console.WriteLine("We had a tools already.");    
    }
}
public class Expert : Mechanic
{
    public override void Tools()
    {
        Console.WriteLine("Do what i say.");
    }
}