using System;
using System.Collections.Generic;
using System.Text;

namespace Day5_Homework2
{
    class PlayerManager : IPlayerService
    {
        public void Add(Player player)
        {
            Console.WriteLine("Oyuncu sisteme eklendi: " + " " + player.FirstName);
        }

        public void Update(Player player)
        {
            Console.WriteLine("Oyuncu sistemde güncellendi: " + " " + player.FirstName);
        }

        public void Delete(Player player)
        {
            Console.WriteLine("Oyuncu sistemden silindi: " + " " + player.FirstName);
        }
    }
}
