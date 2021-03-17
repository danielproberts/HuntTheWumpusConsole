using System;

namespace HuntTheWumpusConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Map map = new Map(5);
            map.DisplayMap();
            Console.ReadKey();
        }
    }
}
