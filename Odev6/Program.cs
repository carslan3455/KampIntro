using System;

namespace Odev6
{
    class Odev6
    {
        static void Main(string[] args)
        {
            Product urun1 = new Product();
            urun1.UrunAdi = "Laptop";
            urun1.Kodu = "101";
            urun1.Stok = 10;

            Product urun2 = new Product();
            urun2.UrunAdi = "Tablet";
            urun2.Kodu = "102";
            urun2.Stok = 5;

            Product urun3 = new Product();
            urun3.UrunAdi = "Play Station";
            urun3.Kodu = "103";
            urun3.Stok = 12;

            Product[] items = new Product[] { urun1, urun2, urun3 };

            Console.WriteLine("*** for döngüsü  ***");

            for (int i = 0; i < items.Length; i++) {
                Console.WriteLine(items[i].UrunAdi + " , " + items[i].Kodu + " , " + items[i].Stok);
            }

            Console.WriteLine("*** foreach  ***");

            foreach (Product item in items) {
                Console.WriteLine(item.UrunAdi + " , " + item.Kodu + " , " + item.Stok);
            }


            Console.WriteLine("*** while  ***");
            int sayac = 0;
            while (sayac < items.Length) {
                Console.WriteLine(items[sayac].UrunAdi + " , " + items[sayac].Kodu + " , " + items[sayac].Stok);

                sayac++;
            }

        }



        class Product
        {

            public string UrunAdi { get; set; }
            public string Kodu { get; set; }
            public int Stok { get; set; }

        }
    }
