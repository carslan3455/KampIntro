using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_1
{
    class ProductManager    // Urun ile ilgili operasyonlari icerir Manager
    {
        // encapsulation -> Urune ait butun verileri kümülatif olarak yollamis oluyoruz
        public void Add(Product product)  // adresi ile geldigi icin degisiklik yapilimis oluyor
                                          // esitleme yapmaya gerek yok
        {
            // product.ProductName = "Kamera";
            Console.WriteLine(product.ProductName + " ekelendi.");

        }

        // public void BirseyYap(int sayi)
        // {
        //    sayi = 99;
       //  }

        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + " güncellendi.");
        }




        //public int Topla(int sayi1, int sayi2)
        //{
        //    return sayi1 + sayi2;
        //}

        //public void Topla2(int sayi1, int sayi2)
        //{
        //    Console.WriteLine(sayi1 + sayi2);
        //}
    }
}
