using System;
using System.Collections.Generic;
using System.Text;

namespace Day5_Homework2
{
    interface IGameService
    {
        void Add(Game game);
        void Update(Game game);
        void Delete(Game game);
    }
}
