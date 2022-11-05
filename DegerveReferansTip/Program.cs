using System;

namespace DegerveReferansTip
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //  ÖNEMLİ KONU

            //DEĞER TİPLER: İNT,DOUBLE,DECİMAL, BOOL
            //REFERANS TİPLER : ARRAY, CLASS, İNTERFACE

            //BELLEK ALANLARI : STACK (değer tipler) ve HEAP (referans tipler)

            int sayi1 = 10;
            int sayi2 = 20;

            sayi1 = sayi2;
            sayi2 = 65;
            Console.WriteLine(sayi1);

            Console.WriteLine("--------");

            int[] sayilar1 = new int[] { 100, 200, 300 }; //new deyince bellekte yeni adres oluşturmadır. heap kısmında oluşur.
            int[] sayilar2 = new int[] { 55, 45, 13 };
            sayilar1 = sayilar2;
            sayilar2[0] = 695;
            Console.WriteLine(sayilar1[0]);



            
        
        }
    }
}
