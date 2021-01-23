using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_3
{
    interface IKrediManager   // Okunurlugu arttirmak icin Interface adi I ile baslar
        // Birbirinin alternatifleri olan ama kod icerikleri farkli olan yapilar icin kullaniriz
    {
           // bir kredi olusturuldugunda mecburen olmasi gereken methodlari tanimladik 
        public void Hesapla();   // Farkli hesaplamalar yapilacak  krediler icin govdesiz methodu olusturduk.
                                 // Bu yapilara Interface denir.
        public void BirseyYap(); // kullanmayacagiz bu methodu. Sadece 1 den fazla operasyon eklenebildigini gostermek icin

    }
}
