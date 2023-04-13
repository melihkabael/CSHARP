int sayi;
Console.WriteLine("Sayi Giriniz");
sayi=int.Parse(Console.ReadLine()!);

Console.WriteLine("(0) sayısı {1}",sayi,(sayi%=2));
