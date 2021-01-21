using System;

namespace OOP_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitInStock = 3;

            // Urun bilgisi tanimlama 2.Yöntem
            Product product2 = new Product {Id = 2, CategoryId = 5, UnitInStock = 5, ProductName = "Kalem", UnitPrice = 35 };

            // PascalCase - > 2.kelimelerin ilk harfi buyuk 
            // case sensitive -> Kucuk buyuk harf duyarliligi
            ProductManager productManager = new ProductManager();   // heap de olusabilmasi icin new yapmak gerekiyor
            // sol taraf -> stack   sag taraf -> heap

            productManager.Add(product1);
           // Console.WriteLine(product1.ProductName); // referans type oldugu icin degiserek donuyor
                    // Kamera olarak donuyor...
                    // adrese ile gidiyor method a . donerken adresteki bilgi ile dönüyor

            int sayi = 100;

            // productManager.BirseyYap(sayi); 
            // Console.WriteLine(sayi);    // esitleme olmadigi icin sayi 100 olarak kalir. Deger type larda esitleme olmasi gerekiyor
            // 100 olarak kaliyor

            // int, double , bool ... deger type    -> atamalar deger uzerinden
            // diziler, class, abstract class, interface ... referans type  -> atamalar adres uzerinden


            productManager.Topla2(3, 6);   // bu method void gidip islemi yapip yazdirmak gorevi var

            int toplamaSonucu = productManager.Topla(3, 6);  // bu methodda gidip geldikten sonra gelecek sonuc ile islem yapmak istiyorsak return type yaiyoruz
              // uzerinde calisacagimiz bir veriye ihtiyacimiiz varsa return olan method kullanmis oluyoruz...
            Console.WriteLine(toplamaSonucu*2);




        }
    }
}
