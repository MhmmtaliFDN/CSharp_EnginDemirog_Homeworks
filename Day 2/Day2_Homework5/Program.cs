/*Bir adet quiz sorusu yazınız. Bu soru bugüne kadar öğrendiklerimizi içermelidir.

QUESTION: Bir e-ticaret sitesine giriniz. Oradaki ürünlerin adı, fiyatı, stok adedi gibi özellikleri bir class içerisinde simüle ediniz. 
Program.cs'ye gelip birkaç ürün yazınız. Ardından onları bir liste içine atınız. Sonra varsayalım ki bir kullanıcı gelsin ve 
sadece 5000 lira altı ürünleri görüntülemek istesin. Siz de sadece 5000 lira altı olan ürünleri görüntüleyin.
Kullanacağınız başlıca yapılar: Class, Loops, Condition, Variable...
 */

using System;
namespace Day2_Homework5
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.ProductId = 1;
            product1.ProductInStock = 100;
            product1.ProductName = "Samsung A11";
            product1.ProductPrice = 3500;

            Product product2 = new Product();
            product2.ProductId = 2;
            product2.ProductInStock = 57;
            product2.ProductName = "Samsung A21";
            product2.ProductPrice = 4750;

            Product product3 = new Product();
            product3.ProductId = 3;
            product3.ProductInStock = 120;
            product3.ProductName = "Samsung A31";
            product3.ProductPrice = 6500;

            Product[] products = new Product[] { product1, product2, product3 };
            foreach (Product product in products)
            {
                if (product.ProductPrice <= 5000)
                {
                    Console.WriteLine(product.ProductName);
                    Console.WriteLine(product.ProductInStock);
                    Console.WriteLine(product.ProductPrice);
                }
            }
        }
    }
}
