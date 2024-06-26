namespace ConsoleApp1;
//Parametreli Constructor ile Kapsulleme
public class Book
{
    private string title;
    private string author;
    public Book(string title,string author)
    {
        this.title = title;
        this.author = author;
    }

    public string Title
    {
        get{return title;}
        set{title = value;}
    }
    public string Author{
        get{return author;}
        set{author = value;}
    }
}
