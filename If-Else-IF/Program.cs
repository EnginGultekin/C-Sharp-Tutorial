using System;

class Program
{
    static void Main()
    {

        Ternary();
        Console.WriteLine("Lütfen bir sayı giriniz:");
        int number = int.Parse(Console.ReadLine());

        if (number > 0)
        {
            Console.WriteLine("Girilen sayı pozitiftir.");
        }
        else if (number < 0)
        {
            Console.WriteLine("Girilen sayı negatiftir.");
        }
        else
        {
            Console.WriteLine("Girilen sayı sıfırdır.");
        }
    }


      static void Ternary()
    {
        Console.WriteLine("Lütfen bir sayı giriniz:");
        int number = int.Parse(Console.ReadLine());

        // Ternary If kullanımı
        string result = (number % 2 == 0) ? "Girilen sayı çifttir." : "Girilen sayı tektir.";
        Console.WriteLine(result);
    }
}
