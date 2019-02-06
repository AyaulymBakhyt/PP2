using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo dir = new DirectoryInfo(@"C:\Users\Raelisten\Documents");
            Console.WriteLine(dir.Name);
            FileInfo[] files = dir.GetFiles();
            foreach (FileInfo count in files)
            {
                Console.WriteLine("   " + count.Name);
            }
        }
    }
}