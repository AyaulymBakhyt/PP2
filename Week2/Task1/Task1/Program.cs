using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        
        static void Main(string[] args)
        {
            string text = System.IO.File.ReadAllText(@"C:\Users\Raelisten\Documents\PP2\PP2\Week2\Task1\test1.txt");
            //Opens a file, reads all text in the file with the specified encoding, and then closes the file.
            char[] letters = new char[text.Length];
            letters = text.ToCharArray();//This method converts strings to character arrays,
          //because we need to compare each element of given string
            bool ok = false;
            //function for checking palindrome
            for (int i = 0; i < letters.Length / 2; i++)
            {
                if (letters[i] == letters[letters.Length - 1 - i])
                    //compares the corresponding values by index
                    ok = true;
            }
            if (ok == true)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
       
    }
    }
