using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            //interfacelerde,o interfacesi impelemnte eden sınıfların referans numarasını tutar.
            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            IKrediManager tasitKrediManager = new TasitKrediManager();
            IKrediManager konutKrediManager = new KonutKrediManager();

            ILoggerService databaseLogger = new DatabaseLoggerService();
            ILoggerService fileLogger = new FileLoggerService();

            BasvuruManager basvuruManager = new BasvuruManager();
            //basvuruManager.BasvuruYap(new EsnafKredisiManager(), new SmsLoggerService());

            List<ILoggerService> logs = new List<ILoggerService>
            {
                databaseLogger,fileLogger
            };
            basvuruManager.BasvuruYap(new EsnafKredisiManager(),logs);



            List<IKrediManager> krediler = new List<IKrediManager>() { 
            ihtiyacKrediManager,tasitKrediManager
            };
            
                //basvuruManager.KrediOnBilgilendirmesiYap(krediler);
          
        }
    }
}
