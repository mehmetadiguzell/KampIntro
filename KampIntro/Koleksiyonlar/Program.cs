using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {


            List<string> isimler = new List<string>() {"A","B","C" };

            isimler.Add("D");

            foreach (var isim in isimler)
            {
                Console.WriteLine(isim);
            }
        }
    }
}
