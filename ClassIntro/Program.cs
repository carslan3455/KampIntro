using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "Cigdem";
            int yas = 38;

            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmeni = "Engin Demirog";
            kurs1.IzlenmeOrani = 68;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Java";
            kurs2.Egitmeni = "Kerem Varis";
            kurs2.IzlenmeOrani = 64;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Python";
            kurs3.Egitmeni = "Berkay Bilgin";
            kurs3.IzlenmeOrani = 80;

            Kurs kurs4 = new Kurs();
            kurs4.KursAdi = "C++";
            kurs4.Egitmeni = "Murat Kurtbogan";
            kurs4.IzlenmeOrani = 100;


            Console.WriteLine(kurs1.KursAdi + " : " + kurs1.Egitmeni);
            Console.WriteLine(kurs2.KursAdi + " : " + kurs2.Egitmeni);
            Console.WriteLine(kurs3.KursAdi + " : " + kurs3.Egitmeni);
            Console.WriteLine(kurs4.KursAdi + " : " + kurs4.Egitmeni);

            Console.WriteLine("***********************");

            Kurs[] kurslar = new Kurs[] {kurs1, kurs2, kurs3, kurs4};

            // foreach yazarken 2 tab ile tyapi otomatik tamamlaniyor
            foreach (Kurs kurs in kurslar)   // foreach (var kurs in kurslar)   // type var olarak da kalabilir
                {
                Console.WriteLine(kurs.KursAdi + " : " + kurs.Egitmeni);
            }
            


            Console.WriteLine("Hello World!");
        }
    }

    class Kurs
    {
        // prop yazarak 2 tab hamlesi ile otomatik olusturuyor. type ve isim yaziyoruz
        public string KursAdi { get; set; }
        public string Egitmeni { get; set; }
        public int IzlenmeOrani { get; set; }
    }
}
