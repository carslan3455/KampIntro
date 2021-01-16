using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {

            //string kurs1 = "Yazilim Gelistirici Kampi";
            //string kurs2 = "Programlamaya baslangic icin temel Kurs";
            //string kurs3 = "Java";
            //string kurs4 = "Python";
            //string kurs5 = "C++";
            //Console.WriteLine(kurs1);
            //Console.WriteLine(kurs2);
            //Console.WriteLine(kurs3);
            //Console.WriteLine(kurs4);
            //Console.WriteLine(kurs5);


            // array - dizi  
            string[] kurslar = new string[] { "Yazilim Gelistirici Kampi", "Programlamaya baslangic icin temel Kurs" , "Java", "Python", "C++"};

            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("For Bitti...");

            // takma isim - alias
            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("Foreach Bitti...");


            Console.WriteLine("Sayfa sonu - footer");

            // 2 tab hareketi ile yapiyi otomatik olusturuyor. Buna snippet denir
            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
