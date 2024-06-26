
using System.Reflection.Metadata.Ecma335;

 static int Divide(int a,int b)
 {
    return a / b;
 }
 try
        {
            int result = Divide(10, 0);
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("Cannot divide by zero!");
        }
        finally
        {
            Console.WriteLine("Finally block executed.");
        }