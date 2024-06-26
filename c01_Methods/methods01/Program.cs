
 public class Program{
    // [erisim belirleyici] [geri donus degeri] [Metot adı] (...)
    //{}
    #region Bir metodun geriye deger dondurmesi 
    //
        //Metodun geriye döndürdüğü değer, algoritmaların akışında kullanılabilir değerdir!!!

    #endregion
    static void Main(string[] args){
        //parametrenin değerini metodun  içerisinde herhangi bir yerde çağırıp kullanabiliriz.
        //Metot içerisinde üretilen herhangi bir değeri tutacak değişken oluşturmaktansa parametre üzerinde bu değeri tutabiliriz.
        //Yani parametrenin değerini değiştirebiliriz. (Çünkü parametreler özünde bir değişkendir.)

    }
    #region Parameters
    //In komutu sayesinde parametreye verilen değeri sabit tutabilmekteyiz.
    //In komutu, metodun parametresini readonly(sadece okunabilir) hale getirir.
    #endregion
    static void C(in int a = 678){

    }
    static void MyMethod() //Name of Method.
    {
        //Static: Means
        //void:  means that this method does not have a return value.
        System.Console.WriteLine("S.a");
    }

}