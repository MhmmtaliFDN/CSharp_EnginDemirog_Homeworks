/*Herhangi bir e-ticaret sistemine giriniz. Genellikle bir e-ticaret sistemine girdiğinizde ürünler listelenir. Siz de Urun (Product) isimli bir class 
oluşturup, oluşturduğunuz bir kaç ürünü bir diziye ekleyiniz. Ürünlerinizi for, foreach ve while döngüleri ile ayrı ayrı listeleyiniz.*/

using System;
namespace Day2_Homework6
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.ProductName = "Samsung M51";
            product1.ProductPrice = 3529.90;
            product1.SellerName = "Samsung";
            product1.Stock = 30;

            Product product2 = new Product();
            product2.ProductName = "Xiaomi Redmi Note 9 Pro";
            product2.ProductPrice = 3169.90;
            product2.SellerName = "Xiaomi";
            product2.Stock = 100;

            Product product3 = new Product();
            product3.ProductName = "iPhone 11";
            product3.ProductPrice = 7399.90;
            product3.SellerName = "Apple";
            product3.Stock = 20;

            Product[] products = new Product[] { product1, product2, product3 };

            //for
            for (int i = 0; i < products.Length; i++)
            {
                Console.WriteLine("Ürünün Adı: " + products[i].ProductName + " - " + "Ürünün Fiyatı: " + products[i].ProductPrice + "Satıcı Adı: " + " - " + products[i].SellerName + " - " + "Stok Adedi: " + products[i].Stock);
            }

            //foreach
            foreach (Product product in products)
            {
                Console.WriteLine("Ürünün Adı: " + product.ProductName + " - " + "Ürünün Fiyatı: " + product.ProductPrice + "Satıcı Adı: " + " - " + product.SellerName + " - " + "Stok Adedi: " + product.Stock);
            }

            //while
            int ii = 0;
            while (ii < products.Length)
            {
                Console.WriteLine("Ürünün Adı: " + products[ii].ProductName + " - " + "Ürünün Fiyatı: " + products[ii].ProductPrice + "Satıcı Adı: " + " - " + products[ii].SellerName + " - " + "Stok Adedi: " + products[ii].Stock);
                ii++;
            }
        }
    }

    class Product
    {
        public string ProductName { get; set; }
        public string SellerName { get; set; }
        public double ProductPrice { get; set; }
        public int Stock { get; set; }
    }
}