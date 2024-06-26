namespace polymorphismExeercise;

public class Shape
{
    public virtual void Draw(){
        Console.WriteLine("Draw a Shape");
    }

}
public class Circle : Shape
{
    public string shape = "Circle";
    public override void Draw()
    {
        Console.WriteLine($"Draw a {shape}.");
    }
}

