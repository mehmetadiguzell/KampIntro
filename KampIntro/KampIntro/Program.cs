using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //Değişken nedir,neden kullanılır ->değişkenler veri tutuculardır.
            //type safety=tip güvenliği
            //do not repeat yourself - kendinin tekrarlama
            //değer tutucu,alias
            //fonk->bir kod bloğunu tekrar tekrar kullanmamızı sağlar

            string kategoriEtiketi = "Kategoriler";
            int ogrenciSayisi = 32000;
            double ortalama = 2.5;
            bool girisYapildiMi = false;

            if (girisYapildiMi==true)
            {
                Console.WriteLine("Ayarlar butonu");
            }
            else
            {
                Console.WriteLine("giriş yap");
            }

            Console.WriteLine(kategoriEtiketi);
        }
    }
}
