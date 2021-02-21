/*ref ve out anahtar kelimelerini bilmeyen birine nasıl anlatırdınız?*/

using System;
namespace Day3_Homework1
{
    class Program
    {
        /*Progralama dilinde veriler ya Value(değer) tip ya da Referance(referans) tip olarak depolanırlar. ref ve out anahtar kelimeleri ise değer olarak
depolanan verileri referans tipine çevirip adres tanımlayarak yapılan işlemlerde değer tipin değişmesine yarar. Örneğin biz hepsiburada'da bir ürünü sepete
eklediğimizde sepetin değeri bir değer tip olsaydı hesaba soktuntan sonra değeri çağırdığımızda değeri değişmezdi. Fakat ref ve out kullanarak ürünleri eklersek
hesabın ne kadar tuttuğunu en son çağırsak da son fiyatı verir.*/
        static void Main(string[] args)
        {
            //ref ve out'suz kod: Cebimdeki paranın hesabı
            double FirstMoney1 = 99.99;
            MyMoney1 myMoney1 = new MyMoney1();
            myMoney1.list(5.99, 10.99, FirstMoney1);        //Şu durumda FirstMoney1, 83,01 olması gerekirken hala 99,99 gözüküyor.
            Console.WriteLine(FirstMoney1);          //FirstMoney1'in değeri list'e sadece kopyasını atayıp ilişkisini çekmiştir. Çünkü kendisi değer tipindedir. Ona yapılan işlem onu etkilememiş.

            //ref ile örnek:
            double FirstMoney2 = 99.99;
            MyMoney1 myMoney2 = new MyMoney1();
            myMoney2.list2(5.99, 10.99, ref FirstMoney2);       //Şu an FirstMoney2, 83,01'dir.
            Console.WriteLine(FirstMoney2);         //Bu sefer FirstMoney2'yi başına ref koyarak değer tipinde değil referans tipinde adres oluşturduk. Bu yüzden yaptığımız işlem onu etkiledi.

            //out ile örnek:
            double FirstMoney3; // tanımlayadabiliriz ama bir şeyi değiştirmez. (double FirstMoney3 = 10.99;) İşlemi yine HaveMoney'den yapacak.
            MyMoney1 myMoney3 = new MyMoney1();
            myMoney3.list3(5.99, 10.99, out FirstMoney3);
            Console.WriteLine(FirstMoney3);         //Bu sefer de referans atadığından 83,01 sonucunu verecek.

            /*ref ile out hemen hemen aynı şeye hizmet ediyor. Fakat farkları şu: ref'de metoda işlemi yazıp HaveMoney'i boş bırakabiliriz. Sonra yukarıda
             tanımlayacağımız FirstMoney'i yerine koyarak işlemi yaparız. Fakat out'da HaveMoney'i metodun içinde tanımlamalıyız. Yukarıda tanımlayacağımız
            FirstMoney herhangi bir şeyi değiştirmez. Bu yüzden tanımsız bırakmak karışıklık oluşturmaması için daha iyidir.
            
            Peki nerede kullanırız: 

            Örneğin (ref) hepsiburada'da sepetimiz boşken 0 lira. Sepeti ref ile kullanmasak da ürün eklesek tipi value type olacağından 
            değeri değişmeyecek ve sepet hep 0 lira olarak görünecek.

            Örneğin (out) hepsiburada'da bir ürün kampanyaya girdi. Arkadaşından gelen linkle alırsan %10 indirim var. Başta adamlar onun değerini girmiş
            linkten geldiğini gördüklerinde ürüne %10 indirim yapıyorlar. Eğer ürün out ile referans atanmadıysa o ürünü yine asıl fiyatından alırsın. Çünkü
            referans adresini almayan kod onu kendi değeriyle işleme koyar.*/
        }
    }

    class MyMoney1
    {
        public void list(double Coke, double Chips, double HaveMoney)
        {
            HaveMoney = HaveMoney - (Coke + Chips);
        }

        public void list2(double Coke, double Chips, ref double HaveMoney)      //ref atadık.
        {
            HaveMoney = HaveMoney - (Coke + Chips);
        }

        public void list3(double Coke, double Chips, out double HaveMoney)      //out atadık.
        {
            HaveMoney = 99.99;
            HaveMoney = HaveMoney - (Coke + Chips);
        }
    }
}