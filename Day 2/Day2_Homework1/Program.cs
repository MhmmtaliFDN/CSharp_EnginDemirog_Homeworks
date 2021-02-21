/*C# dilinde bulunan veri tipleri nelerdir?*/

using System;
namespace Day2_Homework1
{
    class Program
    {
        static void Main(string[] args)
        {
            //int: Tam sayıları ifade eder. Fakat belli bir sınırı vardır. (2.147.483.647 gibi)
            int a = 1000000001; 
            Console.WriteLine(a);           //100000001

            //long: Tam sayıları ifade eder. Hem int gibi hem de int'in ulaşamayacağı boyutlar için kullanılır.
            long b = 1;
            long c = 1000000011;
            Console.WriteLine(b);           //1
            Console.WriteLine(c);           //1000000011

            //float: Yerine genelde double veri türünü kullanırız. Ondalıklı sayıyı belirtmede kullanılır. Sayının sonu 'F' ile bitmelidir.
            float d = 5.75F;
            Console.WriteLine(d);           //5.75

            //double: Yine ondalıklı sayı belirtir fakat '.'dan yani ondalıktan sonra float(6-7)'a göre daha uzun basamak depolayabilir. (double (15))
            //Sonuna 'D' yazılsa da yazılmasa da geçerlidir. 
            double e = 5.75;
            Console.WriteLine(e);           //5.75

            //decimal: int için long ne ise double için de decimal odur. Sonuna 'm' konularak tanımlanır.
            decimal m = 5.75m;
            Console.WriteLine(m);           //5.75

            //bool: İçinde true veya false değerini tutar. Döngü ve koşulların vazgeçilmezidir.
            bool f = true;
            bool g = false;
            Console.WriteLine(f);           //True
            Console.WriteLine(g);           //False

            //char: Sadece tek bir metinsel ifadeyi tutar. İçinde tutacağı değişken '.' tek tırnak içine yazılır.
            //Aynı zamanda char veri tipine int dönüşümü uygularsak klavyede bulunan harflerin sayısal değerlerini verir.
            char letter = 'x';
            char A = 'A';
            Console.WriteLine(letter);      //x
            Console.WriteLine((int)A);      //65

            //string: Çift tırnağın içine yazılan metinsel veya sayısal her değeri 'metin' olarak tutar. İçine sayı yazsak da herhangi bir işleme sokamayız.
            string message = "Hello World!";
            string Id = "123154564";
            Console.WriteLine(message);     //Hello World!
            Console.WriteLine(Id);          //123154564

            //enum:
            Console.WriteLine(Days.Saturday);   //Saturday
            Console.WriteLine((int)Days.Monday);//0

            //Ek bilgi: Değişkenleri bir veri tipi ile tanımlayıp değerini daha sonra da atayabiliriz.
            string name;
            name = "Engin Demiroğ";
            Console.WriteLine(name);        //Engin Demiroğ

            //Ek bilgi: 'var' bir veri tipi değildir fakat veri tipini anlayıp depolayabilir. var ile tanımlanan değişkenin tipi daha sonradan değiştirilemez.
            var type = 20;                  //int olarak algıladı
            Console.WriteLine(type);        //20
        }
    }

    //enum: Birden çok string'i tek tek birden çok değişkene çift tırnak içinde tanımlayıp her birini ayrı ayrı çağırmak yerine enum kullanarak yapabiliriz.
    //Aynı zamanda 0'dan başlayarak sırasıyla numaralandırırlar. Eğer herhani birine değer atarsak değeri ona göre şekillenir.
    enum Days
    {
        Monday,Tuesday,Wednesday,Thursday = 10,Friday,Saturday,Sunday
        //0     1       2           10          11      12      13
    }
}