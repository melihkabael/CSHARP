int[] sayilar= new int[6];
int[] kasaSayilar = new int[6];
int tahmin =0;
Console.WriteLine("Lütfen 6 adet sayı giriniz!");
Random rnd= new Random();

for (int i = 0; i < 6; i++)
{
    kasaSayilar[i]=rnd.Next(1,60);
    Console.Write("{0}. sayıyı giriniz:",(i+1));
    sayilar[i]=int.Parse(Console.ReadLine()!);
}
foreach (var sayi in sayilar)
{
    foreach (var kasasayi in kasaSayilar)
    {
        tahmin= sayi==kasasayi? tahmin++ :tahmin;
    }
}

Console.WriteLine("{0} adet doğru tahminde bulundunuz!",tahmin);
Console.WriteLine("random sayılar:");
for (int i = 0; i < kasaSayilar.Length; i++)
{
    Console.Write("{0}",kasaSayilar[i]);
}
