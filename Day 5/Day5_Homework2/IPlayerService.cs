using System;
using System.Collections.Generic;
using System.Text;

namespace Day5_Homework2
{
    interface IPlayerService
    {
        void Add(Player player);
        void Update(Player player);
        void Delete(Player player);
    }
}
