using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_3
{
    class BasvuruManager
    {
        public void BasvuruYap(IKrediManager krediManager, List<ILoggerService> loggerServices)  // bu sekilde tanimandiginda tum kredileri hesaplayabiliriz
        {
            // Basvuran bilgilerini degerlendir
            // 
            // boyle yazilirsa sadece KonutKredisini hesaplar. Basvurulari bagimli hale getirmis olduk
            // KonutKrediManager konutKrediManager = new KonutKrediManager();
            // konutKrediManager.Hesapla();

            krediManager.Hesapla();  // Hangi kredi bilgisi geldiyse onun Hesapla operasyonu calisir
            foreach (var loggerService in loggerServices) {
                loggerService.Log();    // Hangi logger bilgisi geldiyse onun Log operasyonu calisir
            }
            
        }

        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler)
            // gelen Listedeki tum kredilerin Hesapla methodunu calistiracak
        {
            foreach (var kredi in krediler) 
            {
                kredi.Hesapla();
            }
        }
    }
}
