using System.Reflection.Metadata.Ecma335;

namespace encapsulateExercises;

public class Student
{
    private string name;
    private int grade;

    public string Name
    {
        get{return name;}
        set {name = value;}
    }
    public int Grade{
        get{return grade;}
        set{grade = value;}
    }
}
