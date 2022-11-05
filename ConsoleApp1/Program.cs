using System;

namespace ConsoleApp1
{
    internal class Program
    {
        private static bool sistemeGirisYapmısmı;

        static void Main(string[] args)
        {
            // Console.Write("Uzun Kenar: ");
            // int kisa= int.Parse(Console.ReadLine());

            //Console.Write("Kısa Kenar: ");
            //int uzun = int.Parse(Console.ReadLine());

            //int alan = kisa * uzun;
            //int cevre = (kisa + uzun) * 2;

            //Console.Write("alan: " + alan + " " + "cevre: " + cevre);
            //Console.WriteLine($"alan: {alan} çevre: {cevre}");

            //var sayi = 10.8;

            double dolarDun = 7.75;
            double dolarBugun = 7.65;

            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Dolar Düştü Kral");
            }

            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("Dolar uçuyor abiiğğğ ");
            }

            else
            {
                Console.WriteLine("Dolar aynı yerinde");
            }

            bool sistemeGirisYapmisMi = true;

            if (sistemeGirisYapmisMi==true)
            {
                Console.WriteLine("Kullanıcı Ayarlar Butonu");
            }

            else
            {
                Console.WriteLine("gİRİŞ YAP bUTON");
            }
        }
    }
}
