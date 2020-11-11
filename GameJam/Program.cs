using System;
using System.Collections.Generic;
using System.Text;

namespace GameJam
{
    class Program
    {
        static void Main(string[] args)
        {
            Game g = new Game();
            while (Console.ReadLine() != "end")
            {
                g.advanceTimeStep();
                foreach (var item in g.allTrends)
                {
                    Console.WriteLine($"{item.Currency.Name} {item.Currency.Value} ");
                }
            }
        }
    }
}
