using System;


// tekrar kullanılabilirliği sağlayan kod bloklarıdır.
namespace Metotlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
           //bu kısım uzun hali string urunAdi = "Elma";
            double fiyati = 15;
            string aciklama = "Amasya elması";
            
            //metot tanımlama kısmı. Product sayfasında oluşturduğumuz verileri burada kullandık.
            Product urun1 = new Product();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Acıklama = "Amasya Elması";

            Product urun2 = new Product();
            urun2.Adi = "Muz";
            urun2.Fiyati = 45;
            urun2.Acıklama = "Antalya Muzu";

            Product urun3 = new Product();
            urun3.Adi = "Kiraz";
            urun3.Fiyati = 26;
            urun3.Acıklama = "Kırmızı Kırmızı";

            Product[] urunler = new Product[] {urun1,urun2,urun3 };


            foreach (Product urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Acıklama);
                Console.WriteLine("------------");
              

            }

            Console.WriteLine("-------METHODS-----");

            //instance -- örnek oluşturma işlemi 

            //encapsulation
            SepetManager sepetManager = new SepetManager();
            sepetManager.Add(urun1); 
            sepetManager.Add(urun2); 
            sepetManager.Add(urun3);

            sepetManager.AddAlternative("Armut", "Yeşil Armut", 12,5);
            sepetManager.AddAlternative("erik", "Yeşil", 25,22);
            sepetManager.AddAlternative("mig", "Yeşil Armut", 55,10);
        }
    }
}
