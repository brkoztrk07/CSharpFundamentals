namespace abstrct_ex;

abstract class Employee
{
    protected string name;
    public Employee(string name)
    {
        this.name = name; //ctor name parametresini alır ve name
        //field ını başlatır.
    }
    public abstract void Work();
}
abstract class Manager : Employee //abstract bir classtan inherit
//almak için alacak classlarda abstract olmalıdır.
{
public Manager(string name) : base(name){}

    public override void Work()
    {
        Console.WriteLine($"{name} is managing.");
    }
}
abstract class Developer : Employee //abstract bir classtan inherit
//almak için alacak classlarda abstract olmalıdır.
{
    public Developer(string name) : base(name) { }
    public override void Work()
    {
       Console.WriteLine($"{name} is developing.");
    }
}

