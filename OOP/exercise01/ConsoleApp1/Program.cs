using ConsoleApp1;

Person person = new Person("Burak", 27,"45851290563"); // constructor da belirttiğimiz parametreleri
//kullanmak zorundayız yoksa hata verir.
Car car = new Car();
car.Year = 1994;
car.Model = "E34 535i";
Book book = new Book("1984","George Orwell");
string Burak = book.Author;
string model1 = car.Model;
Console.WriteLine(Burak+ " " + model1);

