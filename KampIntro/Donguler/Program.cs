using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            //dizi-array

            string[] kurslar = { "Java", "Python", "Kotlin" };

            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }
        }
    }
}
