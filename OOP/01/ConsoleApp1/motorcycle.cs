namespace ConsoleApp1;

public class motorcycle
{
    private string bikemodel; //Field
    /*Fieldlar, İçerdiği türün üyeleridir.
    Instance alanlar bir türün bir örneğine özgüdür.
    Fieldlar Genelde protected ya da private AM(acces Modifier) larla
    kullanılır.*/
    private double bikeprice;
     public string Bikemodel { get; set; } // PROPERTY 
    /*PRIVATE FIELD LARA ERİŞİMİ KONTROL ETMEK VE DIŞARIYA AÇMAK İÇİN 
    PROPERTIES KULLANILIR. BU DURUMDA Properties,Genellikle get ve set yöntemleriyle
    kullanılır. */
    
    public double  BikePrice
    {
        get { return bikeprice;}
        set { bikeprice = value;}
    }
    // AUTO-IPMLEMENTED PROPERTIES
    public int yas { get; set; } // auto-implemented property

    //Read-Only Properties
    private string tyre = "Bridgestone";

    public string Name{
        get {return Name;} // only get accessor.
    }
    //Write-Only Properties
    private string password;

    public string Password{
        set {password = value;} // only set accessor
    }
    //OZellikler ve Access Modifiers
    class Person
{
    public string Name { get; private set; }

    public Person(string name)
    {
        Name = name;
    }
}
}
