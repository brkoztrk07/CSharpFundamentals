namespace abstrct_ex;

abstract class Shape
{
    public abstract double CalculateArea();
}
class Circle : Shape
{
    private double radius;

    public Circle(double radius)
    {
        this.radius = radius;
    }
    public override double CalculateArea()
    {
        return Math.PI * radius * radius;
    }
}
