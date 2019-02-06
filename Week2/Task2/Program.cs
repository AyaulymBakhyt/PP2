using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program

    {
        //function for checking primes 
        public static  bool Prime(int y)
        { 
            if (y <= 1) return false;
                for (int j = 2; j <= Math.Sqrt(y); j++)
                    if (y % j == 0)
                    {
                       return false;
                    }
            return true;
            }
        public static void F1()
        {
            StreamReader sr = new StreamReader(@"C:\Users\Raelisten\Documents\PP2\PP2\Week2\Task2\test2.txt");
            //for reading lines of information from a standard text file.
            StreamWriter sw = new StreamWriter(@"C:\Users\Raelisten\Documents\PP2\PP2\Week2\Task2\test2sol.txt");
            // for writing  output of program
            string s = sr.ReadToEnd();
            string[] ss = s.Split();
            for (int i = 0; i < ss.Length; i++)
            {
                int x = Convert.ToInt32(ss[i]);
                if (Prime(x))
                sw.Write(x + " ");
            }
            sr.Close();
            sw.Close();
        }

        static void Main(string[] args)
        {
            F1();
            
        }
    }
}
