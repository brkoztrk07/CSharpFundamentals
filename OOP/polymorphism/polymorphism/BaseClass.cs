namespace polymorphism;

public class BaseClass
{
    public virtual void Display(){
        Console.WriteLine("BaseClass Display.");
    }

}
public class DerivedClass : BaseClass
{
    public override void Display(){
        Console.WriteLine("DerivedClass Display.");

    }
}