using System;
using System.Collections.Generic;
using System.Text;

namespace Day5_Homework2
{
    class CheckManager : ICheckService
    {
        public void Check(Player player)
        {
            if (player.Id == 1 && player.FirstName == "Engin" && player.LastName == "Demiroğ" && player.NationalityNo == "1234567890" && player.YearOfBirth == 1980)
            {
                Console.WriteLine("Sisteme giriş yapıldı");
            }
            else
            {
                Console.WriteLine("Giriş başarısız oldu. Bilgilerinizi kontrol edin.");
            }
        }
    }
}
