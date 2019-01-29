using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            string amount = Console.ReadLine();
            string line = Console.ReadLine();

            int n = int.Parse(amount);
            string[] doubnum = line.Split();

            for (int i = 0; i < doubnum.Length; ++i)
            {
                int x = Convert.ToInt32(doubnum[i]);
                for (int j = 0; j < 2; ++j)
                {
                    Console.Write(x + " ");
                }

            }
        }
    }
}
