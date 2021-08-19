using System;
using System.Collections.Generic;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun()
            {
                Adi = "Elma",
                Fiyati = 2.5,
                Aciklama = "Emasya Elması"
            };

            Urun urun2 = new Urun()
            {
                Adi = "Karpuz",
                Fiyati = 50,
                Aciklama = "Diyarbakır Karpuzu"
            };

            //List<Urun> list = new List<Urun>();
            //list.Add(urun1);
            //list.Add(urun2);

            //foreach (var item in list)
            //{
            //    Console.WriteLine(item.Adi + ":" + item.Fiyati);
            //}

            Urun[] urunler = new Urun[] { urun1, urun2 };

            foreach (var urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("------------------------");
            }

            Console.WriteLine("-----------Metotlar---------");

            //instance -örnek
            //encapsulation

            SepetManager manager = new SepetManager();
            manager.Ekle(urun1);
            manager.Ekle(urun2);

            //yanlış yazım
            manager.Ekle2("Karpuz", "D.bakır", 12,15);

        }
    }
}

//clean code-best practice
//metotlar tekrar tekrar kullanılabilirliği sağlayan kod bloklarıdır