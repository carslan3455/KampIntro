using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {

            string urunAdi = "Elma";
            double fiyati = 15;
            string aciklama = "Amasya Elmasi";

            string[] meyveler = new string[] { };

            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elmasi";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakir Karpuzu";

            Urun[] urunler = new Urun[] { urun1, urun2};

            // type-self  -- tip güvenligi  -- tanimlanan verinin type belirtilmesi

            foreach (Urun urun in urunler) {

                Console.WriteLine("Urun adi : "+urun.Adi);
                Console.WriteLine("Urun Fiyati : "+urun.Fiyati);
                Console.WriteLine("Urun Aciklamasi : "+urun.Aciklama);
                Console.WriteLine("\n***************************\n");
            }

            Console.WriteLine("-------Methods---------");

            // instance - örnek
            // encapsulation  - Kapsulleme
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("Armut", "Yesil Armut", 12, 10);
            sepetManager.Ekle2("Elma", "Yesil Elma", 12, 9);
            sepetManager.Ekle2("Karpuz", "Diyarbakir Karpuzu", 12, 8);


        }
    }
}
        //Don't repeat yourself - DRY - Clean Code - Best Practice
