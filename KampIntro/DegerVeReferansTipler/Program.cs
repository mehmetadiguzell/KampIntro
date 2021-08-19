using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {

            //int,decimal,float,double,bool -> sayısal tipler değer tipleridir.
            //array,class,interface -> referans tiplerdir.

            //değer tiplerde değer aktarılır.
            //referans tipler eşitlendiğinde referans numarası atanır.

            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 55;
            //sayi1 ? =>30

            int[] sayilar1 = new int[] { 10, 20, 30 }; // stock-> referans no 101 heap->[10, 20, 30]
            int[] sayilar2 = new int[] { 100, 200, 300 }; //stock-> referans no 102 heap->[100, 200, 300]
            sayilar1 = sayilar2; //sayilar 2 referans numarası sayilar 1 referans numarasına aktarılır,sayilar1 referans no=102
            //stock-> referans no 102 heap->[100, 200, 300]
            sayilar2[0] = 999;   //stock-> referans no 102 heap->[999, 200, 300]
            //sayilar1[0] ? 999
        }
    }
}
