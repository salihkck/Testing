using System;

namespace ClassIntro
{
    internal class Program
    {
        static void Main(string[] args)
        {
          

            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Salih";
            kurs1.IzlenmeOrani = 68;


            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "jAVA";
            kurs2.Egitmen = "sasas";
            kurs2.IzlenmeOrani = 60;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "mig";
            kurs3.Egitmen = "migi";
            kurs3.IzlenmeOrani = 91;

            //Console.WriteLine(kurs3.KursAdi+" "+kurs2.Egitmen+" "+kurs1.IzlenmeOrani);

            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3 };

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + " " + kurs.Egitmen);
            }

        }
    }



    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int IzlenmeOrani { get; set; }
    }
}
