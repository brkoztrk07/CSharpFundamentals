namespace Abstract_Interface;
/* Interface, bir sınıfın hangi metot ve özellikleri içermesi
gerektiğini belirtir. Somut bir implementasyon içermez.
Interfaceler sınıfların belli bir standarda uymasını sağlar ve çoklu
kalıtımın mümkün olmadığı C# gibi dillerde bu ihtiyacı karşılar.
*/
public interface Ishape
{
    void Draw();

}
public interface Icolor{
    void Paint();
}
public class Rectangle : Ishape , Icolor
{
    public void Draw(){
        Console.WriteLine("Draw Rectangle");
    }
    public void Paint()
    {
        Console.WriteLine("Paint Square");
    }
}