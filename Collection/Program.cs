using System;
using System.Collections.Generic;

namespace Collection
{
    class Program
    {
        static void Main(string[] args)
        {
            // stack         =  heap    
            //string[] isimler = new string[] {"Hasan", "Sinem", "Cigdem", "Ihsan" };
            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);
            //Console.WriteLine(isimler[3]);

            //isimler = new string[5];  // 5 elemanli yeni bir dizi olusturduk. yeni bir adres olusturduk
            //isimler[4] = "Ilker";
            // yeni array in son elemanina deger verdik ama digerleri bos
            //Console.WriteLine(isimler[4]);
            //Console.WriteLine(isimler[0]);   // array bu elemani bos. yeni adres olusturdugumuz icin

            List<string> isimler2 = new List<string> { "Hasan", "Sinem", "Cigdem", "Ihsan" };
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);

            isimler2.Add("Ilker");  // Collections larda ekleme bu sekilde yapilabiliyor ve sinirlama yok
            Console.WriteLine(isimler2[4]);
            Console.WriteLine(isimler2[0]);


        }
    }
}
