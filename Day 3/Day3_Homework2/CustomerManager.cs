using System;
using System.Collections.Generic;
using System.Text;

namespace Day3_Homework2
{
    class CustomerManager
    {
        public void AddCustomer(Customer customer)
        {
            Console.WriteLine("Sisteme Kaydınız Eklendi. Sayın " + customer.Name);
        }
        public void RemoveCustomer(Customer customer)
        {
            Console.WriteLine("Sistemden Kaydınız Silindi. Sayın " + customer.Name);
        }
        public void UpdateCustomer(Customer customer)
        {
            Console.WriteLine("Sistem Olan Kaydınız Güncellendi. Sayın " + customer.Name);
        }
        public void ListCustomer(Customer customer)
        {
            Customer[] customers = new Customer[] { customer };
            foreach (var item in customers)
            {
                Console.WriteLine("Kayıtlı Olan Kullanıcılarımız: " + item.Name);
            }
        }
    }
}
