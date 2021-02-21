/*While döngüsü, for döngüsüne alternatif olarak kullanabileceğimiz bir döngü türüdür. for döngüleri gibi kalıplarının içi dolu değildir. Onlara göre daha
geniş bir çalışma alanı barındırır. for ile yapılabilecek tüm işlemler alternatif kodlarla çalıştırılabilinir.*/

using System;
namespace Day2_Homework4
{
    class Program
    {
        static void Main(string[] args)
        {
            //While ile foreach döngüsü örneği:
            string[] cities = new string[] { "İstanbul", "Ankara", "Adana", "İzmir" };

            int i = 0;
            while (i < cities.Length)
            {
                Console.WriteLine(cities[i]);           //İstanbul, Ankara, Adana, İzmir
                i++;
            }
        }
    }
}