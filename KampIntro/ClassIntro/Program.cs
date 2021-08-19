using System;

namespace ClassIntro
{
    //sınıflar birden fazla (özelliği) verileri barındıran yapılardır
    class Program
    {
        static void Main(string[] args)
        {
            Kurs kurs1 = new Kurs();
            kurs1.Egitmen = "a";
            kurs1.KursAdi = "Java";
            kurs1.IzlenmeOranı = 50;

            Kurs kurs2 = new Kurs();
            kurs2.Egitmen = "b";
            kurs2.KursAdi = "Kotlin";
            kurs2.IzlenmeOranı = 50;

            Kurs kurs3 = new Kurs();
            kurs3.Egitmen = "c";
            kurs3.KursAdi = "Swift";
            kurs3.IzlenmeOranı = 50;

            //Console.WriteLine(kurs1.KursAdi + " " + kurs1.Egitmen);
            //Console.WriteLine(kurs2.KursAdi + " " + kurs2.Egitmen);

            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3 };
            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + ":" + kurs.Egitmen);
            }
        }
    }

    class Kurs
    {
        //propertyler -> özellikler
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int IzlenmeOranı { get; set; }

    }
}
