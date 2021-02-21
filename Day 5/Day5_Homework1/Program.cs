/*Abstract class'lar, hem interface gibi içinde imzalanmamış metotlar tutarken hem de imzalanmış metotları tutabilir. İçinde imzalanmamış metotlar tuttuğundan
newlenemezler. Abstractlar genelde ibr base class görevi görür ve inheritance edilirler.*/

using System;
namespace Day5_Homework1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Database abstract class olduğundan kendisi değil inheritance edildiği classlar newlenir.
            Database database1 = new OracleServer();
            database1.Add();        //Oracle server'a eklendi.
            database1.Delete();     //Database'den silindi.

            Database database2 = new SqlServer();
            database2.Add();        //Sql server'a eklendi.
            database2.Delete();     //Database'den silindi.
        }
    }

    //Normal class'ın başına abstract getirince abstract class olur.
    abstract class Database
    {
        public abstract void Add();
        public void Delete()
        {
            Console.WriteLine("Database'den silindi.");
        }
    }

    class OracleServer : Database
    {
        public override void Add()
        {
            Console.WriteLine("Oracle server'a eklendi.");
        }
    }

    class SqlServer : Database
    {
        public override void Add()
        {
            Console.WriteLine("Sql server'a eklendi.");
        }
    }
}
