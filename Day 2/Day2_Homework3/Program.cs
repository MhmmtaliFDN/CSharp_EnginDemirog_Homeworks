/*C# dilinde "switch" yapısını araştırınız.*/

using System;
namespace Day2_Homework3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Switch; değişim, şalter gibi anlamlara gelir. Örneğin switch case yapısı ile haftanın 7 gününü 1'den 7'ye kadar tanımlarsak ve kullanıcıdan
//          bir sayı alırsak case yapısı bize o sayıya karşılık gelen değerin içindeki kodu çalıştıracaktır. break ile döngüden çıkmak sonsuz döngüye girmeyi
//          engeller.

            int day = 4;
            switch (day)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");          //Thursday
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
            }
        }
    }
}
