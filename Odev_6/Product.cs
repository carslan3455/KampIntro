using System;

public class Product
{
    public static void Main(string[] args)
    {
        Urunler urun1 = new Urunler();
        urun1.UrunAdi = "Laptop"; 
        urun1.Kodu = "101";
        urun1.Stok = 10;

        Urunler urun2 = new Urunler();
        urun2.UrunAdi = "Tablet";
        urun2.Kodu = "102";
        urun2.Stok = 5;

        Urunler urun3 = new Urunler();
        urun3.UrunAdi = "Play Station";
        urun3.Kodu = "103";
        urun3.Stok = 12;

        Urunler[] items = new Urunler[] { urun1, urun2, urun3 };

        foreach (Urunler item in items)
        {
            Console.WriteLine(item.UrunAdi + " , " + item.Kodu + " , " + item.Stok);
        }

    }


    class Urunler
    {

        public string UrunAdi { get; set; }
        public string Kodu { get; set; }
        public int Stok { get; set; }

    }

}
