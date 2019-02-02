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
            int[] arr = new int[n];
            for (int i = 0; i < n; ++i)
            {
                arr[i] = int.Parse(doubnum[i]);
              Console.Write(arr[i] + " " + arr[i] + " ");
            }
        }
    }
}
