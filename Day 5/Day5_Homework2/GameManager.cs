using System;
using System.Collections.Generic;
using System.Text;

namespace Day5_Homework2
{
    class GameManager : IGameService
    {
        public void Add(Game game)
        {
            Console.WriteLine("Oyun sisteme eklendi: " + " " + game.Name);
        }

        public void Update(Game game)
        {
            Console.WriteLine("Oyun sistemde güncellendi: " + " " + game.Name);
        }

        public void Delete(Game game)
        {
            Console.WriteLine("Oyun sistemden silindi: " + " " + game.Name);
        }
    }
}
