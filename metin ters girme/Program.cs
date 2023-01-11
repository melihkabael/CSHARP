string metin;
System.Console.WriteLine("Metin Giriniz"); 
metin=Console.ReadLine()!;
foreach (var item in metin.Reverse())
{
    Console.WriteLine(item);
}