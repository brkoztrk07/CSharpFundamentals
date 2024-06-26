namespace exercise2;

public class Employee
{
    public string Name {get; set;}
    public virtual void Work()
    {
        Console.WriteLine("Employee is woring.");
    }
}
public class Boss : Employee
{
    public override void Work()
    {
        base.Work();
    }
}
public class Intern : Employee
{
    public new void Work(){
        Console.WriteLine("Intern is carrying cofffee.");
    }
}
