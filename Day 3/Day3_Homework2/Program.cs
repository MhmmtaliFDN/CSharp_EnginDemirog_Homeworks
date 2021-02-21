/*
1- Bir bankada müşteri takibi yapmak istiyorsunuz.
2- Musteri isimli bir Class oluşturunuz. Müşteriye istediğiniz özellikleri ekleyiniz. (Id,Ad,Soyad....)
3- MusteriManager sınıfı oluşturunuz. Musteri parametresi alarak Musteri ekleme, listeleme,silme gibi metotları simule ediniz
*/

using System;
namespace Day3_Homework2
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Id = 1;
            customer1.Name = "Engin";
            customer1.Surname = "Demiroğ";
            customer1.PhoneNumber = "0531 531 3131";

            Customer customer2 = new Customer();
            customer2.Id = 2;
            customer2.Name = "Muhammet Ali";
            customer2.Surname = "Fidan";
            customer2.PhoneNumber = "0532 532 3232";

            CustomerManager customerManager1 = new CustomerManager();
            customerManager1.AddCustomer(customer1);
            customerManager1.RemoveCustomer(customer1);
            customerManager1.UpdateCustomer(customer1);
            customerManager1.ListCustomer(customer1);
            customerManager1.ListCustomer(customer2);
        }
    }
}
