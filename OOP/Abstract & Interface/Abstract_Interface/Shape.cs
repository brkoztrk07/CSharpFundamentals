namespace Abstract_Interface;
/*Abstract Sınıf: Soyut sınıflar, doğrudan nesne oluşturulamayan
sınıflardır. Diğer sınıflar bu sınıfları inherit(kalıtım) alarak onlardan
türetilebilir.soyut sınıflar, ortak özellikleri ve metotları tanımlamak
için kullanılır.
*/
public abstract class Shape
{
    public abstract void Draw(); //abstract metod.
    public void Display(){
        Console.WriteLine("Display Shape");
    }
}
public class Circle : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Draw Circle");
    }
}
