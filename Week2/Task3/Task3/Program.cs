using System;
using System.IO;
namespace Task_3
{
    public class Program
    {
        public static void PrintSpaces(int level)//spaces between printing folder and directory
        {
            for (int i = 0; i < level; i++)
                Console.Write("  ");
        }

        public static void Task(DirectoryInfo dir, int level)
        {
            foreach (FileInfo f in dir.GetFiles())//find all files
            {
                PrintSpaces(level);
                Console.WriteLine(f.Name);
            }
            foreach (DirectoryInfo d in dir.GetDirectories())//find directories in directory
            {
                PrintSpaces(level);
                Console.WriteLine(d.Name);
                Task(d, level + 1); //checking if in subdirectories exist some files and get all of them too,but recursion
            }
        }
        static void Main()
        {
            DirectoryInfo dir = new DirectoryInfo(@"C:\Users\Raelisten\Documents\PP2");//given path for display consistents
            Task(dir, 0);
        }
    }
}