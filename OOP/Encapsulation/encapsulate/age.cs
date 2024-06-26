using System.Dynamic;

namespace encapsulate;

public class age
{
    private int age1;

    public int Age
    {
        get{return age1; }
        set
        {
            if(age1 >= 18 && age1<=55)
            {
                age1 = value;
            } else
            {
                throw new ArgumentOutOfRangeException("Age must be between 0 and 120");
            }
        }
    }
}
