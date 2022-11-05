using System;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //string ders1 = "İlk eğitim kursu";
            //string ders 

            //array-dizilerde tutulmalı.


            string[] kurslar = new string[] { "İlk eğitim kursu","ikinci eğitim kral","üçüncü eğitimde çok fena", "Java" };

            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("for bitti aga");


            //alttaki kurs yazan yer takma isim ne verirsen ver çalışır.
            foreach (string kurs in kurslar) //kursları tek tek dolaş. foreach dizilere uygulanır.
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("sayfa sonuna geldiniz.");
        }
    }
}
