using System;
using System.IO;
namespace Task_3
{
    public class Program
    {
        public static void Task(DirectoryInfo dir, int level)
        {
            foreach (FileInfo f in dir.GetFiles())//find all files
            {
                Howfar(level);
                Console.WriteLine(f.Name);
            }
            foreach (DirectoryInfo d in dir.GetDirectories())//find directories in directory
            {
                Howfar(level);
                Console.WriteLine(d.Name);
                Task(d, level + 1); //checking if in subdirectories exist some files and get all of them too,by recursion
            }
        }
        public static void Howfar(int space)//spaces between printing folder and directory
        {
            for (int i = 0; i < space; i++)
                Console.Write("  ");
        }
        static void Main()
        {
            DirectoryInfo dir = new DirectoryInfo(@"C:\Users\Raelisten\Documents\PP2\PP2\Week2\Task1");//given path for display consistents
            Task(dir, 0);
        }
    }
}