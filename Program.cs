
//while döngüsü
// 1den başlayarak ekrandan girilen sayıya kadar ortalama hesaplayan program.
Console.Write("Lütfen bir sayı giriniz : ");
int sayi = int.Parse(Console.ReadLine());
int sayac = 1;
int toplam = 0;

while (sayac <= sayi)
{
    toplam += sayac;
    sayac++;

}
Console.WriteLine(toplam/sayi);


// a'dan zye kadar harfları yanyana yazdırma 
char character = 'a';
while (character <= 'z')
{
    Console.Write(character);
    character++;

}


Console.WriteLine("***** Foreach *****");
string[] arabalar = { "BMW", "Ford", "Mercedes", "Renault" };

foreach (var araba in arabalar)
{
    Console.WriteLine(araba);

}
