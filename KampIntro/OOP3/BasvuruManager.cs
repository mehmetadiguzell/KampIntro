using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    //method injection
    class BasvuruManager
    {
        //parametre olarak hangi kredi gelrse ona özel metot çalışır.
        //public void BasvuruYap(IKrediManager krediManager, ILoggerService loggerService)
        public void BasvuruYap(IKrediManager krediManager, List<ILoggerService> loggerService) //birden fazla logger yollama
        {
            krediManager.Hesapla();

            foreach (var item in loggerService)
            {
                item.Log();
            }
            
        }
        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler)
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();

            }
        }
    }
}
