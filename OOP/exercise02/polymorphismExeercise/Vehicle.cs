namespace polymorphismExeercise;

public class Vehicle
{
    public virtual void Move(){
        Console.WriteLine("Run the engine.");
    }

}
public class Car : Vehicle
{
    public override void Move(){
        Console.WriteLine("Start the engine.");
    }
}
public class Bicycle : Vehicle
{
        public string person = "Burak";
    public override void Move()
    {  
        Console.WriteLine($"{person} is riding a biycle.");
    }
}
