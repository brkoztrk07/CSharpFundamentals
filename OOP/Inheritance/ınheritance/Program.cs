/* KALITIM NEDİR
Kalıtım, Bir sınıfın başka bir sınıftan türetilerek özelliklerini ve davranışlarını devralmasına denir.
Bu şekilde kod tekrarı azaltılır ve daha organize bir yapı oluşturabiliriz.
TEMEL VE TUREMIS SINIF (BASE & DERIVED CLASS)
Base Class:Kalıtımın temel aldığı sınıftır. Diğer sınıflar bu sınıftan türetilir. Temel sınıf, genel 
özelliklerei ve metotları içerir.
Derived Class(Turemis Sınıf): Temel sınıftan türetilmiş sınııftır. Temel sınıfın özelliklerini ve metotlarını
devralır ve bunlara ek olarak kendi özelliklerini ve metotlarını ekleyebilir.
*/
using ınheritance;

Dog dog = new Dog(); //Derived Class Gordugumuz gibi temel sınıfı cagırmadan islem yaptık.
dog.Name = "Kopek";
dog.Eat(); 
/* BASE ANAHTAR KELIMESI Book clasına bakalım.
*/
Human human = new Human("Burak"); //Constructor da string parametresi aldığı için isim vermek zorundayız
//yoksa hata verir.
human.Read();
human.Turn_Page();
/* OVERRIDEEE 
turemis sinifta, temel siniftaki bir metodu yeniden tanımlamak için kullanılır. Temel sinifta 'virtual'
olarak tanımlanmış bir metot olmalıdır.
new:türemis sinifta,, temel siniftaki bir metodu gizlemek icin kullanilir. Temel siniftaki metodun
'virtual' olmasına gerek yoktur.
*/
Dog1 dog1 = new Dog1();
dog1.Name = "Karabas";
dog1.Speak(); // turemis siniftaki 'Speak' metodu temel sinifftaki 'virtual' metodu gecersiz kilar ve
//kendi davranisini ekler.
Cat cat = new Cat();
cat.Name = "Simba"; // animal1.cs dosyasındaki speak metodu temel siniftaki metodu gizler ve yeni bir 
//davranis saglar. Ancak, sinif referansi ile cagrildiginda temel siniftaki metot calisir.
cat.Speak();

