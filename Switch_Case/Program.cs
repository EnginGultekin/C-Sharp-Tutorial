using System;

class Program
{
    static void Main()
    {

        WhichSeason();
        Console.WriteLine("Lütfen 1 ile 7 arasında bir gün numarası giriniz:");
        int day = int.Parse(Console.ReadLine());

        switch (day)
        {
            case 1:
                Console.WriteLine("Pazartesi");
                break;
            case 2:
                Console.WriteLine("Salı");
                break;
            case 3:
                Console.WriteLine("Çarşamba");
                break;
            case 4:
                Console.WriteLine("Perşembe");
                break;
            case 5:
                Console.WriteLine("Cuma");
                break;
            case 6:
                Console.WriteLine("Cumartesi");
                break;
            case 7:
                Console.WriteLine("Pazar");
                break;
            default:
                Console.WriteLine("Geçersiz gün numarası! Lütfen 1 ile 7 arasında bir sayı girin.");
                break;
        }
    }

    public static void WhichSeason()
    {
        Console.WriteLine("Ay Numarasını Girin:");
        int mount = int.Parse(Console.ReadLine());

        switch (mount) {

            case 12:
            case 1:
            case 2:
                Console.WriteLine("Kış");
                break;
            case 3:
            case 4:
            case 5:
                Console.WriteLine("İlkbahar");
                break;
            case 6:
            case 7:
            case 8:
                Console.WriteLine("Yaz");
                break;  
            case 9:
            case 10:
            case 11:
                Console.WriteLine("Sonbahar");
                break;           
            default:    
                break;    
        }

    }


}