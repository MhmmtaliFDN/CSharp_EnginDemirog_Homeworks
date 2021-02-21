/*C# dilinde dictionary yapısını araştırınız.*/

using System;
using System.Collections.Generic;

namespace Day4_Homework1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dictionary, key ve value tipini aynı anda tutan; içinde metotlar tutan bir yapıdır.

            //Dictionary'i tanımlayıp key ve value'nun hangi veri tipleri olacağını belirterek newleriz.
            Dictionary<string, int> NameAge = new Dictionary<string, int>();

            //Metotları kullanarak ekleme ve silme ...vs işlemleri yapabiliriz.
            NameAge.Add("Murat", 35);
            NameAge.Add("Selim", 15);
            foreach (var item in NameAge)
            {
                Console.WriteLine(item);        //[Murat, 35],[Selim, 15]
            }

            Console.WriteLine("----------------------------------------");

            NameAge.Remove("Murat");
            foreach (var item in NameAge)
            {
                Console.WriteLine(item);        //[Selim, 15]
            }
        }
    }
}