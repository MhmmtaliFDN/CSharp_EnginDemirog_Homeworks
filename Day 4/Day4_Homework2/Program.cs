/*Aynen derste yaptığımız MyList gibi siz de kendi Dictonary sınıfınızı yazınız. (MyDictionary) Sadece ekleme (Add) metodunu yazınız.*/

using System;
namespace Day4_Homework2
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new SummerFruit { Id = 1, Name = "Watermelon", Price = 9.99, WaterRatio = 55 };
            Product product2 = new WinterFruit { Id = 2, Name = "Orange", Price = 3.99, VitaminRatio = 35 };

            ProductManager<Product> FruitList = new ProductManager<Product>();
            FruitList.Add(product1);
            FruitList.Add(product2);

            foreach (var item in FruitList.Product)
            {
                Console.WriteLine(item.Name);
            }
        }
    }
}
