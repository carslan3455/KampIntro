using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {


            // Do not repeat your self - Kendini  Tekrarlama
            // Kategori->KAtegoriler olarak degistirmek istesek manuel olarak yapilmasi hataya sebep olur
            //Console.WriteLine("Kategori");
            //Console.WriteLine("Kategori");
            //Console.WriteLine("Kategori");
            //Console.WriteLine("Kategori");


            // type safety = tip guvenligi
            // deger tutucu - alias- takma isim  kategoriEtiketi
            string kategoriEtiketi = "Kategori";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmisMi = true;
            double dolarDun = 7.35;
            double dolarBugun = 7.45;

            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalis Butonu");
            }
            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("Artis Butonu");
            }
            else
            {
                Console.WriteLine("Degismedi Butonu");
            }

            if (sistemeGirisYapmisMi==true)       //  if (sistemeGirisYapmisMi)
            {
                Console.WriteLine("Kullanici ayarlari Butonu...");
            }
            else
            {
                Console.WriteLine("Giris Yap Butonu");
            }
            Console.WriteLine(kategoriEtiketi);



        }
    }
}
