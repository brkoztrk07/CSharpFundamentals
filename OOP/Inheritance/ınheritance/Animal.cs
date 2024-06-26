namespace ınheritance;
//Base Temel sınıf
public class Animal
{
    public string Name {get; set;}
    public void Eat()
    {
        Console.WriteLine($"{Name} is eating");
    }

}
//türetilmiş sınıf Derived class
public class Dog : Animal
{
    public void Bark(){
        Console.WriteLine($"{Name} is Barking.");
    }
}