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
            string amount = Console.ReadLine();//size of array
            string line = Console.ReadLine();//line for reading elements

            int n = int.Parse(amount);//converting "size"(string) to int
            string[] doubnum = line.Split();//split entered line
            int[] arr = new int[n];//create array of integers
            for (int i = 0; i < n; ++i)
            {
                arr[i] = int.Parse(doubnum[i]);// each element of array convert to int
              Console.Write(arr[i] + " " + arr[i] + " ");//print every element in doubled way
            }
        }
    }
}
