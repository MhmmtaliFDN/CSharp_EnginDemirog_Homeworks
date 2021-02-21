using System;
using System.Collections.Generic;
using System.Text;

namespace Day4_Homework2
{
    class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
    }

    class SummerFruit : Product
    {
        public int WaterRatio { get; set; }
    }

    class WinterFruit : Product
    {
        public int VitaminRatio { get; set; }
    }
}