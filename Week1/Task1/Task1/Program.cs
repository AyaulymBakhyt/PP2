using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        public static bool IsPrime(int number)
        {
            if (number <= 1) return false;
            int given = (int)Math.Floor(Math.Sqrt(number));

            for (int i = 2; i <= given; i++)
                if (number % i == 0)
                    return false;

            return true;
        }

        static void Main(string[] args)
        {
            int n;
            n = Int32.Parse(Console.ReadLine());
            int[] arr = new int[n];
            string[] s = Console.ReadLine().Split(' ');
            List<int> list = new List<int>();
            for (int i = 0; i < n; i++)
            {
                arr[i] = Int32.Parse(s[i]);
            }
            foreach (int item in arr)
            {
                if (IsPrime(item) == true)
                {
                    list.Add(item);
                }
            }
            Console.WriteLine(list.Count);
            for (int j = 0; j < list.Count; j++)
            {
                Console.Write(list[j] + " ");
            }
        }
    }
}
    
