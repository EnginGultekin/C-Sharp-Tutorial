using System;

namespace TryCatchFinallyExample
{
    class Program
    {
        public static void Main(string[] args)
        {

            //  func1();
            try
            {
                Console.WriteLine("Bir sayı giriniz:");
                string input = Console.ReadLine();
                int number = Convert.ToInt32(input);
                Console.WriteLine($"Girilen sayının karesi: {number * number}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Geçersiz format! Lütfen bir sayı giriniz.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Girilen sayı çok büyük veya çok küçük!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Bir hata oluştu: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Try-Catch bloğu sona erdi. Program sonlandırılıyor.");
            }
        }


        public static void func1()
        {
            try
            {
                Console.WriteLine("Lütfen birinci sayıyı giriniz:");
                int a = int.Parse(Console.ReadLine());

                Console.WriteLine("Lütfen ikinci sayıyı giriniz:");
                int b = int.Parse(Console.ReadLine());


                int c = a + b;

                Console.WriteLine($"Girilen sayıların toplamı: {c}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Bir Hata Oluştu: " + ex.Message);
            }
            finally
            {
                Console.WriteLine("İşlem tamamlandı.");
            }
        }
    }
}