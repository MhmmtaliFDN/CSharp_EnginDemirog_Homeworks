/*C# dilinde "ternary operatörü" araştırınız.*/

using System;
namespace Day2_Homework2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ternary operator'ün Türkçe karşılığı üçlü operatördür. If-else ifadesini sadeleştirmek için kullanılır. Fakat birden çok koşul barındıran if-else
//          koşullarını sadeleştirse de tercih edilmez çünkü bu kez kodun okunurluğu zorlaşır.
            
            //if-else
            int a = 10;
            if ((a % 2) == 0)
            {
                Console.WriteLine("a sayısı çifttir.");                 //A sayısı çifttir.
            }
            else
            {
                Console.WriteLine("a sayısı tektir.");
            }

            //ternary operator
            int b = 10;
            bool IsSingleOrDouble;
            IsSingleOrDouble = ((b % 2) == 0) ? true : false;
            Console.WriteLine(IsSingleOrDouble);                        //B sayısı çift midir? True
        }
    }
}