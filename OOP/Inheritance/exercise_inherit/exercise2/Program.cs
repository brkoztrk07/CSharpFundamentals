//Kalitim (inheritance) Sorular..
using exercise2;
Bike z800 = new Bike();
z800.StartEngine();
//2.
Shape circle =  new Shape();
circle.Draw();
Employee e1 = new Boss();
Employee e2 = new Intern();
e1.Work();
e2.Work();
//2. class ta override ettiğmiz kodu yazdırdı. 3. classta new ile tanımlasakta çalıştırmadı.
//Eger ıntern le yazarsak..
Intern intern = new Intern();
intern.Work();
//INtern türünden yazdığımız için intern çalıştı ama öncekinde employee den inherit almasına rağmen
//override edildiği için çalıştırmadı.