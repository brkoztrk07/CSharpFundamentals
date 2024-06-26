//Delegates (Temsilciler)
/*Delegates, C# dilinde bir veya daha fazla metodu temsil eden türlerdir.
Metodların referanslarını taşıyan ve bu metodları çağırabilen güçlü bir türdür.
Delegates, özellikle olay tabanlı programlama ve callback(geri çağırma) metodlarında 
yaygın olarak kullanılır.
*/
using delegates;

public class Program
{
    public static void Main(string[] args)
    {
        MyDelegate del = new MyDelegate(ShowMessage);
        del("Hello, Delegates");
        }
            public static void ShowMessage(string message)
            {
            Console.WriteLine(message);
            }
}