using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    //imzanın aynı olduğu operasyonun farklı olduğu durumlarda interface kullanılır
    //interfaceler newlenemez
    interface IKrediManager
    {
        void Hesapla();
        void BirSeyYap();
       
    }
}
