using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        public static bool IsPrime(int number)//function for checking prime numbers
        {
            if (number <= 1) return false;//if the number is 1 or 0, it is not prime
            int given = (int)Math.Floor(Math.Sqrt(number));
            for (int i = 2; i <= given; i++)//checks for is number has dividers from 2 to sqrt(number)
                if (number % i == 0)//if dividers are exist,it is not prime
                    return false;

            return true;
        }

        static void Main(string[] args)
        {
            int n;
            n = Int32.Parse(Console.ReadLine());
            int[] arr = new int[n];
            string[] s = Console.ReadLine().Split(' ');//read line  and split every element for array
            List<int> list = new List<int>();//create a new list for saving primes
            for (int i = 0; i < n; i++)
            {
                arr[i] = Int32.Parse(s[i]);//convert each character to int
            }
            foreach (int item in arr)
            {
                if (IsPrime(item) == true)
                {
                    list.Add(item);//if item is prime add it to list
                }
            }
            Console.WriteLine(list.Count);//gives the amount of primes from initially entered array
            for (int j = 0; j < list.Count; j++)
            {
                Console.Write(list[j] + " ");//display the  prime numbers
            }
        }
    }
}
    
