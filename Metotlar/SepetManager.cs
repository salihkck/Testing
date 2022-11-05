using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    internal class SepetManager
    {
        //encapsulation bu kısım. Kapsül içerisine alma. get setle birleşmiş fonk bütünü.
        public void Add(Product urun) //metotlar böyle açılır. Fonksiyon ve metot aynı gibi.
        {
            Console.WriteLine("Tebrikler, Ürün Sepete Eklendi! : " + urun.Adi);
        }

        public void AddAlternative(string urunAdi, string acıklama, double fiyat, int stokAdet)
        {
            Console.WriteLine("Tebrikler, Ürün Sepete Eklendi! : " + urunAdi);
        }
    }
}
