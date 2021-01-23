using System;
using System.Collections.Generic;

namespace OOP_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Interface lerde o interface implemente eden class in referans nosunu tutabiliyor

            ////IhtiyacKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            //IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            //ihtiyacKrediManager.Hesapla();

            ////TasitKrediManager tasitKrediManager = new TasitKrediManager();
            //IKrediManager tasitKrediManager = new TasitKrediManager();
            //tasitKrediManager.Hesapla();

            ////KonutKrediManager konutKrediManager = new KonutKrediManager();
            //IKrediManager konutKrediManager = new KonutKrediManager();
            //konutKrediManager.Hesapla();


            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            IKrediManager tasitKrediManager = new TasitKrediManager();
            IKrediManager konutKrediManager = new KonutKrediManager();

            BasvuruManager basvuruManager = new BasvuruManager();
            //basvuruManager.BasvuruYap(ihtiyacKrediManager);
            //basvuruManager.BasvuruYap(tasitKrediManager);
            //basvuruManager.BasvuruYap(konutKrediManager);

            List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyacKrediManager, tasitKrediManager };
            // basvuruManager.KrediOnBilgilendirmesiYap(krediler);

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();
            ILoggerService smsLoggerService = new SmsLoggerService();

            List<ILoggerService> loggers = new List<ILoggerService>() { new SmsLoggerService(), new FileLoggerService()};
           // basvuruManager.BasvuruYap(konutKrediManager, new DatabaseLoggerService());  iki sekilde de yapilabilir
            //basvuruManager.BasvuruYap(konutKrediManager, databaseLoggerService);
            //basvuruManager.BasvuruYap(tasitKrediManager, fileLoggerService);
            
            // iki sekilde de tanimlama yapilabilir
            basvuruManager.BasvuruYap(new EsnafKredisiManager(), new List<ILoggerService>() { databaseLoggerService, smsLoggerService });
            basvuruManager.BasvuruYap(new EsnafKredisiManager(), loggers);



        }
    }
}
