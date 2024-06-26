namespace Abstract_Interface;

public interface IAnimal
{
    void MakeSound();
}

public class Dog : IAnimal
{
    public void MakeSound()
    {
        Console.WriteLine("Bark");
    }
}

public class Cat : IAnimal
{
    public void MakeSound()
    {
        Console.WriteLine("Meow");
    }
}

class Program
{
    static void Main(string[] args)
    {
        IAnimal dog = new Dog();
        IAnimal cat = new Cat();

        dog.MakeSound(); // Bark
        cat.MakeSound(); // Meow
    }
}
