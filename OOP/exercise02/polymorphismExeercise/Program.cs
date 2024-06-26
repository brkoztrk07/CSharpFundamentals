//1. soru
using polymorphismExeercise;

Car bmw = new Car();
bmw.Move(); // run the engine değil start the engine calisti
//Yani önceki metodu override ettik ezdik.
Bicycle bianki = new Bicycle();
bianki.Move();
Shape s1 = new Shape();
s1.Draw();
Circle c1 = new Circle();
c1.Draw();
//3. soru
Mechanic[] mechanics = new Mechanic[2]; // dizi kullanarak 
//aralarında geçen diyalogu yazdırdım.
mechanics[0] = new Intern();
mechanics[1] = new Expert();
foreach (var mechanic in mechanics){
    mechanic.Tools();
}