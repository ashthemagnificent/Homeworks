using System;

namespace Homework1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bir sayı giriniz: ");
            int sayi1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("İkinci bir sayı giriniz: ");
            int sayi2 = Convert.ToInt32(Console.ReadLine());

            //int toplam = (sayi1 * (sayi1 + 1)) / 2 - (sayi2 * (sayi2 + 1)) / 2;

            //int toplamm = Math.Abs(toplam);
            int toplam = 0;
            for (int i = sayi1; i <= sayi2; i++)
            {
                toplam += sayi1 + i++;

            }
            Console.Clear();
            Console.WriteLine(toplam);
            Console.ReadLine();
        }
    }
}
